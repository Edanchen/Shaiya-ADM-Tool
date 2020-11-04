


Public Class Accountreg

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("INSERT INTO PS_UserData.dbo.Users_Master ([UserID], [PW], [JoinDate], [Admin], [AdminLevel], [UseQueue], [Status], [Leave], [LeaveDate], [UserType], [UserIP], [Point]) VALUES ('" & TextBox1.Text & "', '" & TextBox2.Text & "',DATEADD(year, +0, GETDATE()),'" & ComboBox1.Text & "','" & ComboBox2.Text & "', 'False','" & ComboBox3.Text & "','0',DATEADD(year, +0, GETDATE()),'" & ComboBox4.Text & "','127.0.0.1','" & TextBox3.Text & "')", con)
        con.Open()
        Dim sdr As SqlDataReader = cmd.ExecuteReader()
        ' If the record can be queried, Pass verification and open another form.  
        If (sdr.Read() = True) Then
            MessageBox.Show("Benutzername erfolgreich geändert")
            Dim mainForm As New ADM
            Me.Hide()
        Else
            MessageBox.Show("Account erfolgreich angelegt.")
            Me.Close()
        End If
    End Sub
End Class