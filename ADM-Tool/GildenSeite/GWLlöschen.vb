


Public Class GWLlöschen

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If ADM.ListView3.SelectedItems.Count = 0 Then Return
        Dim con As Data.SqlClient.SqlConnection = CreateConnection()
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("Delete FROM PS_GameData.dbo.GuildStoredItems WHERE ItemUID='" & SqlEscape(ADM.ListView3.SelectedItems(0).SubItems(0).Text) & "' AND GuildID='" & SqlEscape(ADM.TextBox5.Text) & "'", con)
        con.Open()
        cmd.ExecuteNonQuery()
        cmd.Connection.Close()
            MessageBox.Show("Item erfolgreich gelöscht.")
            Me.Close()
        Dim con1 As Data.SqlClient.SqlConnection = CreateConnection()
        Dim cmd1 As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("select z.ItemID, x.ItemID, x.ItemUID, z.ItemName, y.GuildID, x.GuildID, y.GuildName, y.MasterUserID, y.MasterName, y.Country, y.TotalCount, y.GuildPoint, y.Del from PS_GameData.dbo.Guilds y INNER JOIN PS_GameData.dbo.GuildStoredItems x ON x.GuildID=y.GuildID INNER JOIN PS_GameDefs.dbo.Items z ON x.ItemID=z.ItemID  Where y.GuildID = '" & SqlEscape(ADM.TextBox5.Text) & "'", con)
        Dim reader1 As SqlDataReader

        Try
            ADM.ListView3.Items.Clear()
            con1.Open()
            reader1 = cmd1.ExecuteReader(CommandBehavior.CloseConnection)

            Do While reader1.Read()
                With ADM.ListView3
                    .Items.Add(reader1("ItemUID"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(reader1("ItemName"))
                    End With

                End With

            Loop

            reader1.Close()
            con1.Close()
        Catch ex As Exception
            ShowError(ex)
        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

    End Sub
End Class