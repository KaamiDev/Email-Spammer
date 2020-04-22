<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblCreditsLink = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtGmailUsername = New System.Windows.Forms.TextBox()
        Me.txtGmailPassword = New System.Windows.Forms.TextBox()
        Me.txtNumOfEmails = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEmailBody = New System.Windows.Forms.TextBox()
        Me.txtEmailToSpam = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnSpam = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lblProgressBar = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.txtNumOfEmails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(110, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(324, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Easy Email Spammer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(112, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Created By:"
        '
        'lblCreditsLink
        '
        Me.lblCreditsLink.AutoSize = True
        Me.lblCreditsLink.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreditsLink.Location = New System.Drawing.Point(223, 74)
        Me.lblCreditsLink.Name = "lblCreditsLink"
        Me.lblCreditsLink.Size = New System.Drawing.Size(103, 25)
        Me.lblCreditsLink.TabIndex = 2
        Me.lblCreditsLink.TabStop = True
        Me.lblCreditsLink.Text = "KaamiDev"
        Me.lblCreditsLink.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(455, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Gmail Username:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(456, 232)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Gmail Password:"
        '
        'txtGmailUsername
        '
        Me.txtGmailUsername.Location = New System.Drawing.Point(595, 195)
        Me.txtGmailUsername.Name = "txtGmailUsername"
        Me.txtGmailUsername.Size = New System.Drawing.Size(217, 26)
        Me.txtGmailUsername.TabIndex = 5
        '
        'txtGmailPassword
        '
        Me.txtGmailPassword.Location = New System.Drawing.Point(595, 230)
        Me.txtGmailPassword.Name = "txtGmailPassword"
        Me.txtGmailPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtGmailPassword.Size = New System.Drawing.Size(217, 26)
        Me.txtGmailPassword.TabIndex = 6
        '
        'txtNumOfEmails
        '
        Me.txtNumOfEmails.Location = New System.Drawing.Point(174, 317)
        Me.txtNumOfEmails.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtNumOfEmails.Name = "txtNumOfEmails"
        Me.txtNumOfEmails.Size = New System.Drawing.Size(120, 26)
        Me.txtNumOfEmails.TabIndex = 7
        Me.txtNumOfEmails.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 319)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "# of Emails:"
        '
        'txtEmailBody
        '
        Me.txtEmailBody.Location = New System.Drawing.Point(174, 232)
        Me.txtEmailBody.Multiline = True
        Me.txtEmailBody.Name = "txtEmailBody"
        Me.txtEmailBody.Size = New System.Drawing.Size(217, 72)
        Me.txtEmailBody.TabIndex = 14
        '
        'txtEmailToSpam
        '
        Me.txtEmailToSpam.Location = New System.Drawing.Point(174, 197)
        Me.txtEmailToSpam.Name = "txtEmailToSpam"
        Me.txtEmailToSpam.Size = New System.Drawing.Size(217, 26)
        Me.txtEmailToSpam.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(35, 234)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Email Body:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(34, 199)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 20)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Email to Spam:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(33, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Email Information"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(455, 155)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(164, 20)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Sender Information"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!)
        Me.Label10.Location = New System.Drawing.Point(456, 268)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(352, 75)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Note: This gmail account will be used to send the spam emails." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "It is recommended" &
    " you create a new account specifically for this" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "purpose rather than using your " &
    "own." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnSpam
        '
        Me.btnSpam.Location = New System.Drawing.Point(486, 346)
        Me.btnSpam.Name = "btnSpam"
        Me.btnSpam.Size = New System.Drawing.Size(150, 39)
        Me.btnSpam.TabIndex = 18
        Me.btnSpam.Text = "Spam Email"
        Me.btnSpam.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(642, 346)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(150, 39)
        Me.btnExit.TabIndex = 19
        Me.btnExit.Text = "Exit Program"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(25, 416)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(811, 40)
        Me.ProgressBar1.TabIndex = 20
        '
        'lblProgressBar
        '
        Me.lblProgressBar.AutoSize = True
        Me.lblProgressBar.BackColor = System.Drawing.Color.Transparent
        Me.lblProgressBar.Location = New System.Drawing.Point(21, 393)
        Me.lblProgressBar.Name = "lblProgressBar"
        Me.lblProgressBar.Size = New System.Drawing.Size(125, 20)
        Me.lblProgressBar.TabIndex = 21
        Me.lblProgressBar.Text = "Status: Stopped"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.email_spammer.My.Resources.Resources.email_mail_open_at
        Me.PictureBox1.Location = New System.Drawing.Point(37, 42)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 470)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblProgressBar)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSpam)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtEmailBody)
        Me.Controls.Add(Me.txtEmailToSpam)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNumOfEmails)
        Me.Controls.Add(Me.txtGmailPassword)
        Me.Controls.Add(Me.txtGmailUsername)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblCreditsLink)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(884, 526)
        Me.MinimumSize = New System.Drawing.Size(884, 526)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Easy Email Spammer by KaamiDev"
        CType(Me.txtNumOfEmails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblCreditsLink As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtGmailUsername As TextBox
    Friend WithEvents txtGmailPassword As TextBox
    Friend WithEvents txtNumOfEmails As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEmailBody As TextBox
    Friend WithEvents txtEmailToSpam As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnSpam As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents lblProgressBar As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
