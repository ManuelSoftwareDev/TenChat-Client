<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblMyServers = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.btnJoin = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnVersionLog = New System.Windows.Forms.Button()
        Me.btnCheckForUpdates = New System.Windows.Forms.Button()
        Me.btnServerlist = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.lstServer = New AeroSuite.Controls.AeroListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmdAbout = New AeroSuite.Controls.CommandLink()
        Me.sepDel_Check = New AeroSuite.Controls.Seperator()
        Me.Seperator2 = New AeroSuite.Controls.Seperator()
        Me.SuspendLayout()
        '
        'lblMyServers
        '
        Me.lblMyServers.AutoSize = True
        Me.lblMyServers.Location = New System.Drawing.Point(14, 10)
        Me.lblMyServers.Name = "lblMyServers"
        Me.lblMyServers.Size = New System.Drawing.Size(78, 15)
        Me.lblMyServers.TabIndex = 1
        Me.lblMyServers.Text = "Meine Server:"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(9, 337)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(116, 15)
        Me.lblUsername.TabIndex = 2
        Me.lblUsername.Text = "Mein Benutzername:"
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.SystemColors.Window
        Me.txtUsername.Location = New System.Drawing.Point(12, 355)
        Me.txtUsername.MaxLength = 16
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.ReadOnly = True
        Me.txtUsername.Size = New System.Drawing.Size(113, 23)
        Me.txtUsername.TabIndex = 3
        Me.txtUsername.Text = "%username%"
        '
        'btnJoin
        '
        Me.btnJoin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnJoin.Location = New System.Drawing.Point(486, 27)
        Me.btnJoin.Name = "btnJoin"
        Me.btnJoin.Size = New System.Drawing.Size(87, 27)
        Me.btnJoin.TabIndex = 4
        Me.btnJoin.Text = "Betreten"
        Me.btnJoin.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Location = New System.Drawing.Point(486, 60)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(87, 27)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Hinzufügen"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDel.Location = New System.Drawing.Point(486, 94)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(87, 27)
        Me.btnDel.TabIndex = 6
        Me.btnDel.Text = "Löschen"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnVersionLog
        '
        Me.btnVersionLog.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVersionLog.Location = New System.Drawing.Point(486, 189)
        Me.btnVersionLog.Name = "btnVersionLog"
        Me.btnVersionLog.Size = New System.Drawing.Size(87, 29)
        Me.btnVersionLog.TabIndex = 8
        Me.btnVersionLog.Text = "Versions Log"
        Me.btnVersionLog.UseVisualStyleBackColor = True
        '
        'btnCheckForUpdates
        '
        Me.btnCheckForUpdates.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCheckForUpdates.Location = New System.Drawing.Point(486, 135)
        Me.btnCheckForUpdates.Name = "btnCheckForUpdates"
        Me.btnCheckForUpdates.Size = New System.Drawing.Size(87, 40)
        Me.btnCheckForUpdates.TabIndex = 10
        Me.btnCheckForUpdates.Text = "Auf Updates prüfen"
        Me.btnCheckForUpdates.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCheckForUpdates.UseVisualStyleBackColor = True
        '
        'btnServerlist
        '
        Me.btnServerlist.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnServerlist.Location = New System.Drawing.Point(486, 224)
        Me.btnServerlist.Name = "btnServerlist"
        Me.btnServerlist.Size = New System.Drawing.Size(87, 25)
        Me.btnServerlist.TabIndex = 12
        Me.btnServerlist.Text = "Server Liste"
        Me.btnServerlist.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button8.Location = New System.Drawing.Point(131, 355)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(86, 23)
        Me.Button8.TabIndex = 13
        Me.Button8.Text = "Einstellungen"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'lstServer
        '
        Me.lstServer.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lstServer.FullRowSelect = True
        Me.lstServer.Location = New System.Drawing.Point(12, 29)
        Me.lstServer.Name = "lstServer"
        Me.lstServer.Size = New System.Drawing.Size(412, 294)
        Me.lstServer.TabIndex = 14
        Me.lstServer.UseCompatibleStateImageBehavior = False
        Me.lstServer.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Name"
        Me.ColumnHeader4.Width = 174
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "IP"
        Me.ColumnHeader5.Width = 129
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Port"
        Me.ColumnHeader6.Width = 105
        '
        'cmdAbout
        '
        Me.cmdAbout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAbout.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdAbout.Location = New System.Drawing.Point(460, 253)
        Me.cmdAbout.Name = "cmdAbout"
        Me.cmdAbout.Note = ""
        Me.cmdAbout.Size = New System.Drawing.Size(138, 45)
        Me.cmdAbout.TabIndex = 15
        Me.cmdAbout.Text = "Über TenChat"
        Me.cmdAbout.UseVisualStyleBackColor = True
        '
        'sepDel_Check
        '
        Me.sepDel_Check.BackColor = System.Drawing.Color.White
        Me.sepDel_Check.Location = New System.Drawing.Point(486, 127)
        Me.sepDel_Check.Name = "sepDel_Check"
        Me.sepDel_Check.Size = New System.Drawing.Size(87, 2)
        Me.sepDel_Check.TabIndex = 16
        Me.sepDel_Check.TabStop = False
        '
        'Seperator2
        '
        Me.Seperator2.BackColor = System.Drawing.Color.White
        Me.Seperator2.Location = New System.Drawing.Point(486, 181)
        Me.Seperator2.Name = "Seperator2"
        Me.Seperator2.Size = New System.Drawing.Size(87, 2)
        Me.Seperator2.TabIndex = 18
        Me.Seperator2.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(606, 386)
        Me.Controls.Add(Me.Seperator2)
        Me.Controls.Add(Me.sepDel_Check)
        Me.Controls.Add(Me.cmdAbout)
        Me.Controls.Add(Me.lstServer)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.btnServerlist)
        Me.Controls.Add(Me.btnCheckForUpdates)
        Me.Controls.Add(Me.btnVersionLog)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnJoin)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblMyServers)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TenChat Client"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMyServers As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents btnJoin As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnVersionLog As System.Windows.Forms.Button
    Friend WithEvents btnCheckForUpdates As System.Windows.Forms.Button
    Friend WithEvents btnServerlist As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents lstServer As AeroSuite.Controls.AeroListView
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmdAbout As AeroSuite.Controls.CommandLink
    Friend WithEvents sepDel_Check As AeroSuite.Controls.Seperator
    Friend WithEvents Seperator2 As AeroSuite.Controls.Seperator
    Friend WithEvents btnAdd As Button
End Class
