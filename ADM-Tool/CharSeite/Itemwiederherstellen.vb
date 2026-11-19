


Public Class Itemwiederherstellen

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            Dim con As Data.SqlClient.SqlConnection = CreateConnection()
            Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("INSERT INTO PS_GameData.dbo.CharItems ([CharID],[ItemID],[ItemUID],[Type],[TypeID],[Bag],[Slot],[Quality],[Gem1],[Gem2],[Gem3],[Gem4],[Gem5],[Gem6],[Craftname],[Count],[Maketime],[Maketype],[Del]) VALUES (" & SqlNumber(CStr(TextBox1.Text), "CharID") & "," & SqlNumber(CStr(TextBox2.Text), "ItemID") & "," & SqlNumber(CStr(TextBox3.Text), "ItemUID") & "," & SqlNumber(CStr(TextBox4.Text), "Type") & "," & SqlNumber(CStr(TextBox5.Text), "TypeID") & "," & SqlNumber(CStr(TextBox6.Text), "Bag") & "," & SqlNumber(CStr(TextBox7.Text), "Slot") & "," & SqlNumber(CStr(TextBox8.Text), "Quality") & "," & SqlNumber(CStr(TextBox9.Text), "Gem1") & "," & SqlNumber(CStr(TextBox10.Text), "Gem2") & "," & SqlNumber(CStr(TextBox11.Text), "Gem3") & "," & SqlNumber(CStr(TextBox12.Text), "Gem4") & "," & SqlNumber(CStr(TextBox13.Text), "Gem5") & "," & SqlNumber(CStr(TextBox14.Text), "Gem6") & ",'" & SqlEscape(TextBox15.Text) & "'," & SqlNumber(CStr(TextBox16.Text), "Count") & ",GETDATE(),'D','False')", con)
            con.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()
            MessageBox.Show("Item erfolgreich wiederhergestellt.")
            Me.Close()
        Catch ex As Exception
            ShowError(ex)
        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
