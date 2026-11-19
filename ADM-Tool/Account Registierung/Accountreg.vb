


Public Class Accountreg

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim con As Data.SqlClient.SqlConnection = CreateConnection()
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("INSERT INTO PS_UserData.dbo.Users_Master ([UserID], [PW], [JoinDate], [Admin], [AdminLevel], [UseQueue], [Status], [Leave], [LeaveDate], [UserType], [UserIP], [Point]) VALUES ('" & SqlEscape(TextBox1.Text) & "', '" & SqlEscape(TextBox2.Text) & "',DATEADD(year, +0, GETDATE()),'" & SqlEscape(ComboBox1.Text) & "','" & SqlEscape(ComboBox2.Text) & "', 'False','" & SqlEscape(ComboBox3.Text) & "','0',DATEADD(year, +0, GETDATE()),'" & SqlEscape(ComboBox4.Text) & "','127.0.0.1','" & SqlEscape(TextBox3.Text) & "')", con)
        con.Open()
        cmd.ExecuteNonQuery()
        cmd.Connection.Close()
            MessageBox.Show("Account " & TextBox1.Text & " erfolgreich angelegt.")
            Me.Close()
    End Sub
End Class