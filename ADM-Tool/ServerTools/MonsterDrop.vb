


Public Class MonsterDrop
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim con As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim reader As SqlDataReader

        con.ConnectionString = "Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'"
        cmd.Connection = con
        cmd.CommandText = "SELECT m.MobID, m.MobName, d.MobID, d.Grade, d.DropRate, d.ItemOrder FROM PS_GameDefs.dbo.Mobs m INNER JOIN PS_GameDefs.dbo.MobItems d ON m.MobID=d.MobID Where m.MobID = '" & TextBox1.Text & "'"

        ListView1.Items.Clear()
        Try
            con.Open()
            reader = cmd.ExecuteReader()
            Do While reader.Read()
                With ListView1
                    .Items.Add(reader("ItemOrder"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(reader("Grade"))
                        .Add(reader("DropRate"))
                    End With
                End With
            Loop

            reader.Close()
            con.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim con As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim reader As SqlDataReader

        con.ConnectionString = "Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'"
        cmd.Connection = con
        cmd.CommandText = "SELECT ItemOrder, Grade, DropRate FROM PS_GameDefs.dbo.MobItems Where MobID = '" & TextBox1.Text & "' AND ItemOrder = '" & ListView1.SelectedItems(0).SubItems(0).Text & "'"
        MopDropändern.Show()
        Try
            con.Open()
            reader = cmd.ExecuteReader()
            Do While reader.Read()
                MopDropändern.TextBox2.Text = (reader("ItemOrder")
                    )
                MopDropändern.TextBox3.Text = (reader("Grade")
                )
                MopDropändern.TextBox4.Text = (reader("DropRate")
                )


            Loop

            reader.Close()
            con.Close()

        Catch ex As Exception

        End Try
        MopDropändern.TextBox1.Text = TextBox1.Text
    End Sub
End Class