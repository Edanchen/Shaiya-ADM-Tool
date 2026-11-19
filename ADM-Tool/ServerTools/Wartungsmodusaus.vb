


Public Class Wartungsmodusaus

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim con As Data.SqlClient.SqlConnection = CreateConnection()
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("UPDATE PS_UserData.dbo.Users_Master SET Status='0' WHERE Status='-15'", con)
        con.Open()
        cmd.ExecuteNonQuery()
        cmd.Connection.Close()
            MessageBox.Show("Wartungsmodus erfolgreich ausgeschalet...")
            Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class