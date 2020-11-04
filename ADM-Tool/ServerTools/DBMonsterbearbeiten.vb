


Public Class DBMonsterbearbeiten

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("UPDATE PS_GameDefs.dbo.Mobs SET MobName = '" & TextBox2.Text & "', Level = '" & TextBox3.Text & "', Exp= '" & TextBox4.Text & "', AI = '" & TextBox5.Text & "', Money1 = '" & TextBox6.Text & "', Money2 = '" & TextBox7.Text & "', QuestItemID = '" & TextBox8.Text & "', HP = '" & TextBox9.Text & "',  SP = '" & TextBox10.Text & "', MP = '" & TextBox11.Text & "', Dex = '" & TextBox12.Text & "', Wis = '" & TextBox13.Text & "', Luc = '" & TextBox14.Text & "', Day = '" & TextBox15.Text & "', Size = '" & TextBox16.Text & "', Attrib = '" & TextBox17.Text & "', Defense = '" & TextBox18.Text & "', Magic = '" & TextBox19.Text & "', ResistState1 = '" & TextBox20.Text & "', ResistState2 = '" & TextBox21.Text & "', ResistState3 = '" & TextBox22.Text & "', ResistState4 = '" & TextBox23.Text & "', ResistState5 = '" & TextBox24.Text & "', ResistState6 = '" & TextBox25.Text & "', ResistState7 = '" & TextBox26.Text & "', ResistState8 = '" & TextBox27.Text & "', ResistState9 = '" & TextBox28.Text & "', ResistState10 = '" & TextBox29.Text & "', ResistState11 = '" & TextBox30.Text & "', ResistState12 = '" & TextBox31.Text & "', ResistState13 = '" & TextBox32.Text & "',  ResistState14 = '" & TextBox33.Text & "', ResistState15 = '" & TextBox34.Text & "', ResistSkill1 = '" & TextBox35.Text & "', ResistSkill2 = '" & TextBox36.Text & "', ResistSkill3 = '" & TextBox37.Text & "', ResistSkill4 = '" & TextBox38.Text & "', ResistSkill5 = '" & TextBox39.Text & "', ResistSkill6 = '" & TextBox40.Text & "', NormalTime = '" & TextBox41.Text & "', NormalStep = '" & TextBox42.Text & "', ChaseTime = '" & TextBox43.Text & "', ChaseStep = '" & TextBox44.Text & "', ChaseRange = '" & TextBox45.Text & "', AttackType1 = '" & TextBox46.Text & "', AttackTime1 = '" & TextBox47.Text & "', Attackrange1 = '" & TextBox48.Text & "', Attack1 = '" & TextBox49.Text & "', Attackplus1 = '" & TextBox50.Text & "', Attackattrib1 = '" & TextBox51.Text & "', Attackspecial1 = '" & TextBox52.Text & "', Attackok1 = '" & TextBox53.Text & "', Attacktype2 = '" & TextBox54.Text & "', Attacktime2 = '" & TextBox55.Text & "', Attackrange2 = '" & TextBox56.Text & "',  Attack2 = '" & TextBox57.Text & "', Attackplus2 = '" & TextBox58.Text & "', Attackattrib2 = '" & TextBox59.Text & "', Attackspecial2 = '" & TextBox60.Text & "', Attackok2 = '" & TextBox61.Text & "', Attacktype3 = '" & TextBox62.Text & "', Attacktime3 = '" & TextBox63.Text & "', Attackrange3 = '" & TextBox64.Text & "', Attack3 = '" & TextBox65.Text & "', Attackplus3 = '" & TextBox66.Text & "', Attackattrib3 = '" & TextBox67.Text & "', Attackspecial3 = '" & TextBox68.Text & "', Attackok3 = '" & TextBox69.Text & "' WHERE MobID='" & TextBox1.Text & "'", con)
        con.Open()
        Dim sdr As SqlDataReader = cmd.ExecuteReader()
        ' If the record can be queried, Pass verification and open another form.  
        If (sdr.Read() = True) Then
            MessageBox.Show("Benutzername erfolgreich geändert")
            Dim mainForm As New Main
            Me.Hide()
        Else
            MessageBox.Show("Monster erfolgreich geändert.")
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class