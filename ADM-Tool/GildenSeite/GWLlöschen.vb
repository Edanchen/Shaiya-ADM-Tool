


Public Class GWLlöschen

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=PS_UserData;Integrated Security = SSPI")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("Delete FROM PS_GameData.dbo.GuildStoredItems WHERE ItemUID='" & ADM.ListView3.SelectedItems(0).SubItems(0).Text & "' AND GuildID='" & ADM.TextBox5.Text & "'", con)
        con.Open()
        Dim sdr As SqlDataReader = cmd.ExecuteReader()
        ' If the record can be queried, Pass verification and open another form.  
        If (sdr.Read() = True) Then
            con.Close()
            MessageBox.Show("Benutzername erfolgreich geändert")
            Dim mainForm As New ADM
            Me.Hide()
        Else
            MessageBox.Show("Item erfolgreich gelöscht.")
            Me.Close()
        End If
        Dim con1 As New Data.SqlClient.SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=PS_UserData;Integrated Security = SSPI")
        Dim cmd1 As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("select z.ItemID, x.ItemID, x.ItemUID, z.ItemName, y.GuildID, x.GuildID, y.GuildName, y.MasterUserID, y.MasterName, y.Country, y.TotalCount, y.GuildPoint, y.Del from PS_GameData.dbo.Guilds y INNER JOIN PS_GameData.dbo.GuildStoredItems x ON x.GuildID=y.GuildID INNER JOIN PS_GameDefs.dbo.Items z ON x.ItemID=z.ItemID  Where y.GuildID = '" & ADM.TextBox5.Text & "'", con)
        Dim reader1 As SqlDataReader

        Try
            ADM.ListView3.Items.Clear()
            con1.Open()
            reader1 = cmd1.ExecuteReader()

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

        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

    End Sub
End Class