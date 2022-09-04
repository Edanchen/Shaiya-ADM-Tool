<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbmeldenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÜberShaiyaADMToolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AccountsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountsZurLöschungToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GebannteAccountsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlleGMAccountsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServerToolsToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlleGelöschteCharsEntfernenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EingeloggteSpielerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActionLogEinsehenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlleAuktionenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatPaddersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChatLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImGameMallToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GlobalStatResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.WartungsmodusToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.WartungsmodusEinschaltenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WartungsmodusAusschaltenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatistikToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllePvPKillsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllePvPToteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BossKillsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CharakterStatistikToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Tickets = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        resources.ApplyResources(Me.Button2, "Button2")
        Me.Button2.Name = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        resources.ApplyResources(Me.Button3, "Button3")
        Me.Button3.Name = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Button4
        '
        resources.ApplyResources(Me.Button4, "Button4")
        Me.Button4.Name = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        resources.ApplyResources(Me.Button5, "Button5")
        Me.Button5.Name = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        resources.ApplyResources(Me.Button6, "Button6")
        Me.Button6.Name = "Button6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbmeldenToolStripMenuItem, Me.BeendenToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        resources.ApplyResources(Me.DateiToolStripMenuItem, "DateiToolStripMenuItem")
        '
        'AbmeldenToolStripMenuItem
        '
        Me.AbmeldenToolStripMenuItem.Name = "AbmeldenToolStripMenuItem"
        resources.ApplyResources(Me.AbmeldenToolStripMenuItem, "AbmeldenToolStripMenuItem")
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        resources.ApplyResources(Me.BeendenToolStripMenuItem, "BeendenToolStripMenuItem")
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÜberShaiyaADMToolToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        resources.ApplyResources(Me.ToolStripMenuItem1, "ToolStripMenuItem1")
        '
        'ÜberShaiyaADMToolToolStripMenuItem
        '
        Me.ÜberShaiyaADMToolToolStripMenuItem.Name = "ÜberShaiyaADMToolToolStripMenuItem"
        resources.ApplyResources(Me.ÜberShaiyaADMToolToolStripMenuItem, "ÜberShaiyaADMToolToolStripMenuItem")
        '
        'Button7
        '
        resources.ApplyResources(Me.Button7, "Button7")
        Me.Button7.Name = "Button7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.ContextMenuStrip = Me.ContextMenuStrip2
        resources.ApplyResources(Me.Button8, "Button8")
        Me.Button8.Name = "Button8"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip2
        '
        resources.ApplyResources(Me.ContextMenuStrip2, "ContextMenuStrip2")
        Me.ContextMenuStrip2.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccountsToolStripMenuItem, Me.ServerToolsToolStripMenuItem2, Me.WartungsmodusToolStripMenuItem1, Me.StatistikToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        '
        'AccountsToolStripMenuItem
        '
        Me.AccountsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccountsZurLöschungToolStripMenuItem, Me.GebannteAccountsToolStripMenuItem, Me.AlleGMAccountsToolStripMenuItem})
        resources.ApplyResources(Me.AccountsToolStripMenuItem, "AccountsToolStripMenuItem")
        Me.AccountsToolStripMenuItem.Name = "AccountsToolStripMenuItem"
        '
        'AccountsZurLöschungToolStripMenuItem
        '
        Me.AccountsZurLöschungToolStripMenuItem.Name = "AccountsZurLöschungToolStripMenuItem"
        resources.ApplyResources(Me.AccountsZurLöschungToolStripMenuItem, "AccountsZurLöschungToolStripMenuItem")
        '
        'GebannteAccountsToolStripMenuItem
        '
        Me.GebannteAccountsToolStripMenuItem.Name = "GebannteAccountsToolStripMenuItem"
        resources.ApplyResources(Me.GebannteAccountsToolStripMenuItem, "GebannteAccountsToolStripMenuItem")
        '
        'AlleGMAccountsToolStripMenuItem
        '
        Me.AlleGMAccountsToolStripMenuItem.Name = "AlleGMAccountsToolStripMenuItem"
        resources.ApplyResources(Me.AlleGMAccountsToolStripMenuItem, "AlleGMAccountsToolStripMenuItem")
        '
        'ServerToolsToolStripMenuItem2
        '
        Me.ServerToolsToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlleGelöschteCharsEntfernenToolStripMenuItem, Me.EingeloggteSpielerToolStripMenuItem, Me.ActionLogEinsehenToolStripMenuItem, Me.AlleAuktionenToolStripMenuItem, Me.StatPaddersToolStripMenuItem, Me.ChatLogToolStripMenuItem, Me.ImGameMallToolStripMenuItem, Me.GlobalStatResetToolStripMenuItem, Me.ToolStripMenuItem2})
        Me.ServerToolsToolStripMenuItem2.Name = "ServerToolsToolStripMenuItem2"
        resources.ApplyResources(Me.ServerToolsToolStripMenuItem2, "ServerToolsToolStripMenuItem2")
        '
        'AlleGelöschteCharsEntfernenToolStripMenuItem
        '
        Me.AlleGelöschteCharsEntfernenToolStripMenuItem.Name = "AlleGelöschteCharsEntfernenToolStripMenuItem"
        resources.ApplyResources(Me.AlleGelöschteCharsEntfernenToolStripMenuItem, "AlleGelöschteCharsEntfernenToolStripMenuItem")
        '
        'EingeloggteSpielerToolStripMenuItem
        '
        Me.EingeloggteSpielerToolStripMenuItem.Name = "EingeloggteSpielerToolStripMenuItem"
        resources.ApplyResources(Me.EingeloggteSpielerToolStripMenuItem, "EingeloggteSpielerToolStripMenuItem")
        '
        'ActionLogEinsehenToolStripMenuItem
        '
        Me.ActionLogEinsehenToolStripMenuItem.Name = "ActionLogEinsehenToolStripMenuItem"
        resources.ApplyResources(Me.ActionLogEinsehenToolStripMenuItem, "ActionLogEinsehenToolStripMenuItem")
        '
        'AlleAuktionenToolStripMenuItem
        '
        Me.AlleAuktionenToolStripMenuItem.Name = "AlleAuktionenToolStripMenuItem"
        resources.ApplyResources(Me.AlleAuktionenToolStripMenuItem, "AlleAuktionenToolStripMenuItem")
        '
        'StatPaddersToolStripMenuItem
        '
        Me.StatPaddersToolStripMenuItem.Name = "StatPaddersToolStripMenuItem"
        resources.ApplyResources(Me.StatPaddersToolStripMenuItem, "StatPaddersToolStripMenuItem")
        '
        'ChatLogToolStripMenuItem
        '
        Me.ChatLogToolStripMenuItem.Name = "ChatLogToolStripMenuItem"
        resources.ApplyResources(Me.ChatLogToolStripMenuItem, "ChatLogToolStripMenuItem")
        '
        'ImGameMallToolStripMenuItem
        '
        Me.ImGameMallToolStripMenuItem.Name = "ImGameMallToolStripMenuItem"
        resources.ApplyResources(Me.ImGameMallToolStripMenuItem, "ImGameMallToolStripMenuItem")
        '
        'GlobalStatResetToolStripMenuItem
        '
        Me.GlobalStatResetToolStripMenuItem.Name = "GlobalStatResetToolStripMenuItem"
        resources.ApplyResources(Me.GlobalStatResetToolStripMenuItem, "GlobalStatResetToolStripMenuItem")
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        resources.ApplyResources(Me.ToolStripMenuItem2, "ToolStripMenuItem2")
        '
        'WartungsmodusToolStripMenuItem1
        '
        Me.WartungsmodusToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WartungsmodusEinschaltenToolStripMenuItem, Me.WartungsmodusAusschaltenToolStripMenuItem})
        resources.ApplyResources(Me.WartungsmodusToolStripMenuItem1, "WartungsmodusToolStripMenuItem1")
        Me.WartungsmodusToolStripMenuItem1.Name = "WartungsmodusToolStripMenuItem1"
        '
        'WartungsmodusEinschaltenToolStripMenuItem
        '
        Me.WartungsmodusEinschaltenToolStripMenuItem.Name = "WartungsmodusEinschaltenToolStripMenuItem"
        resources.ApplyResources(Me.WartungsmodusEinschaltenToolStripMenuItem, "WartungsmodusEinschaltenToolStripMenuItem")
        '
        'WartungsmodusAusschaltenToolStripMenuItem
        '
        Me.WartungsmodusAusschaltenToolStripMenuItem.Name = "WartungsmodusAusschaltenToolStripMenuItem"
        resources.ApplyResources(Me.WartungsmodusAusschaltenToolStripMenuItem, "WartungsmodusAusschaltenToolStripMenuItem")
        '
        'StatistikToolStripMenuItem
        '
        Me.StatistikToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllePvPKillsToolStripMenuItem, Me.AllePvPToteToolStripMenuItem, Me.BossKillsToolStripMenuItem, Me.CharakterStatistikToolStripMenuItem})
        Me.StatistikToolStripMenuItem.Name = "StatistikToolStripMenuItem"
        resources.ApplyResources(Me.StatistikToolStripMenuItem, "StatistikToolStripMenuItem")
        '
        'AllePvPKillsToolStripMenuItem
        '
        Me.AllePvPKillsToolStripMenuItem.Name = "AllePvPKillsToolStripMenuItem"
        resources.ApplyResources(Me.AllePvPKillsToolStripMenuItem, "AllePvPKillsToolStripMenuItem")
        '
        'AllePvPToteToolStripMenuItem
        '
        Me.AllePvPToteToolStripMenuItem.Name = "AllePvPToteToolStripMenuItem"
        resources.ApplyResources(Me.AllePvPToteToolStripMenuItem, "AllePvPToteToolStripMenuItem")
        '
        'BossKillsToolStripMenuItem
        '
        Me.BossKillsToolStripMenuItem.Name = "BossKillsToolStripMenuItem"
        resources.ApplyResources(Me.BossKillsToolStripMenuItem, "BossKillsToolStripMenuItem")
        '
        'CharakterStatistikToolStripMenuItem
        '
        Me.CharakterStatistikToolStripMenuItem.Name = "CharakterStatistikToolStripMenuItem"
        resources.ApplyResources(Me.CharakterStatistikToolStripMenuItem, "CharakterStatistikToolStripMenuItem")
        '
        'Button9
        '
        resources.ApplyResources(Me.Button9, "Button9")
        Me.Button9.Name = "Button9"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Tickets
        '
        resources.ApplyResources(Me.Tickets, "Tickets")
        Me.Tickets.Name = "Tickets"
        Me.Tickets.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        resources.ApplyResources(Me.StatusStrip1, "StatusStrip1")
        Me.StatusStrip1.Name = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        resources.ApplyResources(Me.ToolStripStatusLabel1, "ToolStripStatusLabel1")
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        '
        'Button10
        '
        resources.ApplyResources(Me.Button10, "Button10")
        Me.Button10.Name = "Button10"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        resources.ApplyResources(Me.Button11, "Button11")
        Me.Button11.Name = "Button11"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        resources.ApplyResources(Me.Button12, "Button12")
        Me.Button12.Name = "Button12"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Main
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Tickets)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DateiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbmeldenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BeendenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ÜberShaiyaADMToolToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AccountsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ServerToolsToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WartungsmodusToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AccountsZurLöschungToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GebannteAccountsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlleGMAccountsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlleGelöschteCharsEntfernenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EingeloggteSpielerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActionLogEinsehenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlleAuktionenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatPaddersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChatLogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImGameMallToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WartungsmodusEinschaltenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WartungsmodusAusschaltenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Tickets As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents GlobalStatResetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatistikToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AllePvPKillsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AllePvPToteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BossKillsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CharakterStatistikToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents Button12 As Button
    Friend WithEvents Label2 As Label
End Class
