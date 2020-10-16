


Public Class TeamGildehinzufügen

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=PS_UserData;Integrated Security = SSPI")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("INSERT INTO PS_GameData.dbo.GuildChars ([GuildID],[CharID],[GuildLevel],[Del],[JoinDate],[LeaveDate]) VALUES ('1'," & ADM.TextBox24.Text & ",'9','0',DATEADD(year, +10, GETDATE()),'')", con)
        con.Open()
        Dim sdr As SqlDataReader = cmd.ExecuteReader()
        ' If the record can be queried, Pass verification and open another form.  
        If (sdr.Read() = True) Then
            MessageBox.Show("Benutzername erfolgreich geändert")
            Dim mainForm As New ADM
            Me.Hide()
        Else
            MessageBox.Show("Char erfolgreich in die Team Gilde hinzugefügt.")
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class