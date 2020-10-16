


Public Class GWLbearbeiten

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=PS_UserData;Integrated Security = SSPI")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("UPDATE PS_GameData.dbo.GuildStoredItems SET Craftname='" & TextBox20.Text & "', Count='" & TextBox21.Text & "' WHERE GuildID='" & TextBox1.Text & "' AND ItemUID='" & TextBox3.Text & "'", con)
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
        Dim con As New Data.SqlClient.SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=PS_UserData;Integrated Security = SSPI")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("select * from PS_GameDefs.dbo.Items Where Type ='30'", con)
        Dim reader As SqlDataReader

        Try
            GWLLapis.Show()

            con.Open()
            reader = cmd.ExecuteReader()
            Do While reader.Read()
                With GWLLapis.ListView1
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
        GWLLapis.TextBox1.Text = TextBox2.Text
        GWLLapis.TextBox2.Text = TextBox3.Text
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=PS_UserData;Integrated Security = SSPI")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("select * from PS_GameDefs.dbo.Items Where Type ='30'", con)
        Dim reader As SqlDataReader

        Try
            GWLLapis1.Show()

            con.Open()
            reader = cmd.ExecuteReader()
            Do While reader.Read()
                With GWLLapis1.ListView1
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
        GWLLapis1.TextBox1.Text = TextBox2.Text
        GWLLapis1.TextBox2.Text = TextBox3.Text
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=PS_UserData;Integrated Security = SSPI")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("select * from PS_GameDefs.dbo.Items Where Type ='30'", con)
        Dim reader As SqlDataReader

        Try
            GWLLapis2.Show()

            con.Open()
            reader = cmd.ExecuteReader()
            Do While reader.Read()
                With GWLLapis2.ListView1
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
        GWLLapis2.TextBox1.Text = TextBox2.Text
        GWLLapis2.TextBox2.Text = TextBox3.Text
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=PS_UserData;Integrated Security = SSPI")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("select * from PS_GameDefs.dbo.Items Where Type ='30'", con)
        Dim reader As SqlDataReader

        Try
            GWLLapis3.Show()

            con.Open()
            reader = cmd.ExecuteReader()
            Do While reader.Read()
                With GWLLapis3.ListView1
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
        GWLLapis3.TextBox1.Text = TextBox2.Text
        GWLLapis3.TextBox2.Text = TextBox3.Text
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=PS_UserData;Integrated Security = SSPI")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("select * from PS_GameDefs.dbo.Items Where Type ='30'", con)
        Dim reader As SqlDataReader

        Try
            GWLLapis4.Show()

            con.Open()
            reader = cmd.ExecuteReader()
            Do While reader.Read()
                With GWLLapis4.ListView1
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
        GWLLapis4.TextBox1.Text = TextBox2.Text
        GWLLapis4.TextBox2.Text = TextBox3.Text
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=PS_UserData;Integrated Security = SSPI")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("select * from PS_GameDefs.dbo.Items Where Type ='30'", con)
        Dim reader As SqlDataReader

        Try
            GWLLapis5.Show()

            con.Open()
            reader = cmd.ExecuteReader()
            Do While reader.Read()
                With GWLLapis5.ListView1
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
        GWLLapis5.TextBox1.Text = TextBox2.Text
        GWLLapis5.TextBox2.Text = TextBox3.Text
    End Sub
End Class