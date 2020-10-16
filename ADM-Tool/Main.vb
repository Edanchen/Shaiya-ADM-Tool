


Public Class Main

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=PS_UserData;Integrated Security = SSPI")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("SELECT * FROM ADM_Tool.dbo.Account WHERE Benutzer = '" & TextBox1.Text & "' AND Rechte='16' " &
                                                                             "INSERT INTO ADM_Tool.dbo.Tool ([UserID],[Tool],[Date]) VALUES ('" & TextBox1.Text & "','ADM-Tool',DATEADD(year, +0, GETDATE()) )", con)
        con.Open()
        Dim sdr As SqlDataReader = cmd.ExecuteReader()
        ' If the record can be queried, Pass verification and open another form.  
        If (sdr.Read() = True) Then


            Dim mainForm As New Main
            ADM.Show()
        Else
            MessageBox.Show("Dir fehlenden die Berechtigungen um das ADM-Tool zu öffnen! Bitte wende dich an deinen ADM.")
        End If
        sdr.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=PS_UserData;Integrated Security = SSPI")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("SELECT * FROM ADM_Tool.dbo.Account WHERE Benutzer = '" & TextBox1.Text & "' AND Rechte='16' " &
                                                                             "INSERT INTO ADM_Tool.dbo.Tool ([UserID],[Tool],[Date]) VALUES ('" & TextBox1.Text & "','MonsterDB',DATEADD(year, +0, GETDATE()) )", con)
        con.Open()
        Dim sdr As SqlDataReader = cmd.ExecuteReader()
        ' If the record can be queried, Pass verification and open another form.  
        If (sdr.Read() = True) Then
            MonsterDB.Show()

            Dim mainForm As New Main

        Else
            MessageBox.Show("Dir fehlenden die Berechtigungen um die MonsterDB zuladen! Bitte wende dich an deinen ADM.")

        End If
        sdr.Close()

        Dim con1 As New Data.SqlClient.SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=PS_UserData;Integrated Security = SSPI")
        Dim cmd1 As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("SELECT MobID, MobName FROM PS_GameDefs.dbo.Mobs", con)
        Dim reader As SqlDataReader


        con1.Open()
        reader = cmd1.ExecuteReader()

        Do While reader.Read()
            With MonsterDB.ListView1
                .Items.Add(reader("MobID"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(reader("MobName"))
                End With

            End With

        Loop

        reader.Close()
        con1.Close()

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=PS_UserData;Integrated Security = SSPI")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("INSERT INTO ADM_Tool.dbo.Tool ([UserID],[Tool],[Date]) VALUES ('" & TextBox1.Text & "','Passwort aendern',DATEADD(year, +0, GETDATE()) )", con)
        con.Open()
        Dim sdr As SqlDataReader = cmd.ExecuteReader()
        ' If the record can be queried, Pass verification and open another form.  
        If (sdr.Read() = True) Then
        End If
        Passwort.Show()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=PS_UserData;Integrated Security = SSPI")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("SELECT * FROM ADM_Tool.dbo.Account WHERE Benutzer = '" & TextBox1.Text & "' AND Rechte>'15' " &
                                                                             "INSERT INTO ADM_Tool.dbo.Tool ([UserID],[Tool],[Date]) VALUES ('" & TextBox1.Text & "','GV Bearbeitung',DATEADD(year, +0, GETDATE()) )", con)
        con.Open()
        Dim sdr As SqlDataReader = cmd.ExecuteReader()
        ' If the record can be queried, Pass verification and open another form.  
        If (sdr.Read() = True) Then
            GVBearbeitung.Show()
        End If
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=PS_UserData;Integrated Security = SSPI")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("SELECT * FROM ADM_Tool.dbo.Account WHERE Benutzer = '" & TextBox1.Text & "' AND Rechte='16' " &
                                                                             "INSERT INTO ADM_Tool.dbo.Tool ([UserID],[Tool],[Date]) VALUES ('" & TextBox1.Text & "','ADM Tools Logs',DATEADD(year, +0, GETDATE()) )", con)
        con.Open()
        Dim sdr As SqlDataReader = cmd.ExecuteReader()
        ' If the record can be queried, Pass verification and open another form.  
        If (sdr.Read() = True) Then

            ADMLogs.Show()
        Else
            MessageBox.Show("Dir fehlenden die Berechtigungen um die Tool-Logs einzusehen! Bitte wende dich an deinen ADM.")
        End If
        con.Close()


    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=PS_UserData;Integrated Security = SSPI")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("SELECT * FROM ADM_Tool.dbo.Account WHERE Benutzer = '" & TextBox1.Text & "' AND Rechte='16' " &
                                                                             "INSERT INTO ADM_Tool.dbo.Tool ([UserID],[Tool],[Date]) VALUES ('" & TextBox1.Text & "','ItemDB',DATEADD(year, +0, GETDATE()) )", con)
        con.Open()
        Dim sdr As SqlDataReader = cmd.ExecuteReader()
        ' If the record can be queried, Pass verification and open another form.  
        If (sdr.Read() = True) Then
            ItemDB.Show()

            Dim mainForm As New Main

        Else
            MessageBox.Show("Dir fehlenden die Berechtigungen um die ItemDB zuladen! Bitte wende dich an deinen ADM.")

        End If
        sdr.Close()

        Dim con1 As New Data.SqlClient.SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=PS_UserData;Integrated Security = SSPI")
        Dim cmd1 As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("SELECT ItemID, ItemName FROM PS_GameDefs.dbo.Items", con)
        Dim reader As SqlDataReader


        con1.Open()
        reader = cmd1.ExecuteReader()

        Do While reader.Read()
            With ItemDB.ListView1
                .Items.Add(reader("ItemID"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(reader("ItemName"))
                End With

            End With

        Loop

        reader.Close()
        con1.Close()
    End Sub

    Private Sub AbmeldenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AbmeldenToolStripMenuItem.Click
        LoginForm1.Show()
        LoginForm1.UsernameTextBox.Clear()
        LoginForm1.PasswordTextBox.Clear()
        ADM.Hide()
        Me.Hide()
    End Sub

    Private Sub BeendenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BeendenToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ÜberShaiyaADMToolToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ÜberShaiyaADMToolToolStripMenuItem.Click
        Process.Start("https://github.com/Edanchen/ADM-Tool")
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        LoginForm1.Show()
        LoginForm1.UsernameTextBox.Clear()
        LoginForm1.PasswordTextBox.Clear()
        ItemDB.Hide()
        MonsterDB.Hide()
        ADMLogs.Hide()
        GVBearbeitung.Hide()
        ADM.Hide()
        Me.Hide()
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=PS_UserData;Integrated Security = SSPI")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("SELECT * FROM ADM_Tool.dbo.Account WHERE Benutzer = '" & TextBox1.Text & "' AND Rechte='16' " &
                                                                             "INSERT INTO ADM_Tool.dbo.Tool ([UserID],[Tool],[Date]) VALUES ('" & TextBox1.Text & "','ADM-Tool',DATEADD(year, +0, GETDATE()) )", con)
        con.Open()
        Dim sdr As SqlDataReader = cmd.ExecuteReader()
        ' If the record can be queried, Pass verification and open another form.  
        If (sdr.Read() = True) Then
            ContextMenuStrip2.Show(Button8, 0, Button8.Height)
        Else
            MessageBox.Show("Dir fehlenden die Berechtigungen um das ADM-Tool zu öffnen! Bitte wende dich an deinen ADM.")
        End If
        sdr.Close()

    End Sub

    Private Sub AccountsZurLöschungToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AccountsZurLöschungToolStripMenuItem.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=PS_UserData;Integrated Security = SSPI")
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
        Dim con As New Data.SqlClient.SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=PS_UserData;Integrated Security = SSPI")
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
        Dim con As New Data.SqlClient.SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=PS_UserData;Integrated Security = SSPI")
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

    Private Sub AlleGelöschteCharsEntfernenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AlleGelöschteCharsEntfernenToolStripMenuItem.Click
        GelöschteCharsentfernen.Show()
    End Sub

    Private Sub EingeloggteSpielerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EingeloggteSpielerToolStripMenuItem.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=PS_UserData;Integrated Security = SSPI")
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
        Dim con As New Data.SqlClient.SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=PS_UserData;Integrated Security = SSPI")
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
        Dim con As New Data.SqlClient.SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=PS_UserData;Integrated Security = SSPI")
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
        Dim con As New Data.SqlClient.SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=PS_UserData;Integrated Security = SSPI")
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
        Dim con As New Data.SqlClient.SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=PS_UserData;Integrated Security = SSPI")
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
        Dim con As New Data.SqlClient.SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=PS_UserData;Integrated Security = SSPI")
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

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=PS_UserData;Integrated Security = SSPI")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("SELECT * FROM ADM_Tool.dbo.Account WHERE Benutzer = '" & TextBox1.Text & "' AND Rechte='16' " &
                                                                             "INSERT INTO ADM_Tool.dbo.Tool ([UserID],[Tool],[Date]) VALUES ('" & TextBox1.Text & "','Account Registierung',DATEADD(year, +0, GETDATE()) )", con)
        con.Open()
        Dim sdr As SqlDataReader = cmd.ExecuteReader()
        ' If the record can be queried, Pass verification and open another form.  
        If (sdr.Read() = True) Then
            Accountreg.Show()

            Dim mainForm As New Main

        Else
            MessageBox.Show("Dir fehlenden die Berechtigungen um einen Account zu registieren! Bitte wende dich an deinen ADM.")

        End If
        sdr.Close()

    End Sub

    Private Sub Tickets_Click(sender As Object, e As EventArgs) Handles Tickets.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=PS_UserData;Integrated Security = SSPI")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("SELECT * FROM ADM_Tool.dbo.Account WHERE Benutzer = '" & TextBox1.Text & "' AND Rechte='16' " &
                                                                             "INSERT INTO ADM_Tool.dbo.Tool ([UserID],[Tool],[Date]) VALUES ('" & TextBox1.Text & "','Account Registierung',DATEADD(year, +0, GETDATE()) )", con)
        con.Open()
        Dim sdr As SqlDataReader = cmd.ExecuteReader()
        ' If the record can be queried, Pass verification and open another form.  
        If (sdr.Read() = True) Then
            ticketsystem.Show()

            Dim mainForm As New Main

        Else
            MessageBox.Show("Dir fehlenden die Berechtigungen um einen Account zu registieren! Bitte wende dich an deinen ADM.")

        End If
        sdr.Close()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

    End Sub

    Private Sub UpdateHinweisToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub GlobalStatResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GlobalStatResetToolStripMenuItem.Click
        globalreset.Show()

    End Sub

    Private Sub CharakterStatistikToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CharakterStatistikToolStripMenuItem.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=PS_UserData;Integrated Security = SSPI")
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
        Dim con As New Data.SqlClient.SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=PS_UserData;Integrated Security = SSPI")
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
        Dim con As New Data.SqlClient.SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=PS_UserData;Integrated Security = SSPI")
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

    Private Sub BossKillsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BossKillsToolStripMenuItem.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=PS_UserData;Integrated Security = SSPI")
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

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        ServerAPgeben.Show()
    End Sub
End Class
