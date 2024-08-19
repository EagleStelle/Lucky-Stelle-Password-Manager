Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Friend Class SecurityHelperAdvanced
    Friend userFolder As String = "UserFiles"
    Private userFile As String = Path.Combine(userFolder, GenerateEncryptedFileName("UserFiles.csv"))
    Private random As New Random()

    ' AES Handler
    Friend Function Encrypt(plainText As String, password As String) As String
        ' Validate inputs
        If String.IsNullOrEmpty(plainText) OrElse String.IsNullOrEmpty(password) Then
            Throw New ArgumentNullException("plainText or password", "Input cannot be null or empty.")
        End If

        Using aes As Aes = Aes.Create()
            aes.GenerateIV()
            aes.Padding = PaddingMode.PKCS7
            aes.Mode = CipherMode.CBC
            Dim iv As Byte() = aes.IV

            ' Generate salt
            Dim salt As Byte() = GenerateSalt()

            ' Derive key from password and salt
            Dim key As Byte() = DeriveKey(password, salt, aes.KeySize \ 8)
            aes.Key = key

            Using encryptor As ICryptoTransform = aes.CreateEncryptor(aes.Key, aes.IV)
                Using ms As New MemoryStream()
                    ' Write IV and salt to the start of the memory stream
                    ms.Write(iv, 0, iv.Length)
                    ms.Write(salt, 0, salt.Length)

                    Using cs As New CryptoStream(ms, encryptor, CryptoStreamMode.Write)
                        Dim plainTextBytes As Byte() = Encoding.UTF8.GetBytes(plainText)
                        cs.Write(plainTextBytes, 0, plainTextBytes.Length)
                        cs.FlushFinalBlock()
                    End Using

                    Return Convert.ToBase64String(ms.ToArray())
                End Using
            End Using
        End Using
    End Function
    Friend Function Decrypt(encryptedText As String, password As String) As String
        ' Validate inputs
        If String.IsNullOrEmpty(encryptedText) OrElse String.IsNullOrEmpty(password) Then
            Throw New ArgumentNullException("encryptedText or password", "Input cannot be null or empty.")
        End If

        Dim fullCipher As Byte() = Convert.FromBase64String(encryptedText)

        Using aes As Aes = Aes.Create()
            aes.Padding = PaddingMode.PKCS7
            aes.Mode = CipherMode.CBC
            Dim ivLength As Integer = aes.BlockSize \ 8
            Dim saltLength As Integer = 32

            Dim iv As Byte() = New Byte(ivLength - 1) {}
            Array.Copy(fullCipher, 0, iv, 0, iv.Length)

            Dim salt As Byte() = New Byte(saltLength - 1) {}
            Array.Copy(fullCipher, iv.Length, salt, 0, salt.Length)

            Dim cipherBytes As Byte() = New Byte(fullCipher.Length - iv.Length - salt.Length - 1) {}
            Array.Copy(fullCipher, iv.Length + salt.Length, cipherBytes, 0, cipherBytes.Length)

            ' Derive key from password and salt
            Dim key As Byte() = DeriveKey(password, salt, aes.KeySize \ 8)
            aes.Key = key
            aes.IV = iv

            Using decryptor As ICryptoTransform = aes.CreateDecryptor(aes.Key, aes.IV)
                Using ms As New MemoryStream(cipherBytes)
                    Using cs As New CryptoStream(ms, decryptor, CryptoStreamMode.Read)
                        Using sr As New StreamReader(cs)
                            Return sr.ReadToEnd()
                        End Using
                    End Using
                End Using
            End Using
        End Using
    End Function
    Private Shared Function GenerateSalt() As Byte()
        Dim salt As Byte() = New Byte(31) {}
        RandomNumberGenerator.Fill(salt)
        Return salt
    End Function
    Private Shared Function DeriveKey(password As String, salt As Byte(), keySize As Integer) As Byte()
        Using rfc2898 As New Rfc2898DeriveBytes(password, salt, 10000, HashAlgorithmName.SHA256)
            Return rfc2898.GetBytes(keySize)
        End Using
    End Function

    ' Credentials Handler
    Friend Function ReadCredentials(username As String, password As String, selector As Integer) As String
        If Not File.Exists(userFile) Then
            MessageBox.Show("User database file not found.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End If

        ' Read the file line by line to minimize memory usage
        Using reader As New StreamReader(userFile, Encoding.UTF8)
            Dim line As String = reader.ReadLine()
            While line IsNot Nothing
                Dim parts As String() = SplitCSVLine(line)
                Dim decryptedUsername As String = String.Empty
                Try
                    ' Decrypt the username
                    Dim encryptedUsername As String = parts(0)
                    decryptedUsername = Decrypt(encryptedUsername, username)
                Catch ex As CryptographicException
                Catch ex As Exception
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return Nothing
                End Try

                Try
                    If decryptedUsername = username Then
                        ' Decrypt the password for the specified selector
                        Dim encryptedPassword As String = parts(selector)
                        Dim decryptedPassword As String = Decrypt(encryptedPassword, password)
                        Return decryptedPassword
                    End If
                Catch ex As CryptographicException
                    MessageBox.Show("Incorrect credentials. Please try again.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return Nothing
                Catch ex As Exception
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return Nothing
                End Try

                line = reader.ReadLine()
            End While
        End Using
        Return Nothing
    End Function
    Friend Function CheckCredentials(username As String, password As String, selector As Integer) As Boolean
        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please do not leave the textbox empty.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Dim decryptedPassword As String = ReadCredentials(username, password, selector)
        If decryptedPassword IsNot Nothing AndAlso decryptedPassword = password Then
            Return True
        Else
            ' MessageBox.Show("Incorrect password. Please try again.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
    End Function

    Friend Sub ChangeCredentials(username As String, password As String, key As String, selector As Integer, message As Boolean)
        Dim lines As New List(Of String)
        Dim updated As Boolean = False

        Using reader As New StreamReader(userFile, Encoding.UTF8)
            Dim line As String = reader.ReadLine()
            While line IsNot Nothing
                Dim parts As String() = SplitCSVLine(line)
                Dim decryptedUsername As String = String.Empty
                Try
                    ' Decrypt the username
                    Dim encryptedUsername As String = parts(0)
                    decryptedUsername = Decrypt(encryptedUsername, username)
                Catch ex As CryptographicException
                    ' Handle decryption error
                Catch ex As Exception
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

                Try
                    If decryptedUsername = username Then
                        Dim encryptedPassword As String = Encrypt(password, key)
                        parts(selector) = encryptedPassword
                        updated = True
                        If message Then
                            MessageBox.Show("Credentials updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                Catch ex As CryptographicException
                    MessageBox.Show("Incorrect credentials. Please try again.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Catch ex As Exception
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

                lines.Add(String.Join(",", parts))
                line = reader.ReadLine()
            End While
        End Using

        ' Write the updated lines back to the file
        If updated Then
            Using writer As New StreamWriter(userFile, False, Encoding.UTF8)
                For Each line As String In lines
                    writer.WriteLine(line)
                Next
            End Using
        End If
    End Sub
    Friend Function CreateCredentials(username As String, accountPassword As String, vaultPassword As String, hashCode As String, stelleCode As String) As Boolean
        ' Encrypt using the appropriate keys
        Dim encryptedUsername As String = Encrypt(username, username)
        Dim encryptedAccountPassword As String = Encrypt(accountPassword, accountPassword)
        Dim encryptedVaultPassword As String = Encrypt(vaultPassword, vaultPassword)
        Dim encryptedHashCode As String = Encrypt(hashCode, hashCode)
        Dim encryptedOldHashCode As String = Encrypt(hashCode, accountPassword)
        Dim encryptedStelleCode As String = Encrypt(stelleCode, stelleCode)
        Dim encryptedRecentLogin As String = Encrypt(DateTime.Now.ToString("yyyy-MMM-dd HH:mm:ss"), username)
        Dim encryptedPasswordAttempts As String = Encrypt(0, username)
        Dim encryptedStelleAttempts As String = Encrypt(0, username)
        Dim encryptedCustomName As String = Encrypt((Char.ToUpper(username(0)) & username.Substring(1)).Replace("@lucky.com", ""), accountPassword)
        Dim encryptedDurationAttempts As String = Encrypt(DateTime.MinValue.ToString(), username)
        Dim encryptedTotalAttempts As String = Encrypt(0, username)

        ' Ensure the directory exists
        If Not Directory.Exists(Path.GetDirectoryName(userFile)) Then
            Directory.CreateDirectory(Path.GetDirectoryName(userFile))
        End If

        ' Save encrypted data to file
        Dim newLine As String = $"{encryptedUsername},{encryptedAccountPassword},{encryptedVaultPassword},{encryptedHashCode},{encryptedOldHashCode},{encryptedStelleCode},{encryptedRecentLogin},{encryptedPasswordAttempts},{encryptedStelleAttempts},{encryptedCustomName},{encryptedDurationAttempts},{encryptedTotalAttempts}"
        File.AppendAllText(userFile, newLine & Environment.NewLine)
        MessageBox.Show("Account successfully created!" & vbCrLf & "You can now log in using your email and account password.", "Registration Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return True
    End Function
    Friend Sub DeleteCredentials(username As String)
        If Not File.Exists(userFile) Then
            MessageBox.Show("User database file not found.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim lines As New List(Of String)()
        Dim userFound As Boolean = False

        ' Read all lines and store them in a list, skipping the line with the matching username
        Using reader As New StreamReader(userFile, Encoding.UTF8)
            Dim line As String = reader.ReadLine()
            While line IsNot Nothing
                Dim parts As String() = SplitCSVLine(line)
                Dim decryptedUsername As String = String.Empty
                Try
                    ' Decrypt the username
                    Dim encryptedUsername As String = parts(0)
                    decryptedUsername = Decrypt(encryptedUsername, username)
                Catch ex As CryptographicException
                    ' Handle decryption error
                Catch ex As Exception
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End Try

                If decryptedUsername <> username Then
                    lines.Add(line)
                Else
                    userFound = True
                End If

                line = reader.ReadLine()
            End While
        End Using
        If Not userFound Then
            MessageBox.Show("Username not found in the database.", "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        ' Write the updated lines back to the file
        Using writer As New StreamWriter(userFile, False, Encoding.UTF8)
            For Each ln As String In lines
                writer.WriteLine(ln)
            Next
        End Using
        MessageBox.Show("The account has been successfully deleted.", "Account Deletion", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Text Handler
    Friend Function EscapeCSVField(field As String) As String
        If field.Contains(",") Or field.Contains("""") Or field.Contains(vbCr) Or field.Contains(vbLf) Then
            field = """" & field.Replace("""", """""") & """"
        End If
        Return field
    End Function
    Friend Function SplitCSVLine(line As String) As String()
        Dim result As New List(Of String)
        Dim inQuotes As Boolean = False
        Dim field As New StringBuilder()

        For i As Integer = 0 To line.Length - 1
            Dim ch As Char = line(i)

            If inQuotes Then
                If ch = """"c Then
                    If i < line.Length - 1 AndAlso line(i + 1) = """"c Then
                        field.Append(""""c) ' Handle escaped double quote
                        i += 1
                    Else
                        inQuotes = False
                    End If
                Else
                    field.Append(ch)
                End If
            Else
                If ch = """"c Then
                    inQuotes = True
                ElseIf ch = ","c Then
                    result.Add(field.ToString())
                    field.Clear()
                Else
                    field.Append(ch)
                End If
            End If
        Next

        result.Add(field.ToString())
        Return result.ToArray()
    End Function
    Friend Function ValidateEmail(textbox As TextBox) As (Boolean, String)
        If textbox.Text = String.Empty OrElse textbox.Text = "Email" Then
            Return (True, "Email is required. Please enter your email address to proceed.")
        End If
        If Not textbox.Text.EndsWith("@lucky.com", StringComparison.OrdinalIgnoreCase) Then
            Return (True, "Your email address must end with '@lucky.com'. Please enter a valid email address.")
        End If
        If File.Exists(userFile) Then
            Using reader As New StreamReader(userFile, Encoding.UTF8)
                Dim line As String = reader.ReadLine()
                While line IsNot Nothing
                    Dim parts As String() = SplitCSVLine(line)
                    Dim decryptedUsername As String = String.Empty
                    Try
                        ' Decrypt the username
                        Dim encryptedUsername As String = parts(0)
                        decryptedUsername = Decrypt(encryptedUsername, textbox.Text)
                    Catch ex As CryptographicException
                    Catch ex As Exception
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return Nothing
                    End Try

                    Try
                        If decryptedUsername = textbox.Text Then
                            Return (True, "The email address you entered is already registered. Please use a different email address.")
                        End If
                    Catch ex As CryptographicException
                    Catch ex As Exception
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return Nothing
                    End Try

                    line = reader.ReadLine()
                End While
            End Using
        End If
        Return (False, String.Empty)
    End Function

    ' File Handler
    Friend Function GenerateHash(input As String) As String
        If String.IsNullOrEmpty(input) Then
            Throw New ArgumentNullException("input", "Input cannot be null or empty.")
        End If

        Using md5Hash As MD5 = MD5.Create()
            Dim hashBytes As Byte() = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input))
            Dim sb As New StringBuilder()
            For i As Integer = 0 To hashBytes.Length - 1
                sb.Append(hashBytes(i).ToString("X2"))
            Next
            Return sb.ToString()
        End Using
    End Function
    Friend Function GenerateEncryptedFileName(fileName As String) As String
        ' Generate a unique encrypted file name based on the user's credentials
        Dim uniqueFileName As String = GenerateHash(fileName) + ".csv"
        Return uniqueFileName
    End Function

    ' Stelle Handler
    Friend Function DistributeLengths(totalLength As Integer, segments As Integer) As Integer()
        Dim lengths(segments - 1) As Integer
        Dim remainingLength As Integer = totalLength

        ' Randomly assign lengths to segments while ensuring the total length remains constant
        For i As Integer = 0 To segments - 2
            ' Calculate the maximum possible value for the current segment
            Dim maxPossibleLength As Integer = Math.Min(6, remainingLength - (segments - i - 1))

            ' Generate a random length that ensures no segment is 1 and does not exceed 6
            lengths(i) = random.Next(Math.Min(2, maxPossibleLength), maxPossibleLength + 1)
            remainingLength -= lengths(i)
        Next

        ' Assign the remaining length to the last segment
        lengths(segments - 1) = remainingLength

        Return lengths
    End Function
    Friend Function GenerateString(length As Integer, selector As Integer) As String
        Dim chars As String
        If selector = 0 Then
            chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789~!@#$%^&*()-_=+<>?{}[];:,.?/\"
        ElseIf selector = 1 Then
            chars = "0123456789"
        Else
            chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"
        End If
        Dim result As New StringBuilder()

        For i As Integer = 0 To length - 1
            ' Append a random character from the allowed set
            result.Append(chars(random.Next(chars.Length)))
        Next

        Return result.ToString()
    End Function
    Friend Function GenerateStelleCode(totalLength As Integer, segments As Integer)
        Dim segmentLengths As Integer() = DistributeLengths(totalLength, segments)

        Dim stelleCode As String = ""

        ' Loop through each segment length and generate the corresponding string part
        For i As Integer = 0 To segments - 2
            stelleCode += GenerateString(segmentLengths(i), 1) + "-"
        Next

        ' Add the last segment without the trailing "-"
        stelleCode += GenerateString(segmentLengths(segments - 1), 1)

        Return stelleCode
    End Function
End Class
