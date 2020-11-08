Public Class ADM


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim con As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim reader As SqlDataReader

        con.ConnectionString = "Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'"
        cmd.Connection = con
        cmd.CommandText = "select I.ItemName, b.UserUID, I.ItemID, b.ItemID, c.UserID, c.UserUID, c.Del, c.Level, c.StatPoint, c.SkillPoint, c.Str, c.Dex, c.Rec, c.Int, c.Luc, c.Wis, c.K1, c.K2, c.CharID, c.CharName, c.LoginStatus, um.PW, um.UserIP, um.Point, um.Status, um.AdminLevel from PS_GameData.dbo.Chars c INNER JOIN PS_UserData.dbo.Users_Master um ON c.UserUID=um.UserUID INNER JOIN PS_GameData.dbo.UserStoredItems b ON b.UserUID=um.UserUID INNER JOIN PS_GameDefs.dbo.Items I ON I.ItemID=b.ItemID Where c.CharName = '" & TextBox1.Text & "' OR um.UserID = '" & TextBox2.Text & "'"

        Try
            TabControl1.SelectedIndex = 2
            con.Open()
            reader = cmd.ExecuteReader()

            Do While reader.Read()

                TextBox24.Text = (reader("CharID")
                )
                TextBox25.Text = (reader("CharName")
                )
                TextBox26.Text = (reader("Level")
                )
                TextBox27.Text = (reader("K1")
                )
                TextBox28.Text = (reader("K2")
                )
                TextBox29.Text = (reader("Del")
                )
                TextBox29.Text = IIf(TextBox29.Text = 0, "nein", "ja")
                TextBox30.Text = (reader("StatPoint")
                )
                TextBox31.Text = (reader("SkillPoint")
                )
                TextBox32.Text = (reader("Str")
                )
                TextBox33.Text = (reader("Dex")
                )
                TextBox34.Text = (reader("Rec")
                )
                TextBox35.Text = (reader("Int")
                )
                TextBox36.Text = (reader("Luc")
                )
                TextBox37.Text = (reader("Wis")
                )
                TextBox17.Text = (reader("UserUID")
                )
                TextBox18.Text = (reader("UserID")
                )
                TextBox19.Text = (reader("PW")
                )
                TextBox20.Text = (reader("Point")
               )
                TextBox21.Text = (reader("UserIP")
                )
                TextBox22.Text = (reader("Status")
                )
                TextBox22.Text = IIf(TextBox22.Text = 0, "nein", "ja")
                TextBox23.Text = (reader("AdminLevel")
                )
                TextBox23.Text = IIf(TextBox23.Text = 0, "nein", "ja")
                TextBox38.Text = (reader("LoginStatus")
                )
                TextBox38.Text = IIf(TextBox38.Text = 0, "nein", "ja")


            Loop

            reader.Close()
            con.Close()
        Catch ex As Exception
            If MessageBox.Show("Accountdaten erfolgreich geladen.") Then
                Dim mainForm As New ADM

            Else
                MessageBox.Show("Benutzername erfolgreich geändert")

            End If
        End Try
        Dim con2 As New Data.SqlClient.SqlConnection
        Dim cmd2 As New Data.SqlClient.SqlCommand
        Dim reader3 As SqlDataReader

        con2.ConnectionString = "Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'"
        cmd2.Connection = con2
        cmd2.CommandText = "select c.UserID, c.UserUID, c.Del, c.Level, c.CharName, c.StatPoint, c.SkillPoint, c.Str, c.Dex, c.Rec, c.Int, c.Luc, c.Wis, c.K1, c.K2, c.CharID, c.CharName, um.PW, um.UserIP, um.Point, um.Status, um.AdminLevel from PS_GameData.dbo.Chars c INNER JOIN PS_UserData.dbo.Users_Master um ON c.UserUID=um.UserUID Where c.CharName = '" & TextBox1.Text & "' OR um.UserID = '" & TextBox2.Text & "'"
        Try
            con2.Open()
            reader3 = cmd2.ExecuteReader()
            ListBox6.Items.Clear()
            Do While reader3.Read()
                ListBox6.Items.Add(reader3("Charname")
                )
            Loop

            reader3.Close()
            con2.Close()
        Catch ex As Exception
            If MessageBox.Show("Account erfolgreich geladen...") Then
                Dim mainForm As New ADM

            Else
                MessageBox.Show("Account konnten nicht geladen weden...")

            End If
        End Try
        Dim con5 As New Data.SqlClient.SqlConnection
        Dim cmd5 As New Data.SqlClient.SqlCommand
        Dim reader5 As SqlDataReader

        con5.ConnectionString = "Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'"
        cmd5.Connection = con5
        cmd5.CommandText = "select um.UserUID, a.UserUID, b.GuildID, a.CharID, b.CharID, a.CharName, g.GuildID, g.GuildName from PS_GameData.dbo.Guilds g INNER JOIN PS_GameData.dbo.GuildChars b ON g.GuildID=b.GuildID INNER JOIN PS_GameData.dbo.Chars a ON b.CharID=a.CharID INNER JOIN PS_UserData.dbo.Users_Master um ON a.UserUID=um.UserUID Where a.CharName = '" & TextBox1.Text & "' OR um.UserID = '" & TextBox2.Text & "'"


        Try


            con5.Open()
            reader5 = cmd5.ExecuteReader()

            Do While reader5.Read()
                TextBox39.Text = (reader5("GuildName")
                )


            Loop

            reader5.Close()
            con5.Close()
        Catch ex As Exception
            If MessageBox.Show("Benutzername erfolgreich geändert") Then
                Dim Form1 As New ADM

            Else
                MessageBox.Show("Gilde erfolgreich geladen")

            End If
        End Try
        Dim con6 As New Data.SqlClient.SqlConnection
        Dim cmd6 As New Data.SqlClient.SqlCommand
        Dim reader6 As SqlDataReader

        con6.ConnectionString = "Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'"
        cmd6.Connection = con6
        cmd6.CommandText = "select UserUID, UserID, PW, UserIP, Point, Status, AdminLevel from PS_UserData.dbo.Users_Master WHERE UserID = '" & TextBox2.Text & "'"

        Try
            TabControl1.SelectedIndex = 2
            con6.Open()
            reader6 = cmd6.ExecuteReader()

            Do While reader6.Read()

                TextBox17.Text = (reader6("UserUID")
                )
                TextBox18.Text = (reader6("UserID")
                )
                TextBox19.Text = (reader6("PW")
                )
                TextBox20.Text = (reader6("Point")
               )
                TextBox21.Text = (reader6("UserIP")
                )
                TextBox22.Text = (reader6("Status")
                )
                TextBox22.Text = IIf(TextBox22.Text = 0, "nein", "ja")
                TextBox23.Text = (reader6("AdminLevel")
                )
                TextBox23.Text = IIf(TextBox23.Text = 0, "nein", "ja")
                TextBox38.Text = (reader6("LoginStatus")
                )
                TextBox38.Text = IIf(TextBox38.Text = 0, "nein", "ja")

            Loop

            reader6.Close()
            con6.Close()
        Catch ex As Exception
            If MessageBox.Show("Accountdaten erfolgreich geladen.") Then
                Dim mainForm As New ADM

            Else
                MessageBox.Show("Benutzername erfolgreich geändert")

            End If
        End Try

    End Sub

    Private Sub Button52_Click(sender As System.Object, e As System.EventArgs) Handles Button52.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()
        ListView3.Items.Clear()
        ListView1.Items.Clear()
        ListView4.Items.Clear()
        ListView2.Items.Clear()
        ListBox6.Items.Clear()
        ListBox7.Items.Clear()
        ListBox8.Items.Clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
        TextBox11.Clear()
        TextBox12.Clear()
        TextBox13.Clear()
        TextBox14.Clear()
        TextBox15.Clear()
        TextBox16.Clear()
        TextBox17.Clear()
        TextBox18.Clear()
        TextBox19.Clear()
        TextBox20.Clear()
        TextBox21.Clear()
        TextBox22.Clear()
        TextBox23.Clear()
        TextBox24.Clear()
        TextBox25.Clear()
        TextBox26.Clear()
        TextBox27.Clear()
        TextBox28.Clear()
        TextBox29.Clear()
        TextBox30.Clear()
        TextBox31.Clear()
        TextBox32.Clear()
        TextBox33.Clear()
        TextBox34.Clear()
        TextBox35.Clear()
        TextBox36.Clear()
        TextBox37.Clear()
        TextBox38.Clear()
        TextBox39.Clear()
        TextBox40.Clear()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("SELECT GuildName FROM PS_GameData.dbo.Guilds", con)
        Dim reader As SqlDataReader
        Try
            con.Open()
            reader = cmd.ExecuteReader()
            ListBox1.Items.Clear()
            Do While reader.Read()
                ListBox1.Items.Add(reader("GuildName")
                    )
            Loop
            reader.Close()
            con.Close()
        Catch ex As Exception
            If MessageBox.Show("Gilden konnten nicht geladen werden.") Then
                Dim Form1 As New Main

            Else
                MessageBox.Show("Gilden konnten nicht geladen werden.")

            End If
        End Try
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Dim con As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim reader As SqlDataReader

        con.ConnectionString = "Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'"
        cmd.Connection = con
        cmd.CommandText = "select b.GuildID, b.CharID, b.CharID, a.CharName, g.GuildID, g.GuildName, g.MasterUserID, g.MasterName, g.MasterCharID, g.Country, g.TotalCount, g.GuildPoint, g.Del, d.UseHouse, d.Etin, d.Rank, d.Remark from PS_GameData.dbo.Guilds g INNER JOIN PS_GameData.dbo.GuildDetails d ON g.GuildID=d.GuildID INNER JOIN PS_GameData.dbo.GuildChars b ON g.GuildID=b.GuildID INNER JOIN PS_GameData.dbo.Chars a ON b.CharID=a.CharID Where g.GuildName = '" & ListBox1.Text & "'"


        Try

            TabControl1.SelectedIndex = 1
            con.Open()
            reader = cmd.ExecuteReader()
            ListBox2.Items.Clear()
            ListView3.Items.Clear()
            Do While reader.Read()
                TextBox5.Text = (reader("GuildID")
                )
                TextBox6.Text = (reader("GuildName")
                )
                TextBox7.Text = (reader("MasterUserID")
                )
                TextBox8.Text = (reader("MasterName")
                )
                TextBox9.Text = (reader("Country")
                )
                TextBox9.Text = IIf(TextBox9.Text = 0, "Light", "Dark")
                TextBox10.Text = (reader("TotalCount")
                )
                TextBox11.Text = (reader("GuildPoint")
                )
                TextBox12.Text = (reader("Del")
                )
                TextBox12.Text = IIf(TextBox12.Text = 0, "nein", "ja")
                TextBox13.Text = (reader("UseHouse")
                )
                TextBox13.Text = IIf(TextBox13.Text = 0, "nein", "ja")
                TextBox14.Text = (reader("Etin")
                )
                TextBox15.Text = (reader("Rank")
                )
                TextBox16.Text = (reader("Remark")
                )
                ListBox2.Items.Add(reader("CharName")
                )
                TextBox40.Text = (reader("MasterCharID")
                )

            Loop

            reader.Close()
            con.Close()
        Catch ex As Exception
            If MessageBox.Show("Gilde konnte nicht geladen werden.") Then
                Dim Form1 As New Main

            Else
                MessageBox.Show("Gilde erfolgreich geladen")
                TabPage2.Show()
            End If
        End Try
    End Sub

    Private Sub Button55_Click(sender As System.Object, e As System.EventArgs) Handles Button55.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("select b.ItemUID, I.ItemName from PS_GameData.dbo.UserStoredItems b INNER JOIN PS_GameDefs.dbo.Items I ON I.ItemID=b.ItemID Where b.UserUID = '" & TextBox17.Text & "'", con)
        Dim reader As SqlDataReader

        Try

            con.Open()
            reader = cmd.ExecuteReader()
            ListView1.Items.Clear()
            Do While reader.Read()
                With ListView1
                    .Items.Add(reader("ItemUID"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(reader("ItemName"))
                    End With

                End With

            Loop

            reader.Close()
            con.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button53_Click(sender As System.Object, e As System.EventArgs) Handles Button53.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("SELECT [GV],[UserID],[Date],[Text],[Status],[Zugewiesenan],[Thema],[Art],[Type],[Erstelltdurch] FROM ADM_Tool.dbo.Vorgaenge Where UserID = '" & TextBox18.Text & "'", con)
        Dim reader As SqlDataReader

        Try
            ListView2.Items.Clear()
            con.Open()
            reader = cmd.ExecuteReader()

            Do While reader.Read()
                With ListView2
                    .Items.Add(reader("GV"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(reader("UserID"))
                        .Add(reader("Date"))
                        .Add(reader("Status"))
                        .Add(reader("Zugewiesenan"))
                        .Add(reader("Thema"))
                        .Add(reader("Art"))
                        .Add(reader("Type"))
                        .Add(reader("Erstelltdurch"))
                    End With

                End With

            Loop

            reader.Close()
            con.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button56_Click(sender As System.Object, e As System.EventArgs) Handles Button56.Click
        ContextMenuStrip1.Show(Button56, 0, Button56.Height)
    End Sub

    Private Sub Button62_Click(sender As System.Object, e As System.EventArgs) Handles Button62.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("select z.ItemID, x.ItemID, x.ItemUID, z.ItemName, y.GuildID, x.GuildID, y.GuildName, y.MasterUserID, y.MasterName, y.Country, y.TotalCount, y.GuildPoint, y.Del from PS_GameData.dbo.Guilds y INNER JOIN PS_GameData.dbo.GuildStoredItems x ON x.GuildID=y.GuildID INNER JOIN PS_GameDefs.dbo.Items z ON x.ItemID=z.ItemID  Where y.GuildID = '" & TextBox5.Text & "'", con)
        Dim reader As SqlDataReader

        Try

            con.Open()
            reader = cmd.ExecuteReader()
            ListView3.Items.Clear()
            Do While reader.Read()
                With ListView3
                    .Items.Add(reader("ItemUID"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(reader("ItemName"))
                    End With

                End With

            Loop

            reader.Close()
            con.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button63_Click(sender As System.Object, e As System.EventArgs) Handles Button63.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("select b.ItemUID, I.ItemName from PS_GameData.dbo.CharItems b INNER JOIN PS_GameDefs.dbo.Items I ON I.ItemID=b.ItemID Where b.CharID = '" & TextBox24.Text & "'", con)
        Dim reader As SqlDataReader

        Try

            con.Open()
            reader = cmd.ExecuteReader()
            ListView4.Items.Clear()
            Do While reader.Read()
                With ListView4
                    .Items.Add(reader("ItemUID"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(reader("ItemName"))
                    End With

                End With

            Loop

            reader.Close()
            con.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button22_Click(sender As System.Object, e As System.EventArgs) Handles Button22.Click
        GildenName.Show()
        GildenName.TextBox1.Text = TextBox6.Text
    End Sub

    Private Sub Button23_Click(sender As System.Object, e As System.EventArgs) Handles Button23.Click
        Dim con As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim reader As SqlDataReader

        con.ConnectionString = "Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'"
        cmd.Connection = con
        cmd.CommandText = "select b.GuildID, b.CharID, b.CharID, a.CharName, g.GuildID, g.GuildName, g.MasterUserID, g.MasterName, g.Country, g.TotalCount, g.GuildPoint, g.Del, d.UseHouse, d.Etin, d.Rank, d.Remark from PS_GameData.dbo.Guilds g INNER JOIN PS_GameData.dbo.GuildDetails d ON g.GuildID=d.GuildID INNER JOIN PS_GameData.dbo.GuildChars b ON g.GuildID=b.GuildID INNER JOIN PS_GameData.dbo.Chars a ON b.CharID=a.CharID Where g.GuildID = '" & TextBox5.Text & "' AND b.GuildLevel='2' AND b.Del='0'"


        Try
            CozuLeader.Show()

            con.Open()
            reader = cmd.ExecuteReader()
            CozuLeader.ListBox1.Items.Clear()

            Do While reader.Read()

                CozuLeader.ListBox1.Items.Add(reader("CharName")
                )

            Loop

            reader.Close()
            con.Close()
        Catch ex As Exception
            If MessageBox.Show("Benutzername erfolgreich geändert") Then
                Dim Form1 As New ADM

            Else
                MessageBox.Show("Gilde erfolgreich geladen")

            End If
        End Try
    End Sub

    Private Sub Button57_Click(sender As System.Object, e As System.EventArgs) Handles Button57.Click
        Dim con As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim reader As SqlDataReader

        con.ConnectionString = "Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'"
        cmd.Connection = con
        cmd.CommandText = "select b.GuildID, b.CharID, b.CharID, a.CharName, g.GuildID, g.GuildName, g.MasterUserID, g.MasterName, g.Country, g.TotalCount, g.GuildPoint, g.Del, d.UseHouse, d.Etin, d.Rank, d.Remark from PS_GameData.dbo.Guilds g INNER JOIN PS_GameData.dbo.GuildDetails d ON g.GuildID=d.GuildID INNER JOIN PS_GameData.dbo.GuildChars b ON g.GuildID=b.GuildID INNER JOIN PS_GameData.dbo.Chars a ON b.CharID=a.CharID Where g.GuildID = '" & TextBox5.Text & "' AND b.Del='0'"


        Try
            MemberzuLeader.Show()

            con.Open()
            reader = cmd.ExecuteReader()
            MemberzuLeader.ListBox1.Items.Clear()

            Do While reader.Read()

                MemberzuLeader.ListBox1.Items.Add(reader("CharName")
                )

            Loop

            reader.Close()
            con.Close()
        Catch ex As Exception
            If MessageBox.Show("Benutzername erfolgreich geändert") Then
                Dim Form1 As New ADM

            Else
                MessageBox.Show("Gilde erfolgreich geladen")

            End If
        End Try
    End Sub

    Private Sub Button24_Click(sender As System.Object, e As System.EventArgs) Handles Button24.Click
        GRBPunkte.Show()
        GRBPunkte.TextBox1.Text = TextBox11.Text
    End Sub

    Private Sub Button25_Click(sender As System.Object, e As System.EventArgs) Handles Button25.Click
        Gildelöschen.Show()
    End Sub

    Private Sub Button29_Click(sender As System.Object, e As System.EventArgs) Handles Button29.Click
        Gildewiederherstellen.Show()
    End Sub

    Private Sub Button26_Click(sender As System.Object, e As System.EventArgs) Handles Button26.Click
        Gildenhaus.Show()
    End Sub

    Private Sub Button27_Click(sender As System.Object, e As System.EventArgs) Handles Button27.Click
        Etin.Show()
    End Sub

    Private Sub Button28_Click(sender As System.Object, e As System.EventArgs) Handles Button28.Click
        GildenNachricht.Show()
        GildenNachricht.TextBox1.Text = TextBox16.Text
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Dim con As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim reader As SqlDataReader

        con.ConnectionString = "Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'"
        cmd.Connection = con
        cmd.CommandText = "select I.ItemName, b.UserUID, I.ItemID, b.ItemID, c.UserID, c.UserUID, c.Del, c.Level, c.StatPoint, c.SkillPoint, c.Str, c.Dex, c.Rec, c.Int, c.Luc, c.Wis, c.K1, c.K2, c.CharID, c.CharName, c.LoginStatus, um.PW, um.UserIP, um.Point, um.Status, um.AdminLevel from PS_GameData.dbo.Chars c INNER JOIN PS_UserData.dbo.Users_Master um ON c.UserUID=um.UserUID INNER JOIN PS_GameData.dbo.UserStoredItems b ON b.UserUID=um.UserUID INNER JOIN PS_GameDefs.dbo.Items I ON I.ItemID=b.ItemID Where c.CharName = '" & ListBox2.Text & "'"

        Try
            TabControl1.SelectedIndex = 2
            con.Open()
            reader = cmd.ExecuteReader()

            Do While reader.Read()
                TextBox24.Text = (reader("CharID")
                )
                TextBox25.Text = (reader("CharName")
                )
                TextBox26.Text = (reader("Level")
                )
                TextBox27.Text = (reader("K1")
                )
                TextBox28.Text = (reader("K2")
                )
                TextBox29.Text = (reader("Del")
                )
                TextBox29.Text = IIf(TextBox29.Text = 0, "nein", "ja")
                TextBox30.Text = (reader("StatPoint")
                )
                TextBox31.Text = (reader("SkillPoint")
                )
                TextBox32.Text = (reader("Str")
                )
                TextBox33.Text = (reader("Dex")
                )
                TextBox34.Text = (reader("Rec")
                )
                TextBox35.Text = (reader("Int")
                )
                TextBox36.Text = (reader("Luc")
                )
                TextBox37.Text = (reader("Wis")
                )
                TextBox17.Text = (reader("UserUID")
                )
                TextBox18.Text = (reader("UserID")
                )
                TextBox19.Text = (reader("PW")
                )
                TextBox20.Text = (reader("Point")
               )
                TextBox21.Text = (reader("UserIP")
                )
                TextBox22.Text = (reader("Status")
                )
                TextBox22.Text = IIf(TextBox22.Text = 0, "nein", "ja")
                TextBox23.Text = (reader("AdminLevel")
                )
                TextBox23.Text = IIf(TextBox23.Text = 0, "nein", "ja")
                TextBox38.Text = (reader("LoginStatus")
                )
                TextBox38.Text = IIf(TextBox38.Text = 0, "nein", "ja")

                TextBox39.Text = TextBox6.Text

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
        Dim con2 As New Data.SqlClient.SqlConnection
        Dim cmd2 As New Data.SqlClient.SqlCommand
        Dim reader3 As SqlDataReader

        con.ConnectionString = "Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'"
        cmd.Connection = con
        cmd.CommandText = "select c.UserID, c.UserUID, c.Del, c.Level, c.CharName, c.StatPoint, c.SkillPoint, c.Str, c.Dex, c.Rec, c.Int, c.Luc, c.Wis, c.K1, c.K2, c.CharID, c.CharName, um.PW, um.UserIP, um.Point, um.Status, um.AdminLevel from PS_GameData.dbo.Chars c INNER JOIN PS_UserData.dbo.Users_Master um ON c.UserUID=um.UserUID Where c.CharName = '" & ListBox2.Text & "'"
        Try
            con.Open()
            reader3 = cmd.ExecuteReader()
            ListBox6.Items.Clear()
            Do While reader3.Read()
                ListBox6.Items.Add(reader3("Charname")
                )
            Loop

            reader3.Close()
            con.Close()
        Catch ex As Exception
            If MessageBox.Show("Account erfolgreich geladen...") Then
                Dim mainForm As New ADM

            Else
                MessageBox.Show("Account konnten nicht geladen weden...")

            End If
        End Try
        TextBox39.Text = TextBox6.Text
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("SELECT c.GuildID, c.Count,c.ItemID,c.Type,c.TypeID,c.Gem1,c.Gem2,c.Gem3,c.Gem4,c.Gem5,c.Gem6, I.ItemName, I.ItemID, c.ItemID, c.Count,c.ItemID,c.Type,c.TypeID,c.Gem1,c.Gem2,c.Gem3,c.Gem4,c.Gem5,Gem6,SUBSTRING(c.Craftname, 1, 2) AS 'Str', SUBSTRING(c.Craftname, 3, 2) AS 'Dex',SUBSTRING(c.Craftname, 5, 2) AS 'Rec', SUBSTRING(c.Craftname, 7, 2) AS 'Int',SUBSTRING(c.Craftname, 9, 2) AS 'Wis',SUBSTRING(c.Craftname, 11, 2) AS 'Luc', SUBSTRING(c.Craftname, 13, 2) AS 'HP',SUBSTRING(c.Craftname, 15, 2) AS 'MP',SUBSTRING(c.Craftname, 17, 2) AS 'SP', SUBSTRING(c.Craftname, 19, 2) AS 'Enchant', c.ItemUID,I.ItemName,I.ReqWis,I.Type  FROM PS_GameData.dbo.GuildStoredItems c INNER JOIN PS_GameDefs.dbo.Items I ON I.ItemID=c.ItemID WHERE c.GuildID='" & TextBox5.Text & "' AND c.ItemUID='" & ListView3.SelectedItems(0).SubItems(0).Text & "'", con)
        Dim reader As SqlDataReader
        Try
            GWLbearbeiten.Show()
            con.Open()
            reader = cmd.ExecuteReader()

            Do While reader.Read()
                GWLbearbeiten.TextBox22.Text = (reader("ItemID")
                    )
                GWLbearbeiten.TextBox1.Text = (reader("GuildID")
                )
                GWLbearbeiten.TextBox2.Text = (reader("ItemName")
                )
                GWLbearbeiten.TextBox3.Text = (reader("ItemUID")
                )
                GWLbearbeiten.TextBox4.Text = (reader("Gem1")
                )
                GWLbearbeiten.TextBox5.Text = (reader("Gem2")
                )
                GWLbearbeiten.TextBox6.Text = (reader("Gem3")
                )
                GWLbearbeiten.TextBox7.Text = (reader("Gem4")
                )
                GWLbearbeiten.TextBox8.Text = (reader("Gem5")
                )
                GWLbearbeiten.TextBox9.Text = (reader("Gem6")
                )
                GWLbearbeiten.TextBox10.Text = (reader("Str")
                )
                GWLbearbeiten.TextBox11.Text = (reader("Dex")
                )
                GWLbearbeiten.TextBox12.Text = (reader("Rec")
                )
                GWLbearbeiten.TextBox13.Text = (reader("Int")
                )
                GWLbearbeiten.TextBox14.Text = (reader("Wis")
                )
                GWLbearbeiten.TextBox15.Text = (reader("Luc")
                )
                GWLbearbeiten.TextBox16.Text = (reader("HP")
                )
                GWLbearbeiten.TextBox17.Text = (reader("MP")
                )
                GWLbearbeiten.TextBox18.Text = (reader("SP")
                )
                GWLbearbeiten.TextBox19.Text = (reader("Enchant")
                )
                GWLbearbeiten.TextBox21.Text = (reader("Count")
                )
            Loop
            reader.Close()
            con.Close()
            GWLbearbeiten.Show()
        Catch ex As Exception
            If MessageBox.Show("Benutzername erfolgreich geändert") Then
                Dim mainForm As New ADM

            Else
                MessageBox.Show("Item erfolgreich geladen")

            End If
        End Try
        GWLbearbeiten.TextBox20.Text = GWLbearbeiten.TextBox10.Text + GWLbearbeiten.TextBox11.Text + GWLbearbeiten.TextBox12.Text + GWLbearbeiten.TextBox13.Text + GWLbearbeiten.TextBox14.Text + GWLbearbeiten.TextBox15.Text + GWLbearbeiten.TextBox16.Text + GWLbearbeiten.TextBox17.Text + GWLbearbeiten.TextBox18.Text + GWLbearbeiten.TextBox19.Text
    End Sub

    Private Sub Button64_Click(sender As System.Object, e As System.EventArgs) Handles Button64.Click
        GWLlöschen.Show()
    End Sub

    Private Sub AbmeldenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AbmeldenToolStripMenuItem.Click
        LoginForm1.Show()
        LoginForm1.UsernameTextBox.Clear()
        LoginForm1.PasswordTextBox.Clear()
        Main.Hide()
        Me.Hide()
    End Sub

    Private Sub BeendenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BeendenToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub Button65_Click(sender As System.Object, e As System.EventArgs) Handles Button65.Click
        RichTextBox1.Clear()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        AccPasswort.Show()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        APhinzufügen.Show()
    End Sub

    Private Sub Button44_Click(sender As System.Object, e As System.EventArgs) Handles Button44.Click
        APabziehen.Show()
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        AccBan.Show()
    End Sub

    Private Sub Button20_Click(sender As System.Object, e As System.EventArgs) Handles Button20.Click
        Accentban.Show()
    End Sub

    Private Sub Button19_Click(sender As System.Object, e As System.EventArgs) Handles Button19.Click
        GMRechtegeben.Show()
    End Sub

    Private Sub Button21_Click(sender As System.Object, e As System.EventArgs) Handles Button21.Click
        GMRechtenehmen.Show()
    End Sub

    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        Dim con As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim reader As SqlDataReader

        con.ConnectionString = "Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'"
        cmd.Connection = con
        cmd.CommandText = "select c.UserID, c.UserUID, c.Del, c.Level, c.StatPoint, c.SkillPoint, c.Str, c.Dex, c.Rec, c.Int, c.Luc, c.Wis, c.K1, c.K2, c.CharID, c.CharName, um.PW, um.UserIP, um.Point, um.Status, um.AdminLevel from PS_GameData.dbo.Chars c INNER JOIN PS_UserData.dbo.Users_Master um ON c.UserUID=um.UserUID Where c.UserUID = '" & TextBox17.Text & "'"
        Try
            con.Open()
            reader = cmd.ExecuteReader()
            ListBox6.Items.Clear()
            Do While reader.Read()
                ListBox6.Items.Add(reader("Charname")
                )
            Loop

            reader.Close()
            con.Close()
        Catch ex As Exception
            If MessageBox.Show("Account erfolgreich geladen...") Then
                Dim mainForm As New ADM

            Else
                MessageBox.Show("Account konnten nicht geladen weden...")

            End If
        End Try
    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        Dim con As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim reader As SqlDataReader

        con.ConnectionString = "Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'"
        cmd.Connection = con
        cmd.CommandText = "select I.ItemName, b.CharID, I.ItemID, b.ItemID, c.UserID, c.UserUID, c.Del, c.Level, c.StatPoint, c.SkillPoint, c.Str, c.Dex, c.Rec, c.Int, c.Luc, c.Wis, c.K1, c.K2, c.CharID, c.CharName, c.LoginStatus, um.PW, um.UserIP, um.Point, um.Status, um.AdminLevel from PS_GameData.dbo.Chars c INNER JOIN PS_UserData.dbo.Users_Master um ON c.UserUID=um.UserUID INNER JOIN PS_GameData.dbo.CharItems b ON b.CharID=c.CharID INNER JOIN PS_GameDefs.dbo.Items I ON I.ItemID=b.ItemID  Where c.CharName = '" & ListBox6.Text & "'"

        Try
            TabControl1.SelectedIndex = 3
            con.Open()
            reader = cmd.ExecuteReader()

            Do While reader.Read()
                TextBox24.Text = (reader("CharID")
                )
                TextBox25.Text = (reader("CharName")
                )
                TextBox26.Text = (reader("Level")
                )
                TextBox27.Text = (reader("K1")
                )
                TextBox28.Text = (reader("K2")
                )
                TextBox29.Text = (reader("Del")
                )
                TextBox29.Text = IIf(TextBox29.Text = 0, "nein", "ja")
                TextBox30.Text = (reader("StatPoint")
                )
                TextBox31.Text = (reader("SkillPoint")
                )
                TextBox32.Text = (reader("Str")
                )
                TextBox33.Text = (reader("Dex")
                )
                TextBox34.Text = (reader("Rec")
                )
                TextBox35.Text = (reader("Int")
                )
                TextBox36.Text = (reader("Luc")
                )
                TextBox37.Text = (reader("Wis")
                )
                TextBox38.Text = (reader("LoginStatus")
                )
                TextBox38.Text = IIf(TextBox38.Text = 0, "nein", "ja")

            Loop

            reader.Close()
            con.Close()
        Catch ex As Exception
            If MessageBox.Show("Account erfolgreich geladen...") Then
                Dim mainForm As New ADM

            Else
                MessageBox.Show("Account konnten nicht geladen weden...")

            End If
        End Try

        Dim con1 As New Data.SqlClient.SqlConnection
        Dim cmd1 As New Data.SqlClient.SqlCommand
        Dim reader1 As SqlDataReader

        con1.ConnectionString = "Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'"
        cmd1.Connection = con1
        cmd1.CommandText = "select um.UserUID, a.UserUID, b.GuildID, a.CharID, b.CharID, a.CharName, g.GuildID, g.GuildName from PS_GameData.dbo.Guilds g INNER JOIN PS_GameData.dbo.GuildChars b ON g.GuildID=b.GuildID INNER JOIN PS_GameData.dbo.Chars a ON b.CharID=a.CharID INNER JOIN PS_UserData.dbo.Users_Master um ON a.UserUID=um.UserUID Where a.CharName = '" & ListBox6.Text & "'"

        Try
            TabControl1.SelectedIndex = 3
            con1.Open()
            reader1 = cmd1.ExecuteReader()

            Do While reader1.Read()
                TextBox39.Text = (reader1("GuildName")
                    )

            Loop

            reader1.Close()
            con1.Close()

        Catch ex As Exception
            If MessageBox.Show("Char erfolgreich geladen...") Then
                Dim mainForm As New ADM

            Else
                MessageBox.Show("Account konnten nicht geladen weden...")

            End If
        End Try
    End Sub

    Private Sub Button13_Click(sender As System.Object, e As System.EventArgs) Handles Button13.Click
        Dim con As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim reader As SqlDataReader

        con.ConnectionString = "Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'"
        cmd.Connection = con
        cmd.CommandText = "select UserID FROM PS_UserData.dbo.Users_Master Where UserIP = '" & TextBox21.Text & "'"
        Try
            con.Open()
            reader = cmd.ExecuteReader()
            ListBox7.Items.Clear()
            Do While reader.Read()
                ListBox7.Items.Add(reader("UserID")
                )
            Loop

            reader.Close()
            con.Close()
        Catch ex As Exception
            If MessageBox.Show("Account erfolgreich geladen...") Then
                Dim mainForm As New ADM

            Else
                MessageBox.Show("Account konnten nicht geladen weden...")

            End If
        End Try
        Dim con1 As New Data.SqlClient.SqlConnection
        Dim cmd1 As New Data.SqlClient.SqlCommand
        Dim reader1 As SqlDataReader

        con1.ConnectionString = "Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'"
        cmd1.Connection = con1
        cmd1.CommandText = "select DISTINCT um.UserIP, a.Text1, a.UserUID, um.UserUID FROM PS_UserData.dbo.Users_Master um INNER JOIN PS_GameLog.dbo.ActionLog a ON um.UserID=a.UserID Where ActionType='107' AND a.UserUID = '" & TextBox17.Text & "'"
        Try
            con1.Open()
            reader1 = cmd1.ExecuteReader()
            ListBox8.Items.Clear()
            Do While reader1.Read()
                ListBox8.Items.Add(reader1("Text1")
                )
            Loop

            reader1.Close()
            con1.Close()
        Catch ex As Exception
            If MessageBox.Show("Account erfolgreich geladen...") Then
                Dim mainForm As New ADM

            Else
                MessageBox.Show("Account konnten nicht geladen weden...")

            End If
        End Try
    End Sub

    Private Sub Button14_Click(sender As System.Object, e As System.EventArgs) Handles Button14.Click

        Dim con2 As New Data.SqlClient.SqlConnection
        Dim cmd2 As New Data.SqlClient.SqlCommand
        Dim reader3 As SqlDataReader

        con2.ConnectionString = "Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'"
        cmd2.Connection = con2
        cmd2.CommandText = "select c.UserID, c.UserUID, c.Del, c.Level, c.CharName, c.StatPoint, c.SkillPoint, c.Str, c.Dex, c.Rec, c.Int, c.Luc, c.Wis, c.K1, c.K2, c.CharID, c.CharName, um.PW, um.UserIP, um.Point, um.Status, um.AdminLevel from PS_GameData.dbo.Chars c INNER JOIN PS_UserData.dbo.Users_Master um ON c.UserUID=um.UserUID Where c.CharName = '" & TextBox1.Text & "' OR um.UserID = '" & ListBox7.Text & "'"
        Try
            con2.Open()
            reader3 = cmd2.ExecuteReader()
            ListBox6.Items.Clear()
            Do While reader3.Read()
                ListBox6.Items.Add(reader3("Charname")
                )
            Loop

            reader3.Close()
            con2.Close()
        Catch ex As Exception
            If MessageBox.Show("Account erfolgreich geladen...") Then
                Dim mainForm As New ADM

            Else
                MessageBox.Show("Account konnten nicht geladen weden...")

            End If
        End Try

        Dim con6 As New Data.SqlClient.SqlConnection
        Dim cmd6 As New Data.SqlClient.SqlCommand
        Dim reader6 As SqlDataReader

        con6.ConnectionString = "Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'"
        cmd6.Connection = con6
        cmd6.CommandText = "select UserUID, UserID, PW, UserIP, Point, Status, AdminLevel from PS_UserData.dbo.Users_Master WHERE UserID = '" & ListBox7.Text & "'"

        Try
            TabControl1.SelectedIndex = 2
            con6.Open()
            reader6 = cmd6.ExecuteReader()

            Do While reader6.Read()

                TextBox17.Text = (reader6("UserUID")
                )
                TextBox18.Text = (reader6("UserID")
                )
                TextBox19.Text = (reader6("PW")
                )
                TextBox20.Text = (reader6("Point")
               )
                TextBox21.Text = (reader6("UserIP")
                )
                TextBox22.Text = (reader6("Status")
                )
                TextBox22.Text = IIf(TextBox22.Text = 0, "nein", "ja")
                TextBox23.Text = (reader6("AdminLevel")
                )
                TextBox23.Text = IIf(TextBox23.Text = 0, "nein", "ja")
                TextBox38.Text = (reader6("LoginStatus")
                )
                TextBox38.Text = IIf(TextBox38.Text = 0, "nein", "ja")

            Loop

            reader6.Close()
            con6.Close()
        Catch ex As Exception
            If MessageBox.Show("Accountdaten erfolgreich geladen.") Then
                Dim mainForm As New ADM

            Else
                MessageBox.Show("Benutzername erfolgreich geändert")

            End If
        End Try
    End Sub

    Private Sub Button15_Click(sender As System.Object, e As System.EventArgs) Handles Button15.Click
        Dim con As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim reader As SqlDataReader

        con.ConnectionString = "Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'"
        cmd.Connection = con
        cmd.CommandText = "select DISTINCT um.UserIP, a.Text1, a.UserUID, um.UserUID, um.UserID FROM PS_UserData.dbo.Users_Master um INNER JOIN PS_GameLog.dbo.ActionLog a ON um.UserID=a.UserID Where ActionType='107' AND a.UserUID = '" & TextBox17.Text & "'"
        Try
            con.Open()
            reader = cmd.ExecuteReader()
            ListBox8.Items.Clear()
            Do While reader.Read()
                ListBox8.Items.Add(reader("Text1")
                )
            Loop

            reader.Close()
            con.Close()
        Catch ex As Exception
            If MessageBox.Show("Account erfolgreich geladen...") Then
                Dim mainForm As New ADM

            Else
                MessageBox.Show("Account konnten nicht geladen weden...")

            End If
        End Try
    End Sub

    Private Sub Button16_Click(sender As System.Object, e As System.EventArgs) Handles Button16.Click
        Dim con As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim reader As SqlDataReader

        con.ConnectionString = "Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'"
        cmd.Connection = con
        cmd.CommandText = "select DISTINCT UserID FROM PS_GameLog.dbo.ActionLOG Where ActionType='107' AND Text1 = '" & ListBox8.Text & "'"
        Try
            con.Open()
            reader = cmd.ExecuteReader()
            ListBox7.Items.Clear()
            Do While reader.Read()
                ListBox7.Items.Add(reader("UserID")
                )
            Loop

            reader.Close()
            con.Close()
        Catch ex As Exception
            If MessageBox.Show("Account erfolgreich geladen...") Then
                Dim mainForm As New ADM

            Else
                MessageBox.Show("Account konnten nicht geladen weden...")

            End If
        End Try
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("SELECT c.UserUID, c.Count,c.ItemID,c.Type,c.TypeID,c.Gem1,c.Gem2,c.Gem3,c.Gem4,c.Gem5,c.Gem6, I.ItemName, I.ItemID, c.ItemID, c.Count,c.ItemID,c.Type,c.TypeID,c.Gem1,c.Gem2,c.Gem3,c.Gem4,c.Gem5,Gem6,SUBSTRING(c.Craftname, 1, 2) AS 'Str', SUBSTRING(c.Craftname, 3, 2) AS 'Dex',SUBSTRING(c.Craftname, 5, 2) AS 'Rec', SUBSTRING(c.Craftname, 7, 2) AS 'Int',SUBSTRING(c.Craftname, 9, 2) AS 'Wis',SUBSTRING(c.Craftname, 11, 2) AS 'Luc', SUBSTRING(c.Craftname, 13, 2) AS 'HP',SUBSTRING(c.Craftname, 15, 2) AS 'MP',SUBSTRING(c.Craftname, 17, 2) AS 'SP', SUBSTRING(c.Craftname, 19, 2) AS 'Enchant', c.ItemUID,I.ItemName,I.ReqWis,I.Type  FROM PS_GameData.dbo.UserStoredItems c INNER JOIN PS_GameDefs.dbo.Items I ON I.ItemID=c.ItemID WHERE c.ItemUID='" & ListView1.SelectedItems(0).SubItems(0).Text & "'", con)
        Dim reader As SqlDataReader
        Try
            AccWLbearbeiten.Show()
            con.Open()
            reader = cmd.ExecuteReader()

            Do While reader.Read()
                AccWLbearbeiten.TextBox22.Text = (reader("ItemID")
                    )
                AccWLbearbeiten.TextBox1.Text = (reader("UserUID")
                )
                AccWLbearbeiten.TextBox2.Text = (reader("ItemName")
                )
                AccWLbearbeiten.TextBox3.Text = (reader("ItemUID")
                )
                AccWLbearbeiten.TextBox4.Text = (reader("Gem1")
                )
                AccWLbearbeiten.TextBox5.Text = (reader("Gem2")
                )
                AccWLbearbeiten.TextBox6.Text = (reader("Gem3")
                )
                AccWLbearbeiten.TextBox7.Text = (reader("Gem4")
                )
                AccWLbearbeiten.TextBox8.Text = (reader("Gem5")
                )
                AccWLbearbeiten.TextBox9.Text = (reader("Gem6")
                )
                AccWLbearbeiten.TextBox10.Text = (reader("Str")
                )
                AccWLbearbeiten.TextBox11.Text = (reader("Dex")
                )
                AccWLbearbeiten.TextBox12.Text = (reader("Rec")
                )
                AccWLbearbeiten.TextBox13.Text = (reader("Int")
                )
                AccWLbearbeiten.TextBox14.Text = (reader("Wis")
                )
                AccWLbearbeiten.TextBox15.Text = (reader("Luc")
                )
                AccWLbearbeiten.TextBox16.Text = (reader("HP")
                )
                AccWLbearbeiten.TextBox17.Text = (reader("MP")
                )
                AccWLbearbeiten.TextBox18.Text = (reader("SP")
                )
                AccWLbearbeiten.TextBox19.Text = (reader("Enchant")
                )
                AccWLbearbeiten.TextBox21.Text = (reader("Count")
                )
            Loop
            reader.Close()
            con.Close()
            AccWLbearbeiten.Show()
        Catch ex As Exception
            If MessageBox.Show("Item konnte nicht geladen werden.") Then
                Dim mainForm As New ADM

            Else
                MessageBox.Show("Item erfolgreich geladen")

            End If
        End Try
        AccWLbearbeiten.TextBox20.Text = AccWLbearbeiten.TextBox10.Text + AccWLbearbeiten.TextBox11.Text + AccWLbearbeiten.TextBox12.Text + AccWLbearbeiten.TextBox13.Text + AccWLbearbeiten.TextBox14.Text + AccWLbearbeiten.TextBox15.Text + AccWLbearbeiten.TextBox16.Text + AccWLbearbeiten.TextBox17.Text + AccWLbearbeiten.TextBox18.Text + AccWLbearbeiten.TextBox19.Text
    End Sub

    Private Sub Button66_Click(sender As System.Object, e As System.EventArgs) Handles Button66.Click
        AccWLlöschen.Show()
    End Sub

    Private Sub Button61_Click(sender As System.Object, e As System.EventArgs) Handles Button61.Click
        Acclöschen.Show()
    End Sub

    Private Sub AccountsZurLöschungToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AccountsZurLöschungToolStripMenuItem.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("Select UserUID, UserID, Pw, Status, UserIP From PS_UserData.dbo.Users_Master Where Status='-4'", con)
        Dim reader As SqlDataReader

        Try
            AcczurLöschung.Show()
            con.Open()
            reader = cmd.ExecuteReader()

            Do While reader.Read()
                With AcczurLöschung.ListView1
                    .Items.Add(reader("UserUID"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(reader("UserID"))
                        .Add(reader("Pw"))
                        .Add(reader("Status"))
                        .Add(reader("UserIP"))
                    End With

                End With

            Loop

            reader.Close()
            con.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GebannteAccountsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GebannteAccountsToolStripMenuItem.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("Select UserUID, UserID, Pw, Status, UserIP From PS_UserData.dbo.Users_Master Where Status='-5'", con)
        Dim reader As SqlDataReader

        Try
            GebannteAcc.Show()
            con.Open()
            reader = cmd.ExecuteReader()

            Do While reader.Read()
                With GebannteAcc.ListView1
                    .Items.Add(reader("UserUID"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(reader("UserID"))
                        .Add(reader("Pw"))
                        .Add(reader("Status"))
                        .Add(reader("UserIP"))
                    End With

                End With

            Loop

            reader.Close()
            con.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AlleGMAccountsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AlleGMAccountsToolStripMenuItem.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("Select UserUID, UserID, Pw, Admin, AdminLevel, Status, UserType, UserIP From PS_UserData.dbo.Users_Master Where Admin='True'", con)
        Dim reader As SqlDataReader

        Try
            GMListe.Show()
            con.Open()
            reader = cmd.ExecuteReader()

            Do While reader.Read()
                With GMListe.ListView1
                    .Items.Add(reader("UserUID"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(reader("UserID"))
                        .Add(reader("Pw"))
                        .Add(reader("Admin"))
                        .Add(reader("AdminLevel"))
                        .Add(reader("Status"))
                        .Add(reader("UserType"))
                        .Add(reader("UserIP"))
                    End With

                End With

            Loop

            reader.Close()
            con.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ÜberShaiyaADMToolV3ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ÜberShaiyaADMToolV3ToolStripMenuItem.Click
        Process.Start("https://github.com/Edanchen/Shaiya-ADM-Tool")
    End Sub

    Private Sub AlleGelöschteCharsEntfernenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AlleGelöschteCharsEntfernenToolStripMenuItem.Click
        GelöschteCharsentfernen.Show()
    End Sub

    Private Sub EingeloggteSpielerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EingeloggteSpielerToolStripMenuItem.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("Select CharName, LoginStatus From PS_GameData.dbo.Chars Where LoginStatus='1'", con)
        Dim reader As SqlDataReader

        Try
            LoginStatus.Show()
            con.Open()
            reader = cmd.ExecuteReader()

            Do While reader.Read()

                With LoginStatus.ListView1
                    .Items.Add(reader("CharName"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(reader("LoginStatus"))

                    End With

                End With

            Loop

            reader.Close()
            con.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ActionLogEinsehenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ActionLogEinsehenToolStripMenuItem.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("Select CharID, CharName, ActionTime, Value1, Value2, Text1, Text2 From PS_GameLog.dbo.ActionLog", con)
        Dim reader As SqlDataReader

        Try
            GesamterActionLog.Show()
            con.Open()
            reader = cmd.ExecuteReader()

            Do While reader.Read()

                With GesamterActionLog.ListView1
                    .Items.Add(reader("CharID"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(reader("CharName"))
                        .Add(reader("ActionTime"))
                        .Add(reader("Value1"))
                        .Add(reader("Value2"))
                        .Add(reader("Text1"))
                        .Add(reader("Text2"))

                    End With

                End With

            Loop

            reader.Close()
            con.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AlleAuktionenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AlleAuktionenToolStripMenuItem.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("SELECT  m.MarketID, m.CharID, m.MinMoney, m.DirectMoney, m.MarketType, m.GuaranteeMoney, m.TenderCharID, m.TenderCharName, m.TenderMoney, m.EndDate, m.Del, c.CharName From PS_GameData.dbo.Market m INNER Join PS_GameData.dbo.Chars c ON m.CharID=c.CharID", con)
        Dim reader As SqlDataReader

        Try
            AlleAuktionen.Show()
            con.Open()
            reader = cmd.ExecuteReader()

            Do While reader.Read()

                With AlleAuktionen.ListView1
                    .Items.Add(reader("MarketID"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(reader("CharName"))
                        .Add(reader("MinMoney"))
                        .Add(reader("DirectMoney"))
                        .Add(reader("MarketType"))
                        .Add(reader("GuaranteeMoney"))
                        .Add(reader("TenderCharID"))
                        .Add(reader("TenderCharName"))
                        .Add(reader("TenderMoney"))
                        .Add(reader("EndDate"))
                        .Add(reader("Del"))
                    End With

                End With

            Loop

            reader.Close()
            con.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub StatPaddersToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StatPaddersToolStripMenuItem.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("SELECT UserID, UserUID, CharName, Level, K1, K2 From PS_GameData.dbo.Chars WHERE K1 <= 20 AND K2 >= 20", con)
        Dim reader As SqlDataReader

        Try
            StatPadder.Show()
            con.Open()
            reader = cmd.ExecuteReader()

            Do While reader.Read()

                With StatPadder.ListView1
                    .Items.Add(reader("UserID"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(reader("UserUID"))
                        .Add(reader("CharName"))
                        .Add(reader("Level"))
                        .Add(reader("K1"))
                        .Add(reader("K2"))
                    End With

                End With

            Loop

            reader.Close()
            con.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ChatLogToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ChatLogToolStripMenuItem.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("SELECT c.UserUID, c.CharID, c.ChatType, c.ChatData, c.MapID, c.ChatTime, a.CharName From PS_ChatLog.dbo.ChatLog AS c INNER JOIN PS_GameData.dbo.Chars a ON c.CharID=a.CharID", con)
        Dim reader As SqlDataReader

        Try
            ChatLog.Show()
            con.Open()
            reader = cmd.ExecuteReader()

            Do While reader.Read()

                With ChatLog.ListView1
                    .Items.Add(reader("UserUID"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(reader("CharName"))
                        .Add(reader("ChatType"))
                        .Add(reader("ChatData"))
                        .Add(reader("MapID"))
                        .Add(reader("ChatTime"))
                    End With

                End With

            Loop

            reader.Close()
            con.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ImGameMallToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ImGameMallToolStripMenuItem.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("SELECT ProductName, ProductCode, BuyCost, ItemID1, ItemCount1, ItemID2, ItemCount2, ItemID3, ItemCount3, ItemID4, ItemCount4, ItemID5, ItemCount5, ItemID6, ItemCount6, ItemID7, ItemCount7, ItemID8, ItemCount8, ItemID9, ItemCount9, ItemID10, ItemCount10 From PS_GameDefs.dbo.ProductList", con)
        Dim reader As SqlDataReader

        Try
            InGameMall.Show()
            con.Open()
            reader = cmd.ExecuteReader()

            Do While reader.Read()

                With InGameMall.ListView1
                    .Items.Add(reader("ProductName"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(reader("ProductCode"))
                        .Add(reader("BuyCost"))
                        .Add(reader("ItemID1"))
                        .Add(reader("ItemCount1"))
                        .Add(reader("ItemID2"))
                        .Add(reader("ItemCount2"))
                        .Add(reader("ItemID3"))
                        .Add(reader("ItemCount3"))
                        .Add(reader("ItemID4"))
                        .Add(reader("ItemCount4"))
                        .Add(reader("ItemID5"))
                        .Add(reader("ItemCount5"))
                        .Add(reader("ItemID6"))
                        .Add(reader("ItemCount6"))
                        .Add(reader("ItemID7"))
                        .Add(reader("ItemCount7"))
                        .Add(reader("ItemID8"))
                        .Add(reader("ItemCount8"))
                        .Add(reader("ItemID9"))
                        .Add(reader("ItemCount9"))
                        .Add(reader("ItemID10"))
                        .Add(reader("ItemCount10"))
                    End With

                End With

            Loop

            reader.Close()
            con.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub WartungsmodusEinschaltenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles WartungsmodusEinschaltenToolStripMenuItem.Click
        Wartungsmodusein.Show()
    End Sub

    Private Sub WartungsmodusAusschaltenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles WartungsmodusAusschaltenToolStripMenuItem.Click
        Wartungsmodusaus.Show()
    End Sub

    Private Sub Button30_Click(sender As System.Object, e As System.EventArgs) Handles Button30.Click
        CharName.Show()
        CharName.TextBox1.Text = TextBox25.Text
    End Sub

    Private Sub Button31_Click(sender As System.Object, e As System.EventArgs) Handles Button31.Click
        Leveländern.Show()
        Leveländern.TextBox1.Text = TextBox26.Text
    End Sub

    Private Sub Button32_Click(sender As System.Object, e As System.EventArgs) Handles Button32.Click
        Killsändern.Show()
        Killsändern.TextBox1.Text = TextBox27.Text
    End Sub

    Private Sub Button33_Click(sender As System.Object, e As System.EventArgs) Handles Button33.Click
        Toteändern.Show()
        Toteändern.TextBox1.Text = TextBox28.Text
    End Sub

    Private Sub Button34_Click(sender As System.Object, e As System.EventArgs) Handles Button34.Click
        Wiederbelebung.Show()
    End Sub

    Private Sub Button35_Click(sender As System.Object, e As System.EventArgs) Handles Button35.Click
        StatPoints.Show()
        StatPoints.TextBox1.Text = TextBox30.Text
    End Sub

    Private Sub Button36_Click(sender As System.Object, e As System.EventArgs) Handles Button36.Click
        SkillPoints.Show()
        SkillPoints.TextBox1.Text = TextBox31.Text
    End Sub

    Private Sub Button37_Click(sender As System.Object, e As System.EventArgs) Handles Button37.Click
        Stärkeändern.Show()
        Stärkeändern.TextBox1.Text = TextBox32.Text
    End Sub

    Private Sub Button38_Click(sender As System.Object, e As System.EventArgs) Handles Button38.Click
        Geschickändern.Show()
        Geschickändern.TextBox1.Text = TextBox33.Text
    End Sub

    Private Sub Button39_Click(sender As System.Object, e As System.EventArgs) Handles Button39.Click
        Abwehrändern.Show()
        Abwehrändern.TextBox1.Text = TextBox34.Text
    End Sub

    Private Sub Button40_Click(sender As System.Object, e As System.EventArgs) Handles Button40.Click
        Intelligenzändern.Show()
        Intelligenzändern.TextBox1.Text = TextBox35.Text
    End Sub

    Private Sub Button41_Click(sender As System.Object, e As System.EventArgs) Handles Button41.Click
        Glückändern.Show()
        Glückändern.TextBox1.Text = TextBox36.Text
    End Sub

    Private Sub Button42_Click(sender As System.Object, e As System.EventArgs) Handles Button42.Click
        Weisheitändern.Show()
        Weisheitändern.TextBox1.Text = TextBox37.Text
    End Sub

    Private Sub Button43_Click(sender As System.Object, e As System.EventArgs) Handles Button43.Click
        CharLoginStatus.Show()
    End Sub

    Private Sub Button51_Click(sender As System.Object, e As System.EventArgs) Handles Button51.Click
        Dim con As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim reader As SqlDataReader

        con.ConnectionString = "Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'"
        cmd.Connection = con
        cmd.CommandText = "select b.GuildID, b.CharID, b.CharID, a.CharName, g.GuildID, g.GuildName, g.MasterUserID, g.MasterName, g.MasterCharID, g.Country, g.TotalCount, g.GuildPoint, g.Del, d.UseHouse, d.Etin, d.Rank, d.Remark from PS_GameData.dbo.Guilds g INNER JOIN PS_GameData.dbo.GuildDetails d ON g.GuildID=d.GuildID INNER JOIN PS_GameData.dbo.GuildChars b ON g.GuildID=b.GuildID INNER JOIN PS_GameData.dbo.Chars a ON b.CharID=a.CharID Where g.GuildName = '" & TextBox39.Text & "'"


        Try

            TabControl1.SelectedIndex = 1
            con.Open()
            reader = cmd.ExecuteReader()
            ListBox2.Items.Clear()
            ListView3.Items.Clear()
            Do While reader.Read()
                TextBox5.Text = (reader("GuildID")
                )
                TextBox6.Text = (reader("GuildName")
                )
                TextBox7.Text = (reader("MasterUserID")
                )
                TextBox8.Text = (reader("MasterName")
                )
                TextBox9.Text = (reader("Country")
                )
                TextBox9.Text = IIf(TextBox9.Text = 0, "Light", "Dark")
                TextBox10.Text = (reader("TotalCount")
                )
                TextBox11.Text = (reader("GuildPoint")
                )
                TextBox12.Text = (reader("Del")
                )
                TextBox12.Text = IIf(TextBox12.Text = 0, "nein", "ja")
                TextBox13.Text = (reader("UseHouse")
                )
                TextBox13.Text = IIf(TextBox13.Text = 0, "nein", "ja")
                TextBox14.Text = (reader("Etin")
                )
                TextBox15.Text = (reader("Rank")
                )
                TextBox16.Text = (reader("Remark")
                )
                ListBox2.Items.Add(reader("CharName")
                )
                TextBox40.Text = (reader("MasterCharID")
                )
            Loop

            reader.Close()
            con.Close()
        Catch ex As Exception
            If MessageBox.Show("Benutzername erfolgreich geändert") Then
                Dim Form1 As New ADM

            Else
                MessageBox.Show("Gilde erfolgreich geladen")
                TabPage2.Show()
            End If
        End Try
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("SELECT c.Count,c.ItemID,c.Type,c.TypeID,c.Gem1,c.Gem2,c.Gem3,c.Gem4,c.Gem5,c.Gem6, I.ItemName, c.CharID, I.ItemID, c.ItemID, c.Count,c.ItemID,c.Type,c.TypeID,c.Gem1,c.Gem2,c.Gem3,c.Gem4,c.Gem5,Gem6,SUBSTRING(c.Craftname, 1, 2) AS 'Str', SUBSTRING(c.Craftname, 3, 2) AS 'Dex',SUBSTRING(c.Craftname, 5, 2) AS 'Rec', SUBSTRING(c.Craftname, 7, 2) AS 'Int',SUBSTRING(c.Craftname, 9, 2) AS 'Wis',SUBSTRING(c.Craftname, 11, 2) AS 'Luc', SUBSTRING(c.Craftname, 13, 2) AS 'HP',SUBSTRING(c.Craftname, 15, 2) AS 'MP',SUBSTRING(c.Craftname, 17, 2) AS 'SP', SUBSTRING(c.Craftname, 19, 2) AS 'Enchant', c.ItemUID,I.ItemName,I.ReqWis,I.Type  FROM PS_GameData.dbo.CharItems c INNER JOIN PS_GameDefs.dbo.Items I ON I.ItemID=c.ItemID WHERE c.CharID='" & TextBox24.Text & "' AND c.ItemUID='" & ListView4.SelectedItems(0).SubItems(0).Text & "'", con)

        Dim reader As SqlDataReader
        Try
            CharItembearbeiten.Show()
            con.Open()
            reader = cmd.ExecuteReader()

            Do While reader.Read()
                CharItembearbeiten.TextBox3.Text = (reader("ItemID")
                    )
                CharItembearbeiten.TextBox1.Text = (reader("CharID")
                )
                CharItembearbeiten.TextBox2.Text = (reader("ItemName")
                )
                CharItembearbeiten.TextBox22.Text = (reader("ItemUID")
                )
                CharItembearbeiten.TextBox4.Text = (reader("Gem1")
                )
                CharItembearbeiten.TextBox5.Text = (reader("Gem2")
                )
                CharItembearbeiten.TextBox6.Text = (reader("Gem3")
                )
                CharItembearbeiten.TextBox7.Text = (reader("Gem4")
                )
                CharItembearbeiten.TextBox8.Text = (reader("Gem5")
                )
                CharItembearbeiten.TextBox9.Text = (reader("Gem6")
                )
                CharItembearbeiten.TextBox10.Text = (reader("Str")
                )
                CharItembearbeiten.TextBox11.Text = (reader("Dex")
                )
                CharItembearbeiten.TextBox12.Text = (reader("Rec")
                )
                CharItembearbeiten.TextBox13.Text = (reader("Int")
                )
                CharItembearbeiten.TextBox14.Text = (reader("Wis")
                )
                CharItembearbeiten.TextBox15.Text = (reader("Luc")
                )
                CharItembearbeiten.TextBox16.Text = (reader("HP")
                )
                CharItembearbeiten.TextBox17.Text = (reader("MP")
                )
                CharItembearbeiten.TextBox18.Text = (reader("SP")
                )
                CharItembearbeiten.TextBox19.Text = (reader("Enchant")
                )
                CharItembearbeiten.TextBox21.Text = (reader("Count")
                )

            Loop
            reader.Close()
            con.Close()
            CharItembearbeiten.Show()
        Catch ex As Exception
            If MessageBox.Show("Benutzername erfolgreich geändert") Then
                Dim mainForm As New ADM

            Else
                MessageBox.Show("Benutzername erfolgreich geändert")

            End If
        End Try
        CharItembearbeiten.TextBox20.Text = CharItembearbeiten.TextBox10.Text + CharItembearbeiten.TextBox11.Text + CharItembearbeiten.TextBox12.Text + CharItembearbeiten.TextBox13.Text + CharItembearbeiten.TextBox14.Text + CharItembearbeiten.TextBox15.Text + CharItembearbeiten.TextBox16.Text + CharItembearbeiten.TextBox17.Text + CharItembearbeiten.TextBox18.Text + CharItembearbeiten.TextBox19.Text
    End Sub

    Private Sub Button67_Click(sender As System.Object, e As System.EventArgs) Handles Button67.Click
        CharItemlöschen.Show()
    End Sub

    Private Sub Button17_Click(sender As System.Object, e As System.EventArgs) Handles Button17.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("SELECT  CharID, CharName, ActionTime, Value1, Value2, Text1, Text2 From PS_GameLog.dbo.ActionLog Where CharName = '" & TextBox25.Text & "'", con)
        Dim reader As SqlDataReader

        Try
            CharActionLog.Show()
            con.Open()
            reader = cmd.ExecuteReader()

            Do While reader.Read()

                With CharActionLog.ListView1
                    .Items.Add(reader("CharID"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(reader("CharName"))
                        .Add(reader("ActionTime"))
                        .Add(reader("Value1"))
                        .Add(reader("Value2"))
                        .Add(reader("Text1"))
                        .Add(reader("Text2"))

                    End With

                End With

            Loop

            reader.Close()
            con.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button18_Click(sender As System.Object, e As System.EventArgs) Handles Button18.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("SELECT  CharID, CharName, ActionTime, Value1, Value2, Text1, Text2 From PS_GameLog.dbo.ActionLog Where CharName = '" & TextBox25.Text & "' AND ActionType = '112'", con)
        Dim reader As SqlDataReader

        Try
            KaputteItemsActionLog.Show()
            con.Open()
            reader = cmd.ExecuteReader()

            Do While reader.Read()

                With KaputteItemsActionLog.ListView1
                    .Items.Add(reader("CharID"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(reader("CharName"))
                        .Add(reader("ActionTime"))
                        .Add(reader("Value1"))
                        .Add(reader("Value2"))
                        .Add(reader("Text1"))
                        .Add(reader("Text2"))

                    End With

                End With

            Loop

            reader.Close()
            con.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button59_Click(sender As System.Object, e As System.EventArgs) Handles Button59.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("SELECT  CharID, CharName, ActionTime, Value1, Value2, Text1, Text2 From PS_GameLog.dbo.ActionLog Where CharName = '" & TextBox25.Text & "' AND ActionType = '103'", con)
        Dim reader As SqlDataReader

        Try
            KillsActionLog.Show()
            con.Open()
            reader = cmd.ExecuteReader()

            Do While reader.Read()

                With KillsActionLog.ListView1
                    .Items.Add(reader("CharID"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(reader("CharName"))
                        .Add(reader("ActionTime"))
                        .Add(reader("Value1"))
                        .Add(reader("Value2"))
                        .Add(reader("Text1"))
                        .Add(reader("Text2"))

                    End With

                End With

            Loop

            reader.Close()
            con.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button60_Click(sender As System.Object, e As System.EventArgs) Handles Button60.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("SELECT  CharID, CharName, ActionTime, Value1, Value2, Text1, Text2 From PS_GameLog.dbo.ActionLog Where CharName = '" & TextBox25.Text & "' AND ActionType = '104'", con)
        Dim reader As SqlDataReader

        Try
            ToteActionLog.Show()
            con.Open()
            reader = cmd.ExecuteReader()

            Do While reader.Read()

                With ToteActionLog.ListView1
                    .Items.Add(reader("CharID"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(reader("CharName"))
                        .Add(reader("ActionTime"))
                        .Add(reader("Value1"))
                        .Add(reader("Value2"))
                        .Add(reader("Text1"))
                        .Add(reader("Text2"))

                    End With

                End With

            Loop

            reader.Close()
            con.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button58_Click(sender As System.Object, e As System.EventArgs) Handles Button58.Click
        ItemWiederherstellung.Show()
    End Sub

    Private Sub Button46_Click(sender As System.Object, e As System.EventArgs) Handles Button46.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("SELECT  p.UserUID, p.CharID, p.UsePoint, p.ProductCode, p.UseDate, c.CharName From PS_GameData.dbo.PointLog AS p INNER JOIN PS_GameData.dbo.Chars AS c ON p.CharID=c.CharID Where p.CharID = '" & TextBox24.Text & "'", con)
        Dim reader As SqlDataReader

        Try
            KäufeInGameMall.Show()
            con.Open()
            reader = cmd.ExecuteReader()

            Do While reader.Read()

                With KäufeInGameMall.ListView1
                    .Items.Add(reader("UserUID"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(reader("CharName"))
                        .Add(reader("UsePoint"))
                        .Add(reader("ProductCode"))
                        .Add(reader("UseDate"))


                    End With

                End With

            Loop

            reader.Close()
            con.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button47_Click(sender As System.Object, e As System.EventArgs) Handles Button47.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("SELECT  p.UserUID, p.CharID, p.ItemID, p.ItemUID, p.Quality, p.ItemCount, p.BuyDate, p.ReceiveDate, c.CharName, i.ItemName From PS_GameData.dbo.ProductLog AS p INNER JOIN PS_GameData.dbo.Chars AS c ON p.CharID=c.CharID INNER JOIN PS_GameDefs.dbo.Items AS i ON p.ItemID=i.ItemID Where p.UserUID = '" & TextBox17.Text & "'", con)
        Dim reader As SqlDataReader

        Try
            KäufeWebMall.Show()
            con.Open()
            reader = cmd.ExecuteReader()

            Do While reader.Read()

                With KäufeWebMall.ListView1
                    .Items.Add(reader("UserUID"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(reader("CharName"))
                        .Add(reader("ItemName"))
                        .Add(reader("ItemUID"))
                        .Add(reader("Quality"))
                        .Add(reader("ItemCount"))
                        .Add(reader("BuyDate"))
                        .Add(reader("ReceiveDate"))


                    End With

                End With

            Loop

            reader.Close()
            con.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button48_Click(sender As System.Object, e As System.EventArgs) Handles Button48.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("SELECT  p.UserUID, p.Slot, p.ItemID, p.ItemCount, p.BuyDate, i.ItemName From PS_Billing.dbo.Users_Product AS p INNER JOIN PS_GameDefs.dbo.Items AS i ON p.ItemID=i.ItemID Where UserUID = '" & TextBox17.Text & "'", con)
        Dim reader As SqlDataReader

        Try
            Bank.Show()
            con.Open()
            reader = cmd.ExecuteReader()

            Do While reader.Read()

                With Bank.ListView1
                    .Items.Add(reader("UserUID"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(reader("Slot"))
                        .Add(reader("ItemName"))
                        .Add(reader("ItemCount"))
                        .Add(reader("BuyDate"))



                    End With

                End With

            Loop

            reader.Close()
            con.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button49_Click(sender As System.Object, e As System.EventArgs) Handles Button49.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("SELECT  MarketID, CharID, MinMoney, DirectMoney, MarketType, GuaranteeMoney, TenderCharID, TenderCharName, TenderMoney, EndDate, Del From PS_GameData.dbo.Market Where CharID = '" & TextBox24.Text & "'", con)
        Dim reader As SqlDataReader

        Try
            CharAuktionen.Show()
            con.Open()
            reader = cmd.ExecuteReader()

            Do While reader.Read()

                With CharAuktionen.ListView1
                    .Items.Add(reader("MarketID"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(reader("CharID"))
                        .Add(reader("MinMoney"))
                        .Add(reader("DirectMoney"))
                        .Add(reader("MarketType"))
                        .Add(reader("GuaranteeMoney"))
                        .Add(reader("TenderCharID"))
                        .Add(reader("TenderCharName"))
                        .Add(reader("TenderMoney"))
                        .Add(reader("EndDate"))
                        .Add(reader("Del"))



                    End With

                End With

            Loop

            reader.Close()
            con.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button45_Click(sender As System.Object, e As System.EventArgs) Handles Button45.Click
        FestChar.Show()
    End Sub

    Private Sub Button50_Click(sender As System.Object, e As System.EventArgs) Handles Button50.Click
        TeamGilde.Show()
    End Sub
    Private Sub Button54_Click(sender As System.Object, e As System.EventArgs) Handles Button54.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=PS_GameData;Integrated Security = SSPI")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("SELECT GV, UserID, Text, Status, Type, Zugewiesenan FROM ADM_Tool.dbo.Vorgaenge WHERE GV='" & ListView2.SelectedItems(0).SubItems(0).Text & "'", con)
        Dim reader As SqlDataReader
        Try
            GVbearbeiten.Show()
            con.Open()
            reader = cmd.ExecuteReader()
            Do While reader.Read()
                GVbearbeiten.TextBox1.Text = (reader("UserID")
                )
                GVbearbeiten.RichTextBox1.Text = (reader("Text")
                )
                GVbearbeiten.ComboBox1.Text = (reader("Status")
                )
                GVbearbeiten.ComboBox2.Text = (reader("Zugewiesenan")
                )
                GVbearbeiten.TextBox3.Text = (reader("Type")
                )
                GVbearbeiten.TextBox2.Text = (reader("GV")
                                              )
            Loop
            reader.Close()
            con.Close()

        Catch ex As Exception
            If MessageBox.Show("Benutzername erfolgreich geändert") Then
                Dim mainForm As New Main

            Else
                MessageBox.Show("Benutzername erfolgreich geändert")

            End If
        End Try
    End Sub
    Private Sub Button68_Click(sender As System.Object, e As System.EventArgs) Handles Button68.Click
        Dim con As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim reader As SqlDataReader

        con.ConnectionString = "Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'"
        cmd.Connection = con
        cmd.CommandText = "select b.GuildID, b.CharID, b.CharID, a.CharName, g.GuildID, g.GuildName, g.MasterUserID, g.MasterName, g.MasterCharID, g.Country, g.TotalCount, g.GuildPoint, g.Del, d.UseHouse, d.Etin, d.Rank, d.Remark from PS_GameData.dbo.Guilds g INNER JOIN PS_GameData.dbo.GuildDetails d ON g.GuildID=d.GuildID INNER JOIN PS_GameData.dbo.GuildChars b ON g.GuildID=b.GuildID INNER JOIN PS_GameData.dbo.Chars a ON b.CharID=a.CharID Where g.GuildID = '" & TextBox5.Text & "'"


        Try
            ListBox2.Items.Clear()
            TabControl1.SelectedIndex = 1
            con.Open()
            reader = cmd.ExecuteReader()


            Do While reader.Read()

                ListBox2.Items.Add(reader("CharName")
                )

            Loop

            reader.Close()
            con.Close()
        Catch ex As Exception
            If MessageBox.Show("Gilde konnte nicht geladen werden.") Then
                Dim Form1 As New Main

            Else
                MessageBox.Show("Gilde erfolgreich geladen")
                TabPage2.Show()
            End If
        End Try
    End Sub



    Private Sub Button69_Click(sender As System.Object, e As System.EventArgs) Handles Button69.Click
        Dim con As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim reader As SqlDataReader

        con.ConnectionString = "Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'"
        cmd.Connection = con
        cmd.CommandText = "select UserID From PS_UserData.dbo.Users_Master"
        Try
            con.Open()
            reader = cmd.ExecuteReader()
            ListBox3.Items.Clear()
            Do While reader.Read()
                ListBox3.Items.Add(reader("UserID")
                )
            Loop

            reader.Close()
            con.Close()
        Catch ex As Exception
            If MessageBox.Show("Account erfolgreich geladen...") Then
                Dim mainForm As New ADM

            Else
                MessageBox.Show("Account konnten nicht geladen weden...")

            End If
        End Try
    End Sub

    Private Sub Button70_Click(sender As System.Object, e As System.EventArgs) Handles Button70.Click

        Dim con6 As New Data.SqlClient.SqlConnection
        Dim cmd6 As New Data.SqlClient.SqlCommand
        Dim reader6 As SqlDataReader

        con6.ConnectionString = "Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'"
        cmd6.Connection = con6
        cmd6.CommandText = "Select UserUID, UserID, PW, UserIP, Point, Status, AdminLevel From PS_UserData.dbo.Users_Master WHERE UserID = '" & ListBox3.Text & "'"

        Try
            TabControl1.SelectedIndex = 2
            con6.Open()
            reader6 = cmd6.ExecuteReader()

            Do While reader6.Read()

                TextBox17.Text = (reader6("UserUID")
                )
                TextBox18.Text = (reader6("UserID")
                )
                TextBox19.Text = (reader6("PW")
                )
                TextBox20.Text = (reader6("Point")
               )
                TextBox21.Text = (reader6("UserIP")
                )
                TextBox22.Text = (reader6("Status")
                )
                TextBox22.Text = IIf(TextBox22.Text >= 0, "nein", "ja")
                TextBox23.Text = (reader6("AdminLevel")
                )
                TextBox23.Text = IIf(TextBox23.Text = 0, "nein", "ja")



            Loop

            reader6.Close()
            con6.Close()
        Catch ex As Exception
            If MessageBox.Show("Accountdaten erfolgreich geladen.") Then
                Dim mainForm As New ADM

            Else
                MessageBox.Show("Benutzername erfolgreich geändert")

            End If
        End Try

        Dim con2 As New Data.SqlClient.SqlConnection
        Dim cmd2 As New Data.SqlClient.SqlCommand
        Dim reader3 As SqlDataReader

        con2.ConnectionString = "Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'"
        cmd2.Connection = con2
        cmd2.CommandText = "select c.UserID, c.UserUID, c.Del, c.Level, c.CharName, c.StatPoint, c.SkillPoint, c.Str, c.Dex, c.Rec, c.Int, c.Luc, c.Wis, c.K1, c.K2, c.CharID, c.CharName, um.PW, um.UserIP, um.Point, um.Status, um.AdminLevel from PS_GameData.dbo.Chars c INNER JOIN PS_UserData.dbo.Users_Master um ON c.UserUID=um.UserUID Where um.UserID = '" & ListBox3.Text & "'"
        Try
            con2.Open()
            reader3 = cmd2.ExecuteReader()
            ListBox6.Items.Clear()
            Do While reader3.Read()
                ListBox6.Items.Add(reader3("Charname")
                )
            Loop

            reader3.Close()
            con2.Close()
        Catch ex As Exception
            If MessageBox.Show("Account erfolgreich geladen...") Then
                Dim mainForm As New ADM

            Else
                MessageBox.Show("Account konnten nicht geladen weden...")

            End If
        End Try

    End Sub

    Private Sub Button71_Click(sender As System.Object, e As System.EventArgs) Handles Button71.Click
        Dim con As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim reader As SqlDataReader

        con.ConnectionString = "Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'"
        cmd.Connection = con
        cmd.CommandText = "select CharName From PS_GameData.dbo.Chars"
        Try
            con.Open()
            reader = cmd.ExecuteReader()
            ListBox4.Items.Clear()
            Do While reader.Read()
                ListBox4.Items.Add(reader("Charname")
                )
            Loop

            reader.Close()
            con.Close()
        Catch ex As Exception
            If MessageBox.Show("Account erfolgreich geladen...") Then
                Dim mainForm As New ADM

            Else
                MessageBox.Show("Account konnten nicht geladen weden...")

            End If
        End Try
    End Sub

    Private Sub Button72_Click(sender As System.Object, e As System.EventArgs) Handles Button72.Click

        Dim con6 As New Data.SqlClient.SqlConnection
        Dim cmd6 As New Data.SqlClient.SqlCommand
        Dim reader6 As SqlDataReader

        con6.ConnectionString = "Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'"
        cmd6.Connection = con6
        cmd6.CommandText = "select c.UserID, c.UserUID, c.Del, c.Level, c.CharName, c.StatPoint, c.SkillPoint, c.Str, c.Dex, c.Rec, c.Int, c.Luc, c.Wis, c.K1, c.K2, c.CharID, c.CharName, um.PW, um.UserIP, um.Point, um.Status, um.AdminLevel from PS_GameData.dbo.Chars c INNER JOIN PS_UserData.dbo.Users_Master um ON c.UserUID=um.UserUID Where c.CharName = '" & ListBox4.Text & "'"

        Try

            con6.Open()
            reader6 = cmd6.ExecuteReader()

            Do While reader6.Read()

                TextBox17.Text = (reader6("UserUID")
                )
                TextBox18.Text = (reader6("UserID")
                )
                TextBox19.Text = (reader6("PW")
                )
                TextBox20.Text = (reader6("Point")
               )
                TextBox21.Text = (reader6("UserIP")
                )
                TextBox22.Text = (reader6("Status")
                )
                TextBox22.Text = IIf(TextBox22.Text = 0, "nein", "ja")
                TextBox23.Text = (reader6("AdminLevel")
                )
                TextBox23.Text = IIf(TextBox23.Text = 0, "nein", "ja")
                TextBox38.Text = (reader6("LoginStatus")
                )
                TextBox38.Text = IIf(TextBox38.Text = 0, "nein", "ja")

            Loop

            reader6.Close()
            con6.Close()
        Catch ex As Exception
            If MessageBox.Show("Char erfolgreich geladen.") Then
                Dim mainForm As New ADM

            Else
                MessageBox.Show("Benutzername erfolgreich geändert")

            End If
        End Try

        Dim con As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim reader As SqlDataReader

        con.ConnectionString = "Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'"
        cmd.Connection = con
        cmd.CommandText = "select I.ItemName, b.CharID, I.ItemID, b.ItemID, c.UserID, c.UserUID, c.Del, c.Level, c.StatPoint, c.SkillPoint, c.Str, c.Dex, c.Rec, c.Int, c.Luc, c.Wis, c.K1, c.K2, c.CharID, c.CharName, c.LoginStatus, um.PW, um.UserIP, um.Point, um.Status, um.AdminLevel from PS_GameData.dbo.Chars c INNER JOIN PS_UserData.dbo.Users_Master um ON c.UserUID=um.UserUID INNER JOIN PS_GameData.dbo.CharItems b ON b.CharID=c.CharID INNER JOIN PS_GameDefs.dbo.Items I ON I.ItemID=b.ItemID  Where c.CharName = '" & ListBox4.Text & "'"

        Try
            TabControl1.SelectedIndex = 3
            con.Open()
            reader = cmd.ExecuteReader()

            Do While reader.Read()
                TextBox24.Text = (reader("CharID")
                )
                TextBox25.Text = (reader("CharName")
                )
                TextBox26.Text = (reader("Level")
                )
                TextBox27.Text = (reader("K1")
                )
                TextBox28.Text = (reader("K2")
                )
                TextBox29.Text = (reader("Del")
                )
                TextBox29.Text = IIf(TextBox29.Text = 0, "nein", "ja")
                TextBox30.Text = (reader("StatPoint")
                )
                TextBox31.Text = (reader("SkillPoint")
                )
                TextBox32.Text = (reader("Str")
                )
                TextBox33.Text = (reader("Dex")
                )
                TextBox34.Text = (reader("Rec")
                )
                TextBox35.Text = (reader("Int")
                )
                TextBox36.Text = (reader("Luc")
                )
                TextBox37.Text = (reader("Wis")
                )
                TextBox38.Text = (reader("LoginStatus")
                )
                TextBox38.Text = IIf(TextBox38.Text = 0, "nein", "ja")

            Loop

            reader.Close()
            con.Close()
        Catch ex As Exception
            If MessageBox.Show("Account erfolgreich geladen...") Then
                Dim mainForm As New ADM

            Else
                MessageBox.Show("Account konnten nicht geladen weden...")

            End If
        End Try

        Dim con5 As New Data.SqlClient.SqlConnection
        Dim cmd5 As New Data.SqlClient.SqlCommand
        Dim reader5 As SqlDataReader

        con5.ConnectionString = "Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'"
        cmd5.Connection = con5
        cmd5.CommandText = "select um.UserUID, a.UserUID, b.GuildID, a.CharID, b.CharID, a.CharName, g.GuildID, g.GuildName from PS_GameData.dbo.Guilds g INNER JOIN PS_GameData.dbo.GuildChars b ON g.GuildID=b.GuildID INNER JOIN PS_GameData.dbo.Chars a ON b.CharID=a.CharID INNER JOIN PS_UserData.dbo.Users_Master um ON a.UserUID=um.UserUID Where a.CharName = '" & ListBox4.Text & "'"


        Try


            con5.Open()
            reader5 = cmd5.ExecuteReader()

            Do While reader5.Read()
                TextBox39.Text = (reader5("GuildName")
                )


            Loop

            reader5.Close()
            con5.Close()
        Catch ex As Exception
            If MessageBox.Show("Benutzername erfolgreich geändert") Then
                Dim Form1 As New ADM

            Else
                MessageBox.Show("Gilde erfolgreich geladen")

            End If
        End Try

    End Sub

    Private Sub Button73_Click(sender As Object, e As EventArgs) Handles Button73.Click
        Ticketerstellung.Show()
        Dim con2 As New Data.SqlClient.SqlConnection
        Dim cmd2 As New Data.SqlClient.SqlCommand
        Dim reader2 As SqlDataReader

        con2.ConnectionString = "Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'"
        cmd2.Connection = con2
        cmd2.CommandText = "select Art FROM ADM_Tool.dbo.Ticketart"
        Try
            con2.Open()
            reader2 = cmd2.ExecuteReader()
            Do While reader2.Read()
                Ticketerstellung.ComboBox3.Items.Add(reader2("Art")
                )
            Loop

            reader2.Close()
            con2.Close()
        Catch ex As Exception
            If MessageBox.Show("Account erfolgreich geladen...") Then
                Dim mainForm As New ADM

            Else
                MessageBox.Show("Account konnten nicht geladen weden...")

            End If
        End Try

        Dim con1 As New Data.SqlClient.SqlConnection
        Dim cmd1 As New Data.SqlClient.SqlCommand
        Dim reader1 As SqlDataReader

        con1.ConnectionString = "Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'"
        cmd1.Connection = con1
        cmd1.CommandText = "select Benutzer FROM ADM_Tool.dbo.Account"
        Try
            con1.Open()
            reader1 = cmd1.ExecuteReader()
            Do While reader1.Read()
                Ticketerstellung.ComboBox2.Items.Add(reader1("Benutzer")
                )
            Loop

            reader1.Close()
            con1.Close()
        Catch ex As Exception
            If MessageBox.Show("Account erfolgreich geladen...") Then
                Dim mainForm As New ADM

            Else
                MessageBox.Show("Account konnten nicht geladen weden...")

            End If
        End Try
        Ticketerstellung.TextBox2.Text = TextBox25.Text
        Ticketerstellung.TextBox1.Text = TextBox18.Text
    End Sub

    Private Sub HilfeZumToolToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HilfeZumToolToolStripMenuItem.Click
        Process.Start("https://discord.gg/VqdzURPN")
    End Sub



    Private Sub GlobalStatResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GlobalStatResetToolStripMenuItem.Click
        Globalreset.Show()

    End Sub

    Private Sub CharakterStatistikToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CharakterStatistikToolStripMenuItem.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("SELECT TOP 200
	c.CharName,
	c.Str + characterItems.ConstStr + lapisSum.ConstStr AS [Str],
	c.Dex + characterItems.ConstDex + lapisSum.ConstDex AS [Dex],
	c.Rec + characterItems.ConstRec + lapisSum.ConstRec AS [Rec],
	c.Int + characterItems.ConstInt + lapisSum.ConstInt AS [Int],
	c.Wis + characterItems.ConstWis + lapisSum.ConstWis AS [Wis],
	c.Luc + characterItems.ConstLuc + lapisSum.ConstLuc AS [Luc],
	c.Str + characterItems.ConstStr + lapisSum.ConstStr + c.Dex + characterItems.ConstDex + lapisSum.ConstDex + c.Rec + characterItems.ConstRec + lapisSum.ConstRec + c.Int + characterItems.ConstInt + lapisSum.ConstInt + c.Wis + characterItems.ConstWis + lapisSum.ConstWis + c.Luc + characterItems.ConstLuc + lapisSum.ConstLuc AS TotalStat,
	c.Rec + characterItems.ConstRec + lapisSum.ConstRec + characterItems.Defense + lapisSum.Defense AS Defense,
	c.Wis + characterItems.ConstWis + lapisSum.ConstWis + characterItems.MagicResist + lapisSum.MagicResist AS MagicResist,
	characterItems.Absorb + lapisSum.Absorb AS Absorb,
	CASE
		WHEN c.Job < 3 THEN
			(c.Str + characterItems.ConstStr + lapisSum.ConstStr) * 1.3 + (c.Dex + characterItems.ConstDex + lapisSum.ConstDex) * .2 + characterItems.Attack + lapisSum.Attack
		WHEN c.Job = 3 THEN
			(c.Str + characterItems.ConstStr + lapisSum.ConstStr) + (c.Dex + characterItems.ConstDex + lapisSum.ConstDex) * .2 + (c.Luc + characterItems.ConstLuc + lapisSum.ConstLuc) * .3 + characterItems.Attack + lapisSum.Attack
		ELSE
			(c.Int + characterItems.ConstInt + lapisSum.ConstInt) + (c.Wis + characterItems.ConstWis + lapisSum.ConstWis) * .2 + characterItems.Attack + lapisSum.Attack
		END AS AttackMin,
	CASE
		WHEN c.Job < 3 THEN
			(c.Str + characterItems.ConstStr + lapisSum.ConstStr) * 1.3 + (c.Dex + characterItems.ConstDex + lapisSum.ConstDex) * .2 + characterItems.Attack + lapisSum.Attack + characterItems.AttackModifier + lapisSum.AttackModifier
		WHEN c.Job = 3 THEN
			(c.Str + characterItems.ConstStr + lapisSum.ConstStr) + (c.Dex + characterItems.ConstDex + lapisSum.ConstDex) * .2 + (c.Luc + characterItems.ConstLuc + lapisSum.ConstLuc) * .3 + characterItems.Attack + lapisSum.Attack + characterItems.AttackModifier + lapisSum.AttackModifier
		ELSE
			(c.Int + characterItems.ConstInt + lapisSum.ConstInt) + (c.Wis + characterItems.ConstWis + lapisSum.ConstWis) * .2 + characterItems.Attack + lapisSum.Attack + characterItems.AttackModifier + lapisSum.AttackModifier
		END AS AttackMax
FROM [Ps_GameData].[dbo].[Chars] c
INNER JOIN PS_UserData.dbo.Users_Master AS u ON c.UserUID = u.UserUID
INNER JOIN (
	SELECT
		DISTINCT ci.CharID AS CharID,
		SUM(i.ConstStr + CASE WHEN i.ReqWis > 0 AND LEN(ci.CraftName) = 20 THEN CONVERT(int,SUBSTRING(ci.CraftName,1,2)) ELSE 0 END) AS ConstStr,
		SUM(i.ConstDex + CASE WHEN i.ReqWis > 0 AND LEN(ci.CraftName) = 20 THEN CONVERT(int,SUBSTRING(ci.CraftName,3,2)) ELSE 0 END) AS ConstDex,
		SUM(i.ConstRec + CASE WHEN i.ReqWis > 0 AND LEN(ci.CraftName) = 20 THEN CONVERT(int,SUBSTRING(ci.CraftName,5,2)) ELSE 0 END) AS ConstRec,
		SUM(i.ConstInt + CASE WHEN i.ReqWis > 0 AND LEN(ci.CraftName) = 20 THEN CONVERT(int,SUBSTRING(ci.CraftName,7,2)) ELSE 0 END) AS ConstInt,
		SUM(i.ConstWis + CASE WHEN i.ReqWis > 0 AND LEN(ci.CraftName) = 20 THEN CONVERT(int,SUBSTRING(ci.CraftName,9,2)) ELSE 0 END) AS ConstWis,
		SUM(i.ConstLuc + CASE WHEN i.ReqWis > 0 AND LEN(ci.CraftName) = 20 THEN CONVERT(int,SUBSTRING(ci.CraftName,11,2)) ELSE 0 END) AS ConstLuc,
		SUM(i.Effect1 + CASE WHEN i.ReqWis > 0 AND LEN(ci.CraftName) = 20 AND (CONVERT(int,SUBSTRING(ci.CraftName,19,2)) BETWEEN 1 AND 20) THEN 
			CASE
				WHEN SUBSTRING(ci.CraftName,19,2) = '01' THEN 7 WHEN SUBSTRING(ci.CraftName,19,2) = '02' THEN 14 WHEN SUBSTRING(ci.CraftName,19,2) = '03' THEN 21
				WHEN SUBSTRING(ci.CraftName,19,2) = '04' THEN 31 WHEN SUBSTRING(ci.CraftName,19,2) = '05' THEN 41 WHEN SUBSTRING(ci.CraftName,19,2) = '06' THEN 51
				WHEN SUBSTRING(ci.CraftName,19,2) = '07' THEN 64 WHEN SUBSTRING(ci.CraftName,19,2) = '08' THEN 77 WHEN SUBSTRING(ci.CraftName,19,2) = '09' THEN 90
				WHEN SUBSTRING(ci.CraftName,19,2) = '10' THEN 106 WHEN SUBSTRING(ci.CraftName,19,2) = '11' THEN 122 WHEN SUBSTRING(ci.CraftName,19,2) = '12' THEN 138
				WHEN SUBSTRING(ci.CraftName,19,2) = '13' THEN 157 WHEN SUBSTRING(ci.CraftName,19,2) = '14' THEN 176 WHEN SUBSTRING(ci.CraftName,19,2) = '15' THEN 195
				WHEN SUBSTRING(ci.CraftName,19,2) = '16' THEN 217 WHEN SUBSTRING(ci.CraftName,19,2) = '17' THEN 239 WHEN SUBSTRING(ci.CraftName,19,2) = '18' THEN 261
				WHEN SUBSTRING(ci.CraftName,19,2) = '19' THEN 286 WHEN SUBSTRING(ci.CraftName,19,2) = '20' THEN 311 
			END
		ELSE 0 END) AS Attack,
		SUM(i.Effect2) AS AttackModifier,
		SUM(i.Effect3) AS Defense,
		SUM(i.Effect4) AS MagicResist,
		SUM(CASE WHEN i.ReqWis > 0 AND (CONVERT(int,SUBSTRING(ci.CraftName,19,2)) BETWEEN 51 AND 70) THEN ((CONVERT(int,SUBSTRING(ci.CraftName,19,2)) - 50) * 5) ELSE 0 END) AS Absorb
	FROM [Ps_GameData].[dbo].[CharItems] ci
		INNER JOIN [Ps_GameDefs].[dbo].Items i ON i.ItemID = ci.ItemID
	WHERE ci.Bag = 0
		AND ci.Slot >= 0
		AND ci.Slot != 13
	GROUP BY ci.CharID
) AS characterItems ON c.CharID = characterItems.CharID
LEFT JOIN (
	SELECT
		DISTINCT ci.CharID AS CharID,
		SUM(ISNULL(lapis.ConstStr,0)) AS ConstStr,
		SUM(ISNULL(lapis.ConstDex,0)) AS ConstDex,
		SUM(ISNULL(lapis.ConstRec,0)) AS ConstRec,
		SUM(ISNULL(lapis.ConstInt,0)) AS ConstInt,
		SUM(ISNULL(lapis.ConstWis,0)) AS ConstWis,
		SUM(ISNULL(lapis.ConstLuc,0)) AS ConstLuc,
		SUM(ISNULL(lapis.Effect1,0)) AS Attack,
		SUM(ISNULL(lapis.Effect2,0)) AS AttackModifier,
		SUM(ISNULL(lapis.Effect3,0)) AS Defense,
		SUM(ISNULL(lapis.Effect4,0)) AS MagicResist,
		SUM(ISNULL(lapis.Exp,0)) AS Absorb
	FROM [Ps_GameData].[dbo].[CharItems] ci
		INNER JOIN [Ps_GameDefs].[dbo].Items i ON ci.ItemID = i.ItemID
		LEFT JOIN [Ps_GameDefs].[dbo].Items lapis ON lapis.Type = 30 AND lapis.TypeID IN(ci.Gem1,ci.Gem2,ci.Gem3,ci.Gem4,ci.Gem5,ci.Gem6)
	WHERE ci.Bag = 0
		AND ci.Slot >= 0
		AND ci.Slot != 13
	GROUP BY ci.CharID
) AS lapisSum ON c.CharID = lapisSum.CharID
WHERE
	c.Del = 0
	AND u.AdminLevel = 0
ORDER BY TotalStat DESC;", con)

        Dim reader As SqlDataReader

        Try
            CharRank.Show()
            con.Open()
            reader = cmd.ExecuteReader()

            Do While reader.Read()

                With CharRank.ListView1
                    .Items.Add(reader("Charname"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(reader("Str"))
                        .Add(reader("Dex"))
                        .Add(reader("Rec"))
                        .Add(reader("Int"))
                        .Add(reader("Wis"))
                        .Add(reader("Luc"))
                        .Add(reader("TotalStat"))
                        .Add(reader("Defense"))
                        .Add(reader("MagicResist"))
                        .Add(reader("Absorb"))
                        .Add(reader("AttackMin"))
                        .Add(reader("AttackMax"))
                    End With

                End With

            Loop

            reader.Close()
            con.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AllePvPKillsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllePvPKillsToolStripMenuItem.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("SELECT  CharID, CharName, ActionTime, Value1, Value2, Text1, Text2 From PS_GameLog.dbo.ActionLog Where ActionType = '103'", con)
        Dim reader As SqlDataReader

        Try
            Alle_Kills.Show()
            con.Open()
            reader = cmd.ExecuteReader()

            Do While reader.Read()

                With Alle_Kills.ListView1
                    .Items.Add(reader("CharID"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(reader("CharName"))
                        .Add(reader("ActionTime"))
                        .Add(reader("Value1"))
                        .Add(reader("Value2"))
                        .Add(reader("Text1"))
                        .Add(reader("Text2"))

                    End With

                End With

            Loop

            reader.Close()
            con.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AllePvPToteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllePvPToteToolStripMenuItem.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("SELECT  CharID, CharName, ActionTime, Value1, Value2, Text1, Text2 From PS_GameLog.dbo.ActionLog Where ActionType = '104'", con)
        Dim reader As SqlDataReader

        Try
            AlleTote.Show()
            con.Open()
            reader = cmd.ExecuteReader()

            Do While reader.Read()

                With AlleTote.ListView1
                    .Items.Add(reader("CharID"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(reader("CharName"))
                        .Add(reader("ActionTime"))
                        .Add(reader("Value1"))
                        .Add(reader("Value2"))
                        .Add(reader("Text1"))
                        .Add(reader("Text2"))

                    End With

                End With

            Loop

            reader.Close()
            con.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BugMeldenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BugMeldenToolStripMenuItem.Click
        Process.Start("https://github.com/Edanchen/Shaiya-ADM-Tool/issues")
    End Sub

    Private Sub ServerAPVerteilenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServerAPVerteilenToolStripMenuItem.Click
        ServerAPgeben.Show()
    End Sub

    Private Sub BossKillsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BossKillsToolStripMenuItem.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("SELECT[Text1], [Text3], [ActionTime] FROM PS_GameLog.dbo.ActionLog WHERE [ActionType]='173' AND [Text2]='death'order by ActionTime desc", con)
        Dim reader As SqlDataReader

        Try

            con.Open()
            reader = cmd.ExecuteReader()
            BossKills.Show()

            Do While reader.Read()
                With BossKills.ListView1
                    .Items.Add(reader("Text1"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(reader("Text3"))
                        .Add(reader("ActionTime"))
                    End With

                End With

            Loop

            reader.Close()
            con.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AuftragToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AuftragToolStripMenuItem.Click
        Dim con As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim reader As SqlDataReader

        con.ConnectionString = "Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'"
        cmd.Connection = con
        cmd.CommandText = ("select Benutzer FROM ADM_Tool.dbo.Account")

        Try
            con.Open()
            reader = cmd.ExecuteReader()
            Do While reader.Read()
                Account_Auftrag.ComboBox2.Items.Add(reader("Benutzer"))
            Loop

            reader.Close()
            con.Close()
        Catch ex As Exception
            If MessageBox.Show("Account erfolgreich geladen...") Then
                Dim mainForm As New ADM

            Else
                MessageBox.Show("Account konnten nicht geladen weden...")

            End If
        End Try
        Dim con1 As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd1 As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("Select Typ FROM ADM_Tool.dbo.Vorgangart Where Thema='Account' AND Art='Auftrag'", con1)
        Dim reader1 As SqlDataReader

        Try
            con1.Open()
            reader1 = cmd1.ExecuteReader()
            Do While reader1.Read()
                Account_Auftrag.ComboBox1.Items.Add(reader1("Typ"))
            Loop

            reader1.Close()
            con1.Close()
        Catch ex As Exception
            If MessageBox.Show("Account erfolgreich geladen...") Then
                Dim mainForm As New ADM

            Else
                MessageBox.Show("Account konnten nicht geladen weden...")

            End If
        End Try
        Account_Auftrag.Show()
        Account_Auftrag.TextBox3.Text = TextBox18.Text
        Account_Auftrag.TextBox4.Text = Main.TextBox1.Text
    End Sub

    Private Sub InformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformationToolStripMenuItem.Click
        Dim con As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim reader As SqlDataReader

        con.ConnectionString = "Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'"
        cmd.Connection = con
        cmd.CommandText = ("select Benutzer FROM ADM_Tool.dbo.Account")

        Try
            con.Open()
            reader = cmd.ExecuteReader()
            Do While reader.Read()
                Account_Information.ComboBox2.Items.Add(reader("Benutzer"))
            Loop

            reader.Close()
            con.Close()
        Catch ex As Exception
            If MessageBox.Show("Account erfolgreich geladen...") Then
                Dim mainForm As New ADM

            Else
                MessageBox.Show("Account konnten nicht geladen weden...")

            End If
        End Try
        Dim con1 As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd1 As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("Select Typ FROM ADM_Tool.dbo.Vorgangart Where Thema='Account' AND Art='Information'", con1)
        Dim reader1 As SqlDataReader

        Try
            con1.Open()
            reader1 = cmd1.ExecuteReader()
            Do While reader1.Read()
                Account_Information.ComboBox1.Items.Add(reader1("Typ"))
            Loop

            reader1.Close()
            con1.Close()
        Catch ex As Exception
            If MessageBox.Show("Account erfolgreich geladen...") Then
                Dim mainForm As New ADM

            Else
                MessageBox.Show("Account konnten nicht geladen weden...")

            End If
        End Try
        Account_Information.Show()
        Account_Information.TextBox3.Text = TextBox18.Text
        Account_Information.TextBox4.Text = Main.TextBox1.Text
    End Sub

    Private Sub RaklamationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RaklamationToolStripMenuItem.Click
        Dim con As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim reader As SqlDataReader

        con.ConnectionString = "Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'"
        cmd.Connection = con
        cmd.CommandText = ("select Benutzer FROM ADM_Tool.dbo.Account")

        Try
            con.Open()
            reader = cmd.ExecuteReader()
            Do While reader.Read()
                Account_Reklamation.ComboBox2.Items.Add(reader("Benutzer"))
            Loop

            reader.Close()
            con.Close()
        Catch ex As Exception
            If MessageBox.Show("Account erfolgreich geladen...") Then
                Dim mainForm As New ADM

            Else
                MessageBox.Show("Account konnten nicht geladen weden...")

            End If
        End Try
        Dim con1 As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd1 As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("Select Typ FROM ADM_Tool.dbo.Vorgangart Where Thema='Account' AND Art='Reklamation'", con1)
        Dim reader1 As SqlDataReader

        Try
            con1.Open()
            reader1 = cmd1.ExecuteReader()
            Do While reader1.Read()
                Account_Reklamation.ComboBox1.Items.Add(reader1("Typ"))
            Loop

            reader1.Close()
            con1.Close()
        Catch ex As Exception
            If MessageBox.Show("Account erfolgreich geladen...") Then
                Dim mainForm As New ADM

            Else
                MessageBox.Show("Account konnten nicht geladen weden...")

            End If
        End Try
        Account_Reklamation.Show()
        Account_Reklamation.TextBox3.Text = TextBox18.Text
        Account_Reklamation.TextBox4.Text = Main.TextBox1.Text
    End Sub

    Private Sub AuftragToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AuftragToolStripMenuItem1.Click
        Dim con As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim reader As SqlDataReader

        con.ConnectionString = "Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'"
        cmd.Connection = con
        cmd.CommandText = ("select Benutzer FROM ADM_Tool.dbo.Account")

        Try
            con.Open()
            reader = cmd.ExecuteReader()
            Do While reader.Read()
                Char_Auftrag.ComboBox2.Items.Add(reader("Benutzer"))
            Loop

            reader.Close()
            con.Close()
        Catch ex As Exception
            If MessageBox.Show("Account erfolgreich geladen...") Then
                Dim mainForm As New ADM

            Else
                MessageBox.Show("Account konnten nicht geladen weden...")

            End If
        End Try
        Dim con1 As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd1 As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("Select Typ FROM ADM_Tool.dbo.Vorgangart Where Thema='Char' AND Art='Auftrag'", con1)
        Dim reader1 As SqlDataReader

        Try
            con1.Open()
            reader1 = cmd1.ExecuteReader()
            Do While reader1.Read()
                Char_Auftrag.ComboBox1.Items.Add(reader1("Typ"))
            Loop

            reader1.Close()
            con1.Close()
        Catch ex As Exception
            If MessageBox.Show("Account erfolgreich geladen...") Then
                Dim mainForm As New ADM

            Else
                MessageBox.Show("Account konnten nicht geladen weden...")

            End If
        End Try
        Char_Auftrag.Show()
        Char_Auftrag.TextBox3.Text = TextBox25.Text
        Char_Auftrag.TextBox4.Text = Main.TextBox1.Text
    End Sub

    Private Sub InformationToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles InformationToolStripMenuItem1.Click
        Dim con As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim reader As SqlDataReader

        con.ConnectionString = "Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'"
        cmd.Connection = con
        cmd.CommandText = ("select Benutzer FROM ADM_Tool.dbo.Account")

        Try
            con.Open()
            reader = cmd.ExecuteReader()
            Do While reader.Read()
                Char_Information.ComboBox2.Items.Add(reader("Benutzer"))
            Loop

            reader.Close()
            con.Close()
        Catch ex As Exception
            If MessageBox.Show("Account erfolgreich geladen...") Then
                Dim mainForm As New ADM

            Else
                MessageBox.Show("Account konnten nicht geladen weden...")

            End If
        End Try
        Dim con1 As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd1 As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("Select Typ FROM ADM_Tool.dbo.Vorgangart Where Thema='Char' AND Art='Information'", con1)
        Dim reader1 As SqlDataReader

        Try
            con1.Open()
            reader1 = cmd1.ExecuteReader()
            Do While reader1.Read()
                Char_Information.ComboBox1.Items.Add(reader1("Typ"))
            Loop

            reader1.Close()
            con1.Close()
        Catch ex As Exception
            If MessageBox.Show("Account erfolgreich geladen...") Then
                Dim mainForm As New ADM

            Else
                MessageBox.Show("Account konnten nicht geladen weden...")

            End If
        End Try
        Char_Information.Show()
        Char_Information.TextBox3.Text = TextBox25.Text
        Char_Information.TextBox4.Text = Main.TextBox1.Text
    End Sub

    Private Sub ReklamationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReklamationToolStripMenuItem.Click
        Dim con As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim reader As SqlDataReader

        con.ConnectionString = "Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'"
        cmd.Connection = con
        cmd.CommandText = ("select Benutzer FROM ADM_Tool.dbo.Account")

        Try
            con.Open()
            reader = cmd.ExecuteReader()
            Do While reader.Read()
                Char_Reklamation.ComboBox2.Items.Add(reader("Benutzer"))
            Loop

            reader.Close()
            con.Close()
        Catch ex As Exception
            If MessageBox.Show("Account erfolgreich geladen...") Then
                Dim mainForm As New ADM

            Else
                MessageBox.Show("Account konnten nicht geladen weden...")

            End If
        End Try
        Dim con1 As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd1 As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("Select Typ FROM ADM_Tool.dbo.Vorgangart Where Thema='Char' AND Art='Reklamation'", con1)
        Dim reader1 As SqlDataReader

        Try
            con1.Open()
            reader1 = cmd1.ExecuteReader()
            Do While reader1.Read()
                Char_Reklamation.ComboBox1.Items.Add(reader1("Typ"))
            Loop

            reader1.Close()
            con1.Close()
        Catch ex As Exception
            If MessageBox.Show("Account erfolgreich geladen...") Then
                Dim mainForm As New ADM

            Else
                MessageBox.Show("Account konnten nicht geladen weden...")

            End If
        End Try
        Char_Reklamation.Show()
        Char_Reklamation.TextBox3.Text = TextBox25.Text
        Char_Reklamation.TextBox4.Text = Main.TextBox1.Text
    End Sub

    Private Sub AuftragToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles AuftragToolStripMenuItem2.Click
        Dim con As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim reader As SqlDataReader

        con.ConnectionString = "Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'"
        cmd.Connection = con
        cmd.CommandText = ("select Benutzer FROM ADM_Tool.dbo.Account")

        Try
            con.Open()
            reader = cmd.ExecuteReader()
            Do While reader.Read()
                Gilde_Auftrag.ComboBox2.Items.Add(reader("Benutzer"))
            Loop

            reader.Close()
            con.Close()
        Catch ex As Exception
            If MessageBox.Show("Account erfolgreich geladen...") Then
                Dim mainForm As New ADM

            Else
                MessageBox.Show("Account konnten nicht geladen weden...")

            End If
        End Try
        Dim con1 As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd1 As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("Select Typ FROM ADM_Tool.dbo.Vorgangart Where Thema='Gilde' AND Art='Auftrag'", con1)
        Dim reader1 As SqlDataReader

        Try
            con1.Open()
            reader1 = cmd1.ExecuteReader()
            Do While reader1.Read()
                Gilde_Auftrag.ComboBox1.Items.Add(reader1("Typ"))
            Loop

            reader1.Close()
            con1.Close()
        Catch ex As Exception
            If MessageBox.Show("Account erfolgreich geladen...") Then
                Dim mainForm As New ADM

            Else
                MessageBox.Show("Account konnten nicht geladen weden...")

            End If
        End Try
        Gilde_Auftrag.Show()
        Gilde_Auftrag.TextBox3.Text = TextBox6.Text
        Gilde_Auftrag.TextBox4.Text = Main.TextBox1.Text
    End Sub

    Private Sub InformationToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles InformationToolStripMenuItem2.Click
        Dim con As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim reader As SqlDataReader

        con.ConnectionString = "Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'"
        cmd.Connection = con
        cmd.CommandText = ("select Benutzer FROM ADM_Tool.dbo.Account")

        Try
            con.Open()
            reader = cmd.ExecuteReader()
            Do While reader.Read()
                Gilde_Information.ComboBox2.Items.Add(reader("Benutzer"))
            Loop

            reader.Close()
            con.Close()
        Catch ex As Exception
            If MessageBox.Show("Account erfolgreich geladen...") Then
                Dim mainForm As New ADM

            Else
                MessageBox.Show("Account konnten nicht geladen weden...")

            End If
        End Try
        Dim con1 As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd1 As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("Select Typ FROM ADM_Tool.dbo.Vorgangart Where Thema='Gilde' AND Art='Information'", con1)
        Dim reader1 As SqlDataReader

        Try
            con1.Open()
            reader1 = cmd1.ExecuteReader()
            Do While reader1.Read()
                Gilde_Information.ComboBox1.Items.Add(reader1("Typ"))
            Loop

            reader1.Close()
            con1.Close()
        Catch ex As Exception
            If MessageBox.Show("Account erfolgreich geladen...") Then
                Dim mainForm As New ADM

            Else
                MessageBox.Show("Account konnten nicht geladen weden...")

            End If
        End Try
        Gilde_Information.Show()
        Gilde_Information.TextBox3.Text = TextBox6.Text
        Gilde_Information.TextBox4.Text = Main.TextBox1.Text
    End Sub

    Private Sub ReklamationToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ReklamationToolStripMenuItem1.Click
        Dim con As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim reader As SqlDataReader

        con.ConnectionString = "Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'"
        cmd.Connection = con
        cmd.CommandText = ("select Benutzer FROM ADM_Tool.dbo.Account")

        Try
            con.Open()
            reader = cmd.ExecuteReader()
            Do While reader.Read()
                Gilde_Reklamation.ComboBox2.Items.Add(reader("Benutzer"))
            Loop

            reader.Close()
            con.Close()
        Catch ex As Exception
            If MessageBox.Show("Account erfolgreich geladen...") Then
                Dim mainForm As New ADM

            Else
                MessageBox.Show("Account konnten nicht geladen weden...")

            End If
        End Try
        Dim con1 As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd1 As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("Select Typ FROM ADM_Tool.dbo.Vorgangart Where Thema='Gilde' AND Art='Reklamation'", con1)
        Dim reader1 As SqlDataReader

        Try
            con1.Open()
            reader1 = cmd1.ExecuteReader()
            Do While reader1.Read()
                Gilde_Reklamation.ComboBox1.Items.Add(reader1("Typ"))
            Loop

            reader1.Close()
            con1.Close()
        Catch ex As Exception
            If MessageBox.Show("Account erfolgreich geladen...") Then
                Dim mainForm As New ADM

            Else
                MessageBox.Show("Account konnten nicht geladen weden...")

            End If
        End Try
        Gilde_Reklamation.Show()
        Gilde_Reklamation.TextBox3.Text = TextBox6.Text
        Gilde_Reklamation.TextBox4.Text = Main.TextBox1.Text
    End Sub
End Class