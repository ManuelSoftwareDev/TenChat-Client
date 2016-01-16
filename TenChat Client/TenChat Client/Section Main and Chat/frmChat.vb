Imports System.Net.Sockets
Imports System.IO
Public Class frmChat
    Private stream As NetworkStream
    Private streamw As StreamWriter
    Private streamr As StreamReader
    Private client As New TcpClient
    Private ip As IPDOTNETADRESS
    Private t As New Threading.Thread(AddressOf Listen)
    Private Delegate Sub DAddItem(ByVal s As String)
    Public nick As String = "TenChatIP"
    Dim accept As Boolean = False
    Dim saveFile As String = ""
    Dim letzterschritt As Boolean = False
    Private Sub AddItem(ByVal s As String)
        If letzterschritt Then
            Dim bytearray As New List(Of Byte)
            MsgBox(s)
            If s.Length > 0 Then
                For Each charstring As Char In s
                    Dim byt As Byte
                    If Byte.TryParse(charstring, byt) Then
                        bytearray.Add(byt)
                    End If
                Next
                'Dim bytes As Byte()
                'MsgBox(s & " -- " & bytearray.Count)
                IO.File.WriteAllBytes(saveFile, bytearray.ToArray)
                MessageBox.Show("Die Datei wurde Erfolgreich Empfangen und abgespeichert!", "TenChat Client", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                letzterschritt = False
                accept = False
                saveFile = ""
            End If
        Else
            If s.StartsWith("FileSender:: Send File - ") Then
                Dim nickname As String = s.Replace("FileSender:: Send File - ", "")
                Dim msg = MessageBox.Show("Der Benutzer " + nickname + " sendete eine Datei, willst du diese Speichern?", "TenChat Client", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If msg = Windows.Forms.DialogResult.Yes Then
                    accept = True
                Else
                    accept = False
                End If
            ElseIf s.StartsWith("FileName:: ") Then
                If accept = True Then
                    Dim fName As String = s.Replace("FileName:: ", "")
                    Dim svd As New SaveFileDialog
                    svd.Title = "Datei Speichern..."
                    svd.FileName = IO.Path.GetFileNameWithoutExtension(fName)
                    svd.Filter = IO.Path.GetExtension(fName).Replace(".", "").ToUpper & " - File|*" & IO.Path.GetExtension(fName)
                    If svd.ShowDialog = Windows.Forms.DialogResult.OK Then
                        saveFile = svd.FileName
                    Else
                        accept = False
                    End If
                End If
            ElseIf s.StartsWith("Array: ") Then
                If accept = True Then
                    letzterschritt = True
                Else
                    letzterschritt = False
                End If
            ElseIf s.StartsWith(">error:user:not.found ") Then
                Dim username As String = s.Replace(">error:user:not.found ", "")
                RichTextBox1.Text &= vbNewLine & "TenChat Commander: Der Benutzer " + username + " ist nicht Online!"
                Dim selStart = RichTextBox1.SelectionStart
                Dim selLengt = RichTextBox1.SelectionLength
                Dim txSel As String = "TenChat Commander:"

                RichTextBox1.Find(txSel, RichTextBoxFinds.MatchCase)
                RichTextBox1.SelectionFont = New Font(RichTextBox1.SelectionFont, FontStyle.Bold)
                RichTextBox1.SelectionColor = Color.Blue
                RichTextBox1.DeselectAll()
                RichTextBox1.Select(selStart, selLengt)
                RichTextBox1.Update()
            ElseIf s.StartsWith(">info.sendfinishedto ") Then
                Dim username As String = s.Replace(">info.sendfinishedto ", "")
                RichTextBox1.Text &= vbNewLine & "TenChat Commander: Die Naricht an " + username + " wurde übermittelt!"
                Dim selStart = RichTextBox1.SelectionStart
                Dim selLengt = RichTextBox1.SelectionLength
                Dim txSel As String = "TenChat Commander:"
                RichTextBox1.Find(txSel, RichTextBoxFinds.MatchCase)
                RichTextBox1.SelectionFont = New Font(RichTextBox1.SelectionFont, FontStyle.Bold)
                RichTextBox1.SelectionColor = Color.Blue
                RichTextBox1.DeselectAll()
                RichTextBox1.Select(selStart, selLengt)
                RichTextBox1.Update()
            Else
                If RichTextBox1.Text.Length = 0 Then
                    RichTextBox1.Text = s
                Else
                    RichTextBox1.Text = RichTextBox1.Text & vbNewLine & s
                End If
            End If
        End If
    End Sub
    Dim offline As Boolean = False
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        offline = True
        Dim i = frmMain.lstServer.Items.Add(Me.Text.Replace("Chat von ", ""))
        i.SubItems.Add(ip.HostIP)
        i.SubItems.Add(ip.Port)
        Try
            streamw.Dispose()
            streamr.Dispose()
            stream.Dispose()
        Catch ex As Exception
            ' Debug.WriteLine(ex.Message)
        End Try
    End Sub
    Private Sub Form1_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Try
            client.Connect(ip.HostIP, ip.Port) ' hier die ip des servers eintragen.
            ' da dieser beim testen wohl lokal läuft, hier die loopback-ip 127.0.0.1.
            If client.Connected Then
                stream = client.GetStream
                streamw = New StreamWriter(stream)
                streamr = New StreamReader(stream)
                streamw.WriteLine(nick)
                streamw.Flush()
                t.Start()
            Else

                Dim x As New MessageBoxX
                x.ShowBox("Can't connect to the Server!")
                Me.Close()
            End If
        Catch ex As Exception
            Dim x As New MessageBoxX
            x.ShowBox("Can't connect to the Server!")
            Me.Close()
        End Try
    End Sub

    Private Sub Listen()
        While client.Connected
            Try
                Me.Invoke(New DAddItem(AddressOf AddItem), streamr.ReadLine)
            Catch
                If offline = False Then
                    Dim x As New MessageBoxX
                    x.ShowBox("The Server been Shutdown!")
                    x.PictureBox1.Image = SystemIcons.Exclamation.ToBitmap
                    x.Icon = SystemIcons.Exclamation
                    x.TenLabel1.Text = "You Kicked from Server!"
                    Try
                        Me.Close()
                    Catch ex As Exception
                        Application.Exit()
                    End Try
                End If
            End Try
        End While
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Public Sub Connect(IPaddr As IPDOTNETADRESS)
        Me.ip = IPaddr
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub
    Sub Send(text As String)
        history.Add(text)
        If text.StartsWith(">") Then
            Dim cmd = text.Replace(">", "")
            If cmd.ToLower.StartsWith("private") Then
                Dim name As String = cmd.ToLower.Split(" ")(1)
                RichTextBox1.Text &= vbNewLine & "TenChat Commander: Du sendest eine private Naricht an " + name
                Dim selStart = RichTextBox1.SelectionStart
                Dim selLengt = RichTextBox1.SelectionLength
                Dim txSel As String = "TenChat Commander:"
                RichTextBox1.Find(txSel, RichTextBoxFinds.MatchCase)
                RichTextBox1.SelectionFont = New Font(RichTextBox1.SelectionFont, FontStyle.Bold)
                RichTextBox1.SelectionColor = Color.Blue
                RichTextBox1.DeselectAll()
                RichTextBox1.Select(selStart, selLengt)
                RichTextBox1.Update()
                streamw.WriteLine(">message " + name + cmd.Replace("private " + name + " ", ""))
                streamw.Flush()
            End If
        Else
            streamw.WriteLine(text)
            streamw.Flush()
            TextBox1.Clear()
        End If
    End Sub
    Dim historyIndex As Integer = -1
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter AndAlso TextBox1.TextLength > 0 Then
            Send(TextBox1.Text)
        End If
        If e.KeyCode = Keys.Up Then
TryAg:      If history.Count > 0 Then
                If history.Count >= historyIndex + 2 Then
                    historyIndex += 1
                    TextBox1.Text = history(historyIndex)
                Else
                    historyIndex = -1
                    GoTo TryAg
                End If
            End If
        ElseIf e.KeyCode = Keys.Down Then
            If history.Count > 0 Then
                If historyIndex > 0 Then
                    If history.Count >= historyIndex Then

                        historyIndex -= 1

                        TextBox1.Text = history(historyIndex)
                    End If
                Else
                    TextBox1.Text = ""
                End If
            End If
        End If
    End Sub
    Dim history As New List(Of String)
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text.Replace(" ", "").Length = 0 Then
            NavigationButton1.Enabled = False
        Else
            NavigationButton1.Enabled = True
        End If
    End Sub

    Private Sub KopierenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KopierenToolStripMenuItem.Click
        Clipboard.SetText(RichTextBox1.SelectedText)
    End Sub

    Private Sub ChatverlaufSpeichernToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChatverlaufSpeichernToolStripMenuItem.Click
        Dim saveUnder As New SaveFileDialog
        saveUnder.Title = "Save As..."
        saveUnder.Filter = "RichText (*.rtf)|*.rtf|Nur Text(*.txt)|*.txt|ChatLOG (*.log)|*.log|TenChat LOG (*.tlog)|*.tlog"
        If saveUnder.ShowDialog() = Windows.Forms.DialogResult.OK Then
            IO.File.WriteAllText(saveUnder.FileName, TextBox1.Text)
        End If
    End Sub

    Private Sub NavigationButton1_Click(sender As Object, e As EventArgs) Handles NavigationButton1.Click
        Send(TextBox1.Text)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        SendFileDialog.ShowDialog()
    End Sub
    Sub SendFile(filename As String)
        streamw.WriteLine("bytemode on")
        '   streamw.Flush()
        If IO.Path.GetExtension(filename) = "" Then filename = IO.Path.ChangeExtension(filename, "file")
        streamw.WriteLine(filename)
        '  streamw.Flush()
        Dim byt = IO.File.ReadAllBytes(filename)
        ''Dim stringlist As New List(Of String)
        ''stringlist.AddRange(byt)
        ' ''  MsgBox(stringlist(0))
        For Each by As Byte In byt
            streamw.Write(by)
        Next
        MsgBox(byt.Length)
        streamw.WriteLine()
        streamw.Flush()
    End Sub
    Private Sub SendFileDialog_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SendFileDialog.FileOk
        SendFile(SendFileDialog.FileName)
        SendFileDialog.FileName = ""
    End Sub
End Class