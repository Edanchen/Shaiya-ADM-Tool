


Public Class CozuLeader

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim con As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim reader As SqlDataReader

        con.ConnectionString = CurrentConnectionString()
        cmd.Connection = con
        cmd.CommandText = "select I.ItemName, b.UserUID, I.ItemID, b.ItemID, c.UserID, c.UserUID, c.Del, c.Level, c.StatPoint, c.SkillPoint, c.Str, c.Dex, c.Rec, c.Int, c.Luc, c.Wis, c.K1, c.K2, c.CharID, c.CharName, c.LoginStatus, um.PW, um.UserIP, um.Point, um.Status, um.AdminLevel from PS_GameData.dbo.Chars c INNER JOIN PS_UserData.dbo.Users_Master um ON c.UserUID=um.UserUID INNER JOIN PS_GameData.dbo.UserStoredItems b ON b.UserUID=um.UserUID INNER JOIN PS_GameDefs.dbo.Items I ON I.ItemID=b.ItemID Where c.CharName = '" & SqlEscape(ListBox1.Text) & "'"

        Try

            con.Open()
            reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            Do While reader.Read()
                TextBox1.Text = (reader("CharID")
                    )
                TextBox2.Text = (reader("UserID")
                )
                TextBox3.Text = (reader("CharName")
                )


            Loop

            reader.Close()
            con.Close()
        Catch ex As Exception
            ShowError(ex)
        End Try

        TextBox5.Text = ADM.TextBox7.Text
        TextBox4.Text = ADM.TextBox8.Text
        TextBox6.Text = ADM.TextBox40.Text
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim con As Data.SqlClient.SqlConnection = CreateConnection()
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("UPDATE PS_GameData.dbo.Guilds SET MasterUserID='" & SqlEscape(TextBox2.Text) & "', MasterCharID= '" & SqlEscape(TextBox1.Text) & "', MasterName= '" & SqlEscape(TextBox3.Text) & "' WHERE GuildID='" & SqlEscape(ADM.TextBox5.Text) & "'" &
                                                                             "; UPDATE PS_GameData.dbo.GuildChars SET GuildLevel= '2' Where CharID='" & SqlEscape(TextBox6.Text) & "' AND GuildID= '" & SqlEscape(ADM.TextBox5.Text) & "' AND Del='0'" &
                                                                             "; UPDATE Ps_GameData.dbo.GuildChars SET GuildLevel= '1' Where CharID='" & SqlEscape(TextBox1.Text) & "' AND GuildID= '" & SqlEscape(ADM.TextBox5.Text) & "' AND Del='0'", con)
        con.Open()
        cmd.ExecuteNonQuery()
        cmd.Connection.Close()
            MessageBox.Show("Gilden-Leader erfolgreich geändert. Diese Änderung wird erst mit dem nächsten Serverneustart güldig.")
            Me.Close()
        Dim con1 As New Data.SqlClient.SqlConnection
        Dim cmd1 As New Data.SqlClient.SqlCommand
        Dim reader1 As SqlDataReader

        con1.ConnectionString = CurrentConnectionString()
        cmd1.Connection = con1
        cmd1.CommandText = "select MasterUserID, MasterName, MasterCharID, Del from PS_GameData.dbo.Guilds Where GuildID = '" & SqlEscape(ADM.TextBox5.Text) & "' AND Del='0'"


        Try


            con1.Open()
            reader1 = cmd1.ExecuteReader(CommandBehavior.CloseConnection)

            Do While reader1.Read()

                ADM.TextBox7.Text = (reader1("MasterUserID")
                )
                ADM.TextBox8.Text = (reader1("MasterName")
                )
                ADM.TextBox40.Text = (reader1("MasterCharID")
                )

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