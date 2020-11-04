


Public Class ItemWiederherstellung

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("SELECT  CharID, CharName, ActionTime, Value1, Value2, Text1, Text2 From PS_GameLog.dbo.ActionLog Where CharName = '" & ADM.TextBox25.Text & "' AND ActionType = '112'", con)
        Dim reader As SqlDataReader

        Try
            KaputteItemsActionLog.Show()
            con.Open()
            reader = cmd.ExecuteReader()

            Do While reader.Read()

                With KaputteItemsActionLog.ListView1
                    .Items.Add(reader("CharID"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(reader("CharName"))
                        .Add(reader("ActionTime"))
                        .Add(reader("Value1"))
                        .Add(reader("Value2"))
                        .Add(reader("Text1"))
                        .Add(reader("Text2"))

                    End With

                End With

            Loop

            reader.Close()
            con.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Itemwiederherstellen.Show()
        Itemwiederherstellen.TextBox1.Text = ADM.TextBox24.Text
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("SELECT  CharID, ItemID, ItemUID, Type, TypeID, Bag, Slot From PS_GameData.dbo.CharItems Where CharID = '" & ADM.TextBox24.Text & "'", con)
        Dim reader As SqlDataReader

        Try
            Inventar.Show()
            con.Open()
            reader = cmd.ExecuteReader()

            Do While reader.Read()

                With Inventar.ListView1
                    .Items.Add(reader("CharID"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(reader("ItemID"))
                        .Add(reader("ItemUID"))
                        .Add(reader("Type"))
                        .Add(reader("TypeID"))
                        .Add(reader("Bag"))
                        .Add(reader("Slot"))


                    End With

                End With

            Loop

            reader.Close()
            con.Close()
        Catch ex As Exception

        End Try
    End Sub
End Class