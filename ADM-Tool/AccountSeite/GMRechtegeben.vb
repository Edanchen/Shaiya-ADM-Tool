


Public Class GMRechtegeben

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim con As Data.SqlClient.SqlConnection = CreateConnection()
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("UPDATE PS_UserData.dbo.Users_Master SET Admin='1' WHERE UserUID='" & SqlEscape(ADM.TextBox17.Text) & "'" &
                                                                             "; UPDATE PS_UserData.dbo.Users_Master SET AdminLevel='255' WHERE UserUID='" & SqlEscape(ADM.TextBox17.Text) & "'" &
                                                                             "; UPDATE PS_UserData.dbo.Users_Master SET Status='" & SqlEscape(ComboBox1.Text) & "' WHERE UserUID='" & SqlEscape(ADM.TextBox17.Text) & "'" &
                                                                             "; UPDATE PS_UserData.dbo.Users_Master SET UserType='A' WHERE UserUID='" & SqlEscape(ADM.TextBox17.Text) & "'", con)
        con.Open()
        cmd.ExecuteNonQuery()
        cmd.Connection.Close()
            Me.Close()
        con.Close()

        Dim con1 As New Data.SqlClient.SqlConnection
        Dim cmd1 As New Data.SqlClient.SqlCommand
        Dim reader As SqlDataReader

        con1.ConnectionString = CurrentConnectionString()
        cmd1.Connection = con1
        cmd1.CommandText = "select UserUID, Status, AdminLevel from PS_UserData.dbo.Users_Master Where UserUID= '" & SqlEscape(ADM.TextBox17.Text) & "'"
        Try
            con1.Open()
            reader = cmd1.ExecuteReader(CommandBehavior.CloseConnection)
            Do While reader.Read()
                ADM.TextBox22.Text = (reader("Status")
                )
                ADM.TextBox22.Text = IIf(ADM.TextBox22.Text = 0, "nein", "ja")
                ADM.TextBox23.Text = (reader("AdminLevel")
                )
                ADM.TextBox23.Text = IIf(ADM.TextBox23.Text = 0, "nein", "ja")
            Loop
            reader.Close()
            con1.Close()
        Catch ex As Exception
            ShowError(ex)
        End Try


    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class