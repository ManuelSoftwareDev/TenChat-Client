Public Class frmGlobalServerlist

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)
        btnApply.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        Dim lstViewItem As New ListViewItem
        Dim ipBox As New TextBox
        ipBox.Text = lstServers.FocusedItem.SubItems(1).Text
        lstViewItem.Text = lstServers.FocusedItem.Text
        lstViewItem.SubItems.Add(ipBox.Text.Split(":")(0))
        lstViewItem.SubItems.Add(ipBox.Text.Split(":")(1))
        frmMain.lstServer.Items.Add(lstViewItem)
        Me.Close()
    End Sub
    Sub loadData()
        lstServers.Items.Clear()
        Dim textbox As New TextBox
        Dim webclie As New Net.WebClient
        textbox.Text = webclie.DownloadString("http://www.manuelsoftware.de/software/tenchat/server.vlist")
        Dim vs As New TextBox
        For Each line As String In textbox.Lines
            vs.Text = line
            Dim name As String = vs.Text.Split("|")(0)
            Dim ip As String = vs.Text.Split("|")(1).Replace(" ", "")
            lstServers.Items.Add(name).SubItems.Add(ip)
        Next
        vs.Dispose()
    End Sub
    Private Sub Serverliste_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class