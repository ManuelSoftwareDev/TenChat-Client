<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegister
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegister))
        Me.lblCaption = New AeroSuite.Controls.CaptionLabel()
        Me.txtPassword = New AeroSuite.Controls.CueTextBox()
        Me.txtUsername = New AeroSuite.Controls.CueTextBox()
        Me.btnSignUp = New System.Windows.Forms.Button()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtEmail = New AeroSuite.Controls.CueTextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.cbNewsletter = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'lblCaption
        '
        Me.lblCaption.AutoSize = True
        Me.lblCaption.Location = New System.Drawing.Point(127, 18)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(95, 20)
        Me.lblCaption.TabIndex = 8
        Me.lblCaption.Text = "Registrieren"
        '
        'txtPassword
        '
        Me.txtPassword.Cue = "Kennwort eingeben"
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPassword.Location = New System.Drawing.Point(46, 166)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(275, 23)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtUsername
        '
        Me.txtUsername.Cue = "Benutzername eingeben"
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtUsername.Location = New System.Drawing.Point(46, 75)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(275, 23)
        Me.txtUsername.TabIndex = 0
        '
        'btnSignUp
        '
        Me.btnSignUp.AutoSize = True
        Me.btnSignUp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSignUp.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSignUp.Location = New System.Drawing.Point(239, 229)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(82, 30)
        Me.btnSignUp.TabIndex = 4
        Me.btnSignUp.Text = "Registrieren"
        Me.btnSignUp.UseCompatibleTextRendering = True
        Me.btnSignUp.UseVisualStyleBackColor = True
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblPassword.Location = New System.Drawing.Point(43, 148)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(61, 15)
        Me.lblPassword.TabIndex = 5
        Me.lblPassword.Text = "Kennwort:"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblUsername.Location = New System.Drawing.Point(43, 57)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(86, 15)
        Me.lblUsername.TabIndex = 7
        Me.lblUsername.Text = "Benutzername:"
        '
        'txtEmail
        '
        Me.txtEmail.Cue = "E-Mail Adresse eingeben"
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEmail.Location = New System.Drawing.Point(46, 122)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(275, 23)
        Me.txtEmail.TabIndex = 1
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblEmail.Location = New System.Drawing.Point(43, 104)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(44, 15)
        Me.lblEmail.TabIndex = 6
        Me.lblEmail.Text = "E-Mail:"
        '
        'cbNewsletter
        '
        Me.cbNewsletter.AutoSize = True
        Me.cbNewsletter.Checked = True
        Me.cbNewsletter.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbNewsletter.Location = New System.Drawing.Point(46, 195)
        Me.cbNewsletter.Name = "cbNewsletter"
        Me.cbNewsletter.Size = New System.Drawing.Size(167, 64)
        Me.cbNewsletter.TabIndex = 3
        Me.cbNewsletter.Text = "Versionsupdate-Newsletter" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Per E-Mail Informationen" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "über neue Versionen" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "erhalt" &
    "en)"
        Me.cbNewsletter.UseVisualStyleBackColor = True
        '
        'frmRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(365, 268)
        Me.Controls.Add(Me.cbNewsletter)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblCaption)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.btnSignUp)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TenChat - Registrieren"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCaption As AeroSuite.Controls.CaptionLabel
    Friend WithEvents txtPassword As AeroSuite.Controls.CueTextBox
    Friend WithEvents txtUsername As AeroSuite.Controls.CueTextBox
    Friend WithEvents btnSignUp As Button
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtEmail As AeroSuite.Controls.CueTextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents cbNewsletter As CheckBox
End Class
