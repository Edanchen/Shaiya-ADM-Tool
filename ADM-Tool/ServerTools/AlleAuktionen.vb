


Public Class AlleAuktionen

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Auktionlöschen.Show()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=PS_UserData;Integrated Security = SSPI")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("SELECT  m.MarketID, m.CharID, m.MinMoney, m.DirectMoney, m.MarketType, m.GuaranteeMoney, m.TenderCharID, m.TenderCharName, m.TenderMoney, m.EndDate, m.Del, c.CharName From PS_GameData.dbo.Market m INNER Join PS_GameData.dbo.Chars c ON m.CharID=c.CharID", con)
        Dim reader As SqlDataReader

        Try

            con.Open()
            reader = cmd.ExecuteReader()
            ListView1.Items.Clear()
            Do While reader.Read()

                With ListView1
                    .Items.Add(reader("MarketID"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(reader("CharName"))
                        .Add(reader("MinMoney"))
                        .Add(reader("DirectMoney"))
                        .Add(reader("MarketType"))
                        .Add(reader("GuaranteeMoney"))
                        .Add(reader("TenderCharID"))
                        .Add(reader("TenderCharName"))
                        .Add(reader("TenderMoney"))
                        .Add(reader("EndDate"))
                        .Add(reader("Del"))
                    End With

                End With

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