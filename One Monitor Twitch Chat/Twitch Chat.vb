Imports System.ComponentModel
Imports System.IO
Imports Microsoft.Win32
Imports System.Web

Public Class Twitch_Chat
    'Declarations

    Dim file As System.IO.StreamWriter
    Public Declare Function GetAsyncKeyState Lib "user32.dll" (ByVal vKey As Int32) As UShort
    Private Const WS_EX_TRANSPARENT As Integer = &H20

    Public Declare Function SetWindowPos Lib "user32" (ByVal hwnd As Long, ByVal hWndInsertAfter As Long,
  ByVal X As Long, ByVal Y As Long, ByVal cx As Long, ByVal cy As Long, ByVal wFlags As Long) As Long

    Public Const HWND_TOPMOST = -1
    Public Const HWND_NOTOPMOST = -2
    Public Const SWP_NOMOVE = &H2
    Public Const SWP_NOSIZE = &H1

    'First Run, Updater, Input Username.Show, My.Settings
    Private Sub Twitch_Chat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForUpdates()
        Timer1.Enabled = True
        Timer1.Interval = 1

    End Sub

    'Click Through Transparency
    Protected Overrides ReadOnly Property CreateParams() As System.Windows.Forms.CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or WS_EX_TRANSPARENT
            Return cp
        End Get
    End Property

    'Opacity
    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Opacity = Val(Opacity) + 0.1
    End Sub

    'Opacity Tool Strip
    Private Sub OpacityToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Opacity = Val(Opacity) - 0.1
    End Sub

    'Show Input Username Form
    Private Sub ChangeURLToolStripMenuItem_Click(sender As Object, e As EventArgs)
        My.Forms.Input_Username.Show()
    End Sub

    'Check For Updates
    Public Sub CheckForUpdates()

        Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://dl.dropbox.com/s/2mauczjeichi7ts/Version.txt?dl=0")
        Dim response As System.Net.HttpWebResponse = request.GetResponse()
        Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
        Dim newestversion As String = sr.ReadToEnd()
        Dim currentversion As String = Application.ProductVersion

        If newestversion.Contains(currentversion) Then
        Else
            Updater.Show()
        End If

    End Sub

    'Show Settings
    Private Sub SettingsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem1.Click
        Settings.Show()
    End Sub

    'Reset My.Settings
    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        My.Settings.Reset()
    End Sub

    'Donate
    Private Sub DonateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DonateToolStripMenuItem.Click
        MsgBox("If you're actually going to donate, thank you. It means a lot to see something coming back from my work :)")
        Process.Start("https://www.paypal.me/terrykeeton1")
    End Sub

    'Credit
    Private Sub CreditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreditToolStripMenuItem.Click
        Process.Start("https://www.twitch.tv/aylsero")
    End Sub

    'Close Program
    Private Sub Twitch_Chat_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        End
    End Sub

    'Delete All – Also delete files and settings stored by add-ons 
    Private Sub DeleteBrowserFilesHistoryAndSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BrowserManagementToolStripMenuItem.Click
        'Temporary Internet Files
        System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 8")

        'Cookies
        System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 2")

        'History
        System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 1")

        'Form(Data)
        System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 16")

        'Passwords
        System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 32")

        'Delete(All)
        System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 255")

        'Delete All – Also delete files and settings stored by add-ons 
        System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 4351")
    End Sub

    'Timer for Opacity Hotkeys
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim fone As Boolean
        Dim ftwo As Boolean

        fone = GetAsyncKeyState(Keys.F1)
        ftwo = GetAsyncKeyState(Keys.F2)

        If fone = True Then
            Me.Opacity = Val(Opacity) + 0.1
        End If

        If ftwo = True Then
            Me.Opacity = Val(Opacity) - 0.1
        End If

    End Sub

    'Show Change Chat Form
    Private Sub ChangeChatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeChatToolStripMenuItem.Click
        My.Forms.Change_Chat.Show()
    End Sub
End Class


