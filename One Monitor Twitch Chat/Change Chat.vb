Public Class Change_Chat

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Forms.Twitch_Chat.CHATBROWSER.Navigate("https://www.twitch.tv/" & My.Forms.Input_Username.TextBox1.Text & "/chat")
        Me.Close()
    End Sub


    Private Sub TextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If
    End Sub

End Class