


Public Class AccListelöschen

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim con As Data.SqlClient.SqlConnection = CreateConnection()
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("Delete FROM PS_UserData.dbo.Users_Master WHERE Status='-4'", con)
        con.Open()
        Me.Hide()
        cmd.ExecuteNonQuery()
        cmd.Connection.Close()
            MessageBox.Show("Liste ist erfolgreich geleert.")
            con.Close()
        Dim con1 As Data.SqlClient.SqlConnection = CreateConnection()
        Dim cmd1 As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("Select UserUID, UserID, Pw, Status, UserIP From PS_UserData.dbo.Users_Master Where Status='-4'", con1)
        Dim reader As SqlDataReader

        Try

            con1.Open()
            reader = cmd1.ExecuteReader(CommandBehavior.CloseConnection)
            AcczurLöschung.ListView1.Items.Clear()
            Do While reader.Read()
                With AcczurLöschung.ListView1
                    .Items.Add(reader("UserUID"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(reader("UserID"))
                        .Add(reader("Pw"))
                        .Add(reader("Status"))
                        .Add(reader("UserIP"))
                    End With

                End With
                Me.Close()
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