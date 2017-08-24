Imports System.IO
Imports Microsoft.Win32
Public Class Updater

    Private Sub updater_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://dl.dropbox.com/s/2mauczjeichi7ts/Version.txt?dl=0")
        Dim response As System.Net.HttpWebResponse = request.GetResponse()
        Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
        Dim newestversion As String = sr.ReadToEnd()
        Dim currentversion As String = Application.ProductVersion

        If newestversion.Contains(currentversion) Then
            MsgBox("You have the latest version", MsgBoxStyle.Information, "Updater")
            Me.Close()
        Else
            Select Case MsgBox("A new version is available, would you like to update?", MsgBoxStyle.YesNo, "Updater")
                Case MsgBoxResult.Yes
                    WebBrowser1.Navigate("https://dl.dropbox.com/s/yqnri1or930n2ph/one%20monitor%20twitch%20chat.exe?dl=0")
                Case MsgBoxResult.No
                    MsgBox("Okay! There will be more features and bug fixes though.", MsgBoxStyle.Information, "Updater")
                    Me.Close()
            End Select
        End If
    End Sub
End Class