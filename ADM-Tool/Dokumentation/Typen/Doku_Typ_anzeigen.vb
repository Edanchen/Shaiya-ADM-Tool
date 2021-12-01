Public Class Doku_Typ_anzeigen
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Doku_Typ_loeschen.Show()
        Doku_Typ_loeschen.TextBox1.Text = ListView1.SelectedItems(0).SubItems(1).Text
        Doku_Typ_loeschen.TextBox2.Text = ListView1.SelectedItems(0).SubItems(2).Text
        Doku_Typ_loeschen.TextBox3.Text = ListView1.SelectedItems(0).SubItems(3).Text
    End Sub
End Class