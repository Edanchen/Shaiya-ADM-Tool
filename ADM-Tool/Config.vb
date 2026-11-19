Public Class Config
    Private Sub Config_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.Server
        TextBox2.Text = My.Settings.Port
        TextBox3.Text = My.Settings.Benutzer
        TextBox4.Text = UnprotectCredential(My.Settings.Passwort)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.Server = TextBox1.Text
        My.Settings.Port = TextBox2.Text
        My.Settings.Benutzer = TextBox3.Text
        My.Settings.Passwort = ProtectCredential(TextBox4.Text)
        My.Settings.Save()
        My.Settings.Reload()

        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Using con As New Data.SqlClient.SqlConnection(BuildConnectionString(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text))
                con.Open()
            End Using
            Label6.Text = "Verbindung steht."
            Label6.ForeColor = Color.Black
            Label6.BackColor = Color.Green
        Catch ex As SqlException

            Label6.Text = "Fehler bei der Verbindung"
            Label6.ForeColor = Color.Black
            Label6.BackColor = Color.Red
            ShowError(ex)
        End Try

    End Sub
End Class
