


Public Class MopDropändern

    Private Sub MopDropändern_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim con As Data.SqlClient.SqlConnection = CreateConnection()
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("UPDATE PS_GameDefs.dbo.MobItems SET Grade='" & SqlEscape(TextBox3.Text) & "', DropRate='" & SqlEscape(TextBox4.Text) & "' Where MobID='" & SqlEscape(TextBox1.Text) & "' AND ItemOrder ='" & SqlEscape(TextBox2.Text) & "'", con)
        con.Open()
        cmd.ExecuteNonQuery()
        cmd.Connection.Close()
            MessageBox.Show("Drop erfolgreich geändert.")
            Me.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class