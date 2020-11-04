


Public Class AcczurLöschung

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Freigabezurücknehmen.Show()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("Select UserUID, UserID, Pw, Status, UserIP From PS_UserData.dbo.Users_Master Where Status='-4'", con)
        Dim reader As SqlDataReader

        Try

            con.Open()
            reader = cmd.ExecuteReader()
            ListView1.Items.Clear()
            Do While reader.Read()
                With ListView1
                    .Items.Add(reader("UserUID"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(reader("UserID"))
                        .Add(reader("Pw"))
                        .Add(reader("Status"))
                        .Add(reader("UserIP"))
                    End With

                End With

            Loop

            reader.Close()
            con.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        AccListelöschen.Show()
    End Sub
End Class