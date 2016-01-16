Public Class frmAddServer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtServerIP.TextLength > 0 AndAlso txtServerName.TextLength > 0 Then
            Dim IP As String = txtServerIP.Text
            Dim port As Integer = 8120
            If txtServerIP.Text.Contains(":") Then
                IP = txtServerIP.Text.Split(":")(0)
                port = txtServerIP.Text.Split(":")(1)
            End If
            Dim e1 As ListViewItem = frmMain.lstServer.Items.Add(txtServerName.Text)
            e1.SubItems.Add(IP)
            e1.SubItems.Add(port)
            Me.Close()
        Else
            MessageBoxX.ShowBox("Du musst alle Felder ausfüllen!")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtServerName.TextChanged

    End Sub
End Class