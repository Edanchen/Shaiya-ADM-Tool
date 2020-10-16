


Public Class APaba

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=PS_UserData;Integrated Security = SSPI")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("INSERT INTO ADM_Tool.dbo.Vorgaenge ([UserID],[Date],[Text],[Status],[Zugewiesenan], [Thema], [Art], [Type], [Erstelltdurch]) VALUES ('" & TextBox1.Text & "',DATEADD(year, +10, GETDATE()),'" & RichTextBox1.Text & "','" & ComboBox1.Text & "','" & ComboBox2.Text & "', 'Account', 'Auftrag','AP abziehen', '" & Main.TextBox1.Text & "')", con)
        con.Open()
        Dim sdr As SqlDataReader = cmd.ExecuteReader()
        ' If the record can be queried, Pass verification and open another form.  
        If (sdr.Read() = True) Then
            MessageBox.Show("Benutzername erfolgreich geändert")
            Dim mainForm As New ADM
            Me.Hide()
        Else
            MessageBox.Show("GV erfolgreich angelegt.")
            Me.Close()
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class