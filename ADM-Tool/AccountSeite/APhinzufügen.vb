


Public Class APhinzufügen

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim con As Data.SqlClient.SqlConnection = CreateConnection()
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("UPDATE PS_UserData.dbo.Users_Master SET Point= Point + '" & SqlEscape(TextBox1.Text) & "' WHERE UserUID='" & SqlEscape(ADM.TextBox17.Text) & "'", con)
        con.Open()
        cmd.ExecuteNonQuery()
        cmd.Connection.Close()
            MessageBox.Show("AP erfolgreich hinzugefügt.")
            Me.Close()
        con.Close()
        Dim con1 As New Data.SqlClient.SqlConnection
        Dim cmd1 As New Data.SqlClient.SqlCommand
        Dim reader1 As SqlDataReader

        con1.ConnectionString = CurrentConnectionString()
        cmd1.Connection = con1
        cmd1.CommandText = "select UserUID, Point from PS_UserData.dbo.Users_Master Where UserUID= '" & SqlEscape(ADM.TextBox17.Text) & "'"
        Try
            con1.Open()
            reader1 = cmd1.ExecuteReader(CommandBehavior.CloseConnection)
            Do While reader1.Read()
                ADM.TextBox20.Text = (reader1("Point")
                )

            Loop

            reader1.Close()
            con1.Close()
        Catch ex As Exception
            ShowError(ex)
        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class