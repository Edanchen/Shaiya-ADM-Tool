


Public Class GelöschteCharsentfernen

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim con As Data.SqlClient.SqlConnection = CreateConnection()
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("DELETE FROM PS_GameData.dbo.Chars WHERE datediff(day, DeleteDate, getdate()) >= 8 AND Del='1'", con)
        con.Open()
        cmd.ExecuteNonQuery()
        cmd.Connection.Close()
        ' If the record can be queried, Pass verification and open another form.

        ChatLog.ListView1.Items.Clear()
        MessageBox.Show("Gelöschte Char´s erfolgreich entfernt...")
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
