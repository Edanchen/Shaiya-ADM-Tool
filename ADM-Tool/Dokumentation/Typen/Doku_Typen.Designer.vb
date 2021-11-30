<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Doku_Typen
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 53)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(366, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Dokumentation Typen Anzeigen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(13, 82)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(366, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Dokumentation Typen Anlegen"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(13, 155)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(366, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Schließen"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Doku_Typen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 201)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Doku_Typen"
        Me.Text = "Dokumentation Typen bearbeiten"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
End Class
