


Public Class AccWLbearbeiten

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim con As Data.SqlClient.SqlConnection = CreateConnection()
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("UPDATE PS_GameData.dbo.UserStoredItems SET Craftname='" & SqlEscape(TextBox20.Text) & "', Count='" & SqlEscape(TextBox21.Text) & "' WHERE ItemUID='" & SqlEscape(TextBox3.Text) & "'", con)
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
            WLLapis.Show()

            con.Open()
            reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            Do While reader.Read()
                With WLLapis.ListView1
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
        WLLapis.TextBox1.Text = TextBox2.Text
        WLLapis.TextBox2.Text = TextBox3.Text
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim con As Data.SqlClient.SqlConnection = CreateConnection()
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("select * from PS_GameDefs.dbo.Items Where Type ='30'", con)
        Dim reader As SqlDataReader

        Try
            WLLapis1.Show()

            con.Open()
            reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            Do While reader.Read()
                With WLLapis1.ListView1
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
        WLLapis1.TextBox1.Text = TextBox2.Text
        WLLapis1.TextBox2.Text = TextBox3.Text
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim con As Data.SqlClient.SqlConnection = CreateConnection()
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("select * from PS_GameDefs.dbo.Items Where Type ='30'", con)
        Dim reader As SqlDataReader

        Try
            WLLapis2.Show()

            con.Open()
            reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            Do While reader.Read()
                With WLLapis2.ListView1
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
        WLLapis2.TextBox1.Text = TextBox2.Text
        WLLapis2.TextBox2.Text = TextBox3.Text
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim con As Data.SqlClient.SqlConnection = CreateConnection()
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("select * from PS_GameDefs.dbo.Items Where Type ='30'", con)
        Dim reader As SqlDataReader

        Try
            WLLapis3.Show()

            con.Open()
            reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            Do While reader.Read()
                With WLLapis3.ListView1
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
        WLLapis3.TextBox1.Text = TextBox2.Text
        WLLapis3.TextBox2.Text = TextBox3.Text
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim con As Data.SqlClient.SqlConnection = CreateConnection()
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("select * from PS_GameDefs.dbo.Items Where Type ='30'", con)
        Dim reader As SqlDataReader

        Try
            WLLapis4.Show()

            con.Open()
            reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            Do While reader.Read()
                With WLLapis4.ListView1
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
        WLLapis4.TextBox1.Text = TextBox2.Text
        WLLapis4.TextBox2.Text = TextBox3.Text
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim con As Data.SqlClient.SqlConnection = CreateConnection()
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("select * from PS_GameDefs.dbo.Items Where Type ='30'", con)
        Dim reader As SqlDataReader

        Try
            WLLapis5.Show()

            con.Open()
            reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            Do While reader.Read()
                With WLLapis5.ListView1
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
        WLLapis5.TextBox1.Text = TextBox2.Text
        WLLapis5.TextBox2.Text = TextBox3.Text
    End Sub
End Class