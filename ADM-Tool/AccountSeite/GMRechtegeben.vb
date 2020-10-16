


Public Class GMRechtegeben

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=PS_UserData;Integrated Security = SSPI")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("UPDATE PS_UserData.dbo.Users_Master SET Admin='1' WHERE UserUID='" & ADM.TextBox17.Text & "'" &
                                                                             "UPDATE PS_UserData.dbo.Users_Master SET AdminLevel='255' WHERE UserUID='" & ADM.TextBox17.Text & "'" &
                                                                             "UPDATE PS_UserData.dbo.Users_Master SET Status='" & ComboBox1.Text & "' WHERE UserUID='" & ADM.TextBox17.Text & "'" &
                                                                             "UPDATE PS_UserData.dbo.Users_Master SET UserType='A' WHERE UserUID='" & ADM.TextBox17.Text & "'", con)
        con.Open()
        Dim sdr As SqlDataReader = cmd.ExecuteReader()
        ' If the record can be queried, Pass verification and open another form.  
        If (sdr.Read() = True) Then

            Dim mainForm As New ADM

        Else
            Me.Close()

        End If
        sdr.Close()
        con.Close()

        Dim con1 As New Data.SqlClient.SqlConnection
        Dim cmd1 As New Data.SqlClient.SqlCommand
        Dim reader As SqlDataReader

        con1.ConnectionString = "Data Source=127.0.0.1,1433;Initial Catalog=PS_UserData;Integrated Security = SSPI"
        cmd1.Connection = con1
        cmd1.CommandText = "select UserUID, Status, AdminLevel from PS_UserData.dbo.Users_Master Where UserUID= '" & ADM.TextBox17.Text & "'"
        Try
            con1.Open()
            reader = cmd1.ExecuteReader()
            Do While reader.Read()
                ADM.TextBox22.Text = (reader("Status")
                )
                ADM.TextBox22.Text = IIf(ADM.TextBox22.Text = 0, "nein", "ja")
                ADM.TextBox23.Text = (reader("AdminLevel")
                )
                ADM.TextBox23.Text = IIf(ADM.TextBox23.Text = 0, "nein", "ja")
            Loop
            reader.Close()
            con1.Close()
        Catch ex As Exception
            If MessageBox.Show("Benutzername erfolgreich geändert") Then
                Dim mainForm As New ADM
                Me.Hide()
            Else
                MessageBox.Show("Gilde erfolgreich geladen")
                Me.Close()
            End If
        End Try


    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class