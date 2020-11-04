


Public Class Freigabezurücknehmen

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("UPDATE PS_UserData.dbo.Users_Master SET Status='0' WHERE UserUID='" & AcczurLöschung.ListView1.SelectedItems(0).SubItems(0).Text & "'", con)
        con.Open()
        Dim sdr As SqlDataReader = cmd.ExecuteReader()
        ' If the record can be queried, Pass verification and open another form.  
        If (sdr.Read() = True) Then
            MessageBox.Show("Benutzername erfolgreich geändert")
            Dim mainForm As New ADM
            Me.Hide()
        Else
            MessageBox.Show("Account erfolgreich von der Liste genommen.")
            Me.Close()
        End If
        con.Close()
        Dim con1 As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd1 As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("Select UserUID, UserID, Pw, Status, UserIP From PS_UserData.dbo.Users_Master Where Status='-4'", con1)
        Dim reader1 As SqlDataReader

        Try

            con1.Open()
            reader1 = cmd.ExecuteReader()

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

        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class