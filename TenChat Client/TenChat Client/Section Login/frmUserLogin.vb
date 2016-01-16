Imports System.Net

Public Class frmUserLogin
    Private Sub frmUserLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.fiststart Then
            My.Settings.fiststart = False
            My.Settings.Save()
            My.Settings.Reload()
            MessageBox.Show("TenChat benutzt jetzt eigene Benutzer. Bitte registrier dich, da die Benutzer von ManuelSoftware.de nichtmehr funktionieren.", "TenChat Client - 17.3", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            txtUsername.Text = My.Settings.MyUserName
            txtPassword.Text = My.Settings.MyPassword
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim frmReg As New frmRegister
        frmReg.ShowDialog()
    End Sub
    Dim WithEvents wbDownload As New Net.WebClient
    Dim lgIn As New frmLoggingIn
    Private Function setted(ParamArray txt() As TextBox) As Boolean
        Dim bool As Boolean = True
        For Each txtbox As TextBox In txt
            If txtbox.TextLength = 0 Then bool = False
        Next
        Return bool
    End Function
    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If Inet.Connection Then
            If setted(txtPassword, txtUsername) Then
                If cbSaveLogin.Checked Then
                    My.Settings.MyUserName = txtUsername.Text
                    My.Settings.MyPassword = txtPassword.Text
                    My.Settings.Save()
                    My.Settings.Reload()
                Else
                    My.Settings.MyUserName = ""
                    My.Settings.MyPassword = ""
                    My.Settings.Save()
                    My.Settings.Reload()
                End If
                lgIn = New frmLoggingIn
                lgIn.Show()
                Me.Hide()
                wbDownload.DownloadStringAsync(New Uri("http://manuelsoftware.de/projects/tenchat/login?user=" & txtUsername.Text & "&pass=" & txtPassword.Text))
            Else
                highlighnotsetted(txtPassword, txtUsername)
            End If
        Else
            Dim msgBox As New MessageBoxX
            msgBox.Text = "TenChat Client - Internetverbindung fehlgeschlagen"
            msgBox.ShowBox("Bitte verbinden Sie ihren " & My.Computer.Info.OSFullName.Replace("Microsoft", "") & " PC mit dem Internet.")
        End If
    End Sub

    Private Sub highlighnotsetted(ParamArray txt() As TextBox)
        For Each txtbox As TextBox In txt
            If txtbox.TextLength = 0 Then txtbox.BackColor = Color.Red
        Next
        MessageBox.Show("Bitte fülle alle Makierten Felder aus!", "TenChat Client - Anmelden", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub

    Private Sub wbDownload_DownloadStringCompleted(sender As Object, e As DownloadStringCompletedEventArgs) Handles wbDownload.DownloadStringCompleted
        lgIn.Close()
        Dim eString As String = e.Result
        If eString.StartsWith("LoggedIn") Then
            'frmMain = New frmMain
            frmMain.username = txtUsername.Text
            frmMain.id = Integer.Parse(eString.Replace("LoggedIn ", ""))
            frmMain.Show()
        Else
            Dim xmsg As New MessageBoxX
            xmsg.Text = "TenChat Client - Anmeldung fehlgeschlagen"
            xmsg.ShowBox("Falscher Benutzername und/oder" & vbNewLine & " Falsches Kennwort. Result: " & eString)
            Me.Show()
        End If
    End Sub

    Private Sub cbSaveLogin_CheckedChanged(sender As Object, e As EventArgs) Handles cbSaveLogin.CheckedChanged

    End Sub
End Class