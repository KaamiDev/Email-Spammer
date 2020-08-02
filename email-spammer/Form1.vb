Imports System.Net.Mail

Public Class Form1

    Dim thread As System.Threading.Thread
    Private Sub lblCreditsLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblCreditsLink.LinkClicked
        Process.Start("http://kaamidev.com")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub isSendingEmails()
        txtEmailToSpam.Enabled = False
        txtEmailBody.Enabled = False
        txtEmailSubject.Enabled = False
        txtGmailPassword.Enabled = False
        txtGmailUsername.Enabled = False
        txtNumOfEmails.Enabled = False
        btnExit.Enabled = False
        btnSpam.Text = "Spamming.."
        btnSpam.Enabled = False
    End Sub

    Private Sub finishedSendingEmails()
        txtEmailToSpam.Invoke(Sub()
                                  txtEmailToSpam.Enabled = True
                              End Sub)
        txtEmailBody.Invoke(Sub()
                                txtEmailBody.Enabled = True
                            End Sub)
        txtEmailSubject.Invoke(Sub()
                                   txtEmailSubject.Enabled = True
                               End Sub)
        txtGmailPassword.Invoke(Sub()
                                    txtGmailPassword.Enabled = True
                                End Sub)
        txtGmailUsername.Invoke(Sub()
                                    txtGmailUsername.Enabled = True
                                End Sub)
        txtNumOfEmails.Invoke(Sub()
                                  txtNumOfEmails.Enabled = True
                              End Sub)
        btnExit.Invoke(Sub()
                           btnExit.Enabled = True
                       End Sub)
        btnSpam.Invoke(Sub()
                           btnSpam.Text = "Spam Email"
                           btnSpam.Enabled = True
                       End Sub)
        lblProgressBar.Invoke(Sub()
                                  lblProgressBar.Text = "Status: Completed"
                              End Sub)
    End Sub

    Private Sub btnSpam_Click(sender As Object, e As EventArgs) Handles btnSpam.Click

        If txtEmailBody.Text = "" Or txtEmailToSpam.Text = "" Or txtGmailUsername.Text = "" Or txtGmailPassword.Text = "" Or txtEmailSubject.Text = "" Then
            MsgBox("Make sure all fields are filled in.", , "Missing Fields")
        Else
            isSendingEmails()
            thread = New System.Threading.Thread(AddressOf sendEmails)
            thread.Start()
        End If


    End Sub

    Private Sub sendEmails()
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
                e_mail.Subject = txtEmailSubject.Text + " - " + RandomString(7)
                Smtp_Server.Send(e_mail)
                lblProgressBar.Invoke(Sub()
                                          lblProgressBar.Text = "Status: Running - Sending Email " + CStr(i) + "/" + CStr(txtNumOfEmails.Value)
                                          ProgressBar1.Value = i / CInt(txtNumOfEmails.Value) * 100
                                      End Sub)
            Next
            MsgBox("Spam emails sent successfully!", , "Success!")
            finishedSendingEmails()
        Catch error_t As Exception
            MsgBox("Double check gmail login details. You may also have to to go https://myaccount.google.com/lesssecureapps and turn 'allow less secure apps' on.", , "Error!")
        End Try
    End Sub

    Private Function RandomString(ByRef Length As String) As String
        Dim str As String = Nothing
        Dim rnd As New Random
        For i As Integer = 0 To Length
            Dim chrInt As Integer = 0
            Do
                chrInt = rnd.Next(30, 122)
                If (chrInt >= 48 And chrInt <= 57) Or (chrInt >= 65 And chrInt <= 90) Or (chrInt >= 97 And chrInt <= 122) Then
                    Exit Do
                End If
            Loop
            str &= Chr(chrInt)
        Next
        Return str
    End Function
End Class
