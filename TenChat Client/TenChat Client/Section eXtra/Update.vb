Imports System.ComponentModel
Imports System.Net

Public Class Update
    Private Sub Update_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub StartUPDATING()
        CheckForUpdates()
        ShowDialog()
    End Sub
    'IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "downloads", "update-tc.exe")
    Sub CheckForUpdates()
        Dim url As String = "http://www.manuelsoftware.de/downloads/TenChatUpdate/update.info"
        downloader.DownloadStringAsync(New Uri(url))
    End Sub

    Public WithEvents downloader As New Net.WebClient
    Public WithEvents updater As New Net.WebClient

    Dim txt As String = "Prüfe auf Updates"
    Dim dots As Integer = 0
    Private Sub dot3_Tick(sender As Object, e As EventArgs) Handles dot3.Tick
        If dots = 0 Then
            dots = 1
            Label1.Text = txt
        ElseIf dots = 1
            dots = 2
            Label1.Text = txt & "."
        ElseIf dots = 2
            dots = 3
            Label1.Text = txt & ".."
        ElseIf dots = 3
            dots = 0
            Label1.Text = txt & "..."
        End If
        Me.Text = Label1.Text
    End Sub

    Sub StartUpdate()
        dot3.Stop()
        Dim downloUrl As String = "http://www.manuelsoftware.de/downloads/TenChatUpdate/update.exe"
        updater.DownloadFileAsync(New Uri(downloUrl), IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "downloads", "update-tc.exe"))
    End Sub

    Private Sub downloader_DownloadStringCompleted(sender As Object, e As DownloadStringCompletedEventArgs) Handles downloader.DownloadStringCompleted
        If e.Cancelled = False Then
            Dim infs As String = e.Result
            Dim ver As Double = 17.3
            Dim down As Double
            If Double.TryParse(infs, down) Then
                If ver < down Then
                    Dim upswetchName As String = downloader.DownloadString("http://www.manuelsoftware.de/downloads/TenChatUpdate/update.name")
                    Dim version As String = ver.ToString.Replace(",", ".")
                    dot3.Stop()
                    Me.Text = "Update verfügbar"
                    Label1.Text = "Update verfügbar"
                    Dim answer = MessageBox.Show("Es ist das Update " & version & " (" & upswetchName & ") verfügbar. Möchtest du dieses herunterladen und installieren?", "TenChat Updater", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If answer = DialogResult.Yes Then
                        StartUpdate()
                    Else
                        Me.Close()
                    End If
                Else
                    dot3.Stop()
                    Me.Text = "Kein Update verfügbar"
                    Label1.Text = "Kein Update verfügbar"
                    MessageBox.Show("Es ist kein Update verfügbar!", "TenChat Client Updater", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Me.Close()
                End If
            Else
                dot3.Stop()
                Me.Text = "Fehler!"
                Label1.Text = "Fehler beim Downloaden!"
                MessageBox.Show("Bitte Kontaktiere den Support mit dem Fehlercode xAlpha_TenChat Fehler beim prüfen auf Updates!", "TenChat", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If
        End If
    End Sub

    Private Sub updater_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles updater.DownloadProgressChanged
        Me.Text = "Downloade Update..."
        Label1.Text = "Download Update (" & e.ProgressPercentage & "%" & ")"
    End Sub

    Private Sub updater_DownloadFileCompleted(sender As Object, e As AsyncCompletedEventArgs) Handles updater.DownloadFileCompleted
        If e.Cancelled = False Then
            Dim path As String = IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "downloads", "update-tc.exe")
            Try
                Me.Text = "Download abgeschlossen"
                Label1.Text = "Download abgeschlossen"
                Dim prc As New Process
                prc.StartInfo.FileName = path
                prc.StartInfo.Verb = "runas"
                prc.Start()
                Application.Exit()
            Catch
                'MessageBox.Show("Es ist ein unbekannter Fehler aufgetreten!", "TenChat Client Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End Try
        Else
            MessageBox.Show("Beim Downloaden ist ein Fehler aufgetreten!" & vbNewLine & e.Error.Message, "TenChat Client IUpdate Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If
        Me.Close()
    End Sub
End Class