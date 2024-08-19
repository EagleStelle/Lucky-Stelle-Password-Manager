Imports System.ComponentModel.Design.ObjectSelectorEditor
Imports System.IO
Imports System.Security.Cryptography
Imports System.Security.Principal
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Friend Class ListViewHelper
    Friend Sub AttachHandlers(ByVal listView As ListView)
        AddHandler listView.DrawColumnHeader, AddressOf DrawColumnHeader
        AddHandler listView.DrawSubItem, AddressOf DrawSubItem
        AddHandler listView.ItemActivate, AddressOf ItemActivate
        AddHandler listView.ColumnWidthChanged, AddressOf ColumnWidthChanged
    End Sub

    Private Shared Sub DrawColumnHeader(sender As Object, e As DrawListViewColumnHeaderEventArgs)
        Dim headerColor = Color.FromArgb(255, 223, 122)
        Using headerBrush As New SolidBrush(headerColor)
            e.Graphics.FillRectangle(headerBrush, e.Bounds)
        End Using

        Dim boldFont As New Font(e.Font, FontStyle.Bold)
        TextRenderer.DrawText(e.Graphics, e.Header.Text, boldFont, e.Bounds, Color.Black, TextFormatFlags.Left)
    End Sub

    Private Shared Sub DrawSubItem(sender As Object, e As DrawListViewSubItemEventArgs)
        If e.Item.Selected Then
            e.Graphics.FillRectangle(Brushes.White, e.Bounds)
            TextRenderer.DrawText(e.Graphics, e.SubItem.Text, e.SubItem.Font, e.Bounds, Color.Red, TextFormatFlags.Left)
        Else
            e.DrawBackground()
            TextRenderer.DrawText(e.Graphics, e.SubItem.Text, e.SubItem.Font, e.Bounds, e.SubItem.ForeColor, TextFormatFlags.Left)
        End If
    End Sub

    Private Shared Sub ItemActivate(sender As Object, e As EventArgs)
        Dim listView As ListView = CType(sender, ListView)
        Dim selectedItem As ListViewItem = Nothing
        Dim selectedText As String = String.Empty

        selectedItem = listView.SelectedItems(0)

        If selectedItem IsNot Nothing Then
            Body.timerCount = 0
            Body.tmrStelle.Enabled = True
            Body.ptcStelle.Image = My.Resources.Show
            Body.tmrStelle.Stop()

            Body.txtGreeting.Text = "..."
            Body.txtStatus.Text = "Oh, you want to see your saved credentials? Sure, but I'll need the vault password first. Could you provide that?"

            If Passwords.passwordsVisible OrElse Passwords.VerifyPassword("Vault Password", 2, My.Resources.iconVault) Then
                Dim securityHelper As New SecurityHelperAdvanced()
                Dim textHelper As New TextHelper()
                Dim userFile As String = Path.Combine(securityHelper.userFolder, securityHelper.GenerateEncryptedFileName($"{Body.currentHashCode}.csv"))

                Dim parts As String() = Nothing
                Dim lines As String() = Nothing

                If File.Exists(userFile) Then
                    Dim fileContent As String = File.ReadAllText(userFile, Encoding.UTF8)
                    lines = fileContent.Split(New String() {Environment.NewLine}, StringSplitOptions.None)

                    Dim decryptedLine As String = String.Empty

                    For Each line As String In lines
                        decryptedLine = securityHelper.Decrypt(line, Body.currentHashCode)
                        parts = textHelper.SplitCSVLine(decryptedLine)
                        If parts(0) = selectedItem.Text Then
                            Exit For
                        End If
                    Next
                End If

                Using revealPasswordForm As New Message
                    revealPasswordForm.Text = "View/Edit Credentials: "
                    revealPasswordForm.txtField.Text = parts(0)
                    revealPasswordForm.ptcField.Image = My.Resources.iconAccount
                    revealPasswordForm.txtVerify.Text = parts(1)
                    revealPasswordForm.ptcVerify.Image = My.Resources.iconUsername
                    revealPasswordForm.txtEmail.Text = parts(2)
                    revealPasswordForm.txtPassword.Text = parts(3)
                    revealPasswordForm.pnlSuggest.Visible = True

                    If revealPasswordForm.ShowDialog = DialogResult.OK Then
                        Dim updated As Boolean = False
                        For i As Integer = 0 To lines.Length - 1
                            If textHelper.SplitCSVLine(securityHelper.Decrypt(lines(i), Body.currentHashCode))(0) = parts(0) Then
                                Dim dateAdded = DateTime.Now.ToString("yyyy-MM-dd")
                                lines(i) = securityHelper.Encrypt($"{textHelper.EscapeCSVField(revealPasswordForm.txtField.Text)},{textHelper.EscapeCSVField(revealPasswordForm.txtVerify.Text)},{textHelper.EscapeCSVField(revealPasswordForm.txtEmail.Text)},{textHelper.EscapeCSVField(revealPasswordForm.txtPassword.Text)},{dateAdded}", Body.currentHashCode)
                                updated = True
                                Exit For
                            End If
                        Next

                        If updated Then
                            File.WriteAllText(userFile, String.Join(Environment.NewLine, lines), Encoding.UTF8)

                            ' Update the autocomplete entries
                            Dim accountAutoComplete As New AutoCompleteStringCollection()
                            Dim usernameAutoComplete As New AutoCompleteStringCollection()
                            Dim emailAutoComplete As New AutoCompleteStringCollection()

                            For Each item As ListViewItem In Passwords.lsvMain.Items
                                accountAutoComplete.Add(item.Text)
                                usernameAutoComplete.Add(item.SubItems(1).Text)
                                emailAutoComplete.Add(item.SubItems(2).Text)
                            Next

                            Passwords.txtAccount.AutoCompleteSource = AutoCompleteSource.CustomSource
                            Passwords.txtAccount.AutoCompleteCustomSource = accountAutoComplete

                            Passwords.txtUsername.AutoCompleteSource = AutoCompleteSource.CustomSource
                            Passwords.txtUsername.AutoCompleteCustomSource = usernameAutoComplete

                            Passwords.txtEmail.AutoCompleteSource = AutoCompleteSource.CustomSource
                            Passwords.txtEmail.AutoCompleteCustomSource = emailAutoComplete

                            Passwords.LoadPasswords(Body.currentHashCode, Passwords.lsvMain)
                            Review.ReviewPasswords(Body.currentHashCode)

                            Dim helper As New ListViewHelper()
                            helper.AutoResizeColumns(Passwords.lsvMain)
                            helper.AutoResizeColumns(Review.lsvReview)
                        End If
                    End If
                End Using
            End If
        End If
    End Sub

    Private Shared Sub ColumnWidthChanged(sender As Object, e As ColumnWidthChangedEventArgs)
        Dim listView As ListView = CType(sender, ListView)
        Dim totalWidth As Integer = 0

        For Each column As ColumnHeader In listView.Columns
            totalWidth += column.Width
        Next

        Dim newWidth As Integer = totalWidth + SystemInformation.VerticalScrollBarWidth - 16

        If newWidth > 1135 Then
            Dim resizedColumn As ColumnHeader = listView.Columns(e.ColumnIndex)
            Dim excessWidth As Integer = newWidth - 1135
            resizedColumn.Width -= excessWidth

            totalWidth = 0
            For Each column As ColumnHeader In listView.Columns
                totalWidth += column.Width
            Next
            newWidth = totalWidth + SystemInformation.VerticalScrollBarWidth - 16
        End If

        listView.Width = newWidth
        Body.ClientSize = New Size(Body.pnlDashboard.Width + Body.flpAssistant.Width + Body.currentFlowLayoutPanel.Width, Math.Max(Body.pnlDashboard.Height, Body.currentFlowLayoutPanel.Height))
    End Sub

    Friend Sub AutoResizeColumns(ByVal listView As ListView)
        Using g As Graphics = listView.CreateGraphics()
            For i As Integer = 0 To listView.Columns.Count - 1
                Dim maxWidth As Integer = 0
                Dim headerWidth As Integer = CInt(g.MeasureString(listView.Columns(i).Text, listView.Font).Width) + 20

                For Each item As ListViewItem In listView.Items
                    Dim itemWidth As Integer = CInt(g.MeasureString(item.SubItems(i).Text, listView.Font).Width) + 20
                    If itemWidth > maxWidth Then
                        maxWidth = itemWidth
                    End If
                Next

                Dim finalWidth As Integer = Math.Max(headerWidth, maxWidth)
                listView.Columns(i).Width = Math.Max(finalWidth, 150)
            Next
        End Using
    End Sub
End Class
