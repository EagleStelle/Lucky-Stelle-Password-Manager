Imports System.Text

Friend Class TextHelper
    ' Dictionary to store the actual text for each textbox
    Private actualTexts As New Dictionary(Of TextBox, String)
    ' Dictionary to store the timers for each textbox
    Private concealTimers As New Dictionary(Of TextBox, Timer)
    ' Indicates whether a character is being hidden
    Private isHiding As Boolean = False
    ' Indicates whether TextChanged event handling is enabled
    Private ignoreTextChanged As Boolean = False
    Friend Sub StandardTextBox(sourceTextBox As TextBox, sourceTextDefault As String)
        sourceTextBox.Text = sourceTextDefault
        sourceTextBox.ForeColor = Color.Gray
    End Sub
    Private Sub TransferTextBox(sourceTextValue As String, sourceTextDefault As String, targetTextBox As TextBox, isPassword As Boolean)
        GetActualText(targetTextBox)

        If Not String.IsNullOrEmpty(sourceTextValue) AndAlso sourceTextValue <> sourceTextDefault Then
            targetTextBox.Text = sourceTextValue
            targetTextBox.ForeColor = Color.Black
        End If

        ' Start the concealment timer for the target textbox
        If concealTimers.ContainsKey(targetTextBox) AndAlso isPassword Then
            concealTimers(targetTextBox).Stop()
            concealTimers(targetTextBox).Start()
        End If
    End Sub
    Friend Sub ForwardTextBox(sourceForm As Form, sourceTextBoxName As String, sourceTextDefault As String, sourceTextValue As String, targetForm As Form, isPassword As Boolean)
        Dim sourceTextBox As TextBox = FindControlRecursive(Of TextBox)(sourceForm, sourceTextBoxName)
        Dim targetTextBox As TextBox = FindControlRecursive(Of TextBox)(targetForm, sourceTextBoxName) ' Assuming same name as sourceTextBox

        ' Use the existing methods without changes
        StandardTextBox(sourceTextBox, sourceTextDefault)
        TransferTextBox(sourceTextValue, sourceTextDefault, targetTextBox, isPassword)
    End Sub

    Friend Sub ConfigureTextBox(textBox As TextBox, defaultText As String, isPassword As Boolean)
        ' Set the initial text and color
        textBox.Text = defaultText
        textBox.ForeColor = Color.Gray

        ' Initialize the actual text and timer for the textbox
        actualTexts(textBox) = String.Empty
        concealTimers(textBox) = New Timer()
        concealTimers(textBox).Interval = 1000 ' Set delay time (in milliseconds)
        AddHandler concealTimers(textBox).Tick, Sub(sender As Object, e As EventArgs) OnConcealTimerTick(sender, e, textBox)

        ' If it's a password field, set the PasswordChar property to empty initially
        If isPassword Then
            textBox.PasswordChar = ControlChars.NullChar
        End If

        ' Define the GotFocus event handler
        AddHandler textBox.GotFocus, Sub(sender As Object, e As EventArgs)
                                         If textBox.Text = defaultText Then
                                             textBox.Text = ""
                                             textBox.ForeColor = Color.Black
                                         End If
                                     End Sub

        ' Define the LostFocus event handler
        AddHandler textBox.LostFocus, Sub(sender As Object, e As EventArgs)
                                          If String.IsNullOrWhiteSpace(textBox.Text) OrElse textBox.Text = defaultText Then
                                              textBox.Text = defaultText
                                              textBox.ForeColor = Color.Gray
                                          End If
                                      End Sub

        ' Define the TextChanged event handler for password masking
        If isPassword Then
            AddHandler textBox.TextChanged, Sub(sender As Object, e As EventArgs)
                                                If ignoreTextChanged OrElse isHiding Then
                                                    Return
                                                End If

                                                isHiding = True

                                                ' Stop the timer if running
                                                concealTimers(textBox).Stop()

                                                ' Only start the timer if the textbox has content and the last character is a new addition
                                                If Not String.IsNullOrWhiteSpace(textBox.Text) AndAlso textBox.Text <> defaultText Then
                                                    If textBox.Text.Length > actualTexts(textBox).Length Then
                                                        ' Handle typing or pasting text
                                                        Dim newText As String = textBox.Text.Substring(actualTexts(textBox).Length)
                                                        actualTexts(textBox) &= newText

                                                        ' Conceal the characters before the last typed or pasted character
                                                        If newText.Length = 1 Then
                                                            ' Only one character was typed
                                                            If textBox.Text.Length > 1 Then
                                                                Dim text As String = textBox.Text
                                                                textBox.Text = New String("*"c, textBox.Text.Length - 1) & newText
                                                                textBox.SelectionStart = textBox.Text.Length
                                                            End If
                                                        Else
                                                            ' Multiple characters were pasted, show them all for a while
                                                            textBox.SelectionStart = textBox.Text.Length
                                                        End If

                                                        ' Start the timer to conceal the last character after a delay
                                                        concealTimers(textBox).Start()
                                                    ElseIf textBox.Text.Length < actualTexts(textBox).Length Then
                                                        ' Handle backspace or deletion
                                                        actualTexts(textBox) = actualTexts(textBox).Substring(0, textBox.Text.Length)
                                                    End If
                                                ElseIf textBox.Text.Length = 0 Then
                                                    ' Clear the actual text if the textbox is empty
                                                    actualTexts(textBox) = String.Empty
                                                End If

                                                ' Keep the cursor at the end of the text
                                                textBox.SelectionStart = textBox.Text.Length

                                                isHiding = False
                                            End Sub

            ' Disable copy-paste functionality once all characters are concealed
            AddHandler textBox.KeyDown, Sub(sender As Object, e As KeyEventArgs)
                                            If textBox.Text.All(Function(c) c = "*"c) Then
                                                If (e.Control AndAlso (e.KeyCode = Keys.C OrElse e.KeyCode = Keys.X)) Then
                                                    e.SuppressKeyPress = True
                                                End If
                                            End If
                                        End Sub

            AddHandler textBox.MouseDown, Sub(sender As Object, e As MouseEventArgs)
                                              If textBox.Text.All(Function(c) c = "*"c) Then
                                                  textBox.SelectionLength = 0
                                              End If
                                          End Sub
        Else
            ' For non-password fields, update actual text immediately if it's not the default text
            AddHandler textBox.TextChanged, Sub(sender As Object, e As EventArgs)
                                                If ignoreTextChanged Then
                                                    Return
                                                End If
                                                If textBox.Text <> defaultText Then
                                                    actualTexts(textBox) = textBox.Text
                                                Else
                                                    actualTexts(textBox) = String.Empty
                                                End If
                                            End Sub
        End If
    End Sub
    Private Function FindControlRecursive(Of T As Control)(parent As Control, name As String) As T
        For Each ctrl As Control In parent.Controls
            If TypeOf ctrl Is T AndAlso ctrl.Name = name Then
                Return DirectCast(ctrl, T)
            Else
                Dim foundCtrl As T = FindControlRecursive(Of T)(ctrl, name)
                If foundCtrl IsNot Nothing Then
                    Return foundCtrl
                End If
            End If
        Next
        Return Nothing
    End Function
    Private Sub OnConcealTimerTick(sender As Object, e As EventArgs, textBox As TextBox)
        concealTimers(textBox).Stop()

        ' Conceal the entire text in the textbox
        If textBox.Text.Length > 0 Then
            textBox.Text = New String("*"c, textBox.Text.Length)
            textBox.SelectionStart = textBox.Text.Length
        End If
    End Sub

    Friend Sub SetActualText(textBox As TextBox, text As String)
        If actualTexts.ContainsKey(textBox) Then
            actualTexts(textBox) = text
        Else
            actualTexts.Add(textBox, text)
        End If
    End Sub
    Friend Function GetActualText(textBox As TextBox) As String
        If actualTexts.ContainsKey(textBox) Then
            Return actualTexts(textBox)
        Else
            Return String.Empty
        End If
    End Function

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

End Class
