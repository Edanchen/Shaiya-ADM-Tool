


Public Class Freigabezurücknehmen

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If AcczurLöschung.ListView1.SelectedItems.Count = 0 Then Return
        Dim con As Data.SqlClient.SqlConnection = CreateConnection()
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("UPDATE PS_UserData.dbo.Users_Master SET Status='0' WHERE UserUID='" & SqlEscape(AcczurLöschung.ListView1.SelectedItems(0).SubItems(0).Text) & "'", con)
        con.Open()
        cmd.ExecuteNonQuery()
        cmd.Connection.Close()
            MessageBox.Show("Account erfolgreich von der Liste genommen.")
            Me.Close()
        con.Close()
        Dim con1 As Data.SqlClient.SqlConnection = CreateConnection()
        Dim cmd1 As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("Select UserUID, UserID, Pw, Status, UserIP From PS_UserData.dbo.Users_Master Where Status='-4'", con1)
        Dim reader1 As SqlDataReader

        Try

            con1.Open()
            reader1 = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            Do While reader1.Read()
                With AcczurLöschung.ListView1
                    .Items.Add(reader1("UserUID"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(reader1("UserID"))
                        .Add(reader1("Pw"))
                        .Add(reader1("Status"))
                        .Add(reader1("UserIP"))
                    End With

                End With

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