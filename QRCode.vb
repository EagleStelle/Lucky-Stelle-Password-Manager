Imports QRCoder

Public Class QRCode
    Private textHelper As New TextHelper()
    Private securityHelper As New SecurityHelperAdvanced()

    Private Sub QRCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        ClientSize = New Size(flpQRCode.Width + 60, flpQRCode.Height + 60)
        BackgroundImage = My.Resources.backgroundQRCode

        ' Assign random string to txtRandom textbox
        Dim stelleCode = securityHelper.GenerateStelleCode(15, 5)
        txtStelleCode.Text = stelleCode

        Using qrGenerator As New QRCodeGenerator()
            Using qrCodeData = qrGenerator.CreateQrCode(stelleCode, QRCodeGenerator.ECCLevel.Q)
                Using qrCode As New QRCoder.QRCode(qrCodeData) ' Ensure the correct namespace is used
                    Using qrCodeImage = qrCode.GetGraphic(20) ' Ensure GetGraphic method exists in QRCoder.QRCode
                        ' Load the logo image
                        Using logo = New Bitmap(My.Resources.Logo) ' Replace with your logo path
                            ' Calculate the logo position
                            Dim logoSize = qrCodeImage.Width \ 5
                            Dim logoPosition = New Point((qrCodeImage.Width - logoSize) \ 2, (qrCodeImage.Height - logoSize) \ 2)

                            ' Resize the logo to fit within the QR code
                            Using resizedLogo As New Bitmap(logo, New Size(logoSize, logoSize))
                                ' Overlay the logo onto the QR code
                                Using graphicss = Graphics.FromImage(qrCodeImage)
                                    graphicss.DrawImage(resizedLogo, logoPosition)
                                End Using

                                ' Display the QR code with the logo in the PictureBox
                                ptcQRCode.Image = New Bitmap(qrCodeImage)
                            End Using
                        End Using

                        ' Dispose of the QR code bitmap to free memory
                        qrCodeImage.Dispose()
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Me.DialogResult = DialogResult.OK
    End Sub
End Class