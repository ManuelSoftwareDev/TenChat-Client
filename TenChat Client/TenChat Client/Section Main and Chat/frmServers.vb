Public Class frmMain

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnJoin.Click
        If lstServer.SelectedItems.Count = 1 Then
            Dim client As New frmChat
            client.Connect(New IPDOTNETADRESS(lstServer.FocusedItem.SubItems(1).Text.Replace("localhost", "127.0.0.1"), lstServer.FocusedItem.SubItems(2).Text))
            client.Text = "Chat von " & lstServer.FocusedItem.Text
            client.nick = txtUsername.Text
            client.Show()
            lstServer.FocusedItem.Remove()
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Dim c As Integer = lstServer.SelectedItems.Count
        Dim cItem = lstServer.SelectedItems
        If c > 0 Then
            If c = 1 Then
                Dim msgRes As DialogResult
                Dim itm As ListViewItem = cItem(0)
                msgRes = MessageBox.Show("Möchtest du den Server """ & itm.Text & """ entfernen?", "TenChat - Server entfernen", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If msgRes = DialogResult.Yes Then
                    itm.Remove()
                End If
            Else
                Dim msgRes As DialogResult
                msgRes = MessageBox.Show("Möchtest du die " & c & " ausgewählten Server entfernen?", "TenChat - Server entfernen", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If msgRes = DialogResult.Yes Then
                    For Each itm As ListViewItem In cItem
                        itm.Remove()
                    Next
                End If
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim add As New frmAddServer
        add.ShowDialog()
    End Sub
    Public Sub LoadServers()
        If IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\tenchat\srv\src\Data") = False Then IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\tenchat\srv\src\Data")
        For Each file As String In My.Computer.FileSystem.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\tenchat\srv\src\Data", FileIO.SearchOption.SearchTopLevelOnly, "*.tcs")
            addserver(IO.File.ReadAllText(file), IO.Path.GetFileNameWithoutExtension(file))
        Next
    End Sub

    Public Sub SaveServers()
        If IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\tenchat\srv\src\Data") = False Then IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\tenchat\srv\src\Data")

        For Each item As ListViewItem In Me.lstServer.Items
            IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\tenchat\srv\src\Data\" & item.Text & ".tcs", item.SubItems(1).Text & ":" & item.SubItems(2).Text)
        Next
    End Sub

    Sub addserver(IP As String, name As String)
        Dim port As Integer
        If IP.Contains(":") Then
            Dim tx As New TextBox
            tx.Text = IP
            IP = tx.Text.Split(":")(0)
            port = tx.Text.Split(":")(1)
        End If
        Dim e1 As ListViewItem = Me.lstServer.Items.Add(name)
        e1.SubItems.Add(IP)
        e1.SubItems.Add(port)
    End Sub
    Sub LogOut()
        Dim webBrowser As New WebBrowser
        webBrowser.Navigate("http://www.manuelsoftware.de/?do=logout")
    End Sub
    Private Sub TenChat_Client_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        SaveServers()
        LogOut()
        Application.Exit()
    End Sub
    Public Function GetData(id As Integer, username As String, column As String) As String
        Dim wb As New Net.WebClient
        Return wb.DownloadString("http://www.manuelsoftware.de/projects/tenchat/info?user=" & username & "&id=" & id & "&info=" & column)
    End Function
    Public Function SetData(id As Integer, username As String, column As String, value As String)
        Dim wb As New Net.WebClient
        Return wb.DownloadString("http://www.manuelsoftware.de/projects/tenchat/change?user=" & username & "&id=" & id & "&col=" & column & "&val=" & value)
    End Function
    Public Function SetPass(id As Integer, username As String, newpass As String, pass As String)
        Dim wb As New Net.WebClient
        Return wb.DownloadString("http://www.manuelsoftware.de/projects/tenchat/changepass?user=" & username & "&id=" & id & "&newpass=" & newpass & "&pass=" & pass)
    End Function
    Public username As String
    Public id As Integer
    Private Sub TenChat_Client_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Text = username
        'If _bASr = True Then
        'Me.TextBox1.Text = "TestNutzer"
        'Else
        'LOGIN
        'Try
        '        Dim ne As New Net.WebClient
        '        Dim str As String = ne.DownloadString("http://www.manuelsoftware.de/api.php")
        '        If str.Replace(" ", "").Length > 0 Then
        '            Dim username As String = GetUserName(str)
        '            Me.TextBox1.Text = username
        '            Dim ini As New INIFile(str)
        '            TextBox2.Text = "Hobbys: " & ini.GetFromIni("hobby") & vbNewLine & "IP: " & ini.GetFromIni("ip")
        '        Else
        '            MessageBox.Show("Fehler beim Anmelden, Kontaktiere den Support Fehlercode ist xC14!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '            Application.Exit()
        '        End If
        '        If TextBox1.Text.Length = 0 Then
        '            MessageBox.Show("Kontaktiere den Support es ist ein Fehler aufgetreten!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '            Application.Exit()
        '        End If
        '        updatechecking()
        '        TextBox1.ReadOnly = True
        '        TextBox1.BackColor = Color.White
        '    Catch ex As Exception
        '        MessageBox.Show("Du musst mit dem Internet verbunden Sein!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    End Try
        LoadServers()
        'Load Plugins
        Dim loadPL As Boolean = True
        If My.Application.CommandLineArgs.Count = 1 Then
            Dim arg As String = My.Application.CommandLineArgs(0)
            If arg = "-noplugins" Then
                loadPL = False
            End If
        End If
        If loadPL Then
            loadplugins()
        End If
        'End If
    End Sub

    Sub loadplugins()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        If txtUsername.Text = "Konsole" Then
            txtUsername.Text = "TenChatUser"
            Dim x As New MessageBoxX
            x.ShowBox("Du kannst nicht Konsole heißen!")
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        If lstServer.SelectedItems.Count = 1 Then
            Dim client As New frmChat
            client.Connect(New IPDOTNETADRESS("127.0.0.1", 8120))
            client.Text = "Localserver"
            client.nick = txtUsername.Text
            client.Show()
            lstServer.FocusedItem.Remove()
        End If
    End Sub
    Public Sub DownloadWithAsy(num As Nummerader)
        If MessageBox.Show("Ein Update ist verfügbar! Möchtest du es Herunterladen und Installieren? Version " & num.ver, "Update Verfügbar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
            Dim download As New Net.WebClient
            download.DownloadFile(num.linkeras, Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\updater.exe")
            Try
                Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\updater.exe").StartInfo.Verb = "runas"
            Catch
            End Try
        End If
    End Sub
    Public Sub CheckForUpdates(Optional isStill As Boolean = False)
        Dim bool = CheckForUpdatses()
        If isStill Then
            If bool.PropBool = True Then
                DownloadWithAsy(bool)
            End If
        Else
            If bool.PropBool = True Then
                DownloadWithAsy(bool)
            Else
                MessageBox.Show("Es ist kein Update verfügbar. " & vbNewLine & "Aktuelle Version: " & sing.ToString.Replace(",", ".") & vbNewLine & "Neueste Version: " & bool.ver.ToString.Replace(",", "."), "Kein Update gefunden!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        End If
    End Sub
    Private sing As Double = 16.2

    Public Sub updatechecking()
        Dim downloader As New Net.WebClient
        Dim versionurl As String = "http://www.manuelsoftware.de/downloads/TenChatUpdate/update.info"
        Dim duble As Double
        Dim thisversion As Double = 16.3
        Dim ver As String = downloader.DownloadString(versionurl)
        If Double.TryParse(ver, duble) Then
            If duble > thisversion Then
                Dim updatenameurl As String = "http://www.manuelsoftware.de/downloads/TenChatUpdate/update.name"
                Dim updatename As String = downloader.DownloadString(updatenameurl)
                Dim ans = MessageBox.Show("Es ist ein Update verfügbar Version " & duble.ToString.Replace(",", ".") & " (" & updatename & "). Willst du es downloaden?", "Updater", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If ans = DialogResult.Yes Then
                    Dim upd As New Update
                    upd.StartUpdate()
                    upd.ShowDialog()
                End If
            End If
        End If
    End Sub
    Private Function CheckForUpdatses() As Nummerader
        Dim aktuelleVersion As Single = sing
        Dim downloadClient As New Net.WebClient
        Dim textInBox As New TextBox
        textInBox.Text = downloadClient.DownloadString("https://dl.dropboxusercontent.com/u/68852811/UpdateTenChat/downloadscript.dsx")
        Dim downloadScript As String() = textInBox.Lines
        Dim downloadVersio As Double
        Double.TryParse(downloadClient.DownloadString(downloadScript(0).Replace("VER=", "")), downloadVersio)
        Dim downloadUpdate As String = downloadScript(1).Replace("DOW=", "")
        If downloadVersio <= aktuelleVersion Then
            Return New Nummerader(False, "", downloadVersio)
        Else
            Return New Nummerader(True, downloadUpdate, downloadVersio)
        End If
    End Function
    Public Class Nummerader
        Private isRet As Boolean
        Private links As String
        Private sr As Double
        Public Sub New(isRet As Boolean, Link As String, ver As Double)
            Me.isRet = isRet
            sr = ver
            links = Link
        End Sub
        Public ReadOnly Property PropBool As Boolean
            Get
                Return isRet
            End Get
        End Property
        Public ReadOnly Property ver As Double
            Get
                Return sr
            End Get
        End Property
        Public ReadOnly Property linkeras As String
            Get
                Return links
            End Get
        End Property
    End Class
    Sub StartAgain()
        Dim process As System.Diagnostics.Process = Nothing
        Dim processStartInfo As System.Diagnostics.ProcessStartInfo

        processStartInfo = New System.Diagnostics.ProcessStartInfo()

        processStartInfo.FileName = Application.ExecutablePath


        If System.Environment.OSVersion.Version.Major >= 6 Then ' Windows Vista or higher
            processStartInfo.Verb = "runas"
        Else
            ' No need to prompt to run as admin
        End If

        processStartInfo.Arguments = ""
        processStartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal
        processStartInfo.UseShellExecute = True

        Try
            process = System.Diagnostics.Process.Start(processStartInfo)
        Catch ex As Exception
        Finally

            If Not (process Is Nothing) Then
                process.Dispose()
            End If

        End Try
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnCheckForUpdates.Click
        Dim checkforupdates As New Update
        checkforupdates.StartUPDATING()
        'CheckForUpdates(False)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnVersionLog.Click
        'Dim ver As New frmVersionLOG
        'ver.ShowDialog()
        Process.Start("http://dl.manuelsoftware.de/TenChat/VersionLog.log")
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListView1_DragDrop(sender As Object, e As DragEventArgs)
        If e.Data.GetDataPresent("FileDrop", True) = True Then


            Dim Wert As String() = CType(e.Data.GetData("FileDrop"), Object) 'Hier wird der Variable "Wert" das übergeben, was wir auf die Form gezogen haben. Bei einer Datei wäre es dann der Pfad der Datei.
            If IO.File.Exists(Wert(0)) Then
                Dim t = Wert(0)
                If IO.Path.GetExtension(t) = ".tLog" Then
                    Dim jF As String() = IO.File.ReadAllLines(t)
                    Dim adress As String = jF(0)
                    Dim port As String = jF(1)
                    Dim s = lstServer.Items.Add(IO.Path.GetFileNameWithoutExtension(t))
                    s.SubItems.Add(adress)
                    s.SubItems.Add(port)
                End If
            End If
        End If
    End Sub

    Private Sub ListView1_DragEnter(sender As Object, e As DragEventArgs)
        e.Effect = DragDropEffects.Move
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnServerlist.Click
        frmGlobalServerlist.ShowDialog()
    End Sub

    Private Sub lstServerListe_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lstServer.ColumnClick
        If lstServer.Sorting = SortOrder.Ascending Then
            lstServer.Sorting = SortOrder.Descending
            lstServer.Sort()
            lstServer.Columns(0).Text = "Name   ˄"
        Else
            lstServer.Sorting = SortOrder.Ascending
            lstServer.Sort()
            lstServer.Columns(0).Text = "Name   ˅"
        End If
    End Sub

    Private Sub lstServerListe_ColumnWidthChanging(sender As Object, e As ColumnWidthChangingEventArgs) Handles lstServer.ColumnWidthChanging
        e.Cancel = True
    End Sub

    Private Sub ServerListe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstServer.SelectedIndexChanged

    End Sub


    Private Sub CommandLink1_Click(sender As Object, e As EventArgs) Handles cmdAbout.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim edp As New frmEditProfile
        edp.ShowDialog()
    End Sub
End Class