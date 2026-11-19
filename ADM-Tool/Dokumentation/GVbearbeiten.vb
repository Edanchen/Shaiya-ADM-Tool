


Public Class GVbearbeiten

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs)
        Dim con As Data.SqlClient.SqlConnection = CreateConnection()
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("SELECT GV, UserID, Text, Status, Type, Zugewiesenan FROM ADM_Tool.dbo.Vorgaenge WHERE GV='" & SqlEscape(TextBox2.Text) & "'" &
                                                                             "; INSERT INTO ADM_Tool.dbo.GV_Aufruf ([Bearbeiter],[GV],[Date]) VALUES ('" & SqlEscape(Main.Label2.Text) & "','" & SqlEscape(TextBox2.Text) & "',GETDATE() )", con)
        Dim reader As SqlDataReader
        Try
            con.Open()
            reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            Do While reader.Read()
                TextBox1.Text = (reader("UserID")
                )
                RichTextBox1.Text = (reader("Text")
                )
                ComboBox1.Text = (reader("Status")
                )
                ComboBox2.Text = (reader("Zugewiesenan")
                )
                TextBox3.Text = (reader("Type")
                )
            Loop
            reader.Close()
            con.Close()

        Catch ex As Exception
            ShowError(ex)
        End Try
        Dim con1 As New Data.SqlClient.SqlConnection
        Dim cmd1 As New Data.SqlClient.SqlCommand
        Dim reader1 As SqlDataReader

        con1.ConnectionString = CurrentConnectionString()
        cmd1.Connection = con1
        cmd1.CommandText = "select Benutzer FROM ADM_Tool.dbo.Account"
        Try
            con1.Open()
            reader1 = cmd1.ExecuteReader(CommandBehavior.CloseConnection)
            Do While reader1.Read()
                ComboBox2.Items.Add(reader1("UserID")
                )
            Loop

            reader1.Close()
            con.Close()
        Catch ex As Exception
            ShowError(ex)
        End Try
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim con As Data.SqlClient.SqlConnection = CreateConnection()
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("UPDATE ADM_Tool.dbo.Vorgaenge SET Text='" & SqlEscape(RichTextBox1.Text) & "', Status='" & SqlEscape(ComboBox1.Text) & "', Zugewiesenan='" & SqlEscape(ComboBox2.Text) & "', Letzterbearbeiter='" & SqlEscape(Main.Label2.Text) & "' Where GV='" & SqlEscape(TextBox2.Text) & "'", con)
        con.Open()
        cmd.ExecuteNonQuery()
        cmd.Connection.Close()
            MessageBox.Show("GV erfolgreich geändert.")
            Me.Close()
    End Sub
End Class