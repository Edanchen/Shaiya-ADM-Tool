


Public Class Accentbannen

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If GebannteAcc.ListView1.SelectedItems.Count = 0 Then Return
        Dim con As Data.SqlClient.SqlConnection = CreateConnection()
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("UPDATE PS_UserData.dbo.Users_Master SET Status='0' WHERE UserUID='" & SqlEscape(GebannteAcc.ListView1.SelectedItems(0).SubItems(0).Text) & "'", con)
        con.Open()
        cmd.ExecuteNonQuery()
        cmd.Connection.Close()
        ' If the record can be queried, Pass verification and open another form.  
        GebannteAcc.ListView1.Items.Clear()
        MessageBox.Show("Account erfolgreich gebannt.")
        Me.Close()
        con.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
