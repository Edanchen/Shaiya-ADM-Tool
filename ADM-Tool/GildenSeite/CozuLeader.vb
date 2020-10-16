


Public Class CozuLeader

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim con As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim reader As SqlDataReader

        con.ConnectionString = "Data Source=127.0.0.1,1433;Initial Catalog=PS_UserData;Integrated Security = SSPI"
        cmd.Connection = con
        cmd.CommandText = "select I.ItemName, b.UserUID, I.ItemID, b.ItemID, c.UserID, c.UserUID, c.Del, c.Level, c.StatPoint, c.SkillPoint, c.Str, c.Dex, c.Rec, c.Int, c.Luc, c.Wis, c.K1, c.K2, c.CharID, c.CharName, c.LoginStatus, um.PW, um.UserIP, um.Point, um.Status, um.AdminLevel from PS_GameData.dbo.Chars c INNER JOIN PS_UserData.dbo.Users_Master um ON c.UserUID=um.UserUID INNER JOIN PS_GameData.dbo.UserStoredItems b ON b.UserUID=um.UserUID INNER JOIN PS_GameDefs.dbo.Items I ON I.ItemID=b.ItemID Where c.CharName = '" & ListBox1.Text & "'"

        Try

            con.Open()
            reader = cmd.ExecuteReader()

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
            If MessageBox.Show("Benutzername erfolgreich geändert") Then
                Dim mainForm As New ADM

            Else
                MessageBox.Show("Benutzername erfolgreich geändert")

            End If
        End Try

        TextBox5.Text = ADM.TextBox7.Text
        TextBox4.Text = ADM.TextBox8.Text
        TextBox6.Text = ADM.TextBox40.Text
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=PS_UserData;Integrated Security = SSPI")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("UPDATE PS_GameData.dbo.Guilds SET MasterUserID='" & TextBox2.Text & "', MasterCharID= '" & TextBox1.Text & "', MasterName= '" & TextBox3.Text & "' WHERE GuildID='" & ADM.TextBox5.Text & "'" &
                                                                             "UPDATE PS_GameData.dbo.GuildChars SET GuildLevel= '2' Where CharID='" & TextBox6.Text & "' AND GuildID= '" & ADM.TextBox5.Text & "' AND Del='0'" &
                                                                             "UPDATE Ps_GameData.dbo.GuildChars SET GuildLevel= '1' Where CharID='" & TextBox1.Text & "' AND GuildID= '" & ADM.TextBox5.Text & "' AND Del='0'", con)
        con.Open()
        Dim sdr As SqlDataReader = cmd.ExecuteReader()
        ' If the record can be queried, Pass verification and open another form.  
        If (sdr.Read() = True) Then
            con.Close()
            MessageBox.Show("Benutzername erfolgreich geändert")
            Dim mainForm As New ADM
            Me.Hide()
        Else
            MessageBox.Show("Gilden-Leader erfolgreich geändert. Diese Änderung wird erst mit dem nächsten Serverneustart güldig.")
            Me.Close()
        End If
        Dim con1 As New Data.SqlClient.SqlConnection
        Dim cmd1 As New Data.SqlClient.SqlCommand
        Dim reader1 As SqlDataReader

        con1.ConnectionString = "Data Source=127.0.0.1,1433;Initial Catalog=PS_UserData;Integrated Security = SSPI"
        cmd1.Connection = con1
        cmd1.CommandText = "select MasterUserID, MasterName, MasterCharID, Del from PS_GameData.dbo.Guilds Where GuildID = '" & ADM.TextBox5.Text & "' AND Del='0'"


        Try


            con1.Open()
            reader1 = cmd1.ExecuteReader()

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
            If MessageBox.Show("Benutzername erfolgreich geändert") Then
                Dim Form1 As New ADM

            Else
                MessageBox.Show("Gilde erfolgreich geladen")

            End If
        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class