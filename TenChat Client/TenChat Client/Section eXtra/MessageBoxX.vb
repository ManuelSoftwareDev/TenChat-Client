Public Class MessageBoxX

    Private Sub MessageBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub ShowBox(Text As String)
        Label1.Text = Text
        Me.ShowDialog()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
Public Class TenLabel
    Inherits Label

    Public Sub New()
        Me.Font = New Font("Segoe UI", 11)
        Me.ForeColor = Color.FromArgb(0, 51, 153)

    End Sub
End Class
