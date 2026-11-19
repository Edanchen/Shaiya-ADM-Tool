


Public Class TeamGildehinzufügen

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            Dim con As Data.SqlClient.SqlConnection = CreateConnection()
            Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("INSERT INTO PS_GameData.dbo.GuildChars ([GuildID],[CharID],[GuildLevel],[Del],[JoinDate],[LeaveDate]) VALUES ('1'," & SqlNumber(CStr(ADM.TextBox24.Text), "CharID") & ",'9','0',GETDATE(),'')", con)
            con.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()
            MessageBox.Show("Char erfolgreich in die Team Gilde hinzugefügt.")
            Me.Close()
        Catch ex As Exception
            ShowError(ex)
        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
