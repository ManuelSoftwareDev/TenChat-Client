Imports System.Net.NetworkInformation

Public Class frmRegister
    Private Function validateAll() As Boolean
        Dim bRet As Boolean = True
        If txtEmail.Text.Contains("@") AndAlso txtEmail.Text.Contains(".") Then
            txtEmail.BackColor = Color.White
        Else
            bRet = False
            txtEmail.BackColor = Color.Red
        End If
        If txtUsername.Text.ToLower.Contains("@") OrElse txtUsername.Text.ToLower.Contains("porno") OrElse txtUsername.Text.ToLower.Contains("admin") OrElse txtUsername.Text.ToLower.Contains("!") OrElse txtUsername.Text.ToLower.Contains("fick") OrElse txtUsername.Text.ToLower.Contains("dum") OrElse txtUsername.Text.ToLower.Contains(":") OrElse txtUsername.Text.ToLower.Contains(";") OrElse txtUsername.Text.ToLower.Contains("\r") OrElse txtUsername.Text.ToLower.Contains("\n") Then
            bRet = False
            txtUsername.BackColor = Color.Red
        End If
        Return bRet
    End Function
    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        If Inet.Connection Then
            If setted(txtEmail, txtPassword, txtUsername) Then
                If validateAll() Then
                    Dim wbclient As New Net.WebClient
                    Dim news As Integer
                    If cbNewsletter.Checked Then news = 1 Else news = 0
                    Dim strRegister = wbclient.DownloadString("http://manuelsoftware.de/projects/tenchat/register?user=" & txtUsername.Text.Replace(" ", "%20") & "&pass=" & txtPassword.Text.Replace(" ", "%20") & "&email=" & txtEmail.Text.Replace(" ", "%20") & "&news=" & news)
                    If strRegister = "Username not avaible" Then
                        txtUsername.BackColor = Color.Red
                        Dim msgX As New MessageBoxX
                        msgX.Text = "TenChat Client - Registrieren"
                        msgX.ShowBox("Dieser Benutzername ist bereits vergeben.")
                        Return
                    End If
                    MessageBox.Show("Du hast dich erfolgreich Registriert. Du bekommst von uns eine E-Mail. Du kannst dich jetzt einloggen.", "TenChat Client - Registrieren", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Me.Close()
                Else
                    MessageBox.Show("Wende Bitte das richtige Format an.", "TenChat Client - Registrieren")
                End If
            Else
                    highlighnotsetted(txtEmail, txtPassword, txtUsername)
            End If
        Else
            Dim msgBox As New MessageBoxX
            msgBox.Text = "TenChat Client - Internetverbindung fehlgeschlagen"
            msgBox.ShowBox("Bitte verbinden Sie ihren " & My.Computer.Info.OSFullName.Replace("Microsoft", "") & " PC mit dem Internet.")
        End If
    End Sub
    Private Function setted(ParamArray txt() As TextBox) As Boolean
        Dim bool As Boolean = True
        For Each txtbox As TextBox In txt
            If txtbox.TextLength = 0 Then bool = False
        Next
        Return bool
    End Function
    Private Sub highlighnotsetted(ParamArray txt() As TextBox)
        For Each txtbox As TextBox In txt
            If txtbox.TextLength = 0 Then txtbox.BackColor = Color.Red
        Next
        MessageBox.Show("Bitte fülle alle Makierten Felder aus!", "TenChat Client - Anmelden", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub
    Private Sub frmRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

Public Class Inet
    Public Shared Function Connection() As Boolean
        Try
            Dim ping As New Ping
            ping = New Ping()
            Dim pingreply As PingReply
            pingreply = ping.Send("www.google.com", 100)
            Return pingreply.Status = IPStatus.Success
        Catch
            Return False
        End Try
    End Function
End Class