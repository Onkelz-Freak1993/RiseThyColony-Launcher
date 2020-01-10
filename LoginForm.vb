Imports System.IO
Imports System.Net
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Web.Script.Serialization

Public Class LoginForm
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = 185
    End Sub

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
                    MainWindow.usernamelbl.Text = "Eingeloggt als " & usernamejson.SelectToken("selectedProfile").SelectToken("name").ToString
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
        ObtainAccessToken(usernametxt.Text, pwdtxt.Text)
    End Sub
End Class