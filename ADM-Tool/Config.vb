Public Class Config
    Private Sub Config_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.Server
        TextBox2.Text = My.Settings.Port
        TextBox3.Text = My.Settings.Benutzer
        TextBox4.Text = My.Settings.Passwort
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.Server = TextBox1.Text
        My.Settings.Port = TextBox2.Text
        My.Settings.Benutzer = TextBox3.Text
        My.Settings.Passwort = TextBox4.Text
        My.Settings.Save()
        My.Settings.Reload()

        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class