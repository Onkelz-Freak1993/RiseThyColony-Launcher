Imports System.IO
Imports System.Net
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Web.Script.Serialization
Imports System.Security.Cryptography
Imports System.Security.Cryptography.TripleDES
Imports System.Text

Public Class LoginForm

    Private Sub LoginForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
        Application.ExitThread()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        MainWindow.Show()
        MainWindow.usernamelbl.Text = "Offlinemodus"
    End Sub

    Public Sub ObtainAccessToken(username As String, password As String)
        Dim UUID As String = Guid.NewGuid.ToString()
        Dim httpWebRequest = DirectCast(WebRequest.Create("https://authserver.mojang.com/authenticate"), HttpWebRequest)
        httpWebRequest.ContentType = "application/json"
        httpWebRequest.Method = "POST"

        Using streamWriter = New StreamWriter(httpWebRequest.GetRequestStream())
            Dim json As String = (Convert.ToString((Convert.ToString("{""agent"":{""name"":""Minecraft"",""version"":1},""username"":""") & username) + """,""password"":""") & password) + """,""clientToken"":" & ControlChars.Quote & UUID & ControlChars.Quote & "}"

            streamWriter.Write(json)
            streamWriter.Flush()
            streamWriter.Close()

            Try
                Dim httpResponse = DirectCast(httpWebRequest.GetResponse(), HttpWebResponse)
                Using streamReader = New StreamReader(httpResponse.GetResponseStream())
                    Dim result = streamReader.ReadToEnd()
                    ACCESS_TOKEN = result
                    My.Settings.resultJson = result
                    Dim Serializer As JavaScriptSerializer = New JavaScriptSerializer()
                    Dim Dictionary As Dictionary(Of String, Object) = Serializer.Deserialize(Of Dictionary(Of String, Object))(result)
                    Dim loginResponse = JsonConvert.DeserializeObject(Of RootObject)(result)
                    Dim AccessToken As String = Dictionary("accessToken")
                    Dim ClientToken As String = Dictionary("clientToken")
                    My.Settings.accessToken = AccessToken
                    My.Settings.clientToken = ClientToken
                    Dim usernamejson As JObject = JObject.Parse(result)
                    MainWindow.usernamelbl.Text = usernamejson.SelectToken("selectedProfile").SelectToken("name").ToString
                    My.Settings.currentUser = usernamejson.SelectToken("selectedProfile").SelectToken("name").ToString
                    My.Settings.userID = usernamejson.SelectToken("selectedProfile").SelectToken("id").ToString
                End Using
                If Not My.Settings.accessToken = Nothing Then
                    Me.Hide()
                    MainWindow.Show()
                End If
            Catch ex As Exception
                MsgBox("E-Mail oder Passwort falsch." & vbNewLine & vbNewLine & "Fehlercode:" & vbNewLine & ex.ToString)
            End Try
        End Using
    End Sub
    Public Class SelectedProfile
        Public Property name As String
        Public Property id As String
    End Class

    Public Class AvailableProfile
        Public Property name As String
        Public Property id As String
    End Class

    Public Class RootObject
        Public Property accessToken As String
        Public Property selectedProfile As SelectedProfile
        Public Property clientToken As String
        Public Property availableProfiles As List(Of AvailableProfile)
    End Class

    Private ACCESS_TOKEN As String
    Public Function GetAccessToken() As String
        Return ACCESS_TOKEN
    End Function

    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        If saveCedentialschkbox.CheckState = CheckState.Checked Then
            My.Settings.credentialssaved = True
            Dim usernameencrypt As String = EncryptCredentials(usernametxt.Text)
            My.Settings.usernamecrypt = usernameencrypt
            Dim passwordencrypt As String = EncryptCredentials(pwdtxt.Text)
            My.Settings.passwordcrypt = passwordencrypt
        Else
            My.Settings.credentialssaved = False
            My.Settings.usernamecrypt = Nothing
            My.Settings.passwordcrypt = Nothing
        End If
        Me.Enabled = False
        ObtainAccessToken(usernametxt.Text, pwdtxt.Text)
        Me.Enabled = True
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles saveCedentialschkbox.CheckedChanged
        If saveCedentialschkbox.CheckState = CheckState.Checked Then
            If My.Settings.seenwarningcredentials = False Then
                MsgBox("Die Daten werden zwar doppelt verschlüsselt, allerdings werden sie auf dem Computer gespeichert. Andere Nutzer könnten (mit entsprechendem Know-How) die Daten entschlüsseln und E-Mail sowie Passwort in Klartext anzeigen lassen. Benutzung auf eigene Gefahr.", vbInformation, "ACHTUNG!")
                My.Settings.seenwarningcredentials = True
            Else
                'nix
            End If
        End If
    End Sub

    Public Function EncryptCredentials(clearText As String) As String
        Dim EncryptionKey As String = "$kldfKFSAK37236780!!*+++hHUDO723BNU!$hask+*jhds7!2929j$+jP*!hWrT$kldfKFSAK37236780!!*+++hHUDO723BNU!$hask+*jhds7!2929j$+jP*!hWrT"
        Dim clearBytes As Byte() = Encoding.Unicode.GetBytes(clearText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D, &H65, &H64, &H76, &H65, &H64, &H65, &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)

            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write)
                    cs.Write(clearBytes, 0, clearBytes.Length)
                    cs.Close()
                End Using
                clearText = Convert.ToBase64String(ms.ToArray())
            End Using
        End Using
        Return clearText
    End Function

    Public Function DecryptCredentials(cipherText As String) As String
        Dim EncryptionKey As String = "$kldfKFSAK37236780!!*+++hHUDO723BNU!$hask+*jhds7!2929j$+jP*!hWrT$kldfKFSAK37236780!!*+++hHUDO723BNU!$hask+*jhds7!2929j$+jP*!hWrT"
        Dim cipherBytes As Byte() = Convert.FromBase64String(cipherText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D, &H65, &H64, &H76, &H65, &H64, &H65, &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)

            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write)
                    cs.Write(cipherBytes, 0, cipherBytes.Length)
                    cs.Close()
                End Using
                cipherText = Encoding.Unicode.GetString(ms.ToArray())
            End Using
        End Using
        Return cipherText
    End Function

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.credentialssaved = True Then
            saveCedentialschkbox.CheckState = CheckState.Checked
            Dim usernamedecrypt As String = DecryptCredentials(My.Settings.usernamecrypt)
            Dim passworddecrypt As String = DecryptCredentials(My.Settings.passwordcrypt)
            usernametxt.Text = usernamedecrypt
            pwdtxt.Text = passworddecrypt
        End If
    End Sub
End Class