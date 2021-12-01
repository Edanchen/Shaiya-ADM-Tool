


Public Class Ticketsystem
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ticketsuche.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con1 As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd1 As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("SELECT TicketID, Art, Account, Char, Datum, Bearbeiter FROM ADM_Tool.dbo.tickets Where Status = 'Offen'", con1)
        Dim reader1 As SqlDataReader
        offenetickets.Show()

        con1.Open()
        reader1 = cmd1.ExecuteReader()

        Do While reader1.Read()
            With offenetickets.ListView1
                .Items.Add(reader1("TicketID"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(reader1("Art"))
                    .Add(reader1("Char"))
                    .Add(reader1("Account"))
                    .Add(reader1("Datum"))
                    .Add(reader1("Bearbeiter"))
                End With
            End With

        Loop

        reader1.Close()
        con1.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim con1 As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd1 As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("SELECT TicketID, Art, Account, Char, Datum, Bearbeiter FROM ADM_Tool.dbo.tickets Where Status = 'In Bearbeitung'", con1)
        Dim reader1 As SqlDataReader
        Ticketsinbearbeitung.Show()

        con1.Open()
        reader1 = cmd1.ExecuteReader()

        Do While reader1.Read()
            With Ticketsinbearbeitung.ListView1
                .Items.Add(reader1("TicketID"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(reader1("Art"))
                    .Add(reader1("Char"))
                    .Add(reader1("Account"))
                    .Add(reader1("Datum"))
                    .Add(reader1("Bearbeiter"))
                End With
            End With

        Loop

        reader1.Close()
        con1.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim con1 As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd1 As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("SELECT TicketID, Art, Account, Char, Datum, Bearbeiter FROM ADM_Tool.dbo.tickets Where Status = 'Geschlossen'", con1)
        Dim reader1 As SqlDataReader
        Ticketsgeschlossen.Show()

        con1.Open()
        reader1 = cmd1.ExecuteReader()

        Do While reader1.Read()
            With Ticketsgeschlossen.ListView1
                .Items.Add(reader1("TicketID"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(reader1("Art"))
                    .Add(reader1("Char"))
                    .Add(reader1("Account"))
                    .Add(reader1("Datum"))
                    .Add(reader1("Bearbeiter"))
                End With
            End With

        Loop

        reader1.Close()
        con1.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("SELECT * FROM ADM_Tool.dbo.Account WHERE Benutzer = '" & Main.TextBox1.Text & "' AND Rechte='16' " &
                                                                             "INSERT INTO ADM_Tool.dbo.Tool ([UserID],[Tool],[Date]) VALUES ('" & Main.TextBox1.Text & "','Ticket Thema Anlegen',DATEADD(year, +0, GETDATE()) )", con)
        con.Open()
        Dim sdr As SqlDataReader = cmd.ExecuteReader()
        ' If the record can be queried, Pass verification and open another form.  
        If (sdr.Read() = True) Then


            Dim mainForm As New Main
            Ticket_Art_Anlegen.Show()
        Else
            MessageBox.Show("Dir fehlenden die Berechtigungen um den Bereich zu öffnen! Bitte wende dich an deinen ADM.")
        End If
        sdr.Close()
    End Sub
End Class