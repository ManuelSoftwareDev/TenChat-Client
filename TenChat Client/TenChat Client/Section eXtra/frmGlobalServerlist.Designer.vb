<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGlobalServerlist
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGlobalServerlist))
        Me.btnApply = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lstServers = New AeroSuite.Controls.AeroListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'btnApply
        '
        Me.btnApply.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnApply.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.btnApply.Location = New System.Drawing.Point(469, 0)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(145, 55)
        Me.btnApply.TabIndex = 1
        Me.btnApply.Text = "Übernehmen"
        Me.btnApply.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.btnClose.Location = New System.Drawing.Point(469, 373)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(145, 56)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Schließen"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lstServers
        '
        Me.lstServers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lstServers.Dock = System.Windows.Forms.DockStyle.Left
        Me.lstServers.FullRowSelect = True
        Me.lstServers.Location = New System.Drawing.Point(0, 0)
        Me.lstServers.Name = "lstServers"
        Me.lstServers.Size = New System.Drawing.Size(470, 428)
        Me.lstServers.TabIndex = 3
        Me.lstServers.UseCompatibleStateImageBehavior = False
        Me.lstServers.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Servername"
        Me.ColumnHeader3.Width = 175
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "IP"
        Me.ColumnHeader4.Width = 291
        '
        'frmServerlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 428)
        Me.Controls.Add(Me.lstServers)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnApply)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmServerlist"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Globale Serverliste [server.vlist]"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lstServers As AeroSuite.Controls.AeroListView
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
End Class
