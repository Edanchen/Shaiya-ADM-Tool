


Public Class Ticketerstellung
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As Data.SqlClient.SqlConnection = CreateConnection()
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("INSERT INTO ADM_Tool.dbo.tickets ([Art], [Account], [Char], [Text], [Datum], [Replay], [Bearbeiter], [Status]) VALUES ('" & SqlEscape(ComboBox3.Text) & "','" & SqlEscape(TextBox1.Text) & "', '" & SqlEscape(TextBox2.Text) & "','" & SqlEscape(RichTextBox1.Text) & "',GETDATE(), '0','" & SqlEscape(ComboBox2.Text) & "','" & SqlEscape(ComboBox1.Text) & "')", con)
        con.Open()
        cmd.ExecuteNonQuery()
        cmd.Connection.Close()
            MessageBox.Show("Ticket erfolgreich angelegt.")
            Me.Close()
    End Sub
End Class