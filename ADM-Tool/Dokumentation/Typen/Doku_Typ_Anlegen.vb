Public Class Doku_Typ_Anlegen
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim con As Data.SqlClient.SqlConnection = CreateConnection()
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("INSERT INTO ADM_Tool.dbo.Vorgangart ([Thema], [Art], [Typ]) VALUES ('" & SqlEscape(ComboBox1.Text) & "','" & SqlEscape(ComboBox2.Text) & "','" & SqlEscape(TextBox1.Text) & "')", con)

        con.Open()
        cmd.ExecuteNonQuery()
        cmd.Connection.Close()
            MessageBox.Show("Typ " & ComboBox1.Text & " - " & ComboBox2.Text & " - " & TextBox1.Text & " erfolgreich angelegt.")
        Me.Close()
    End Sub

End Class