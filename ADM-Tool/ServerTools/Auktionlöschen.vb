


Public Class Auktionlöschen

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("DELETE PS_GameData.dbo.MarketItems FROM PS_GameData.dbo.MarketItems t1 INNER JOIN PS_GameData.dbo.Market t2 ON t1.MarketID = t2.MarketID WHERE t2.Del IN ('1','1')" & _
                                                                             "DELETE From PS_GameData.dbo.Market Where Del='1'", con)
        con.Open()
        AlleAuktionen.ListView1.Items.Clear()
        Dim sdr As SqlDataReader = cmd.ExecuteReader()
        ' If the record can be queried, Pass verification and open another form.  
        If (sdr.Read() = True) Then
            con.Close()
            MessageBox.Show("Benutzername erfolgreich geändert")
            Dim mainForm As New ADM
            Me.Hide()

        Else
            MessageBox.Show("Abgelaufende Auktionen gelöscht.")
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class