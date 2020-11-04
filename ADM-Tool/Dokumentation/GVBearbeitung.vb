


Public Class GVBearbeitung

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("SELECT GV, Erstelltdurch, UserID, Date, Zugewiesenan, Thema, Art, Type, Status, Letzterbearbeiter From ADM_Tool.dbo.Vorgaenge WHERE Status= 'Zugewiesen' AND Zugewiesenan = '" & Main.TextBox1.Text & "'", con)
        Dim reader As SqlDataReader

        Try
            ZugewieseneGVS.Show()
            con.Open()
            reader = cmd.ExecuteReader()

            Do While reader.Read()
                With ZugewieseneGVS.ListView1
                    .Items.Add(reader("GV"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(reader("Erstelltdurch"))
                        .Add(reader("UserID"))
                        .Add(reader("Date"))
                        .Add(reader("Zugewiesenan"))
                        .Add(reader("Thema"))
                        .Add(reader("Art"))
                        .Add(reader("Type"))
                        .Add(reader("Status"))
                        .Add(reader("Letzterbearbeiter"))
                    End With

                End With

            Loop

            reader.Close()
            con.Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("SELECT GV, Erstelltdurch, UserID, Date, Zugewiesenan, Thema, Art, Type, Status, Letzterbearbeiter From ADM_Tool.dbo.Vorgaenge WHERE Status= 'In Bearbeitung' AND Zugewiesenan = '" & Main.TextBox1.Text & "'", con)
        Dim reader As SqlDataReader

        Try
            GVSinBearbeitung.Show()
            con.Open()
            reader = cmd.ExecuteReader()

            Do While reader.Read()
                With GVSinBearbeitung.ListView1
                    .Items.Add(reader("GV"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(reader("Erstelltdurch"))
                        .Add(reader("UserID"))
                        .Add(reader("Date"))
                        .Add(reader("Zugewiesenan"))
                        .Add(reader("Thema"))
                        .Add(reader("Art"))
                        .Add(reader("Type"))
                        .Add(reader("Status"))
                        .Add(reader("Letzterbearbeiter"))
                    End With

                End With

            Loop

            reader.Close()
            con.Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("SELECT GV, Erstelltdurch, UserID, Date, Zugewiesenan, Thema, Art, Type, Status, Letzterbearbeiter From ADM_Tool.dbo.Vorgaenge WHERE Status= 'Zurueckgewiesen' AND Zugewiesenan = '" & Main.TextBox1.Text & "'", con)
        Dim reader As SqlDataReader

        Try
            ZurueckgewieseneGVS.Show()
            con.Open()
            reader = cmd.ExecuteReader()

            Do While reader.Read()
                With ZurueckgewieseneGVS.ListView1
                    .Items.Add(reader("GV"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(reader("Erstelltdurch"))
                        .Add(reader("UserID"))
                        .Add(reader("Date"))
                        .Add(reader("Zugewiesenan"))
                        .Add(reader("Thema"))
                        .Add(reader("Art"))
                        .Add(reader("Type"))
                        .Add(reader("Status"))
                        .Add(reader("Letzterbearbeiter"))
                    End With

                End With

            Loop

            reader.Close()
            con.Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("SELECT * FROM ADM_Tool.dbo.Account WHERE Benutzer = '" & Main.TextBox1.Text & "' AND Rechte='16' " &
                                                                             "INSERT INTO ADM_Tool.dbo.Tool ([UserID],[Tool],[Date]) VALUES ('" & Main.TextBox1.Text & "','ADM-Tool',DATEADD(year, +0, GETDATE()) )", con)
        con.Open()
        Dim sdr As SqlDataReader = cmd.ExecuteReader()
        ' If the record can be queried, Pass verification and open another form.  
        If (sdr.Read() = True) Then
            AlleGVS.Show()

            Dim mainForm As New Main

        Else
            MessageBox.Show("Dir fehlenden die Berechtigungen um alle GV´s zu öffnen! Bitte wende dich an deinen ADM.")
        End If
        sdr.Close()
        Dim con1 As New Data.SqlClient.SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=ADM_Tool;Integrated Security = SSPI")
        Dim cmd1 As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("SELECT [GV],[UserID],[Date],[Status],[Zugewiesenan],[Thema],[Art],[Type],[Erstelltdurch], [Letzterbearbeiter] FROM [ADM_Tool].[dbo].[Vorgaenge]", con1)
        Dim reader As SqlDataReader

        Try

            con1.Open()
            reader = cmd1.ExecuteReader()

            Do While reader.Read()
                With AlleGVS.ListView1
                    .Items.Add(reader("GV"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(reader("Erstelltdurch"))
                        .Add(reader("UserID"))
                        .Add(reader("Date"))
                        .Add(reader("Zugewiesenan"))
                        .Add(reader("Thema"))
                        .Add(reader("Art"))
                        .Add(reader("Type"))
                        .Add(reader("Status"))
                        .Add(reader("Letzterbearbeiter"))
                    End With

                End With

            Loop

            reader.Close()
            con1.Close()
        Catch ex As Exception

        End Try
    End Sub
End Class