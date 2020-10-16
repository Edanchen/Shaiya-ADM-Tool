


Public Class LapisAuswaehlen4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=PS_UserData;Integrated Security = SSPI")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("UPDATE PS_GameData.dbo.CharItems SET Gem5 = '" & ListView1.SelectedItems(0).SubItems(0).Text & "' WHERE ItemUID='" & TextBox2.Text & "'", con)
        con.Open()
        Dim sdr As SqlDataReader = cmd.ExecuteReader()
        ' If the record can be queried, Pass verification and open another form.  
        If (sdr.Read() = True) Then
            MessageBox.Show("Benutzername erfolgreich geändert")
            Dim mainForm As New ADM
            Me.Hide()
        Else
            MessageBox.Show("Lapis erfolgreich gesockelt.")
            Me.Close()
        End If

        Dim con1 As New Data.SqlClient.SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=PS_UserData;Integrated Security = SSPI")
        Dim cmd1 As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("SELECT Gem1, Gem2, Gem3, Gem4, Gem5, Gem6 FROM PS_GameData.dbo.CharItems WHERE ItemUID='" & CharItembearbeiten.TextBox22.Text & "'", con1)

        Dim reader1 As SqlDataReader
        Try

            con1.Open()
            reader1 = cmd1.ExecuteReader()

            Do While reader1.Read()
                CharItembearbeiten.TextBox8.Text = (reader1("Gem5")
                )
            Loop
            reader1.Close()
            con1.Close()
        Catch ex As Exception
            If MessageBox.Show("Benutzername erfolgreich geändert") Then
                Dim mainForm As New ADM

            Else
                MessageBox.Show("Benutzername erfolgreich geändert")

            End If
        End Try
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class