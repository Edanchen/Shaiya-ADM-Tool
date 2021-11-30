Public Class Doku_Typen
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Doku_Typ_Anlegen.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("select ID,Thema,Art,Typ from ADM_Tool.dbo.Vorgangart", con)
        Dim reader As SqlDataReader

        Try
            Doku_Typ_anzeigen.Show()
            con.Open()
            reader = cmd.ExecuteReader()
            Doku_Typ_anzeigen.ListView1.Items.Clear()
            Do While reader.Read()
                With Doku_Typ_anzeigen.ListView1
                    .Items.Add(reader("ID"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(reader("Thema"))
                        .Add(reader("Art"))
                        .Add(reader("Typ"))
                    End With

                End With

            Loop

            reader.Close()
            con.Close()
        Catch ex As Exception

        End Try
    End Sub
End Class