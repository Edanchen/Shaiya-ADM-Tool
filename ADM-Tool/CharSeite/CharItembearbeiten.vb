


Public Class CharItembearbeiten

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim con As Data.SqlClient.SqlConnection = CreateConnection()
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("UPDATE PS_GameData.dbo.CharItems SET Gem1 = '" & SqlEscape(TextBox4.Text) & "', Gem2 = '" & SqlEscape(TextBox5.Text) & "', Gem3 = '" & SqlEscape(TextBox6.Text) & "', Gem4 = '" & SqlEscape(TextBox7.Text) & "', Gem5 = '" & SqlEscape(TextBox8.Text) & "', Gem6 = '" & SqlEscape(TextBox9.Text) & "', Craftname='" & SqlEscape(TextBox20.Text) & "', Count='" & SqlEscape(TextBox21.Text) & "' WHERE ItemUID='" & SqlEscape(TextBox22.Text) & "'", con)
        con.Open()
        cmd.ExecuteNonQuery()
        cmd.Connection.Close()
            MessageBox.Show("Item erfolgreich geändert.")
            Me.Close()
        TextBox20.Text = TextBox10.Text + TextBox11.Text + TextBox12.Text + TextBox13.Text + TextBox14.Text + TextBox15.Text + TextBox16.Text + TextBox17.Text + TextBox18.Text + TextBox19.Text
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub TextBox20_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox20.TextChanged
        TextBox20.Text = TextBox10.Text + TextBox11.Text + TextBox12.Text + TextBox13.Text + TextBox14.Text + TextBox15.Text + TextBox16.Text + TextBox17.Text + TextBox18.Text + TextBox19.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As Data.SqlClient.SqlConnection = CreateConnection()
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("select * from PS_GameDefs.dbo.Items Where Type ='30'", con)
        Dim reader As SqlDataReader

        Try
            LapisAuswaehlen.Show()

            con.Open()
            reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
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
            ShowError(ex)
        End Try
        LapisAuswaehlen.TextBox1.Text = TextBox2.Text
        LapisAuswaehlen.TextBox2.Text = TextBox22.Text
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim con As Data.SqlClient.SqlConnection = CreateConnection()
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("select * from PS_GameDefs.dbo.Items Where Type ='30'", con)
        Dim reader As SqlDataReader

        Try
            LapisAuswaehlen1.Show()
            con.Open()
            reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
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
            ShowError(ex)
        End Try
        LapisAuswaehlen1.TextBox1.Text = TextBox2.Text
        LapisAuswaehlen1.TextBox2.Text = TextBox22.Text
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim con As Data.SqlClient.SqlConnection = CreateConnection()
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("select * from PS_GameDefs.dbo.Items Where Type ='30'", con)
        Dim reader As SqlDataReader

        Try
            LapisAuswaehlen2.Show()
            con.Open()
            reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
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
            ShowError(ex)
        End Try
        LapisAuswaehlen2.TextBox1.Text = TextBox2.Text
        LapisAuswaehlen2.TextBox2.Text = TextBox22.Text
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim con As Data.SqlClient.SqlConnection = CreateConnection()
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("select * from PS_GameDefs.dbo.Items Where Type ='30'", con)
        Dim reader As SqlDataReader

        Try
            LapisAuswaehlen3.Show()
            con.Open()
            reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
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
            ShowError(ex)
        End Try
        LapisAuswaehlen3.TextBox1.Text = TextBox2.Text
        LapisAuswaehlen3.TextBox2.Text = TextBox22.Text
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim con As Data.SqlClient.SqlConnection = CreateConnection()
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("select * from PS_GameDefs.dbo.Items Where Type ='30'", con)
        Dim reader As SqlDataReader

        Try
            LapisAuswaehlen4.Show()
            con.Open()
            reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
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
            ShowError(ex)
        End Try
        LapisAuswaehlen4.TextBox1.Text = TextBox2.Text
        LapisAuswaehlen4.TextBox2.Text = TextBox22.Text
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim con As Data.SqlClient.SqlConnection = CreateConnection()
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("select * from PS_GameDefs.dbo.Items Where Type ='30'", con)
        Dim reader As SqlDataReader

        Try
            LapisAuswaehlen5.Show()
            con.Open()
            reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
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
            ShowError(ex)
        End Try
        LapisAuswaehlen5.TextBox1.Text = TextBox2.Text
        LapisAuswaehlen5.TextBox2.Text = TextBox22.Text
    End Sub
End Class