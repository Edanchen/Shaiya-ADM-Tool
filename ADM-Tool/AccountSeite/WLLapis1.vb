Public Class WLLapis1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListView1.SelectedItems.Count = 0 Then Return
        Dim con As Data.SqlClient.SqlConnection = CreateConnection()
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("UPDATE PS_GameData.dbo.UserStoredItems SET Gem2 = '" & SqlEscape(ListView1.SelectedItems(0).SubItems(0).Text) & "' WHERE ItemUID='" & SqlEscape(TextBox2.Text) & "'", con)
        con.Open()
        cmd.ExecuteNonQuery()
        cmd.Connection.Close()
            MessageBox.Show("Lapis erfolgreich gesockelt.")
            Me.Close()

        Dim con1 As Data.SqlClient.SqlConnection = CreateConnection()
        Dim cmd1 As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("SELECT Gem1, Gem2, Gem3, Gem4, Gem5, Gem6 FROM PS_GameData.dbo.UserStoredItems WHERE ItemUID='" & SqlEscape(AccWLbearbeiten.TextBox3.Text) & "'", con1)

        Dim reader1 As SqlDataReader
        Try

            con1.Open()
            reader1 = cmd1.ExecuteReader(CommandBehavior.CloseConnection)

            Do While reader1.Read()
                AccWLbearbeiten.TextBox5.Text = (reader1("Gem2")
                )
            Loop
            reader1.Close()
            con1.Close()
        Catch ex As Exception
            ShowError(ex)
        End Try
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class