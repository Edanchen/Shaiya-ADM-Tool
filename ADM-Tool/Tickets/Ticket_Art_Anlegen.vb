Public Class Ticket_Art_Anlegen
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As Data.SqlClient.SqlConnection = CreateConnection()
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("INSERT INTO ADM_Tool.dbo.Ticketart ([Art]) VALUES ('" & SqlEscape(TextBox1.Text) & "')", con)
        con.Open()
        cmd.ExecuteNonQuery()
        cmd.Connection.Close()
            MessageBox.Show("Ticket Thema " & TextBox1.Text & " erfolgreich angelegt.")
            TextBox1.Clear()
    End Sub
End Class