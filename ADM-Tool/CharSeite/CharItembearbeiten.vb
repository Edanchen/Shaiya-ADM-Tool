


Public Class CharItembearbeiten

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("UPDATE PS_GameData.dbo.CharItems SET Gem1 = '" & TextBox4.Text & "', Gem2 = '" & TextBox5.Text & "', Gem3 = '" & TextBox6.Text & "', Gem4 = '" & TextBox7.Text & "', Gem5 = '" & TextBox8.Text & "', Gem6 = '" & TextBox9.Text & "', Craftname='" & TextBox20.Text & "', Count='" & TextBox21.Text & "' WHERE ItemUID='" & TextBox22.Text & "'", con)
        con.Open()
        Dim sdr As SqlDataReader = cmd.ExecuteReader()
        ' If the record can be queried, Pass verification and open another form.  
        If (sdr.Read() = True) Then
            MessageBox.Show("Benutzername erfolgreich geändert")
            Dim mainForm As New ADM
            Me.Hide()
        Else
            MessageBox.Show("Item erfolgreich geändert.")
            Me.Close()
        End If
        TextBox20.Text = TextBox10.Text + TextBox11.Text + TextBox12.Text + TextBox13.Text + TextBox14.Text + TextBox15.Text + TextBox16.Text + TextBox17.Text + TextBox18.Text + TextBox19.Text
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub TextBox20_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox20.TextChanged
        TextBox20.Text = TextBox10.Text + TextBox11.Text + TextBox12.Text + TextBox13.Text + TextBox14.Text + TextBox15.Text + TextBox16.Text + TextBox17.Text + TextBox18.Text + TextBox19.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("select * from PS_GameDefs.dbo.Items Where Type ='30'", con)
        Dim reader As SqlDataReader

        Try
            LapisAuswaehlen.Show()

            con.Open()
            reader = cmd.ExecuteReader()
            Do While reader.Read()
                With LapisAuswaehlen.ListView1
                    .Items.Add(reader("TypeID"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(reader("ItemName"))
                    End With

                End With

            Loop

            reader.Close()
            con.Close()
        Catch ex As Exception

        End Try
        LapisAuswaehlen.TextBox1.Text = TextBox2.Text
        LapisAuswaehlen.TextBox2.Text = TextBox22.Text
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("select * from PS_GameDefs.dbo.Items Where Type ='30'", con)
        Dim reader As SqlDataReader

        Try
            LapisAuswaehlen1.Show()
            con.Open()
            reader = cmd.ExecuteReader()
            Do While reader.Read()
                With LapisAuswaehlen1.ListView1
                    .Items.Add(reader("TypeID"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(reader("ItemName"))
                    End With

                End With

            Loop


            reader.Close()
            con.Close()
        Catch ex As Exception

        End Try
        LapisAuswaehlen1.TextBox1.Text = TextBox2.Text
        LapisAuswaehlen1.TextBox2.Text = TextBox22.Text
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("select * from PS_GameDefs.dbo.Items Where Type ='30'", con)
        Dim reader As SqlDataReader

        Try
            LapisAuswaehlen2.Show()
            con.Open()
            reader = cmd.ExecuteReader()
            Do While reader.Read()
                With LapisAuswaehlen2.ListView1
                    .Items.Add(reader("TypeID"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(reader("ItemName"))
                    End With

                End With

            Loop


            reader.Close()
            con.Close()
        Catch ex As Exception

        End Try
        LapisAuswaehlen2.TextBox1.Text = TextBox2.Text
        LapisAuswaehlen2.TextBox2.Text = TextBox22.Text
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("select * from PS_GameDefs.dbo.Items Where Type ='30'", con)
        Dim reader As SqlDataReader

        Try
            LapisAuswaehlen3.Show()
            con.Open()
            reader = cmd.ExecuteReader()
            Do While reader.Read()
                With LapisAuswaehlen3.ListView1
                    .Items.Add(reader("TypeID"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(reader("ItemName"))
                    End With

                End With

            Loop


            reader.Close()
            con.Close()
        Catch ex As Exception

        End Try
        LapisAuswaehlen3.TextBox1.Text = TextBox2.Text
        LapisAuswaehlen3.TextBox2.Text = TextBox22.Text
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("select * from PS_GameDefs.dbo.Items Where Type ='30'", con)
        Dim reader As SqlDataReader

        Try
            LapisAuswaehlen4.Show()
            con.Open()
            reader = cmd.ExecuteReader()
            Do While reader.Read()
                With LapisAuswaehlen4.ListView1
                    .Items.Add(reader("TypeID"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(reader("ItemName"))
                    End With

                End With

            Loop


            reader.Close()
            con.Close()
        Catch ex As Exception

        End Try
        LapisAuswaehlen4.TextBox1.Text = TextBox2.Text
        LapisAuswaehlen4.TextBox2.Text = TextBox22.Text
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("select * from PS_GameDefs.dbo.Items Where Type ='30'", con)
        Dim reader As SqlDataReader

        Try
            LapisAuswaehlen5.Show()
            con.Open()
            reader = cmd.ExecuteReader()
            Do While reader.Read()
                With LapisAuswaehlen5.ListView1
                    .Items.Add(reader("TypeID"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(reader("ItemName"))
                    End With

                End With

            Loop


            reader.Close()
            con.Close()
        Catch ex As Exception

        End Try
        LapisAuswaehlen5.TextBox1.Text = TextBox2.Text
        LapisAuswaehlen5.TextBox2.Text = TextBox22.Text
    End Sub
End Class