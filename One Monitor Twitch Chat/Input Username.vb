Imports System.IO
Imports Microsoft.Win32

Public Class Input_Username
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Twitch_Chat.Show()
        My.Forms.Twitch_Chat.CHATBROWSER.Navigate("https://www.twitch.tv/" & My.Forms.Input_Username.TextBox1.Text & "/chat")

        If CheckBox1.Checked = True Then
            My.Settings.Save()
        End If

        If CheckBox1.Checked = False Then
            My.Settings.Reset()
        End If

        Me.Hide()
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If
    End Sub

    Private Sub Input_Username_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class