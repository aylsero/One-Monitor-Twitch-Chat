Public Class Settings
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Opacity TrackBar
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        If TrackBar1.Value = TrackBar1.Maximum Then
            Label1.Text = "0%"

        ElseIf TrackBar1.Value = TrackBar1.Minimum Then
            Label1.Text = "100%"
        Else
            Label1.Text = TrackBar1.Maximum - TrackBar1.Value + 1 & "%"
        End If

        Twitch_Chat.Opacity = Val(TrackBar1.Maximum - TrackBar1.Value + 1) / 100
    End Sub

    'Show Menu Strip
    Private Sub showmenustrip_CheckedChanged(sender As Object, e As EventArgs) Handles showmenustrip.CheckedChanged
        If showmenustrip.Checked = True Then
            My.Forms.Twitch_Chat.MenuStrip1.Visible = True
        Else
            If showmenustrip.Checked = False Then
                My.Forms.Twitch_Chat.MenuStrip1.Visible = False
            End If
        End If
    End Sub
    'Saving Settings
    Private Sub Settings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.Save()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles showadvancedsettings.CheckedChanged
        If showadvancedsettings.Checked = True Then
            My.Forms.Twitch_Chat.ResetToolStripMenuItem.Visible = True
            My.Forms.Twitch_Chat.BrowserManagementToolStripMenuItem.Visible = True
        Else
            If showadvancedsettings.Checked = False Then
                My.Forms.Twitch_Chat.ResetToolStripMenuItem.Visible = False
                My.Forms.Twitch_Chat.BrowserManagementToolStripMenuItem.Visible = False
            End If
        End If
    End Sub

End Class