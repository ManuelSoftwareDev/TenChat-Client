<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChat
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChat))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.KopierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ChatverlaufSpeichernToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NavigationButton1 = New AeroSuite.Controls.NavigationButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SendFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        resources.ApplyResources(Me.TextBox1, "TextBox1")
        Me.TextBox1.Name = "TextBox1"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.White
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.RichTextBox1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.RichTextBox1.EnableAutoDragDrop = True
        resources.ApplyResources(Me.RichTextBox1, "RichTextBox1")
        Me.RichTextBox1.ForeColor = System.Drawing.Color.Black
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.White
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KopierenToolStripMenuItem, Me.ToolStripMenuItem1, Me.ChatverlaufSpeichernToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        resources.ApplyResources(Me.ContextMenuStrip1, "ContextMenuStrip1")
        '
        'KopierenToolStripMenuItem
        '
        Me.KopierenToolStripMenuItem.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.KopierenToolStripMenuItem, "KopierenToolStripMenuItem")
        Me.KopierenToolStripMenuItem.Name = "KopierenToolStripMenuItem"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.BackColor = System.Drawing.Color.White
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        resources.ApplyResources(Me.ToolStripMenuItem1, "ToolStripMenuItem1")
        '
        'ChatverlaufSpeichernToolStripMenuItem
        '
        Me.ChatverlaufSpeichernToolStripMenuItem.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.ChatverlaufSpeichernToolStripMenuItem, "ChatverlaufSpeichernToolStripMenuItem")
        Me.ChatverlaufSpeichernToolStripMenuItem.Name = "ChatverlaufSpeichernToolStripMenuItem"
        '
        'NavigationButton1
        '
        Me.NavigationButton1.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.NavigationButton1, "NavigationButton1")
        Me.NavigationButton1.Name = "NavigationButton1"
        Me.NavigationButton1.Type = AeroSuite.Controls.NavigationButtonType.Forward
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SendFileDialog
        '
        resources.ApplyResources(Me.SendFileDialog, "SendFileDialog")
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.NavigationButton1)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents KopierenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ChatverlaufSpeichernToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NavigationButton1 As AeroSuite.Controls.NavigationButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SendFileDialog As System.Windows.Forms.OpenFileDialog

End Class
