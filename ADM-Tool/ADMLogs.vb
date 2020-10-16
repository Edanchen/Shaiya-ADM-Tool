


Public Class ADMLogs

    Private Sub ListView1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        If (ListView1.Items.Count = 0) Then Return 'ListView leer
        If (ListView1.SelectedItems.Count = 0) Then Return 'Kein Eintrag markiert
        If (ListView1.SelectedItems(0).SubItems.Count < 2) Then Return 'Keine oder zu wenige SubItems
        ListView1.Select()

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=PS_UserData;Integrated Security = SSPI")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("SELECT Date, UserID, Tool FROM ADM_Tool.dbo.Tool", con)
        Dim reader As SqlDataReader


        con.Open()

        reader = cmd.ExecuteReader()

        Do While reader.Read()
            With ListView1
                .Items.Add(reader("Date"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(reader("UserID"))
                    .Add(reader("Tool"))
                End With

            End With

        Loop

        reader.Close()
        con.Close()
    End Sub
End Class