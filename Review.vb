Imports System.IO
Imports System.Text

Public Class Review
    Private textHelper As New TextHelper()
    Private securityHelper As New SecurityHelperAdvanced()
    Private listViewHelper As New ListViewHelper()

    Private Sub Review_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClientSize = New Size(flpReview.Width, flpReview.Height)

        listViewHelper.AttachHandlers(lsvReview)
        listViewHelper.AutoResizeColumns(lsvReview)
    End Sub

    Friend Sub ReviewPasswords(key As String)
        lsvReview.Items.Clear()
        Dim weakPasswordCount As Integer

        Dim userFile As String = Path.Combine(securityHelper.userFolder, securityHelper.GenerateEncryptedFileName($"{key}.csv"))
        If File.Exists(userFile) Then
            Using reader As New StreamReader(userFile, Encoding.UTF8)
                Dim line As String = reader.ReadLine()
                While line IsNot Nothing
                    Dim decryptedLine As String = securityHelper.Decrypt(line, key)
                    Dim parts As String() = textHelper.SplitCSVLine(decryptedLine)

                    Dim account As String = parts(0)
                    Dim password As String = parts(3)
                    Dim dateAdded As String = parts(4) ' Retrieve dateAdded

                    Dim strength As Integer = EvaluatePasswordStrength(password, dateAdded)

                    Dim feedback As String = GetFeedback(password, dateAdded)

                    Dim listViewItem As New ListViewItem(account) ' Account
                    listViewItem.SubItems.Add(New ListViewItem.ListViewSubItem() With {.Text = If(Passwords.passwordsVisible, password, New String("*"c, password.Length)), .Tag = password}) ' Password
                    listViewItem.SubItems.Add(dateAdded) ' Date Added
                    listViewItem.SubItems.Add(strength.ToString()) ' Strength
                    listViewItem.SubItems.Add(If(Passwords.passwordsVisible, feedback.ToString(), String.Empty)) ' Feedback

                    ' Darker color coding based on strength
                    If strength < 25 Then
                        listViewItem.SubItems(3).ForeColor = Color.DarkRed
                    ElseIf strength < 40 Then
                        listViewItem.SubItems(3).ForeColor = Color.DarkOrange
                    Else
                        listViewItem.SubItems(3).ForeColor = Color.DarkViolet
                    End If

                    If strength < 50 Then ' Arbitrary threshold for review
                        lsvReview.Items.Add(listViewItem)
                        weakPasswordCount += 1
                    End If

                    line = reader.ReadLine()
                End While
            End Using

            If weakPasswordCount = 0 Then
                flpReviewUnsecure.Visible = False
                flpReviewSecure.Visible = True
                Body.btnReview.Image = My.Resources.iconReviewCheck
            Else
                lblReviewUnsecure.Text = $"You have {weakPasswordCount} unsecured passwords!"
                flpReviewUnsecure.Visible = True
                flpReviewSecure.Visible = False
                Body.btnReview.Image = My.Resources.iconReviewFail
            End If
        End If
    End Sub
    Private Function EvaluatePasswordStrength(password As String, dateAdded As String) As Integer
        Dim score As Integer = 0
        Dim length As Integer = password.Length

        ' Length scoring
        If length >= 20 Then
            score += 15
        ElseIf length >= 20 Then
            score += 10
        ElseIf length >= 15 Then
            score += 5
        End If

        ' Capitalization scoring
        Dim hasUpper As Boolean = password.Any(AddressOf Char.IsUpper)
        Dim hasLower As Boolean = password.Any(AddressOf Char.IsLower)
        If hasUpper AndAlso hasLower Then
            score += 15
        ElseIf hasUpper OrElse hasLower Then
            score += 10
        End If

        ' Digit scoring
        If password.Any(AddressOf Char.IsDigit) Then
            score += 10
        End If

        ' Symbol scoring
        If password.Any(Function(c) Not Char.IsLetterOrDigit(c)) Then
            score += 10
        End If

        ' Age scoring
        Dim addedDate As DateTime = DateTime.Parse(dateAdded)
        Dim ageInMonths As Integer = DateDiff(DateInterval.Month, addedDate, DateTime.Now)
        If ageInMonths < 3 Then
            score += 5 ' Good if the password is less than 3 months old
        End If

        Return score
    End Function

    Friend Function GetFeedback(password As String, dateAdded As String) As String
        Dim feedback As New List(Of String)

        If password.Length < 25 Then
            feedback.Add("Increase Length")
        End If
        If Not password.Any(AddressOf Char.IsUpper) Then
            feedback.Add("No Uppercase Letters")
        End If
        If Not password.Any(AddressOf Char.IsLower) Then
            feedback.Add("No Lowercase Letters")
        End If
        If Not password.Any(AddressOf Char.IsDigit) Then
            feedback.Add("No Numbers")
        End If
        If Not password.Any(Function(c) Not Char.IsLetterOrDigit(c)) Then
            feedback.Add("No Symbols")
        End If

        ' Feedback for old passwords
        Dim addedDate As DateTime = DateTime.Parse(dateAdded)
        Dim ageInMonths As Integer = DateDiff(DateInterval.Month, addedDate, DateTime.Now)
        If ageInMonths >= 3 Then
            feedback.Add("Old Password")
        End If

        Return String.Join(", ", feedback)
    End Function
End Class