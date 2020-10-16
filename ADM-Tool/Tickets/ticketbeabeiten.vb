


Public Class ticketbeabeiten_vb
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=PS_GameData;Integrated Security = SSPI")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("UPDATE ADM_Tool.dbo.tickets SET Text='" & RichTextBox1.Text & "', Status='" & ComboBox1.Text & "', Bearbeiter='" & ComboBox2.Text & "', Art='" & ComboBox3.Text & "' Where TicketID='" & TextBox1.Text & "'", con)
        con.Open()
        Dim sdr As SqlDataReader = cmd.ExecuteReader()
        ' If the record can be queried, Pass verification and open another form.  
        If (sdr.Read() = True) Then
            MessageBox.Show("Benutzername erfolgreich geändert")
            Dim mainForm As New Main
            Me.Hide()
        Else
            MessageBox.Show("Ticket erfolgreich geändert.")
            Me.Close()
        End If
    End Sub
End Class