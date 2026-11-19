



Public Class LoginForm1


    ' TODO: Code zum Durchführen der benutzerdefinierten Authentifizierung mithilfe des angegebenen Benutzernamens und des Kennworts hinzufügen 
    ' (Siehe http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' Der benutzerdefinierte Prinzipal kann anschließend wie folgt an den Prinzipal des aktuellen Threads angefügt werden: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' wobei CustomPrincipal die IPrincipal-Implementierung ist, die für die Durchführung der Authentifizierung verwendet wird. 
    ' Anschließend gibt My.User Identitätsinformationen zurück, die in das CustomPrincipal-Objekt gekapselt sind,
    ' z.B. den Benutzernamen, den Anzeigenamen usw.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            If AuthenticateAdmin(UsernameTextBox.Text, PasswordTextBox.Text, 15) Then
                TextBox1.Text = "Verbindung steht."
                TextBox1.ForeColor = Color.Black
                TextBox1.BackColor = Color.Green
                MessageBox.Show("Herzlich Willkommen " & UsernameTextBox.Text & ", du hast dich erfolgreich eingeloggt.")
                Main.Show()
                Me.Hide()
            Else
                MessageBox.Show("Benutzername oder Password Falsch oder die fehlenden Berechtigungen!")
            End If
            Main.Label2.Text = UsernameTextBox.Text

        Catch ex As SqlException
            TextBox1.Text = "Fehler bei der Verbindung"
            TextBox1.ForeColor = Color.Black
            TextBox1.BackColor = Color.Red
            ShowError(ex)
        End Try

    End Sub

    Private Sub Cancel_Click(sender As System.Object, e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeendenToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ServerEinstellungToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServerEinstellungToolStripMenuItem.Click
        Config.Show()
    End Sub
End Class
