Imports System.Net.Mail

Public Class Form1
    Private Sub lblCreditsLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblCreditsLink.LinkClicked
        Process.Start("http://kaamidev.com")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub isSendingEmails()
        txtEmailToSpam.Enabled = False
        txtEmailBody.Enabled = False
        txtGmailPassword.Enabled = False
        txtGmailUsername.Enabled = False
        txtNumOfEmails.Enabled = False
        btnExit.Enabled = False
        btnSpam.Text = "Spamming.."
        btnSpam.Enabled = False
    End Sub

    Private Sub finishedSendingEmails()
        txtEmailToSpam.Enabled = True
        txtEmailBody.Enabled = True
        txtGmailPassword.Enabled = True
        txtGmailUsername.Enabled = True
        txtNumOfEmails.Enabled = True
        btnExit.Enabled = True
        btnSpam.Text = "Spam Email"
        btnSpam.Enabled = True
        lblProgressBar.Text = "Status: Completed"
    End Sub

    Private Sub btnSpam_Click(sender As Object, e As EventArgs) Handles btnSpam.Click

        If txtEmailBody.Text = "" Or txtEmailToSpam.Text = "" Or txtGmailUsername.Text = "" Or txtGmailPassword.Text = "" Then
            MsgBox("Make sure all fields are filled in.", , "Missing Fields")
        Else
            isSendingEmails()

            Try
                Dim Smtp_Server As New SmtpClient
                Smtp_Server.UseDefaultCredentials = False
                Smtp_Server.Credentials = New Net.NetworkCredential(txtGmailUsername.Text, txtGmailPassword.Text)
                Smtp_Server.Port = 587
                Smtp_Server.EnableSsl = True
                Smtp_Server.Host = "smtp.gmail.com"

                Dim e_mail As New MailMessage()
                e_mail = New MailMessage()
                e_mail.From = New MailAddress(txtGmailUsername.Text)
                e_mail.To.Add(txtEmailToSpam.Text)
                e_mail.IsBodyHtml = False
                e_mail.Body = txtEmailBody.Text

                For i As Integer = 1 To CInt(txtNumOfEmails.Value)
                    e_mail.Subject = "Spam Email - " + CStr(i)
                    Smtp_Server.Send(e_mail)
                    lblProgressBar.Text = "Status: Running - Sending Email " + CStr(i) + "/" + CStr(txtNumOfEmails.Value)
                    ProgressBar1.Value = i / CInt(txtNumOfEmails.Value) * 100
                    Application.DoEvents()
                Next
                MsgBox("Spam emails sent successfully!", , "Success!")

            Catch error_t As Exception
                MsgBox("Double check gmail login details. You may also have to to go https://myaccount.google.com/lesssecureapps and turn 'allow less secure apps' on.", , "Error!")
            End Try

            finishedSendingEmails()

        End If


    End Sub
End Class
