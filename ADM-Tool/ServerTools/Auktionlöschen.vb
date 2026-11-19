


Public Class Auktionlöschen

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim con As Data.SqlClient.SqlConnection = CreateConnection()
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("DELETE PS_GameData.dbo.MarketItems FROM PS_GameData.dbo.MarketItems t1 INNER JOIN PS_GameData.dbo.Market t2 ON t1.MarketID = t2.MarketID WHERE t2.Del IN ('1','1')" & _
                                                                             "; DELETE From PS_GameData.dbo.Market Where Del='1'", con)
        con.Open()
        AlleAuktionen.ListView1.Items.Clear()
        cmd.ExecuteNonQuery()
        cmd.Connection.Close()
            MessageBox.Show("Abgelaufende Auktionen gelöscht.")
            Me.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class