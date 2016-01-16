<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUserLogin
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserLogin))
        Me.txtPassword = New AeroSuite.Controls.CueTextBox()
        Me.txtUsername = New AeroSuite.Controls.CueTextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.cbSaveLogin = New System.Windows.Forms.CheckBox()
        Me.TenLabel1 = New TenChat_Client.TenLabel()
        Me.SuspendLayout()
        '
        'txtPassword
        '
        Me.txtPassword.Cue = "Kennwort eingeben"
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPassword.Location = New System.Drawing.Point(47, 131)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(275, 23)
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtUsername
        '
        Me.txtUsername.Cue = "Benutzername eingeben"
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtUsername.Location = New System.Drawing.Point(47, 75)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(275, 23)
        Me.txtUsername.TabIndex = 0
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblPassword.Location = New System.Drawing.Point(44, 113)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(59, 21)
        Me.lblPassword.TabIndex = 5
        Me.lblPassword.Text = "Kennwort:"
        Me.lblPassword.UseCompatibleTextRendering = True
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblUsername.Location = New System.Drawing.Point(44, 57)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(86, 21)
        Me.lblUsername.TabIndex = 6
        Me.lblUsername.Text = "Benutzername:"
        Me.lblUsername.UseCompatibleTextRendering = True
        '
        'btnLogin
        '
        Me.btnLogin.AutoSize = True
        Me.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnLogin.Location = New System.Drawing.Point(250, 198)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(72, 30)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "Anmelden"
        Me.btnLogin.UseCompatibleTextRendering = True
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnRegister
        '
        Me.btnRegister.AutoSize = True
        Me.btnRegister.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRegister.Location = New System.Drawing.Point(44, 198)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(82, 30)
        Me.btnRegister.TabIndex = 3
        Me.btnRegister.Text = "Registrieren"
        Me.btnRegister.UseCompatibleTextRendering = True
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'cbSaveLogin
        '
        Me.cbSaveLogin.AutoSize = True
        Me.cbSaveLogin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cbSaveLogin.Location = New System.Drawing.Point(44, 170)
        Me.cbSaveLogin.Name = "cbSaveLogin"
        Me.cbSaveLogin.Size = New System.Drawing.Size(259, 22)
        Me.cbSaveLogin.TabIndex = 4
        Me.cbSaveLogin.Text = "Anmeldedaten speichern (nicht empfohlen)"
        Me.cbSaveLogin.UseCompatibleTextRendering = True
        Me.cbSaveLogin.UseVisualStyleBackColor = True
        '
        'TenLabel1
        '
        Me.TenLabel1.AutoSize = True
        Me.TenLabel1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.TenLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TenLabel1.Location = New System.Drawing.Point(132, 20)
        Me.TenLabel1.Name = "TenLabel1"
        Me.TenLabel1.Size = New System.Drawing.Size(74, 25)
        Me.TenLabel1.TabIndex = 7
        Me.TenLabel1.Text = "Anmelden"
        Me.TenLabel1.UseCompatibleTextRendering = True
        '
        'frmUserLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(365, 240)
        Me.Controls.Add(Me.cbSaveLogin)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.TenLabel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUserLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TenChat Client - Anmelden"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TenLabel1 As TenLabel
    Friend WithEvents txtPassword As AeroSuite.Controls.CueTextBox
    Friend WithEvents txtUsername As AeroSuite.Controls.CueTextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents cbSaveLogin As CheckBox
End Class
