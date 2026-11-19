Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Globalization
Imports System.Security.Cryptography
Imports System.Text
Imports System.Windows.Forms

Public Module Database
    Private Const PasswordIterations As Integer = 100000
    Private Const ProtectedPrefix As String = "dpapi:"

    Public Function CreateConnection() As SqlConnection
        Return New SqlConnection(CurrentConnectionString())
    End Function

    Public Function CurrentConnectionString() As String
        Dim password = UnprotectCredential(My.Settings.Passwort)
        If Not String.IsNullOrEmpty(My.Settings.Passwort) AndAlso Not My.Settings.Passwort.StartsWith(ProtectedPrefix, StringComparison.Ordinal) Then
            My.Settings.Passwort = ProtectCredential(password)
            My.Settings.Save()
        End If
        Return BuildConnectionString(My.Settings.Server, My.Settings.Port, My.Settings.Benutzer, password)
    End Function

    Public Function BuildConnectionString(server As String, port As String, userName As String, password As String) As String
        Dim dataSource = server.Trim()
        If Not String.IsNullOrWhiteSpace(port) Then dataSource &= "," & port.Trim()

        Dim builder As New SqlConnectionStringBuilder With {
            .DataSource = dataSource,
            .InitialCatalog = "PS_UserData",
            .UserID = userName,
            .Password = password,
            .PersistSecurityInfo = False
        }
        Return builder.ConnectionString
    End Function

    Public Function SqlEscape(value As Object) As String
        If value Is Nothing OrElse value Is DBNull.Value Then Return String.Empty
        Return Convert.ToString(value, CultureInfo.InvariantCulture).Replace("'", "''")
    End Function

    Public Function SqlNumber(value As String, fieldName As String) As String
        Dim number As Decimal
        Dim styles = NumberStyles.AllowLeadingSign Or NumberStyles.AllowDecimalPoint
        If Not Decimal.TryParse(value, styles, CultureInfo.CurrentCulture, number) AndAlso
           Not Decimal.TryParse(value, styles, CultureInfo.InvariantCulture, number) Then
            Throw New FormatException(fieldName & " muss eine Zahl sein.")
        End If
        Return number.ToString(CultureInfo.InvariantCulture)
    End Function

    Public Sub ShowError(ex As Exception)
        MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Public Function ProtectCredential(value As String) As String
        If String.IsNullOrEmpty(value) OrElse value.StartsWith(ProtectedPrefix, StringComparison.Ordinal) Then Return value
        Dim protectedBytes = ProtectedData.Protect(Encoding.UTF8.GetBytes(value), Nothing, DataProtectionScope.CurrentUser)
        Return ProtectedPrefix & Convert.ToBase64String(protectedBytes)
    End Function

    Public Function UnprotectCredential(value As String) As String
        If String.IsNullOrEmpty(value) OrElse Not value.StartsWith(ProtectedPrefix, StringComparison.Ordinal) Then Return value
        Dim protectedBytes = Convert.FromBase64String(value.Substring(ProtectedPrefix.Length))
        Return Encoding.UTF8.GetString(ProtectedData.Unprotect(protectedBytes, Nothing, DataProtectionScope.CurrentUser))
    End Function

    Public Function AuthenticateAdmin(userName As String, password As String, minimumRights As Integer) As Boolean
#If DEBUG Then
        RunSecuritySelfTest()
#End If
        Using connection = CreateConnection()
            connection.Open()
            Dim supportsPasswordHashes = EnsurePasswordColumn(connection)

            Dim storedPassword As String = Nothing
            Using command As New SqlCommand("SELECT Passwort FROM ADM_Tool.dbo.Account WHERE Benutzer=@user AND Rechte>@rights", connection)
                command.Parameters.Add("@user", SqlDbType.VarChar, 30).Value = userName
                command.Parameters.Add("@rights", SqlDbType.Int).Value = minimumRights
                Dim result = command.ExecuteScalar()
                If result IsNot Nothing AndAlso result IsNot DBNull.Value Then storedPassword = CStr(result)
            End Using

            LogLoginAttempt(connection, userName)
            If storedPassword Is Nothing OrElse Not VerifyPassword(password, storedPassword) Then Return False

            If supportsPasswordHashes AndAlso Not storedPassword.StartsWith("pbkdf2$", StringComparison.Ordinal) Then
                UpdateAdminPassword(connection, userName, HashPassword(password))
            End If
            Return True
        End Using
    End Function

    Public Function ChangeAdminPassword(userName As String, currentPassword As String, newPassword As String) As Boolean
        Using connection = CreateConnection()
            connection.Open()
            Dim supportsPasswordHashes = EnsurePasswordColumn(connection)

            Dim storedPassword As String = Nothing
            Using command As New SqlCommand("SELECT Passwort FROM ADM_Tool.dbo.Account WHERE Benutzer=@user", connection)
                command.Parameters.Add("@user", SqlDbType.VarChar, 30).Value = userName
                Dim result = command.ExecuteScalar()
                If result IsNot Nothing AndAlso result IsNot DBNull.Value Then storedPassword = CStr(result)
            End Using

            If storedPassword Is Nothing OrElse Not VerifyPassword(currentPassword, storedPassword) Then Return False
            UpdateAdminPassword(connection, userName, If(supportsPasswordHashes, HashPassword(newPassword), newPassword))
            Return True
        End Using
    End Function

    Private Function EnsurePasswordColumn(connection As SqlConnection) As Boolean
        Try
            Const sql = "IF COL_LENGTH('ADM_Tool.dbo.Account','Passwort') < 256 ALTER TABLE ADM_Tool.dbo.Account ALTER COLUMN Passwort varchar(256) NOT NULL"
            Using command As New SqlCommand(sql, connection)
                command.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As SqlException
            My.Application.Log.WriteException(ex, TraceEventType.Warning, "Die Passwortspalte konnte nicht automatisch erweitert werden.")
            Return False
        End Try
    End Function

    Private Sub LogLoginAttempt(connection As SqlConnection, userName As String)
        Const sql = "INSERT INTO ADM_Tool.dbo.Login ([UserID],[Password],[IP],[Date]) VALUES (@user,'','127.0.0.1',GETDATE())"
        Using command As New SqlCommand(sql, connection)
            command.Parameters.Add("@user", SqlDbType.NChar, 20).Value = userName
            command.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub UpdateAdminPassword(connection As SqlConnection, userName As String, passwordHash As String)
        Using command As New SqlCommand("UPDATE ADM_Tool.dbo.Account SET Passwort=@password WHERE Benutzer=@user", connection)
            command.Parameters.Add("@password", SqlDbType.VarChar, 256).Value = passwordHash
            command.Parameters.Add("@user", SqlDbType.VarChar, 30).Value = userName
            command.ExecuteNonQuery()
        End Using
    End Sub

    Private Function HashPassword(password As String) As String
        Dim salt(15) As Byte
        Using random = RandomNumberGenerator.Create()
            random.GetBytes(salt)
        End Using
        Using derive As New Rfc2898DeriveBytes(password, salt, PasswordIterations, HashAlgorithmName.SHA256)
            Return "pbkdf2$" & PasswordIterations & "$" & Convert.ToBase64String(salt) & "$" & Convert.ToBase64String(derive.GetBytes(32))
        End Using
    End Function

    Private Function VerifyPassword(password As String, storedPassword As String) As Boolean
        If Not storedPassword.StartsWith("pbkdf2$", StringComparison.Ordinal) Then
            Return String.Equals(password, storedPassword.TrimEnd(), StringComparison.Ordinal)
        End If

        Dim parts = storedPassword.Split("$"c)
        If parts.Length <> 4 Then Return False
        Dim iterations As Integer
        If Not Integer.TryParse(parts(1), iterations) Then Return False

        Dim salt = Convert.FromBase64String(parts(2))
        Dim expected = Convert.FromBase64String(parts(3))
        Using derive As New Rfc2898DeriveBytes(password, salt, iterations, HashAlgorithmName.SHA256)
            Dim actual = derive.GetBytes(expected.Length)
            Dim different As Integer = actual.Length Xor expected.Length
            For index = 0 To Math.Min(actual.Length, expected.Length) - 1
                different = different Or (actual(index) Xor expected(index))
            Next
            Return different = 0
        End Using
    End Function

    <Conditional("DEBUG")>
    Private Sub RunSecuritySelfTest()
        Debug.Assert(SqlEscape("' OR 1=1--") = "'' OR 1=1--")
        Dim passwordHash = HashPassword("Test-Passwort")
        Debug.Assert(VerifyPassword("Test-Passwort", passwordHash))
        Debug.Assert(Not VerifyPassword("falsch", passwordHash))
    End Sub
End Module
