


Public Class AlleGVS


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If ListView1.SelectedItems.Count = 0 Then Return
        Dim con As Data.SqlClient.SqlConnection = CreateConnection()
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("SELECT GV, UserID, Text, Status, Type, Zugewiesenan FROM ADM_Tool.dbo.Vorgaenge WHERE GV='" & SqlEscape(ListView1.SelectedItems(0).SubItems(0).Text) & "'" &
                                                                             "; INSERT INTO ADM_Tool.dbo.GV_Aufruf ([Bearbeiter],[GV],[Date]) VALUES ('" & SqlEscape(Main.Label2.Text) & "','" & SqlEscape(ListView1.SelectedItems(0).SubItems(0).Text) & "',GETDATE() )", con)
        Dim reader As SqlDataReader
        Try
            GVbearbeiten.Show()
            con.Open()
            reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            Do While reader.Read()
                GVbearbeiten.TextBox1.Text = (reader("UserID")
                )
                GVbearbeiten.RichTextBox1.Text = (reader("Text")
                )
                GVbearbeiten.ComboBox1.Text = (reader("Status")
                )
                GVbearbeiten.ComboBox2.Text = (reader("Zugewiesenan")
                )
                GVbearbeiten.TextBox3.Text = (reader("Type")
                )
                GVbearbeiten.TextBox2.Text = (reader("GV")
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
                GVbearbeiten.ComboBox2.Items.Add(reader1("Benutzer")
                )
            Loop

            reader1.Close()
            con.Close()
        Catch ex As Exception
            ShowError(ex)
        End Try
        GVbearbeiten.Show()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class