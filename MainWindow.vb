Imports System.ComponentModel
Imports System.Security.Cryptography
Imports System.Environment
Imports System.Net
Imports Shell32
Imports System.IO
Imports Microsoft.Win32

Public Class MainWindow
    Dim isInstalling = False
    Dim TargetPath As String
    Dim extractedModsbefore As Boolean = False
    Dim extractedMusicbefore As Boolean = False
    Dim Params As String = ""
    Dim filesizesha1 As String
    Dim JavaInstalled As Boolean = False

    Public WithEvents Wc As New WebClient
    Public WithEvents Wc2 As New WebClient
    Dim appData As String = GetFolderPath(SpecialFolder.ApplicationData)

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://www.gingolingoo.de/")
    End Sub

    Function isOS64bit()
        If Environment.Is64BitOperatingSystem = True Then
            console.debugcon.AppendText("OS Architecture:            " & "x64" & vbNewLine)
        Else
            console.debugcon.AppendText("OS Architecture:            " & "x86" & vbNewLine)
        End If
        Return True
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        For Each Dir As String In Directory.GetDirectories(appData & "\.minecraft\versions")
            Dim dirInfo As New System.IO.DirectoryInfo(Dir)
            If dirInfo.Name.Contains("forge") Then
                settings.SelectedGameVersion.Items.Add(dirInfo.Name)
                settings.SelectedGameVersion.SelectedItem = dirInfo.Name
            End If
        Next


        Try
            My.Settings.JavaPath = GetJavaInstallationPath.ToString & "\bin\javaw.exe"
            settings.javapathtxt.Text = My.Settings.JavaPath
        Catch ex As Exception
            Dim Response As String
            Response = MsgBox("Die Java Laufzeitumgebung wurde nicht automatisch gefunden. " &
                              "Um Minecraft starten zu können, muss die Ausführbare Datei von Java (javaw.exe) in den Java-Optionen angegeben werden. " &
                              "Üblicherweise befindet diese sich unter:" & vbNewLine & "'C:\Program Files\Java\jre-<versionsnummer>\bin\javaw.exe'." & vbNewLine & vbNewLine &
                              "Ja = Java ist installiert, ich zeig dir wo..." & vbNewLine &
                              "Nein - Java ist nicht installiert, bitte installieren...", vbYesNo, "Java wurde nicht automatisch gefunden.")
            If Response = vbYes Then
                JavaInstalled = True
                Try
                    settings.OpenFileDialog1.ShowDialog()
                    settings.javapathtxt.Text = settings.OpenFileDialog1.FileName
                Catch
                    JavaInstalled = False
                End Try
            ElseIf Response = vbNo Then
                JavaInstalled = False
            End If
        End Try
        ExecuteParams()
        settings.installpathtxt.Text = My.Settings.installpath
        versionlbl.Text = My.Application.Info.Version.ToString

        filesizesha1 = getSHA1Hash(GetDownloadSize("https://www.gingolingoo.de/files/Symphonia.zip"))
        console.debugcon.AppendText(My.Computer.Clock.LocalTime.ToString & vbNewLine & vbNewLine)
        console.debugcon.AppendText("OS Full Name:               " & My.Computer.Info.OSFullName & vbNewLine)
        console.debugcon.AppendText("OS Platform:                " & My.Computer.Info.OSPlatform & vbNewLine)
        isOS64bit()
        console.debugcon.AppendText("OS Version:                 " & My.Computer.Info.OSVersion & vbNewLine)
        console.debugcon.AppendText("UI Culture:                 " & My.Computer.Info.InstalledUICulture.ToString & vbNewLine)
        console.debugcon.AppendText("Total Physical Memory:      " & My.Computer.Info.TotalPhysicalMemory & " bytes (" & Math.Round(My.Computer.Info.TotalPhysicalMemory / 1024 ^ 3, 1) & " GB)" & vbNewLine)
        console.debugcon.AppendText("Total Virtual Memory:       " & My.Computer.Info.TotalVirtualMemory & " bytes (" & Math.Round(My.Computer.Info.TotalVirtualMemory / 1024 ^ 3, 1) & " GB)" & vbNewLine & vbNewLine)
        console.debugcon.AppendText("Installer Version:          " & My.Application.Info.Version.ToString & vbNewLine)
        console.debugcon.AppendText("CommandLineArgs:           " & Params.ToString & vbNewLine & vbNewLine)
        console.debugcon.AppendText("Installed SHA1:             " & My.Settings.SHA1.ToString & vbNewLine)
        console.debugcon.AppendText("Serverfile SHA1:            " & filesizesha1.ToString & vbNewLine)
        console.debugcon.AppendText("Serverfile Size:            " & GetDownloadSize("https://www.gingolingoo.de/files/Symphonia.zip") & " bytes (" & Math.Round(GetDownloadSize("https://www.gingolingoo.de/files/Symphonia.zip") / 1024 ^ 2, 1) & " MB)" & vbNewLine & vbNewLine)

        If My.Settings.SHA1 = filesizesha1.ToString Then
            playbtn.Text = "Spielen"
        Else
            playbtn.Text = "Update"
        End If

    End Sub

    Public Sub ExecuteParams()
        Dim args As String()
        args = Environment.GetCommandLineArgs()

        'bei 1 starten, weil das Programm IMMER seinen eigenen 
        'FULLPATH als ersten Parameter erkennt!
        For i As Integer = 1 To args.Length - 1
            Select Case args(i).ToLower

                Case "debug"
                    Params = Params & " debug"
                    consolebtn.Visible = True
                    console.Show()
                    consoletsmenu.Visible = True
                    dividertsmenu.Visible = True
                    showtsmenu.Visible = True

                Case "invis"
                    Params = Params & " invis"
                    playbtn.PerformClick()
                    Me.Hide()
                    Me.ShowInTaskbar = False

                Case Else
                    MessageBox.Show("Unbekannter Parameter:" & vbCrLf & args(i), "Unbekannt!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Application.Exit()
            End Select
        Next
        My.Settings.Params = Params
    End Sub

    Private Sub playbtn_Click(sender As Object, e As EventArgs) Handles playbtn.Click
        Dim Response As String

        If playbtn.Text = "Spielen" Then
            'playbtn.Text = "Schließen"
            'playbtn.PerformClick()
            startMinecraft()
            'Process.Start("java -Xms512m -Xmx4G -Djava.library.path=natives/ -cp 'minecraft.jar;lwjgl.jar;lwjgl_util.jar' net.minecraft.client.Minecraft <username> <sessionID>")

        ElseIf playbtn.Text = "Schließen" Then
            MsgBox("Du kannst jetzt über den Minecraft Launcher spielen." & vbNewLine & vbNewLine & "HINWEIS: Stelle Sicher, dass du den gleichen Pfad im Launcher-Spielprofil hinterlegt hast, wie du auch hier im Installer angegeben hast.")
            Me.Close()
        ElseIf playbtn.Text = "Update" Then
            Try
                If My.Settings.installpath = "" Then
                    console.debugcon.AppendText("InstallPath:   " & "none" & vbNewLine)
                    Response = MsgBox("Es wurde noch kein Installationspfad gesetzt. Soll der Standard Minecraftpfad verwendet werden?" & vbNewLine & vbNewLine & "HINWEIS: Es wird ausdrücklich empfohlen, ein eigenes Profil mit eigenem Ordner in Minecraft anzulegen.", vbYesNoCancel, "Installationspfad nicht gesetzt.")
                    If Response = vbYes Then
                        My.Settings.installpath = appData & "\.minecraft"
                    ElseIf Response = vbNo Then
                        FolderBrowserDialog1.ShowDialog()
                        My.Settings.installpath = FolderBrowserDialog1.SelectedPath

                    ElseIf Response = vbCancel Then
                        MsgBox("Kein Installationspfad festgelegt. Programm wird beendet.")
                        Application.Exit()
                    End If
                    console.debugcon.AppendText("New InstallPath: " & My.Settings.installpath & vbNewLine)
                End If
                If My.Settings.installpath = "" Then
                    MsgBox("Kein Installationspfad festgelegt. Programm wird beendet.")
                    Application.Exit()
                End If
                settings.installpathtxt.Text = My.Settings.installpath
            Catch ex As Exception

            End Try
            My.Settings.Save()
            console.debugcon.AppendText("InstallPath: " & My.Settings.installpath & vbNewLine)
            console.debugcon.AppendText("Starting download..." & vbNewLine)
            downloadModpack()
        Else
            MsgBox("Es ist ein Fehler aufgetreten. Starte den Installer bitte erneut.")
            Me.Close()
        End If
    End Sub

    Function startMinecraft()
        Dim p As New Process
        Dim appData As String = GetFolderPath(SpecialFolder.ApplicationData)
        Dim Root As String = appData & "\.minecraft"
        Dim JavaPath As String = My.Settings.JavaPath

        Try
            p.StartInfo.FileName = "cmd.exe"
            p.StartInfo.Arguments = """" + JavaPath + """" + " -Xms" + settings.Xmstxt.Value.ToString + "M -Xmx" + settings.Xmxtxt.Value.ToString +
            " -XX:HeapDumpPath=MojangTricksIntelDriversForPerformance_javaw.exe_minecraft.exe.heapdump" +
            " -Djava.library.path=" + Root + "\versions\1.12.2\natives\" +
            " -Dminecraft.client.jar=" + Root + "\versions\1.12.2\1.12.2.jar -cp " + Root + "\libraries\net\minecraftforge\forge\" + settings.SelectedGameVersion.Text.ToString + "\forge-" + settings.SelectedGameVersion.Text.ToString + ".jar;" + Root + "\libraries\net\minecraft\launchwrapper\1.12\launchwrapper-1.12.jar;" + Root + "\libraries\org\ow2\asm\asm-all\5.2\asm-all-5.2.jar;" + Root + "\libraries\org\jline\jline\3.5.1\jline-3.5.1.jar;" + Root + "\libraries\net\java\dev\jna\jna\4.4.0\jna-4.4.0.jar;" + Root + "\libraries\com\typesafe\akka\akka-actor_2.11\2.3.3\akka-actor_2.11-2.3.3.jar;" + Root + "\libraries\com\typesafe\config\1.2.1\config-1.2.1.jar;" + Root + "\libraries\org\scala-lang\scala-actors-migration_2.11\1.1.0\scala-actors-migration_2.11-1.1.0.jar;" + Root + "\libraries\org\scala-lang\scala-compiler\2.11.1\scala-compiler-2.11.1.jar;" + Root + "\libraries\org\scala-lang\plugins\scala-continuations-library_2.11\1.0.2\scala-continuations-library_2.11-1.0.2.jar;" + Root + "\libraries\org\scala-lang\plugins\scala-continuations-plugin_2.11.1\1.0.2\scala-continuations-plugin_2.11.1-1.0.2.jar;" + Root + "\libraries\org\scala-lang\scala-library\2.11.1\scala-library-2.11.1.jar;" + Root + "\libraries\org\scala-lang\scala-parser-combinators_2.11\1.0.1\scala-parser-combinators_2.11-1.0.1.jar;" + Root + "\libraries\org\scala-lang\scala-reflect\2.11.1\scala-reflect-2.11.1.jar;" + Root + "\libraries\org\scala-lang\scala-swing_2.11\1.0.1\scala-swing_2.11-1.0.1.jar;" + Root + "\libraries\org\scala-lang\scala-xml_2.11\1.0.2\scala-xml_2.11-1.0.2.jar;" + Root + "\libraries\lzma\lzma\0.0.1\lzma-0.0.1.jar;" + Root + "\libraries\net\sf\jopt-simple\jopt-simple\5.0.3\jopt-simple-5.0.3.jar;" + Root + "\libraries\java3d\vecmath\1.5.2\vecmath-1.5.2.jar;" + Root + "\libraries\net\sf\trove4j\trove4j\3.0.3\trove4j-3.0.3.jar;" + Root + "\libraries\org\apache\maven\maven-artifact\3.5.3\maven-artifact-3.5.3.jar;" + Root + "\libraries\com\mojang\patchy\1.1\patchy-1.1.jar;" + Root + "\libraries\oshi-project\oshi-core\1.1\oshi-core-1.1.jar;" + Root + "\libraries\net\java\dev\jna\jna\4.4.0\jna-4.4.0.jar;" + Root + "\libraries\net\java\dev\jna\platform\3.4.0\platform-3.4.0.jar;" + Root + "\libraries\com\ibm\icu\icu4j-core-mojang\51.2\icu4j-core-mojang-51.2.jar;" + Root + "\libraries\net\sf\jopt-simple\jopt-simple\5.0.3\jopt-simple-5.0.3.jar;" + Root + "\libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + Root + "\libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + Root + "\libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + Root + "\libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + Root + "\libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + Root + "\libraries\io\netty\netty-all\4.1.9.Final\netty-all-4.1.9.Final.jar;" + Root + "\libraries\com\google\guava\guava\21.0\guava-21.0.jar;" + Root + "\libraries\org\apache\commons\commons-lang3\3.5\commons-lang3-3.5.jar;" + Root + "\libraries\commons-io\commons-io\2.5\commons-io-2.5.jar;" + Root + "\libraries\commons-codec\commons-codec\1.10\commons-codec-1.10.jar;" + Root + "\libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + Root + "\libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + Root + "\libraries\com\google\code\gson\gson\2.8.0\gson-2.8.0.jar;" + Root + "\libraries\com\mojang\authlib\1.5.25\authlib-1.5.25.jar;" + Root + "\libraries\com\mojang\realms\1.10.22\realms-1.10.22.jar;" + Root + "\libraries\org\apache\commons\commons-compress\1.8.1\commons-compress-1.8.1.jar;" + Root + "\libraries\org\apache\httpcomponents\httpclient\4.3.3\httpclient-4.3.3.jar;" + Root + "\libraries\commons-logging\commons-logging\1.1.3\commons-logging-1.1.3.jar;" + Root + "\libraries\org\apache\httpcomponents\httpcore\4.3.2\httpcore-4.3.2.jar;" + Root + "\libraries\it\unimi\dsi\fastutil\7.1.0\fastutil-7.1.0.jar;" + Root + "\libraries\org\apache\logging\log4j\log4j-api\2.8.1\log4j-api-2.8.1.jar;" + Root + "\libraries\org\apache\logging\log4j\log4j-core\2.8.1\log4j-core-2.8.1.jar;" + Root + "\libraries\org\lwjgl\lwjgl\lwjgl\2.9.4-nightly-20150209\lwjgl-2.9.4-nightly-20150209.jar;" + Root + "\libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.4-nightly-20150209\lwjgl_util-2.9.4-nightly-20150209.jar;" + Root + "\libraries\com\mojang\text2speech\1.10.3\text2speech-1.10.3.jar;" + Root + "\versions\1.12.2\1.12.2.jar -XX:+UnlockExperimentalVMOptions -XX:+UseG1GC -XX:G1NewSizePercent=20 -XX:G1ReservePercent=20 -XX:MaxGCPauseMillis=50 -XX:G1HeapRegionSize=32M net.minecraft.launchwrapper.Launch" +
            " --username " + My.Settings.currentUser +
            " --version " + settings.SelectedGameVersion.Text.ToString +
            " --gameDir " + Root +
            " --assetsDir " + Root + "\assets\" +
            " --assetIndex 1.12" +
            " --uuid " + My.Settings.userID +
            " --accessToken " + My.Settings.accessToken +
            " --userType mojang --tweakClass net.minecraftforge.fml.common.launcher.FMLTweaker --versionType Forge"
            p.StartInfo.WorkingDirectory = Root
            p.StartInfo.CreateNoWindow = True
            p.StartInfo.UseShellExecute = False
            p.EnableRaisingEvents = True
            Application.DoEvents()
            p.StartInfo.RedirectStandardError = True
            p.StartInfo.RedirectStandardOutput = True
            'AddHandler p.ErrorDataReceived, AddressOf P_OutputDataReceived
            'AddHandler p.OutputDataReceived, AddressOf P_OutputDataReceived
            MsgBox(p.StartInfo.FileName + p.StartInfo.Arguments)
            p.Start()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return True
    End Function

    Public Sub P_OutputDataReceived(ByVal sender As Object, ByVal e As DataReceivedEventArgs)
        MsgBox(e.Data)
        'If e.Data IsNot Nothing Then
        'Invoke(Sub() My.Computer.FileSystem.WriteAllText(Application.StartupPath & "latest.log", e.Data & NewLine, False))
        'My.Computer.FileSystem.WriteAllText(Application.StartupPath & "latest.log", e.Data & NewLine, False)
        'End If
    End Sub

    Private Sub Wc_DownloadProgressChanged(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs) Handles Wc.DownloadProgressChanged
        progress.Value = e.ProgressPercentage
        Dim ibreceived As Double = e.BytesReceived / 1024 ^ 2
        Dim ibtoreceive As Double = e.TotalBytesToReceive / 1024 ^ 2
        progress.Value = e.ProgressPercentage
        progresslbl.Text = Math.Round(ibreceived, 2).ToString("#,##0.00") & "MB von " & Math.Round(ibtoreceive, 2).ToString("#,##0.00") & "MB - " & e.ProgressPercentage & "%"
        playbtn.Text = "Lade herunter... " & e.ProgressPercentage & "%"
        trayicon.Text = "Symphonia Installer - Lade herunter... " & e.ProgressPercentage & "%"
        filenamelbl.Text = TargetPath
        settings.installpathbtn.Enabled = False
        settings.installpathtxt.Enabled = False
        playbtn.Image = Nothing
        playbtn.Enabled = False
        isInstalling = True
    End Sub

    Private Sub Wc_DownloadFileCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs) Handles Wc.DownloadFileCompleted
        isInstalling = False
        settings.installpathbtn.Enabled = True
        settings.installpathtxt.Enabled = True
        playbtn.Enabled = True
        playbtn.Text = "Spielen"
        playbtn.Image = My.Resources.book_writable
        'downloadMusic()
        extractModpack() 'Neue ab Version 2019.12.31.0
    End Sub

    Private Sub Wc2_DownloadProgressChanged(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs) Handles Wc2.DownloadProgressChanged
        progress.Value = e.ProgressPercentage
        Dim ibreceived As Double = e.BytesReceived / 1024 / 1024
        Dim ibtoreceive As Double = e.TotalBytesToReceive / 1024 / 1024
        progress.Value = e.ProgressPercentage
        progresslbl.Text = Math.Round(ibreceived, 2).ToString("#,##0.00") & "MB von " & Math.Round(ibtoreceive, 2).ToString("#,##0.00") & "MB - " & e.ProgressPercentage & "%"
        playbtn.Text = "Lade herunter... " & e.ProgressPercentage & "%"
        filenamelbl.Text = TargetPath
        settings.installpathbtn.Enabled = False
        settings.installpathtxt.Enabled = False
        playbtn.Image = Nothing
        playbtn.Enabled = False
        isInstalling = True
    End Sub

    Private Sub Wc2_DownloadFileCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs) Handles Wc2.DownloadFileCompleted
        isInstalling = False
        settings.installpathbtn.Enabled = True
        settings.installpathtxt.Enabled = True
        playbtn.Enabled = True
        playbtn.Text = "Spielen"
        playbtn.Image = My.Resources.book_writable
        extractModpack()
    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If File.Exists(My.Settings.installpath & "\Symphonia.zip") Then
            My.Computer.FileSystem.DeleteFile(My.Settings.installpath & "\Symphonia.zip")
        End If

        Application.Exit()
        Application.ExitThread()

        'If File.Exists(My.Settings.installpath & "\GSMPNM.zip") Then
        '    My.Computer.FileSystem.DeleteFile(My.Settings.installpath & "\GSMPNM.zip")
        'End If
        'If File.Exists(My.Settings.installpath & "\GSMPJM.zip") Then
        '   My.Computer.FileSystem.DeleteFile(My.Settings.installpath & "\GSMPJM.zip")
        'End If
    End Sub

    Private Sub MainWindow_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim Response As String
        If isInstalling = True Then
            Response = MsgBox("Wirklich abbrechen? Das Modpack muss dann erneut Heruntergeladen und entpackt werden.", vbYesNo, "Installation abbrechen?")
            If Response = vbYes Then
                Wc.CancelAsync()
                Wc2.CancelAsync()
            ElseIf Response = vbNo Then
                e.Cancel = True
            End If
        Else
            'alles in Ordnung
        End If
    End Sub
    Private Function GetJavaInstallationPath() As String
        Dim environmentPath As String = Environment.GetEnvironmentVariable("JAVA_HOME")

        If Not String.IsNullOrEmpty(environmentPath) Then
            Return environmentPath
        End If

        Dim javaKey As String = "SOFTWARE\JavaSoft\JRE\"

        If Not Environment.Is64BitOperatingSystem Then

            Using rk As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(javaKey)
                Dim currentVersion As String = rk.GetValue("CurrentVersion").ToString()

                Using key As Microsoft.Win32.RegistryKey = rk.OpenSubKey(currentVersion)
                    Return key.GetValue("JavaHome").ToString()
                End Using
            End Using
        Else

            Using view64 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64)

                Using clsid64 = view64.OpenSubKey(javaKey)
                    Dim currentVersion As String = clsid64.GetValue("CurrentVersion").ToString()

                    Using key As RegistryKey = clsid64.OpenSubKey(currentVersion)
                        Return key.GetValue("JavaHome").ToString()
                    End Using
                End Using
            End Using
        End If
    End Function

    Function downloadModpack()
        AddHandler Wc.DownloadProgressChanged, AddressOf Wc_DownloadProgressChanged
        AddHandler Wc.DownloadFileCompleted, AddressOf Wc_DownloadFileCompleted
        If File.Exists(My.Settings.installpath & "\Symphonia.zip") Then
            My.Computer.FileSystem.DeleteFile(My.Settings.installpath & "\Symphonia.zip")
        End If
        'If File.Exists(My.Settings.installpath & "\GSMPNM.zip") Then
        '   My.Computer.FileSystem.DeleteFile(My.Settings.installpath & "\GSMPNM.zip")
        'End If
        TargetPath = My.Settings.installpath & "\Symphonia.zip"
        'TargetPath = My.Settings.installpath & "\GSMPNM.zip"
        console.debugcon.AppendText("Downloading zipfile To " & TargetPath & vbNewLine)
        Wc.DownloadFileAsync(New Uri("https://www.gingolingoo.de/files/Symphonia.zip"), TargetPath)
        'Wc.DownloadFileAsync(New Uri("https://www.gingolingoo.de/files/GSMPNM.zip"), TargetPath)
        playbtn.Image = Nothing
        settings.installpathbtn.Enabled = False
        settings.installpathtxt.Enabled = False
        repairbtn.Enabled = False
        playbtn.Enabled = False
        isInstalling = True
        Return Nothing
    End Function

    Function downloadMusic()
        If Not Wc2.IsBusy Then
            Dim Response As String
            Response = MsgBox("Soll die Ambientmusik heruntergeladen werden? Sie ist nicht notwendig, aber verbessert das Spielerlebnis erheblich." & vbNewLine & vbNewLine & "Ungefähre Größe: 300 Megabyte", vbYesNo, "Musik installieren?")
            If Response = vbYes Then
                AddHandler Wc2.DownloadProgressChanged, AddressOf Wc2_DownloadProgressChanged
                AddHandler Wc2.DownloadFileCompleted, AddressOf Wc2_DownloadFileCompleted
                If File.Exists(My.Settings.installpath & "\GSMPJM.zip") Then
                    My.Computer.FileSystem.DeleteFile(My.Settings.installpath & "\GSMPJM.zip")
                End If
                TargetPath = My.Settings.installpath & "\GSMPJM.zip"
                Wc2.DownloadFileAsync(New Uri("https://www.gingolingoo.de/files/GSMPJM.zip"), TargetPath)
                playbtn.Image = Nothing
                playbtn.Enabled = False
                settings.installpathbtn.Enabled = False
                settings.installpathtxt.Enabled = False
                isInstalling = True
            ElseIf Response = vbNo Then
                playbtn.Enabled = True
                settings.installpathbtn.Enabled = True
                settings.installpathtxt.Enabled = True
                repairbtn.Enabled = True
                playbtn.Text = "Spielen"
                playbtn.Image = My.Resources.book_writable
                extractModpack()
            End If
        End If
        Return Nothing
    End Function

    Function extractModpack()
        If extractedModsbefore = True Then
            'Workaround für doppeltes entpacken - Schlampig, aber nötig, bis ich ne bessere Lösung habe!
        Else
            Try
                If Not File.Exists(My.Settings.installpath & "\Symphonia.zip") Then
                    'If Not File.Exists(My.Settings.installpath & "\GSMPNM.zip") Then
                    'keine Daten da zum Entpacken O.o Wie kann das passieren?!
                Else
                    If Not Directory.Exists(My.Settings.installpath & "\mods\") Then
                        console.debugcon.AppendText("Folder 'mods' does not exist, moving on..." & vbNewLine)
                        'Ordner gibts nicht
                    Else
                        playbtn.Text = "Lösche Mods... "
                        console.debugcon.AppendText("Deleting Folder 'mods'..." & vbNewLine)
                        Directory.Delete(My.Settings.installpath & "\mods\", True)
                    End If

                    If Not Directory.Exists(My.Settings.installpath & "\config\") Then

                        console.debugcon.AppendText("Folder 'config' does not exist, moving on..." & vbNewLine)
                        'Ordner gibts nicht
                    Else
                        playbtn.Text = "Lösche Configs... "
                        console.debugcon.AppendText("Deleting Folder 'config'..." & vbNewLine)
                        Directory.Delete(My.Settings.installpath & "\config\", True)
                    End If

                    If Not Directory.Exists(My.Settings.installpath & "\resources\") Then

                        console.debugcon.AppendText("Folder 'resources' does not exist, moving on..." & vbNewLine)
                        'Ordner gibts nicht
                    Else
                        playbtn.Text = "Lösche Resourcen... "
                        console.debugcon.AppendText("Deleting Folder 'resources'..." & vbNewLine)
                        Directory.Delete(My.Settings.installpath & "\resources\", True)
                    End If

                    If Not File.Exists(My.Settings.installpath & "\options.txt") Then
                        console.debugcon.AppendText("File 'options.txt' does not exist, moving on..." & vbNewLine)
                        'Datei gibts nicht
                    Else
                        playbtn.Text = "Lösche options.txt... "
                        console.debugcon.AppendText("Deleting file 'options.txt'..." & vbNewLine)
                        My.Computer.FileSystem.DeleteFile(My.Settings.installpath & "\options.txt")
                    End If

                    If Not File.Exists(My.Settings.installpath & "\servers.dat") Then
                        console.debugcon.AppendText("File 'servers.dat' does not exist, moving on..." & vbNewLine)
                        'Datei gibts nicht
                    Else
                        playbtn.Text = "Lösche servers.dat... "
                        console.debugcon.AppendText("Deleting file 'servers.dat'..." & vbNewLine)
                        My.Computer.FileSystem.DeleteFile(My.Settings.installpath & "\servers.dat")
                    End If

                    Me.Enabled = False
                    playbtn.Text = "Entpacke Mods... "
                    settings.installpathbtn.Enabled = False
                    settings.installpathtxt.Enabled = False
                    playbtn.Image = Nothing
                    playbtn.Enabled = False
                    isInstalling = True
                    console.debugcon.AppendText("Extracting " & My.Settings.installpath & "\Symphonia.zip" & vbNewLine)
                    ExtractZipFileToContainingFolder(My.Settings.installpath & "\Symphonia.zip")
                    'ExtractZipFileToContainingFolder(My.Settings.installpath & "\GSMPNM.zip")
                    extractedModsbefore = True
                End If
                'extractMusic()
                console.debugcon.AppendText("Setting SHA1 Hash " & filesizesha1 & " as installed version" & vbNewLine)
                My.Settings.SHA1 = filesizesha1
                console.debugcon.AppendText("Finished downloading zipfile to " & TargetPath & vbNewLine)
                playbtn.Text = "Schließe ab... "
                'MsgBox("Fertig! :)")
                Me.Enabled = True
                playbtn.Text = "Schließen"
            Catch exc As Exception
                console.debugcon.AppendText("Extraction failed: " & exc.ToString & vbNewLine)
                MsgBox(exc.ToString)
            End Try
        End If
        If Params.Contains("invis") Then
            Me.Close()
        End If
        Return Nothing
    End Function

    Function extractMusic()
        If extractedMusicbefore = True Then
            'Workaround für doppeltes entpacken - Schlampig, aber nötig, bis ich ne bessere Lösung habe!
        Else
            Try
                If Not File.Exists(My.Settings.installpath & "\GSMPJM.zip") Then
                    'keine Musik da zum Entpacken :(
                Else

                    If Not Directory.Exists(My.Settings.installpath & "\ambience_music\") Then
                        'Ordner gibts nicht
                    Else
                        playbtn.Text = "Lösche Musik... "
                        Directory.Delete(My.Settings.installpath & "\ambience_music\", True)
                    End If

                    playbtn.Text = "Entpacke Musik... "
                    settings.installpathbtn.Enabled = False
                    settings.installpathtxt.Enabled = False
                    playbtn.Image = Nothing
                    playbtn.Enabled = False
                    isInstalling = True

                    ExtractZipFileToContainingFolder(My.Settings.installpath & "\GSMPJM.zip")
                    extractedMusicbefore = True
                End If
            Catch exc As Exception
                MsgBox(exc.ToString)
            End Try
        End If
        Return Nothing
    End Function
    Function getSHA1Hash(ByVal strToHash As String) As String
        Dim sha1Obj As New SHA1CryptoServiceProvider
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)
        bytesToHash = sha1Obj.ComputeHash(bytesToHash)
        Dim strResult As String = ""
        For Each b As Byte In bytesToHash
            strResult += b.ToString("x2")
        Next
        Return strResult
    End Function
    Public Function GetDownloadSize(ByVal URL As String) As Long
        Dim r As WebRequest = WebRequest.Create(URL)
        r.Method = WebRequestMethods.Http.Head
        Using rsp = r.GetResponse()
            Return rsp.ContentLength
        End Using
    End Function

    Sub ExtractZipFileToContainingFolder(ByVal ZipFile As String)
        Dim Shl As New Shell
        Dim ExtractFolder As Folder = Shl.NameSpace(Path.GetDirectoryName(ZipFile))
        Dim ZipFolder As Folder = Shl.NameSpace(ZipFile)
        ExtractFolder.CopyHere(ZipFolder.Items)
    End Sub

    Private Sub filenamelbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles filenamelbl.LinkClicked
        Process.Start(My.Settings.installpath)
    End Sub

    Private Sub consolebtn_Click(sender As Object, e As EventArgs) Handles consolebtn.Click
        console.Show()
    End Sub

    Private Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles closetsmenu.Click
        Me.Close()
    End Sub

    Private Sub AnzeigenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles showtsmenu.Click
        Me.Show()
    End Sub

    Private Sub KonsoleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles consoletsmenu.Click
        console.Show()
    End Sub

    Private Sub repairbtn_Click(sender As Object, e As EventArgs) Handles repairbtn.Click
        playbtn.Text = "Update"
        playbtn.PerformClick()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        settings.Show()
    End Sub

    Private Sub MainWindow_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.accessToken = Nothing
        My.Settings.clientToken = Nothing
        My.Settings.userID = Nothing
        My.Settings.currentUser = Nothing
        My.Settings.currentUser = Nothing
        My.Settings.resultJson = Nothing

        My.Settings.Save()
    End Sub

    Private Sub BenutzerWechselnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BenutzerWechselnToolStripMenuItem.Click
        Dim Response As String
        If isInstalling = True Then
            Response = MsgBox("Wirklich abbrechen? Das Modpack muss dann erneut Heruntergeladen und entpackt werden.", vbYesNo, "Installation abbrechen?")
            If Response = vbYes Then
                Me.Hide()
                LoginForm.Show()
            ElseIf Response = vbNo Then
                'Nicht abmelden, Fortsetzen
            End If
        Else
            Me.Hide()
            LoginForm.Show()
        End If
    End Sub

    Private Sub BeendenToolStripMenuItem_Click_2(sender As Object, e As EventArgs) Handles BeendenToolStripMenuItem.Click
        Dim Response As String
        If isInstalling = True Then
            Response = MsgBox("Wirklich abbrechen? Das Modpack muss dann erneut Heruntergeladen und entpackt werden.", vbYesNo, "Installation abbrechen?")
            If Response = vbYes Then
                Application.Exit()
                Application.ExitThread()
            ElseIf Response = vbNo Then
                'Nicht beenden, Fortsetzen
            End If
        Else
            Application.Exit()
            Application.ExitThread()
        End If
    End Sub
End Class