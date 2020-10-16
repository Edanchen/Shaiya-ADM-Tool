


Public Class Chatloglöschen

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=PS_UserData;Integrated Security = SSPI")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("DELETE FROM PS_ChatLog.dbo.ChatLog WHERE datediff(day, ChatTime, getdate()) >= 8", con)
        con.Open()
        Dim sdr As SqlDataReader = cmd.ExecuteReader()
        ' If the record can be queried, Pass verification and open another form.

        ChatLog.ListView1.Items.Clear()
        If (sdr.Read() = True) Then
            MessageBox.Show("Password erfolgreich geändert")
            Dim mainForm As New ADM
            Me.Hide()
        Else
            MessageBox.Show("Gelöschte ChatLog erfolgreich entfernt...")
            Me.Hide()
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class