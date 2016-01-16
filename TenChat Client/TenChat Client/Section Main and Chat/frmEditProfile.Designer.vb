<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditProfile))
        Me.avatar = New System.Windows.Forms.PictureBox()
        Me.lblAboutMe = New System.Windows.Forms.Label()
        Me.txtAboutMe = New System.Windows.Forms.TextBox()
        Me.gbChangePassword = New System.Windows.Forms.GroupBox()
        Me.lblNewPass = New System.Windows.Forms.Label()
        Me.txtNewPass = New System.Windows.Forms.TextBox()
        Me.txtNewPassLoop = New System.Windows.Forms.TextBox()
        Me.lblNewPassLoop = New System.Windows.Forms.Label()
        Me.txtOldPass = New System.Windows.Forms.TextBox()
        Me.lblOldPass = New System.Windows.Forms.Label()
        Me.btnChangePass = New System.Windows.Forms.Button()
        Me.btnChangeAboutMe = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.lblverbleibend = New System.Windows.Forms.Label()
        CType(Me.avatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbChangePassword.SuspendLayout()
        Me.SuspendLayout()
        '
        'avatar
        '
        Me.avatar.Location = New System.Drawing.Point(21, 12)
        Me.avatar.Name = "avatar"
        Me.avatar.Size = New System.Drawing.Size(64, 64)
        Me.avatar.TabIndex = 0
        Me.avatar.TabStop = False
        '
        'lblAboutMe
        '
        Me.lblAboutMe.AutoSize = True
        Me.lblAboutMe.Location = New System.Drawing.Point(91, 23)
        Me.lblAboutMe.Name = "lblAboutMe"
        Me.lblAboutMe.Size = New System.Drawing.Size(210, 15)
        Me.lblAboutMe.TabIndex = 1
        Me.lblAboutMe.Text = "Über mich (das können andere sehen):"
        '
        'txtAboutMe
        '
        Me.txtAboutMe.Location = New System.Drawing.Point(94, 41)
        Me.txtAboutMe.MaxLength = 300
        Me.txtAboutMe.Multiline = True
        Me.txtAboutMe.Name = "txtAboutMe"
        Me.txtAboutMe.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtAboutMe.Size = New System.Drawing.Size(207, 78)
        Me.txtAboutMe.TabIndex = 2
        '
        'gbChangePassword
        '
        Me.gbChangePassword.Controls.Add(Me.btnChangePass)
        Me.gbChangePassword.Controls.Add(Me.txtOldPass)
        Me.gbChangePassword.Controls.Add(Me.lblOldPass)
        Me.gbChangePassword.Controls.Add(Me.txtNewPassLoop)
        Me.gbChangePassword.Controls.Add(Me.lblNewPassLoop)
        Me.gbChangePassword.Controls.Add(Me.txtNewPass)
        Me.gbChangePassword.Controls.Add(Me.lblNewPass)
        Me.gbChangePassword.Location = New System.Drawing.Point(94, 147)
        Me.gbChangePassword.Name = "gbChangePassword"
        Me.gbChangePassword.Size = New System.Drawing.Size(207, 183)
        Me.gbChangePassword.TabIndex = 3
        Me.gbChangePassword.TabStop = False
        Me.gbChangePassword.Text = "Kennwort ändern"
        '
        'lblNewPass
        '
        Me.lblNewPass.AutoSize = True
        Me.lblNewPass.Location = New System.Drawing.Point(9, 19)
        Me.lblNewPass.Name = "lblNewPass"
        Me.lblNewPass.Size = New System.Drawing.Size(97, 15)
        Me.lblNewPass.TabIndex = 0
        Me.lblNewPass.Text = "Neues Kennwort:"
        '
        'txtNewPass
        '
        Me.txtNewPass.Location = New System.Drawing.Point(12, 38)
        Me.txtNewPass.Name = "txtNewPass"
        Me.txtNewPass.Size = New System.Drawing.Size(189, 23)
        Me.txtNewPass.TabIndex = 1
        Me.txtNewPass.UseSystemPasswordChar = True
        '
        'txtNewPassLoop
        '
        Me.txtNewPassLoop.Location = New System.Drawing.Point(12, 82)
        Me.txtNewPassLoop.Name = "txtNewPassLoop"
        Me.txtNewPassLoop.Size = New System.Drawing.Size(189, 23)
        Me.txtNewPassLoop.TabIndex = 3
        Me.txtNewPassLoop.UseSystemPasswordChar = True
        '
        'lblNewPassLoop
        '
        Me.lblNewPassLoop.AutoSize = True
        Me.lblNewPassLoop.Location = New System.Drawing.Point(9, 64)
        Me.lblNewPassLoop.Name = "lblNewPassLoop"
        Me.lblNewPassLoop.Size = New System.Drawing.Size(165, 15)
        Me.lblNewPassLoop.TabIndex = 2
        Me.lblNewPassLoop.Text = "Neues Kennwort wiederholen:"
        '
        'txtOldPass
        '
        Me.txtOldPass.Location = New System.Drawing.Point(12, 126)
        Me.txtOldPass.Name = "txtOldPass"
        Me.txtOldPass.Size = New System.Drawing.Size(189, 23)
        Me.txtOldPass.TabIndex = 5
        Me.txtOldPass.UseSystemPasswordChar = True
        '
        'lblOldPass
        '
        Me.lblOldPass.AutoSize = True
        Me.lblOldPass.Location = New System.Drawing.Point(9, 108)
        Me.lblOldPass.Name = "lblOldPass"
        Me.lblOldPass.Size = New System.Drawing.Size(90, 15)
        Me.lblOldPass.TabIndex = 4
        Me.lblOldPass.Text = "Altes Kennwort:"
        '
        'btnChangePass
        '
        Me.btnChangePass.AutoSize = True
        Me.btnChangePass.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnChangePass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChangePass.Location = New System.Drawing.Point(145, 152)
        Me.btnChangePass.Name = "btnChangePass"
        Me.btnChangePass.Size = New System.Drawing.Size(56, 25)
        Me.btnChangePass.TabIndex = 6
        Me.btnChangePass.Text = "Ändern"
        Me.btnChangePass.UseVisualStyleBackColor = True
        '
        'btnChangeAboutMe
        '
        Me.btnChangeAboutMe.AutoSize = True
        Me.btnChangeAboutMe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnChangeAboutMe.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChangeAboutMe.Location = New System.Drawing.Point(245, 122)
        Me.btnChangeAboutMe.Name = "btnChangeAboutMe"
        Me.btnChangeAboutMe.Size = New System.Drawing.Size(56, 25)
        Me.btnChangeAboutMe.TabIndex = 7
        Me.btnChangeAboutMe.Text = "Ändern"
        Me.btnChangeAboutMe.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.AutoSize = True
        Me.btnOk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOk.Location = New System.Drawing.Point(233, 336)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(68, 25)
        Me.btnOk.TabIndex = 8
        Me.btnOk.Text = "Schließen"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'lblverbleibend
        '
        Me.lblverbleibend.AutoSize = True
        Me.lblverbleibend.Location = New System.Drawing.Point(91, 122)
        Me.lblverbleibend.Name = "lblverbleibend"
        Me.lblverbleibend.Size = New System.Drawing.Size(90, 15)
        Me.lblverbleibend.TabIndex = 9
        Me.lblverbleibend.Text = "300 verbleibend"
        '
        'frmEditProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(388, 370)
        Me.Controls.Add(Me.lblverbleibend)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnChangeAboutMe)
        Me.Controls.Add(Me.gbChangePassword)
        Me.Controls.Add(Me.txtAboutMe)
        Me.Controls.Add(Me.lblAboutMe)
        Me.Controls.Add(Me.avatar)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEditProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TenChat - Profil bearbeiten"
        CType(Me.avatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbChangePassword.ResumeLayout(False)
        Me.gbChangePassword.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents avatar As PictureBox
    Friend WithEvents lblAboutMe As Label
    Friend WithEvents txtAboutMe As TextBox
    Friend WithEvents gbChangePassword As GroupBox
    Friend WithEvents btnChangePass As Button
    Friend WithEvents txtOldPass As TextBox
    Friend WithEvents lblOldPass As Label
    Friend WithEvents txtNewPassLoop As TextBox
    Friend WithEvents lblNewPassLoop As Label
    Friend WithEvents txtNewPass As TextBox
    Friend WithEvents lblNewPass As Label
    Friend WithEvents btnChangeAboutMe As Button
    Friend WithEvents btnOk As Button
    Friend WithEvents lblverbleibend As Label
End Class
