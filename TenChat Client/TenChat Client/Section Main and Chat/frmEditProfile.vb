Public Class frmEditProfile
    Private Sub txtAboutMe_TextChanged(sender As Object, e As EventArgs) Handles txtAboutMe.TextChanged
        lblverbleibend.Text = txtAboutMe.MaxLength - txtAboutMe.TextLength & " verbleibend"
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Me.Close()
    End Sub

    Private Sub frmEditProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtAboutMe.Text = frmMain.GetData(frmMain.id, frmMain.username, "about").Replace("\rn", vbNewLine).Replace("$SHA$", "<$MODSCHASKI$>")

    End Sub

    Private Sub btnChangeAboutMe_Click(sender As Object, e As EventArgs) Handles btnChangeAboutMe.Click
        Dim res As String = frmMain.SetData(frmMain.id, frmMain.username, "about", txtAboutMe.Text.Replace(vbNewLine, "\rn").Replace("$SHA$", "SHA").Replace("<$MODSCHASKI$>", "$SHA$"))
        If res = "Updated" Then
            MessageBox.Show("Die Daten wurden erfolgreich umgeändert.", "TenChat - Profil bearbeiten", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Es gab einen Fehler beim ändern der Daten. Bitte starte TenChat neu.", "TenChat - Fehler beim ändern", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnChangePass_Click(sender As Object, e As EventArgs) Handles btnChangePass.Click
        If txtNewPass.Text = txtNewPassLoop.Text Then
            Dim res As String = frmMain.SetPass(frmMain.id, frmMain.username, txtNewPass.Text, txtOldPass.Text)
            If res = "Updated" Then
                MessageBox.Show("Das Kennwort wurde erfolgreich geändert.", "TenChat - Kennwort ändern", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                MessageBox.Show("Es gab einen Fehler beim ändern des Kennworts. Das alte Kennwort ist falsch!", "TenChat - Kennwort ändern", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Das neue Kennwort wurde nicht richtig wiederholt.", "TenChat - Kennwort ändern", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class