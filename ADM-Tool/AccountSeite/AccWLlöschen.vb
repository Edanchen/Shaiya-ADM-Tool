


Public Class AccWLlöschen

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If ADM.ListView1.SelectedItems.Count = 0 Then Return
        Dim con As Data.SqlClient.SqlConnection = CreateConnection()
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("Delete FROM PS_GameData.dbo.UserStoredItems WHERE ItemUID='" & SqlEscape(ADM.ListView1.SelectedItems(0).SubItems(0).Text) & "' AND UserUID='" & SqlEscape(ADM.TextBox17.Text) & "'", con)
        con.Open()
        ADM.ListView1.Items.Clear()
        cmd.ExecuteNonQuery()
        cmd.Connection.Close()
            MessageBox.Show("Item erfolgreich gelöscht.")
            Me.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class