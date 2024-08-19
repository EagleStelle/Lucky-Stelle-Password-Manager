Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Friend Class SecurityHelper
    Friend userFolder As String = "UserFiles"

    Friend secretKey As String = "o{4tYA=.)?q#E88mq;}T<pb)hQ$$7$k3"
    Private rng As New Random()

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

    ' Generate a 256-bit salt
    Private Shared Function GenerateSalt() As Byte()
        Dim salt As Byte() = New Byte(31) {}
        RandomNumberGenerator.Fill(salt)
        Return salt
    End Function

    ' Derive a key from the password and salt
    Private Shared Function DeriveKey(password As String, salt As Byte(), keySize As Integer) As Byte()
        Using rfc2898 As New Rfc2898DeriveBytes(password, salt, 10000, HashAlgorithmName.SHA256)
            Return rfc2898.GetBytes(keySize)
        End Using
    End Function

    ' Method to distribute the total length over a specified number of segments
    Friend Function DistributeLengths(totalLength As Integer, segments As Integer) As Integer()
        Dim lengths(segments - 1) As Integer
        Dim remainingLength As Integer = totalLength

        ' Randomly assign lengths to segments while ensuring the total length remains constant
        For i As Integer = 0 To segments - 2
            ' Calculate the maximum possible value for the current segment
            Dim maxPossibleLength As Integer = Math.Min(6, remainingLength - (segments - i - 1))

            ' Generate a random length that ensures no segment is 1 and does not exceed 6
            lengths(i) = rng.Next(Math.Min(2, maxPossibleLength), maxPossibleLength + 1)
            remainingLength -= lengths(i)
        Next

        ' Assign the remaining length to the last segment
        lengths(segments - 1) = remainingLength

        Return lengths
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
            result.Append(chars(rng.Next(chars.Length)))
        Next

        Return result.ToString()
    End Function

    Friend Function ReadCredentials(username As String, password As String, selector As Integer) As String
        Try
            Dim uniqueFileName As String = Path.Combine(userFolder, GenerateEncryptedFileName($"{username}.csv"))
            If File.Exists(uniqueFileName) Then
                Dim encryptedLines As String() = File.ReadAllLines(uniqueFileName)
                Dim decryptedPassword As String = Decrypt(encryptedLines(selector), password)
                Return decryptedPassword
            Else
                MessageBox.Show("Sorry, we couldn't find your account." & vbCrLf & "Please sign up to create a new account.", "Account Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        Catch ex As CryptographicException
            MessageBox.Show("Incorrect password. Please try again.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
        Return False
    End Function
    Friend Function CheckCredentials(username As String, password As String, selector As Integer) As Boolean
        Dim parts = ReadCredentials(username, password, selector)
        If parts = password Then
            Return True
        Else
            Return False
        End If
    End Function
    Friend Function CreateCredentials(username As String, accountPassword As String, vaultPassword As String, hashCode As String, stelleCode As String) As Boolean
        Try
            ' Generate encrypted file name
            Dim userFile As String = Path.Combine(userFolder, GenerateEncryptedFileName($"{username}.csv"))

            ' Check if the account already exists
            If File.Exists(userFile) Then
                MessageBox.Show("The email address you entered is already registered. Please use a different email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            Dim encryptedUsername As String = Encrypt(username, username)
            ' 1
            Dim encryptedAccountPassword As String = Encrypt(accountPassword, accountPassword)
            ' 2
            Dim encryptedVaultPassword As String = Encrypt(vaultPassword, vaultPassword)
            ' 3
            Dim encryptedHashCode As String = Encrypt(hashCode, hashCode)
            ' 4
            Dim encryptedHashCodeWithAccount As String = Encrypt(hashCode, secretKey)
            ' 5
            Dim encryptedStelleCode = Encrypt(stelleCode, stelleCode)

            ' Ensure the directory exists
            If Not Directory.Exists(userFolder) Then
                Directory.CreateDirectory(userFolder)
            End If

            ' Save encrypted data to file
            File.WriteAllLines(userFile, New String() {username, encryptedAccountPassword, encryptedVaultPassword, encryptedHashCode, encryptedHashCodeWithAccount, encryptedStelleCode})
            MessageBox.Show("Account successfully created!" & vbCrLf & "You can now log in using your email and account password.", "Registration Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return True
        Catch ex As Exception
            MessageBox.Show("An unexpected error occurred during registration.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Friend Sub ChangeCredentials(username As String, password As String, key As String, selector As Integer, message As Boolean)
        Try
            Dim uniqueFileName As String = Path.Combine(userFolder, GenerateEncryptedFileName($"{username}.csv"))
            If File.Exists(uniqueFileName) Then
                Dim encryptedLines As String() = File.ReadAllLines(uniqueFileName)
                Dim encryptedPassword As String = Encrypt(password, key)

                encryptedLines(selector) = encryptedPassword
                File.WriteAllLines(uniqueFileName, encryptedLines)

                ' Create directory if it doesn't exist
                If Not Directory.Exists(userFolder) Then
                    Directory.CreateDirectory(userFolder)
                End If

                If message Then
                    MessageBox.Show("Your password has been updated successfully.", "Password Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Incorrect password. Please try again.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Friend Sub DeleteCredentials(username As String, password As String)
        Dim userFile As String = Path.Combine(userFolder, GenerateEncryptedFileName($"{username}.csv"))
        Dim passwordFile As String = Path.Combine(userFolder, GenerateEncryptedFileName($"{password}.csv"))

        File.Delete(userFile)
        File.Delete(passwordFile)
        MessageBox.Show("Your account has been successfully deleted. Thank you for being with us!", "Account Deleted", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub

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

    Friend Function ValidateEmail(textbox As TextBox) As (Boolean, String)
        If textbox.Text = String.Empty OrElse textbox.Text = "Email" Then
            Return (True, "Email is required. Please enter your email address to proceed.")
        End If
        If Not textbox.Text.EndsWith("@lucky.com", StringComparison.OrdinalIgnoreCase) Then
            Return (True, "Your email address must end with '@lucky.com'. Please enter a valid email address.")
        End If
        Dim userFile As String = Path.Combine(userFolder, GenerateEncryptedFileName($"{textbox.Text}.csv"))
        If File.Exists(userFile) Then
            Return (True, "The email address you entered is already registered. Please use a different email address.")
        End If
        Return (False, "Null")
    End Function
End Class
