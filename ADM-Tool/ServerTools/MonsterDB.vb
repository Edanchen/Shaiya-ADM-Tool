


Public Class MonsterDB

    
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim con As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim reader As SqlDataReader

        con.ConnectionString = "Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'"
        cmd.Connection = con
        cmd.CommandText = "SELECT [MobID], [MobName],[Level],[Exp],[AI],[Money1],[Money2],[QuestItemID],[HP],[SP],[MP],[Dex],[Wis],[Luc],[Day],[Size],[Attrib],[Defense],[Magic],[ResistState1],[ResistState2],[ResistState3],[ResistState4],[ResistState5],[ResistState6], [ResistState7],[ResistState8],[ResistState9],[ResistState10],[ResistState11],[ResistState12],[ResistState13],[ResistState14],[ResistState15],[ResistSkill1],[ResistSkill2],[ResistSkill3],[ResistSkill4],[ResistSkill5],[ResistSkill6],[NormalTime],[NormalStep],[ChaseTime],[ChaseStep],[ChaseRange],[AttackType1],[AttackTime1],[Attackrange1],[Attack1],[Attackplus1],[Attackattrib1],[Attackspecial1],[Attackok1],[Attacktype2],[Attacktime2],[Attackrange2],[Attack2],[Attackplus2],[Attackattrib2],[Attackspecial2],[Attackok2],[Attacktype3],[Attacktime3],[Attackrange3],[Attack3],[Attackplus3],[Attackattrib3],[Attackspecial3],[Attackok3] FROM PS_GameDefs.dbo.Mobs Where MobID = '" & ListView1.SelectedItems(0).SubItems(0).Text & "'"
        DBMonsterbearbeiten.Show()
        Try
            con.Open()
            reader = cmd.ExecuteReader()
            Do While reader.Read()
                DBMonsterbearbeiten.TextBox1.Text = (reader("MobID")
                    )
                DBMonsterbearbeiten.TextBox2.Text = (reader("MobName")
                )
                DBMonsterbearbeiten.TextBox3.Text = (reader("Level")
                )
                DBMonsterbearbeiten.TextBox4.Text = (reader("EXP")
                )
                DBMonsterbearbeiten.TextBox5.Text = (reader("AI")
                )
                DBMonsterbearbeiten.TextBox6.Text = (reader("Money1")
                )
                DBMonsterbearbeiten.TextBox7.Text = (reader("Money2")
                )
                DBMonsterbearbeiten.TextBox8.Text = (reader("QuestItemID")
                )
                DBMonsterbearbeiten.TextBox9.Text = (reader("HP")
                )
                DBMonsterbearbeiten.TextBox10.Text = (reader("SP")
                )
                DBMonsterbearbeiten.TextBox11.Text = (reader("MP")
                )
                DBMonsterbearbeiten.TextBox12.Text = (reader("Dex")
                )
                DBMonsterbearbeiten.TextBox13.Text = (reader("Wis")
                )
                DBMonsterbearbeiten.TextBox14.Text = (reader("Luc")
                )
                DBMonsterbearbeiten.TextBox15.Text = (reader("Day")
                )
                DBMonsterbearbeiten.TextBox16.Text = (reader("Size")
                )
                DBMonsterbearbeiten.TextBox17.Text = (reader("Attrib")
                )
                DBMonsterbearbeiten.TextBox18.Text = (reader("Defense")
                )
                DBMonsterbearbeiten.TextBox19.Text = (reader("Magic")
                )
                DBMonsterbearbeiten.TextBox20.Text = (reader("ResistState1")
                )
                DBMonsterbearbeiten.TextBox21.Text = (reader("ResistState2")
                )
                DBMonsterbearbeiten.TextBox22.Text = (reader("ResistState3")
                )
                DBMonsterbearbeiten.TextBox23.Text = (reader("ResistState4")
                )
                DBMonsterbearbeiten.TextBox24.Text = (reader("ResistState5")
                )
                DBMonsterbearbeiten.TextBox25.Text = (reader("ResistState6")
                )
                DBMonsterbearbeiten.TextBox26.Text = (reader("ResistState7")
                )
                DBMonsterbearbeiten.TextBox27.Text = (reader("ResistState8")
                )
                DBMonsterbearbeiten.TextBox28.Text = (reader("ResistState9")
                )
                DBMonsterbearbeiten.TextBox29.Text = (reader("ResistState10")
                )
                DBMonsterbearbeiten.TextBox30.Text = (reader("ResistState11")
                )
                DBMonsterbearbeiten.TextBox31.Text = (reader("ResistState12")
                )
                DBMonsterbearbeiten.TextBox32.Text = (reader("ResistState13")
                )
                DBMonsterbearbeiten.TextBox33.Text = (reader("ResistState14")
                )
                DBMonsterbearbeiten.TextBox34.Text = (reader("ResistState15")
                )
                DBMonsterbearbeiten.TextBox35.Text = (reader("ResistSkill1")
                )
                DBMonsterbearbeiten.TextBox36.Text = (reader("ResistSkill2")
                )
                DBMonsterbearbeiten.TextBox37.Text = (reader("ResistSkill3")
                )
                DBMonsterbearbeiten.TextBox38.Text = (reader("ResistSkill4")
                )
                DBMonsterbearbeiten.TextBox39.Text = (reader("ResistSkill5")
                )
                DBMonsterbearbeiten.TextBox40.Text = (reader("ResistSkill6")
                )
                DBMonsterbearbeiten.TextBox41.Text = (reader("NormalTime")
                )
                DBMonsterbearbeiten.TextBox42.Text = (reader("NormalStep")
                )
                DBMonsterbearbeiten.TextBox43.Text = (reader("ChaseTime")
                )
                DBMonsterbearbeiten.TextBox44.Text = (reader("ChaseStep")
                )
                DBMonsterbearbeiten.TextBox45.Text = (reader("ChaseRange")
                )
                DBMonsterbearbeiten.TextBox46.Text = (reader("AttackType1")
                )
                DBMonsterbearbeiten.TextBox47.Text = (reader("AttackTime1")
                )
                DBMonsterbearbeiten.TextBox48.Text = (reader("Attackrange1")
                )
                DBMonsterbearbeiten.TextBox49.Text = (reader("Attack1")
                )
                DBMonsterbearbeiten.TextBox50.Text = (reader("Attackplus1")
                    )
                DBMonsterbearbeiten.TextBox51.Text = (reader("Attackattrib1")
                )
                DBMonsterbearbeiten.TextBox52.Text = (reader("Attackspecial1")
                )
                DBMonsterbearbeiten.TextBox53.Text = (reader("Attackok1")
                )
                DBMonsterbearbeiten.TextBox54.Text = (reader("Attacktype2")
                )
                DBMonsterbearbeiten.TextBox55.Text = (reader("Attacktime2")
                )
                DBMonsterbearbeiten.TextBox56.Text = (reader("Attackrange2")
                )
                DBMonsterbearbeiten.TextBox57.Text = (reader("Attack2")
                )
                DBMonsterbearbeiten.TextBox58.Text = (reader("Attackplus2")
                )
                DBMonsterbearbeiten.TextBox59.Text = (reader("Attackattrib2")
                )
                DBMonsterbearbeiten.TextBox60.Text = (reader("Attackspecial2")
                )
                DBMonsterbearbeiten.TextBox61.Text = (reader("Attackok2")
                )
                DBMonsterbearbeiten.TextBox62.Text = (reader("Attacktype3")
                )
                DBMonsterbearbeiten.TextBox63.Text = (reader("Attacktime3")
                )
                DBMonsterbearbeiten.TextBox64.Text = (reader("Attackrange3")
                )
                DBMonsterbearbeiten.TextBox65.Text = (reader("Attack3")
                )
                DBMonsterbearbeiten.TextBox66.Text = (reader("Attackplus3")
                )
                DBMonsterbearbeiten.TextBox67.Text = (reader("Attackattrib3")
                )
                DBMonsterbearbeiten.TextBox68.Text = (reader("Attackspecial3")
                )
                DBMonsterbearbeiten.TextBox69.Text = (reader("Attackok3")
                )

            Loop

            reader.Close()
            con.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        Dim con As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim reader As SqlDataReader

        con.ConnectionString = "Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'"
        cmd.Connection = con
        cmd.CommandText = "SELECT m.MobID, m.MobName, d.MobID, d.Grade, d.DropRate, d.ItemOrder FROM PS_GameDefs.dbo.Mobs m INNER JOIN PS_GameDefs.dbo.MobItems d ON m.MobID=d.MobID Where m.MobID = '" & ListView1.SelectedItems(0).SubItems(0).Text & "'"

        MonsterDrop.Show()
        Try
            con.Open()
            reader = cmd.ExecuteReader()
            Do While reader.Read()
                With MonsterDrop.ListView1
                    .Items.Add(reader("ItemOrder"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(reader("Grade"))
                        .Add(reader("DropRate"))
                    End With
                End With
                MonsterDrop.TextBox1.Text = (reader("MobID")
                    )
                MonsterDrop.TextBox2.Text = (reader("MobName")
                    )
            Loop

            reader.Close()
            con.Close()

        Catch ex As Exception

        End Try
       
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class