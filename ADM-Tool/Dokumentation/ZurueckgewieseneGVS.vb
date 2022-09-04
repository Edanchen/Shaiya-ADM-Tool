


Public Class ZurueckgewieseneGVS

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=PS_GameData;Integrated Security = SSPI")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("SELECT GV, UserID, Text, Status, Type, Zugewiesenan FROM ADM_Tool.dbo.Vorgaenge WHERE GV='" & ListView1.SelectedItems(0).SubItems(0).Text & "'" &
                                                                             "INSERT INTO ADM_Tool.dbo.GV_Aufruf ([Bearbeiter],[GV],[Date]) VALUES ('" & Main.Label2.Text & "','" & ListView1.SelectedItems(0).SubItems(0).Text & "',DATEADD(year, +10, GETDATE()) )", con)
        Dim reader As SqlDataReader
        Try
            GVbearbeiten.Show()
            con.Open()
            reader = cmd.ExecuteReader()
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
            If MessageBox.Show("Benutzername erfolgreich geändert") Then
                Dim mainForm As New Main

            Else
                MessageBox.Show("Benutzername erfolgreich geändert")

            End If
        End Try
        Dim con1 As New Data.SqlClient.SqlConnection
        Dim cmd1 As New Data.SqlClient.SqlCommand
        Dim reader1 As SqlDataReader

        con1.ConnectionString = "Data Source=127.0.0.1,1433;Initial Catalog=PS_GameData;Integrated Security = SSPI"
        cmd1.Connection = con1
        cmd1.CommandText = "select Benutzer FROM ADM_Tool.dbo.Account"
        Try
            con1.Open()
            reader1 = cmd1.ExecuteReader()
            Do While reader1.Read()
                GVbearbeiten.ComboBox2.Items.Add(reader1("Benutzer")
                )
            Loop

            reader1.Close()
            con.Close()
        Catch ex As Exception
            If MessageBox.Show("Account erfolgreich geladen...") Then
                Dim mainForm As New Main

            Else
                MessageBox.Show("Account konnten nicht geladen weden...")

            End If
        End Try
        GVbearbeiten.Show()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    
End Class