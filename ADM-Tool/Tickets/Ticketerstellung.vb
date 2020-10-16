


Public Class Ticketerstellung
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=PS_UserData;Integrated Security = SSPI")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("INSERT INTO ADM_Tool.dbo.tickets ([Art], [Account], [Char], [Text], [Datum], [Replay], [Bearbeiter], [Status]) VALUES ('" & ComboBox3.Text & "','" & TextBox1.Text & "', '" & TextBox2.Text & "','" & RichTextBox1.Text & "',DATEADD(year, +10, GETDATE()), '0','" & ComboBox2.Text & "','" & ComboBox1.Text & "')", con)
        con.Open()
        Dim sdr As SqlDataReader = cmd.ExecuteReader()
        ' If the record can be queried, Pass verification and open another form.  
        If (sdr.Read() = True) Then
            MessageBox.Show("Benutzername erfolgreich geändert")
            Dim mainForm As New ADM
            Me.Hide()
        Else
            MessageBox.Show("Ticket erfolgreich angelegt.")
            Me.Close()
        End If
    End Sub
End Class