


Public Class AccPasswort

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim con As Data.SqlClient.SqlConnection = CreateConnection()
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("UPDATE PS_UserData.dbo.Users_Master SET PW='" & SqlEscape(TextBox1.Text) & "' WHERE UserID='" & SqlEscape(ADM.TextBox18.Text) & "'", con)
        con.Open()
        cmd.ExecuteNonQuery()
        cmd.Connection.Close()
            MessageBox.Show("Password erfolgreich geändert.")
            Me.Close()
        con.Close()
        Dim con1 As New Data.SqlClient.SqlConnection
        Dim cmd1 As New Data.SqlClient.SqlCommand
        Dim reader1 As SqlDataReader

        con1.ConnectionString = CurrentConnectionString()
        cmd1.Connection = con1
        cmd1.CommandText = "select UserUID, PW from PS_UserData.dbo.Users_Master Where UserUID= '" & SqlEscape(ADM.TextBox17.Text) & "'"
        Try
            con1.Open()
            reader1 = cmd1.ExecuteReader(CommandBehavior.CloseConnection)
            Do While reader1.Read()
                ADM.TextBox19.Text = (reader1("PW")
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