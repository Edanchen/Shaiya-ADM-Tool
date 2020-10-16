


Public Class Gildewiederherstellen

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=PS_UserData;Integrated Security = SSPI")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("UPDATE PS_GameData.dbo.Guilds SET Del='0' WHERE GuildName='" & ADM.TextBox6.Text & "'", con)
        con.Open()
        Dim sdr As SqlDataReader = cmd.ExecuteReader()
        ' If the record can be queried, Pass verification and open another form.  
        If (sdr.Read() = True) Then
            MessageBox.Show("Benutzername erfolgreich geändert")
            Dim mainForm As New ADM
            Me.Hide()
        Else
            MessageBox.Show("Gilde erfolgreich wiederhergestellt.")
            Me.Close()
        End If
        con.Close()
        Dim con1 As New Data.SqlClient.SqlConnection
        Dim cmd1 As New Data.SqlClient.SqlCommand
        Dim reader1 As SqlDataReader

        con1.ConnectionString = "Data Source=127.0.0.1,1433;Initial Catalog=PS_UserData;Integrated Security = SSPI"
        cmd1.Connection = con1
        cmd1.CommandText = "select g.GuildID, g.GuildName, g.MasterUserID, g.MasterName, g.Country, g.TotalCount, g.GuildPoint, g.Del, d.UseHouse, d.Etin, d.Rank, d.Remark from PS_GameData.dbo.Guilds g INNER JOIN PS_GameData.dbo.GuildDetails d ON g.GuildID=d.GuildID Where g.GuildID = '" & ADM.TextBox5.Text & "'"
        Try
            con1.Open()
            reader1 = cmd1.ExecuteReader()
            Do While reader1.Read()
                ADM.TextBox12.Text = (reader1("Del")
                )
                ADM.TextBox12.Text = IIf(ADM.TextBox12.Text = 0, "nein", "ja")
            Loop

            reader1.Close()
            con1.Close()
        Catch ex As Exception
            If MessageBox.Show("Benutzername erfolgreich geändert") Then
                Dim mainForm As New ADM
                Me.Hide()
            Else
                MessageBox.Show("Gilde erfolgreich geladen")
                Me.Close()
            End If
        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class