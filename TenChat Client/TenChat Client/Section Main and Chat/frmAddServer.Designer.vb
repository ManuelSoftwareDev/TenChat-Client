<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddServer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddServer))
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblServerIP = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtServerName = New AeroSuite.Controls.CueTextBox()
        Me.txtServerIP = New AeroSuite.Controls.CueTextBox()
        Me.SuspendLayout()
        '
        'lblName
        '
        resources.ApplyResources(Me.lblName, "lblName")
        Me.lblName.Name = "lblName"
        '
        'lblServerIP
        '
        resources.ApplyResources(Me.lblServerIP, "lblServerIP")
        Me.lblServerIP.Name = "lblServerIP"
        '
        'btnSave
        '
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White
        resources.ApplyResources(Me.btnSave, "btnSave")
        Me.btnSave.Name = "btnSave"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtServerName
        '
        resources.ApplyResources(Me.txtServerName, "txtServerName")
        Me.txtServerName.Name = "txtServerName"
        '
        'txtServerIP
        '
        resources.ApplyResources(Me.txtServerIP, "txtServerIP")
        Me.txtServerIP.Name = "txtServerIP"
        '
        'frmAddServer
        '
        Me.AcceptButton = Me.btnSave
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Controls.Add(Me.txtServerIP)
        Me.Controls.Add(Me.txtServerName)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblServerIP)
        Me.Controls.Add(Me.lblName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddServer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblServerIP As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtServerName As AeroSuite.Controls.CueTextBox
    Friend WithEvents txtServerIP As AeroSuite.Controls.CueTextBox
End Class
