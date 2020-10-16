<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CharRank
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CharRank))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.CharName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Str = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Dex = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Rec = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Int = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Wis = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Luc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TotalStat = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Defense = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MagicResist = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Absorb = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AttackMin = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AttackMax = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CharName, Me.Str, Me.Dex, Me.Rec, Me.Int, Me.Wis, Me.Luc, Me.TotalStat, Me.Defense, Me.MagicResist, Me.Absorb, Me.AttackMin, Me.AttackMax})
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1160, 554)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'CharName
        '
        Me.CharName.Text = "CharName"
        Me.CharName.Width = 100
        '
        'Str
        '
        Me.Str.Text = "STR"
        Me.Str.Width = 70
        '
        'Dex
        '
        Me.Dex.Text = "DEX"
        Me.Dex.Width = 70
        '
        'Rec
        '
        Me.Rec.Text = "REC"
        Me.Rec.Width = 70
        '
        'Int
        '
        Me.Int.Text = "INT"
        Me.Int.Width = 70
        '
        'Wis
        '
        Me.Wis.Text = "WIS"
        Me.Wis.Width = 70
        '
        'Luc
        '
        Me.Luc.Text = "LUC"
        Me.Luc.Width = 70
        '
        'TotalStat
        '
        Me.TotalStat.Text = "TotalStat"
        Me.TotalStat.Width = 80
        '
        'Defense
        '
        Me.Defense.Text = "Defense"
        Me.Defense.Width = 80
        '
        'MagicResist
        '
        Me.MagicResist.Text = "MagicResist"
        Me.MagicResist.Width = 90
        '
        'Absorb
        '
        Me.Absorb.Text = "Absorb"
        Me.Absorb.Width = 70
        '
        'AttackMin
        '
        Me.AttackMin.Text = "AttackMin"
        Me.AttackMin.Width = 100
        '
        'AttackMax
        '
        Me.AttackMax.Text = "AttackMax"
        Me.AttackMax.Width = 100
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 560)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(1136, 33)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Schließen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CharRank
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1160, 605)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListView1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CharRank"
        Me.Text = "Charakter Statistik"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents CharName As ColumnHeader
    Friend WithEvents Str As ColumnHeader
    Friend WithEvents Dex As ColumnHeader
    Friend WithEvents Rec As ColumnHeader
    Friend WithEvents Int As ColumnHeader
    Friend WithEvents Wis As ColumnHeader
    Friend WithEvents Luc As ColumnHeader
    Friend WithEvents TotalStat As ColumnHeader
    Friend WithEvents Defense As ColumnHeader
    Friend WithEvents MagicResist As ColumnHeader
    Friend WithEvents Absorb As ColumnHeader
    Friend WithEvents AttackMin As ColumnHeader
    Friend WithEvents AttackMax As ColumnHeader
    Friend WithEvents Button1 As Button
End Class
