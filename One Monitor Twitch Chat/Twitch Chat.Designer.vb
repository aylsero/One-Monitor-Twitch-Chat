<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Twitch_Chat
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Twitch_Chat))
        Me.CHATBROWSER = New System.Windows.Forms.WebBrowser()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeChatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckForUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CreditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DonateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BrowserManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CHATBROWSER
        '
        Me.CHATBROWSER.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CHATBROWSER.Location = New System.Drawing.Point(0, 0)
        Me.CHATBROWSER.MinimumSize = New System.Drawing.Size(20, 20)
        Me.CHATBROWSER.Name = "CHATBROWSER"
        Me.CHATBROWSER.ScriptErrorsSuppressed = True
        Me.CHATBROWSER.Size = New System.Drawing.Size(306, 497)
        Me.CHATBROWSER.TabIndex = 0
        Me.CHATBROWSER.WebBrowserShortcutsEnabled = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(306, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "Strip"
        Me.MenuStrip1.Visible = False
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem1, Me.ChangeChatToolStripMenuItem, Me.CheckForUpdatesToolStripMenuItem, Me.ToolStripSeparator2, Me.CreditToolStripMenuItem, Me.DonateToolStripMenuItem, Me.ToolStripSeparator1, Me.ResetToolStripMenuItem, Me.BrowserManagementToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F3), System.Windows.Forms.Keys)
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'SettingsToolStripMenuItem1
        '
        Me.SettingsToolStripMenuItem1.Name = "SettingsToolStripMenuItem1"
        Me.SettingsToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.SettingsToolStripMenuItem1.Size = New System.Drawing.Size(195, 22)
        Me.SettingsToolStripMenuItem1.Text = "Settings"
        '
        'ChangeChatToolStripMenuItem
        '
        Me.ChangeChatToolStripMenuItem.Name = "ChangeChatToolStripMenuItem"
        Me.ChangeChatToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.ChangeChatToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.ChangeChatToolStripMenuItem.Text = "Change Chat"
        '
        'CheckForUpdatesToolStripMenuItem
        '
        Me.CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem"
        Me.CheckForUpdatesToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.CheckForUpdatesToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.CheckForUpdatesToolStripMenuItem.Text = "Check For Updates "
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(192, 6)
        '
        'CreditToolStripMenuItem
        '
        Me.CreditToolStripMenuItem.Name = "CreditToolStripMenuItem"
        Me.CreditToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.CreditToolStripMenuItem.Text = "Credit"
        '
        'DonateToolStripMenuItem
        '
        Me.DonateToolStripMenuItem.Name = "DonateToolStripMenuItem"
        Me.DonateToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.DonateToolStripMenuItem.Text = "Donate"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(192, 6)
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.ResetToolStripMenuItem.Text = "Reset User Settings"
        Me.ResetToolStripMenuItem.Visible = False
        '
        'BrowserManagementToolStripMenuItem
        '
        Me.BrowserManagementToolStripMenuItem.Name = "BrowserManagementToolStripMenuItem"
        Me.BrowserManagementToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.BrowserManagementToolStripMenuItem.Text = "Browser Management"
        Me.BrowserManagementToolStripMenuItem.Visible = False
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(12, 442)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.ScrollBarsEnabled = False
        Me.WebBrowser1.Size = New System.Drawing.Size(42, 49)
        Me.WebBrowser1.TabIndex = 2
        Me.WebBrowser1.Visible = False
        '
        'Timer1
        '
        '
        'Twitch_Chat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 497)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.CHATBROWSER)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "Twitch_Chat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "1 Monitor Twitch Chat | version 1.2"
        Me.TopMost = True
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CHATBROWSER As WebBrowser
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckForUpdatesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents ResetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BrowserManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents DonateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ChangeChatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
End Class
