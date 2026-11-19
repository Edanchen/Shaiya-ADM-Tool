


Public Class Stärkeändern

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim con As Data.SqlClient.SqlConnection = CreateConnection()
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("UPDATE PS_GameData.dbo.Chars SET Str='" & SqlEscape(TextBox1.Text) & "' WHERE CharName='" & SqlEscape(ADM.TextBox25.Text) & "'", con)
        con.Open()
        cmd.ExecuteNonQuery()
        cmd.Connection.Close()
            MessageBox.Show("Stärke erfolgreich geändert.")
            Me.Close()

        Dim con1 As New Data.SqlClient.SqlConnection
        Dim cmd1 As New Data.SqlClient.SqlCommand
        Dim reader1 As SqlDataReader

        con1.ConnectionString = CurrentConnectionString()
        cmd1.Connection = con1
        cmd1.CommandText = "select I.ItemName, b.CharID, I.ItemID, b.ItemID, c.UserID, c.UserUID, c.Del, c.Level, c.StatPoint, c.SkillPoint, c.Str, c.Dex, c.Rec, c.Int, c.Luc, c.Wis, c.K1, c.K2, c.CharID, c.CharName, c.LoginStatus, um.PW, um.UserIP, um.Point, um.Status, um.AdminLevel from PS_GameData.dbo.Chars c INNER JOIN PS_UserData.dbo.Users_Master um ON c.UserUID=um.UserUID INNER JOIN PS_GameData.dbo.CharItems b ON b.CharID=c.CharID INNER JOIN PS_GameDefs.dbo.Items I ON I.ItemID=b.ItemID Where c.CharID = '" & SqlEscape(ADM.TextBox24.Text) & "'"

        Try

            con1.Open()
            reader1 = cmd1.ExecuteReader(CommandBehavior.CloseConnection)
            Do While reader1.Read()

                ADM.TextBox32.Text = (reader1("Str")
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