


Public Class Ticketsinbearbeitung
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con2 As New Data.SqlClient.SqlConnection
        Dim cmd2 As New Data.SqlClient.SqlCommand
        Dim reader2 As SqlDataReader

        con2.ConnectionString = "Data Source=127.0.0.1,1433;Initial Catalog=PS_UserData;Integrated Security = SSPI"
        cmd2.Connection = con2
        cmd2.CommandText = "select Art FROM ADM_Tool.dbo.Ticketart"
        Try
            con2.Open()
            reader2 = cmd2.ExecuteReader()
            Do While reader2.Read()
                ticketbeabeiten_vb.ComboBox3.Items.Add(reader2("Art")
                )
            Loop

            reader2.Close()
            con2.Close()
        Catch ex As Exception
            If MessageBox.Show("Account erfolgreich geladen...") Then
                Dim mainForm As New ADM

            Else
                MessageBox.Show("Account konnten nicht geladen weden...")

            End If
        End Try

        Dim con1 As New Data.SqlClient.SqlConnection
        Dim cmd1 As New Data.SqlClient.SqlCommand
        Dim reader1 As SqlDataReader

        con1.ConnectionString = "Data Source=127.0.0.1,1433;Initial Catalog=PS_UserData;Integrated Security = SSPI"
        cmd1.Connection = con1
        cmd1.CommandText = "select Benutzer FROM ADM_Tool.dbo.Account"
        Try
            con1.Open()
            reader1 = cmd1.ExecuteReader()
            Do While reader1.Read()
                ticketbeabeiten_vb.ComboBox2.Items.Add(reader1("Benutzer")
                )
            Loop

            reader1.Close()
            con1.Close()
        Catch ex As Exception
            If MessageBox.Show("Account erfolgreich geladen...") Then
                Dim mainForm As New ADM

            Else
                MessageBox.Show("Account konnten nicht geladen weden...")

            End If
        End Try
        Dim con As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim reader As SqlDataReader

        con.ConnectionString = "Data Source=127.0.0.1,1433;Initial Catalog=PS_UserData;Integrated Security = SSPI"
        cmd.Connection = con
        cmd.CommandText = "SELECT TicketID, Account, Art, Char, Text, Datum, Bearbeiter, Status FROM ADM_Tool.dbo.tickets Where TicketID = '" & ListView1.SelectedItems(0).SubItems(0).Text & "'"
        ticketbeabeiten_vb.Show()
        Try
            con.Open()
            reader = cmd.ExecuteReader()
            Do While reader.Read()
                ticketbeabeiten_vb.TextBox1.Text = (reader("TicketID")
                    )
                ticketbeabeiten_vb.TextBox2.Text = (reader("Account")
                )
                ticketbeabeiten_vb.TextBox3.Text = (reader("Char")
                )
                ticketbeabeiten_vb.TextBox4.Text = (reader("Datum")
                )
                ticketbeabeiten_vb.ComboBox1.Text = (reader("Status")
                )
                ticketbeabeiten_vb.ComboBox2.Text = (reader("Bearbeiter")
                )
                ticketbeabeiten_vb.RichTextBox1.Text = (reader("Text")
                )
                ticketbeabeiten_vb.ComboBox3.Text = (reader("Art")
)

            Loop

            reader.Close()
            con.Close()

        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class