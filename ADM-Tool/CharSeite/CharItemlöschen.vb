


Public Class CharItemlöschen

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If ADM.ListView4.SelectedItems.Count = 0 Then Return
        Dim con As Data.SqlClient.SqlConnection = CreateConnection()
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("Delete FROM PS_GameData.dbo.CharItems WHERE ItemUID='" & SqlEscape(ADM.ListView4.SelectedItems(0).SubItems(0).Text) & "' AND CharID='" & SqlEscape(ADM.TextBox24.Text) & "'", con)
        con.Open()
        ADM.ListView4.Items.Clear()
        cmd.ExecuteNonQuery()
        cmd.Connection.Close()
            MessageBox.Show("Item erfolgreich gelöscht.")
            Me.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class