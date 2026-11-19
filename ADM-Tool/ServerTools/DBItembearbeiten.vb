


Public Class DBItembearbeiten

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim con As Data.SqlClient.SqlConnection = CreateConnection()
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("UPDATE PS_GameDefs.dbo.Items SET ItemName = '" & SqlEscape(TextBox2.Text) & "', Type = '" & SqlEscape(TextBox3.Text) & "', TypeID = '" & SqlEscape(TextBox4.Text) & "', Reqlevel = '" & SqlEscape(TextBox5.Text) & "', Country = '" & SqlEscape(TextBox6.Text) & "', Attackfighter = '" & SqlEscape(TextBox7.Text) & "', Defensefighter = '" & SqlEscape(TextBox8.Text) & "', Patrolrogue = '" & SqlEscape(TextBox9.Text) & "',  Shootrogue = '" & SqlEscape(TextBox10.Text) & "', Attackmage = '" & SqlEscape(TextBox11.Text) & "', Defensemage = '" & SqlEscape(TextBox12.Text) & "', Grow = '" & SqlEscape(TextBox13.Text) & "', ReqStr = '" & SqlEscape(TextBox14.Text) & "', ReqDex = '" & SqlEscape(TextBox15.Text) & "', ReqRec = '" & SqlEscape(TextBox16.Text) & "', ReqInt = '" & SqlEscape(TextBox17.Text) & "', ReqWis = '" & SqlEscape(TextBox18.Text) & "', Reqluc = '" & SqlEscape(TextBox19.Text) & "', ReqVg = '" & SqlEscape(TextBox20.Text) & "', ReqOg = '" & SqlEscape(TextBox21.Text) & "', ReqIg = '" & SqlEscape(TextBox22.Text) & "', Range = '" & SqlEscape(TextBox23.Text) & "', AttackTime = '" & SqlEscape(TextBox24.Text) & "', Attrib = '" & SqlEscape(TextBox25.Text) & "', Special = '" & SqlEscape(TextBox26.Text) & "', Slot = '" & SqlEscape(TextBox27.Text) & "', Quality = '" & SqlEscape(TextBox28.Text) & "', Effect1 = '" & SqlEscape(TextBox29.Text) & "', Effect2 = '" & SqlEscape(TextBox30.Text) & "', Effect3 = '" & SqlEscape(TextBox31.Text) & "', Effect4 = '" & SqlEscape(TextBox32.Text) & "',  ConstHP = '" & SqlEscape(TextBox33.Text) & "', ConstSP = '" & SqlEscape(TextBox34.Text) & "', ConstMP = '" & SqlEscape(TextBox35.Text) & "', ConstStr = '" & SqlEscape(TextBox36.Text) & "', ConstDex = '" & SqlEscape(TextBox37.Text) & "', ConstRec = '" & SqlEscape(TextBox38.Text) & "', ConstInt = '" & SqlEscape(TextBox39.Text) & "', ConstWis = '" & SqlEscape(TextBox40.Text) & "', ConstLuc = '" & SqlEscape(TextBox41.Text) & "', Speed = '" & SqlEscape(TextBox42.Text) & "', Exp = '" & SqlEscape(TextBox43.Text) & "', Buy = '" & SqlEscape(TextBox44.Text) & "', Sell = '" & SqlEscape(TextBox45.Text) & "', Grade = '" & SqlEscape(TextBox46.Text) & "', Server = '" & SqlEscape(TextBox48.Text) & "', Count = '" & SqlEscape(TextBox49.Text) & "' WHERE ItemID='" & SqlEscape(TextBox1.Text) & "'", con)
        con.Open()
        cmd.ExecuteNonQuery()
        cmd.Connection.Close()
            MessageBox.Show("Item DB erfolgreich geändert.")
            Me.Close()
    End Sub
End Class