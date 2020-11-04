


Public Class Globalreset
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New Data.SqlClient.SqlConnection("Data Source=" & My.Settings.Server & "," & My.Settings.Port & ";Initial Catalog=PS_UserData;user id='" & My.Settings.Benutzer & "'; password='" & My.Settings.Passwort & "'")
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("DECLARE @Stat_NM tinyint, @Stat_HM tinyint, @Stat_UM tinyint, @Stat_EM tinyint;
DECLARE @Skill_NM tinyint, @Skill_HM tinyint, @Skill_UM tinyint, @Skill_EM tinyint;

    -- set your custom Status Points gained per level here
SET @Stat_NM = 5;
SET @Stat_HM = 7;
SET @Stat_UM = 9;
    -- set your custom Skill Points gained per level here
SET @Skill_NM = 3;
SET @Skill_HM = 4;
SET @Skill_UM = 5;


/*************************************************
 *    reset status and skill points for AoL & UoF  *
 *************************************************/

DECLARE @i tinyint;
SET @i=0;

WHILE @i<=3
begin
    if @i=0
    begin
        exec sp_executesql N'UPDATE PS_GameData.dbo.Chars SET [Str]=14, Dex=12, Rec=9, [Int]=8, Wis=7, Luc=15 WHERE Family=@i AND Job=0 AND [Level]>1 AND Del=0 AND Grow>0',N'@i tinyint',@i
        exec sp_executesql N'UPDATE PS_GameData.dbo.Chars SET [Str]=10, Dex=9, Rec=12, [Int]=10, Wis=10, Luc=14 WHERE Family=@i AND Job=1 AND [Level]>1 AND Del=0 AND Grow>0',N'@i tinyint',@i
        exec sp_executesql N'UPDATE PS_GameData.dbo.Chars SET [Str]=8, Dex=9, Rec=10, [Int]=12, Wis=14, Luc=12 WHERE Family=@i AND Job=5 AND [Level]>1 AND Del=0 AND Grow>0',N'@i tinyint',@i
    end

    if @i=1
    begin
        exec sp_executesql N'UPDATE PS_GameData.dbo.Chars SET [Str]=10, Dex=19, Rec=9, [Int]=7, Wis=8, Luc=12 WHERE Family=@i AND Job=2 AND [Level]>1 AND Del=0 AND Grow>0',N'@i tinyint',@i
        exec sp_executesql N'UPDATE PS_GameData.dbo.Chars SET [Str]=11, Dex=14, Rec=10, [Int]=7, Wis=10, Luc=13 WHERE Family=@i AND Job=3 AND [Level]>1 AND Del=0 AND Grow>0',N'@i tinyint',@i
        exec sp_executesql N'UPDATE PS_GameData.dbo.Chars SET [Str]=7, Dex=13, Rec=9, [Int]=15, Wis=12, Luc=9 WHERE Family=@i AND Job=4 AND [Level]>1 AND Del=0 AND Grow>0',N'@i tinyint',@i
    end

    if @i=2
    begin
        exec sp_executesql N'UPDATE PS_GameData.dbo.Chars SET [Str]=10, Dex=15, Rec=9, [Int]=9, Wis=10, Luc=12 WHERE Family=@i AND Job=2 AND [Level]>1 AND Del=0 AND Grow>0',N'@i tinyint',@i
        exec sp_executesql N'UPDATE PS_GameData.dbo.Chars SET [Str]=7, Dex=9, Rec=9, [Int]=17, Wis=14, Luc=9 WHERE Family=@i AND Job=4 AND [Level]>1 AND Del=0 AND Grow>0',N'@i tinyint',@i
        exec sp_executesql N'UPDATE PS_GameData.dbo.Chars SET [Str]=8, Dex=9, Rec=10, [Int]=14, Wis=16, Luc=8 WHERE Family=@i AND Job=5 AND [Level]>1 AND Del=0 AND Grow>0',N'@i tinyint',@i
    end

    if @i=3
    begin
        exec sp_executesql N'UPDATE PS_GameData.dbo.Chars SET [Str]=16, Dex=12, Rec=11, [Int]=8, Wis=7, Luc=11 WHERE Family=@i AND Job=0 AND [Level]>1 AND Del=0 AND Grow>0',N'@i tinyint',@i
        exec sp_executesql N'UPDATE PS_GameData.dbo.Chars SET [Str]=12, Dex=9, Rec=14, [Int]=10, Wis=10, Luc=10 WHERE Family=@i AND Job=1 AND [Level]>1 AND Del=0 AND Grow>0',N'@i tinyint',@i
        exec sp_executesql N'UPDATE PS_GameData.dbo.Chars SET [Str]=13, Dex=10, Rec=12, [Int]=7, Wis=10, Luc=13 WHERE Family=@i AND Job=3 AND [Level]>1 AND Del=0 AND Grow>0',N'@i tinyint',@i
    end
    
    SET @i = @i + 1;
end


/*************************************************************
 *  Add class specific bonus status points gained each level  *
 *************************************************************/

UPDATE PS_GameData.dbo.Chars SET [Str] = (
	CASE 
		WHEN Family=0 AND Job=0 THEN [STR] + ([Level]-1)
		WHEN Family=3 AND Job=0 THEN [STR] + ([Level]-1) ELSE [Str] END),
	Rec = (
	CASE
		WHEN Family=0 AND Job=1 THEN Rec + ([Level]-1)
		WHEN Family=3 AND Job=1 THEN Rec + ([Level]-1) ELSE Rec END),
	Dex = (
	CASE
		WHEN Family=1 AND Job=2 THEN Dex + ([Level]-1)
		WHEN Family=2 AND Job=2 THEN Dex + ([Level]-1) ELSE Dex END),
	Luc = (
	CASE
		WHEN Family=1 AND Job=3 THEN Luc + ([Level]-1)
		WHEN Family=3 AND Job=3 THEN Luc + ([Level]-1) ELSE Luc END),
	[Int] = (
	CASE
		WHEN Family=1 AND Job=4 THEN [Int] + ([Level]-1)
		WHEN Family=2 AND Job=4 THEN [Int] + ([Level]-1) ELSE [Int] END),
	Wis = (
	CASE
		WHEN Family=0 AND Job=5 THEN Wis + ([Level]-1)
		WHEN Family=2 AND Job=5 THEN Wis + ([Level]-1) ELSE Wis END)
WHERE [Level]>1 AND Del=0 AND Grow<>0


/*******************************************************************
 *  Finally, set Skill * Status Points according to players level  *
 *******************************************************************/

UPDATE PS_GameData.dbo.Chars SET StatPoint=([Level]-1)*(
        CASE Grow 
        WHEN 1 THEN @Stat_NM
        WHEN 2 THEN @Stat_HM
        WHEN 3 THEN @Stat_UM END), 
    SkillPoint = ([Level]-1)*(
        CASE Grow
        WHEN 1 THEN @Skill_NM
        WHEN 2 THEN @Skill_HM
        WHEN 3 THEN @Skill_UM END)
WHERE [Level]>1 AND Del=0 AND Grow>0

/* Let's not forget to clear the skills! */
DELETE FROM PS_GameData.dbo.CharSkills", con)
        con.Open()
        Dim sdr As SqlDataReader = cmd.ExecuteReader()
        ' If the record can be queried, Pass verification and open another form.  
        If MessageBox.Show("Accountdaten erfolgreich geladen.") Then
            Dim mainForm As New ADM

        Else
            MessageBox.Show("Benutzername erfolgreich geändert")

        End If
        Me.Close()
        sdr.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class