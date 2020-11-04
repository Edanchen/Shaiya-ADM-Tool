


Public Class DBItembearbeiten

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("UPDATE PS_GameDefs.dbo.Items SET ItemName = '" & TextBox2.Text & "', Type = '" & TextBox3.Text & "', TypeID = '" & TextBox4.Text & "', Reqlevel = '" & TextBox5.Text & "', Country = '" & TextBox6.Text & "', Attackfighter = '" & TextBox7.Text & "', Defensefighter = '" & TextBox8.Text & "', Patrolrogue = '" & TextBox9.Text & "',  Shootrogue = '" & TextBox10.Text & "', Attackmage = '" & TextBox11.Text & "', Defensemage = '" & TextBox12.Text & "', Grow = '" & TextBox13.Text & "', ReqStr = '" & TextBox14.Text & "', ReqDex = '" & TextBox15.Text & "', ReqRec = '" & TextBox16.Text & "', ReqInt = '" & TextBox17.Text & "', ReqWis = '" & TextBox18.Text & "', Reqluc = '" & TextBox19.Text & "', ReqVg = '" & TextBox20.Text & "', ReqOg = '" & TextBox21.Text & "', ReqIg = '" & TextBox22.Text & "', Range = '" & TextBox23.Text & "', AttackTime = '" & TextBox24.Text & "', Attrib = '" & TextBox25.Text & "', Special = '" & TextBox26.Text & "', Slot = '" & TextBox27.Text & "', Quality = '" & TextBox28.Text & "', Effect1 = '" & TextBox29.Text & "', Effect2 = '" & TextBox30.Text & "', Effect3 = '" & TextBox31.Text & "', Effect4 = '" & TextBox32.Text & "',  ConstHP = '" & TextBox33.Text & "', ConstSP = '" & TextBox34.Text & "', ConstMP = '" & TextBox35.Text & "', ConstStr = '" & TextBox36.Text & "', ConstDex = '" & TextBox37.Text & "', ConstRec = '" & TextBox38.Text & "', ConstInt = '" & TextBox39.Text & "', ConstWis = '" & TextBox40.Text & "', ConstLuc = '" & TextBox41.Text & "', Speed = '" & TextBox42.Text & "', Exp = '" & TextBox43.Text & "', Buy = '" & TextBox44.Text & "', Sell = '" & TextBox45.Text & "', Grade = '" & TextBox46.Text & "', Server = '" & TextBox48.Text & "', Count = '" & TextBox49.Text & "' WHERE ItemID='" & TextBox1.Text & "'", con)
        con.Open()
        Dim sdr As SqlDataReader = cmd.ExecuteReader()
        ' If the record can be queried, Pass verification and open another form.  
        If (sdr.Read() = True) Then
            MessageBox.Show("Benutzername erfolgreich geändert")
            Dim mainForm As New Main
            Me.Hide()
        Else
            MessageBox.Show("Item DB erfolgreich geändert.")
            Me.Close()
        End If
    End Sub
End Class