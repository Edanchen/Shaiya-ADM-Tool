


Public Class ticketbeabeiten_vb
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As Data.SqlClient.SqlConnection = CreateConnection()
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("UPDATE ADM_Tool.dbo.tickets SET Text='" & SqlEscape(RichTextBox1.Text) & "', Status='" & SqlEscape(ComboBox1.Text) & "', Bearbeiter='" & SqlEscape(ComboBox2.Text) & "', Art='" & SqlEscape(ComboBox3.Text) & "' Where TicketID='" & SqlEscape(TextBox1.Text) & "'", con)
        con.Open()
        cmd.ExecuteNonQuery()
        cmd.Connection.Close()
            MessageBox.Show("Ticket erfolgreich geändert.")
            Me.Close()
    End Sub
End Class