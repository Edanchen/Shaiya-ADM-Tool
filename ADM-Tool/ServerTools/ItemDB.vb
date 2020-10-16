


Public Class ItemDB

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim con As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim reader As SqlDataReader

        con.ConnectionString = "Data Source=127.0.0.1,1433;Initial Catalog=PS_UserData;Integrated Security = SSPI"
        cmd.Connection = con
        cmd.CommandText = "SELECT [ItemID],[ItemName],[Type],[TypeID],[Reqlevel],[Country],[Attackfighter],[Defensefighter],[Patrolrogue],[Shootrogue],[Attackmage],[Defensemage],[Grow],[ReqStr],[ReqDex],[ReqRec],[ReqInt],[ReqWis],[Reqluc],[ReqVg],[ReqOg],[ReqIg],[Range],[AttackTime],[Attrib],[Special],[Slot],[Quality],[Effect1],[Effect2],[Effect3],[Effect4],[ConstHP],[ConstSP],[ConstMP],[ConstStr],[ConstDex],[ConstRec],[ConstInt],[ConstWis],[ConstLuc],[Speed],[Exp],[Buy],[Sell],[Grade],[Drop],[Server],[Count] FROM PS_GameDefs.dbo.Items Where ItemID = '" & ListView1.SelectedItems(0).SubItems(0).Text & "'"
        DBItembearbeiten.Show()
        Try
            con.Open()
            reader = cmd.ExecuteReader()
            Do While reader.Read()
                DBItembearbeiten.TextBox1.Text = (reader("ItemID")
                    )
                DBItembearbeiten.TextBox2.Text = (reader("ItemName")
                )
                DBItembearbeiten.TextBox3.Text = (reader("Type")
                )
                DBItembearbeiten.TextBox4.Text = (reader("TypeID")
                )
                DBItembearbeiten.TextBox5.Text = (reader("Reqlevel")
                )
                DBItembearbeiten.TextBox6.Text = (reader("Country")
                )
                DBItembearbeiten.TextBox7.Text = (reader("Attackfighter")
                )
                DBItembearbeiten.TextBox8.Text = (reader("Defensefighter")
                )
                DBItembearbeiten.TextBox9.Text = (reader("Patrolrogue")
                )
                DBItembearbeiten.TextBox10.Text = (reader("Shootrogue")
                )
                DBItembearbeiten.TextBox11.Text = (reader("Attackmage")
                )
                DBItembearbeiten.TextBox12.Text = (reader("Defensemage")
                )
                DBItembearbeiten.TextBox13.Text = (reader("Grow")
                )
                DBItembearbeiten.TextBox14.Text = (reader("ReqStr")
                )
                DBItembearbeiten.TextBox15.Text = (reader("ReqDex")
                )
                DBItembearbeiten.TextBox16.Text = (reader("ReqRec")
                )
                DBItembearbeiten.TextBox17.Text = (reader("ReqInt")
                )
                DBItembearbeiten.TextBox18.Text = (reader("ReqWis")
                )
                DBItembearbeiten.TextBox19.Text = (reader("Reqluc")
                )
                DBItembearbeiten.TextBox20.Text = (reader("ReqVg")
                )
                DBItembearbeiten.TextBox21.Text = (reader("ReqOg")
                )
                DBItembearbeiten.TextBox22.Text = (reader("ReqIg")
                )
                DBItembearbeiten.TextBox23.Text = (reader("Range")
                )
                DBItembearbeiten.TextBox24.Text = (reader("AttackTime")
                )
                DBItembearbeiten.TextBox25.Text = (reader("Attrib")
                )
                DBItembearbeiten.TextBox26.Text = (reader("Special")
                )
                DBItembearbeiten.TextBox27.Text = (reader("Slot")
                )
                DBItembearbeiten.TextBox28.Text = (reader("Quality")
                )
                DBItembearbeiten.TextBox29.Text = (reader("Effect1")
                )
                DBItembearbeiten.TextBox30.Text = (reader("Effect2")
                )
                DBItembearbeiten.TextBox31.Text = (reader("Effect3")
                )
                DBItembearbeiten.TextBox32.Text = (reader("Effect4")
                )
                DBItembearbeiten.TextBox33.Text = (reader("ConstHP")
                )
                DBItembearbeiten.TextBox34.Text = (reader("ConstSP")
                )
                DBItembearbeiten.TextBox35.Text = (reader("ConstMP")
                )
                DBItembearbeiten.TextBox36.Text = (reader("ConstStr")
                )
                DBItembearbeiten.TextBox37.Text = (reader("ConstDex")
                )
                DBItembearbeiten.TextBox38.Text = (reader("ConstRec")
                )
                DBItembearbeiten.TextBox39.Text = (reader("ConstInt")
                )
                DBItembearbeiten.TextBox40.Text = (reader("ConstWis")
                )
                DBItembearbeiten.TextBox41.Text = (reader("ConstLuc")
                )
                DBItembearbeiten.TextBox42.Text = (reader("Speed")
                )
                DBItembearbeiten.TextBox43.Text = (reader("Exp")
                )
                DBItembearbeiten.TextBox44.Text = (reader("Buy")
                )
                DBItembearbeiten.TextBox45.Text = (reader("Sell")
                )
                DBItembearbeiten.TextBox46.Text = (reader("Grade")
                )
                DBItembearbeiten.TextBox47.Text = (reader("Drop")
                )
                DBItembearbeiten.TextBox48.Text = (reader("Server")
                )
                DBItembearbeiten.TextBox49.Text = (reader("Count")
                )
            Loop

            reader.Close()
            con.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        If (ListView1.Items.Count = 0) Then Return 'ListView leer
        If (ListView1.SelectedItems.Count = 0) Then Return 'Kein Eintrag markiert
        If (ListView1.SelectedItems(0).SubItems.Count < 2) Then Return 'Keine oder zu wenige SubItems
        ListView1.Select()
        DBItembearbeiten.TextBox1.Text = ListView1.SelectedItems(0).SubItems(0).Text
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class