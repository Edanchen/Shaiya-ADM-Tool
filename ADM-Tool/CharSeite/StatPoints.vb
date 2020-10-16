


Public Class StatPoints

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=PS_UserData;Integrated Security = SSPI")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("UPDATE PS_GameData.dbo.Chars SET StatPoint='" & TextBox1.Text & "' WHERE CharName='" & ADM.TextBox25.Text & "'", con)
        con.Open()
        Dim sdr As SqlDataReader = cmd.ExecuteReader()
        ' If the record can be queried, Pass verification and open another form.  
        If (sdr.Read() = True) Then
            con.Close()
            MessageBox.Show("Benutzername erfolgreich geändert")
            Dim mainForm As New ADM
            Me.Hide()
        Else
            MessageBox.Show("StatPoints erfolgreich geändert.")
            Me.Close()
        End If

        Dim con1 As New Data.SqlClient.SqlConnection
        Dim cmd1 As New Data.SqlClient.SqlCommand
        Dim reader1 As SqlDataReader

        con1.ConnectionString = "Data Source=127.0.0.1,1433;Initial Catalog=PS_UserData;Integrated Security = SSPI"
        cmd1.Connection = con1
        cmd1.CommandText = "select I.ItemName, b.CharID, I.ItemID, b.ItemID, c.UserID, c.UserUID, c.Del, c.Level, c.StatPoint, c.SkillPoint, c.Str, c.Dex, c.Rec, c.Int, c.Luc, c.Wis, c.K1, c.K2, c.CharID, c.CharName, c.LoginStatus, um.PW, um.UserIP, um.Point, um.Status, um.AdminLevel from PS_GameData.dbo.Chars c INNER JOIN PS_UserData.dbo.Users_Master um ON c.UserUID=um.UserUID INNER JOIN PS_GameData.dbo.CharItems b ON b.CharID=c.CharID INNER JOIN PS_GameDefs.dbo.Items I ON I.ItemID=b.ItemID Where c.CharID = '" & ADM.TextBox24.Text & "'"

        Try

            con1.Open()
            reader1 = cmd1.ExecuteReader()
            Do While reader1.Read()

                ADM.TextBox30.Text = (reader1("StatPoint")
                )
            Loop

            reader1.Close()
            con1.Close()
        Catch ex As Exception
            If MessageBox.Show("Benutzername erfolgreich geändert") Then
                Dim mainForm As New ADM

            Else
                MessageBox.Show("Benutzername erfolgreich geändert")

            End If
        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class