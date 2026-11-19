


Public Class Passwort

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            If ChangeAdminPassword(Main.Label2.Text, TextBox1.Text, TextBox2.Text) Then
            MessageBox.Show("Passwort erfolgreich geändert.")
            Dim mainForm As New Main
            Me.Hide()
            Else
                MessageBox.Show("Das angegebene Passwort ist falsch.")
            End If
        Catch ex As Exception
            ShowError(ex)
        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
