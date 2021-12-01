Public Class Doku_Typ_loeschen
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("Delete FROM ADM_Tool.dbo.Vorgangart WHERE ID='" & Doku_Typ_anzeigen.ListView1.SelectedItems(0).SubItems(0).Text & "'", con)
        con.Open()
        Doku_Typ_anzeigen.ListView1.Items.Clear()

        Dim sdr As SqlDataReader = cmd.ExecuteReader()
        ' If the record can be queried, Pass verification and open another form.  
        If (sdr.Read() = True) Then
            con.Close()
            MessageBox.Show("Benutzername erfolgreich geändert")
            Dim mainForm As New ADM
            Me.Hide()

        Else
            MessageBox.Show("Typ " & TextBox1.Text & " / " & TextBox2.Text & " / " & TextBox3.Text & " erfolgreich gelöscht.")
            Me.Close()

        End If
        Dim con1 As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd1 As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("select ID,Thema,Art,Typ from ADM_Tool.dbo.Vorgangart", con1)
        Dim reader1 As SqlDataReader

        Try

            con1.Open()
            reader1 = cmd.ExecuteReader()

            Do While reader1.Read()
                With Doku_Typ_anzeigen.ListView1
                    .Items.Add(reader1("ID"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(reader1("Thema"))
                        .Add(reader1("Art"))
                        .Add(reader1("Typ"))
                    End With

                End With

            Loop

            reader1.Close()
            con1.Close()
        Catch ex As Exception

        End Try
    End Sub
End Class