


Public Class Itemwiederherstellen

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=PS_UserData;Integrated Security = SSPI")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("INSERT INTO PS_GameData.dbo.CharItems ([CharID],[ItemID],[ItemUID],[Type],[TypeID],[Bag],[Slot],[Quality],[Gem1],[Gem2],[Gem3],[Gem4],[Gem5],[Gem6],[Craftname],[Count],[Maketime],[Maketype],[Del]) VALUES (" & TextBox1.Text & "," & TextBox2.Text & "," & TextBox3.Text & "," & TextBox4.Text & "," & TextBox5.Text & "," & TextBox6.Text & "," & TextBox7.Text & "," & TextBox8.Text & "," & TextBox9.Text & "," & TextBox10.Text & "," & TextBox11.Text & "," & TextBox12.Text & "," & TextBox13.Text & "," & TextBox14.Text & "," & TextBox15.Text & "," & TextBox16.Text & ",DATEADD(year, +10, GETDATE()),'D','False')", con)
        con.Open()
        Dim sdr As SqlDataReader = cmd.ExecuteReader()
        ' If the record can be queried, Pass verification and open another form.  
        If (sdr.Read() = True) Then
            MessageBox.Show("Benutzername erfolgreich geändert")
            Dim mainForm As New ADM
            Me.Hide()
        Else
            MessageBox.Show("Item erfolgreich wiederhergestellt.")
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class