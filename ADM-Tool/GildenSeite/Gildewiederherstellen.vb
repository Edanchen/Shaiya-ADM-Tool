


Public Class Gildewiederherstellen

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim con As Data.SqlClient.SqlConnection = CreateConnection()
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("UPDATE PS_GameData.dbo.Guilds SET Del='0' WHERE GuildName='" & SqlEscape(ADM.TextBox6.Text) & "'", con)
        con.Open()
        cmd.ExecuteNonQuery()
        cmd.Connection.Close()
            MessageBox.Show("Gilde erfolgreich wiederhergestellt.")
            Me.Close()
        con.Close()
        Dim con1 As New Data.SqlClient.SqlConnection
        Dim cmd1 As New Data.SqlClient.SqlCommand
        Dim reader1 As SqlDataReader

        con1.ConnectionString = CurrentConnectionString()
        cmd1.Connection = con1
        cmd1.CommandText = "select g.GuildID, g.GuildName, g.MasterUserID, g.MasterName, g.Country, g.TotalCount, g.GuildPoint, g.Del, d.UseHouse, d.Etin, d.Rank, d.Remark from PS_GameData.dbo.Guilds g INNER JOIN PS_GameData.dbo.GuildDetails d ON g.GuildID=d.GuildID Where g.GuildID = '" & SqlEscape(ADM.TextBox5.Text) & "'"
        Try
            con1.Open()
            reader1 = cmd1.ExecuteReader(CommandBehavior.CloseConnection)
            Do While reader1.Read()
                ADM.TextBox12.Text = (reader1("Del")
                )
                ADM.TextBox12.Text = IIf(ADM.TextBox12.Text = 0, "nein", "ja")
            Loop

            reader1.Close()
            con1.Close()
        Catch ex As Exception
            ShowError(ex)
        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class