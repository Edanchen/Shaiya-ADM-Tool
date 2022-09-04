


Public Class GVbearbeiten

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs)
        Dim con As New Data.SqlClient.SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=PS_GameData;Integrated Security = SSPI")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("SELECT GV, UserID, Text, Status, Type, Zugewiesenan FROM ADM_Tool.dbo.Vorgaenge WHERE GV='" & TextBox2.Text & "'" &
                                                                             "INSERT INTO ADM_Tool.dbo.GV_Aufruf ([Bearbeiter],[GV],[Date]) VALUES ('" & Main.Label2.Text & "','" & TextBox2.Text & "',DATEADD(year, +10, GETDATE()) )", con)
        Dim reader As SqlDataReader
        Try
            con.Open()
            reader = cmd.ExecuteReader()
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
                ComboBox2.Items.Add(reader1("UserID")
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
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=PS_GameData;Integrated Security = SSPI")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("UPDATE ADM_Tool.dbo.Vorgaenge SET Text='" & RichTextBox1.Text & "', Status='" & ComboBox1.Text & "', Zugewiesenan='" & ComboBox2.Text & "', Letzterbearbeiter='" & Main.Label2.Text & "' Where GV='" & TextBox2.Text & "'", con)
        con.Open()
        Dim sdr As SqlDataReader = cmd.ExecuteReader()
        ' If the record can be queried, Pass verification and open another form.  
        If (sdr.Read() = True) Then
            MessageBox.Show("Benutzername erfolgreich geändert")
            Dim mainForm As New Main
            Me.Hide()
        Else
            MessageBox.Show("GV erfolgreich geändert.")
            Me.Close()
        End If
    End Sub
End Class