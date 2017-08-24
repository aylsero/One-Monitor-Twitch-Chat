<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.showadvancedsettings = New System.Windows.Forms.CheckBox()
        Me.showmenustrip = New System.Windows.Forms.CheckBox()
        Me.checkforupdates = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.showadvancedsettings)
        Me.GroupBox2.Controls.Add(Me.showmenustrip)
        Me.GroupBox2.Controls.Add(Me.checkforupdates)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(208, 118)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "User Options"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = Global.One_Monitor_Twitch_Chat.My.MySettings.Default.DisplayInformation
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.One_Monitor_Twitch_Chat.My.MySettings.Default, "DisplayInformation", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox1.Location = New System.Drawing.Point(7, 90)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(192, 17)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "Do Not Display Information on Start"
        Me.ToolTip1.SetToolTip(Me.CheckBox1, "This determins if the message boxes load on startup.")
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'showadvancedsettings
        '
        Me.showadvancedsettings.AutoSize = True
        Me.showadvancedsettings.Location = New System.Drawing.Point(7, 66)
        Me.showadvancedsettings.Name = "showadvancedsettings"
        Me.showadvancedsettings.Size = New System.Drawing.Size(146, 17)
        Me.showadvancedsettings.TabIndex = 6
        Me.showadvancedsettings.Text = "Show Advanced Settings"
        Me.ToolTip1.SetToolTip(Me.showadvancedsettings, "Shows advanced settings (Not Reccomended)")
        Me.showadvancedsettings.UseVisualStyleBackColor = True
        '
        'showmenustrip
        '
        Me.showmenustrip.AutoSize = True
        Me.showmenustrip.Checked = Global.One_Monitor_Twitch_Chat.My.MySettings.Default.showmenustrip
        Me.showmenustrip.CheckState = System.Windows.Forms.CheckState.Checked
        Me.showmenustrip.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.One_Monitor_Twitch_Chat.My.MySettings.Default, "showmenustrip", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.showmenustrip.Location = New System.Drawing.Point(7, 43)
        Me.showmenustrip.Name = "showmenustrip"
        Me.showmenustrip.Size = New System.Drawing.Size(107, 17)
        Me.showmenustrip.TabIndex = 5
        Me.showmenustrip.Text = "Show Menu Strip"
        Me.ToolTip1.SetToolTip(Me.showmenustrip, "Shows the Options Menu Strip")
        Me.showmenustrip.UseVisualStyleBackColor = True
        '
        'checkforupdates
        '
        Me.checkforupdates.AutoSize = True
        Me.checkforupdates.Checked = Global.One_Monitor_Twitch_Chat.My.MySettings.Default.checkforupdates
        Me.checkforupdates.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.One_Monitor_Twitch_Chat.My.MySettings.Default, "checkforupdates", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.checkforupdates.Location = New System.Drawing.Point(6, 19)
        Me.checkforupdates.Name = "checkforupdates"
        Me.checkforupdates.Size = New System.Drawing.Size(158, 17)
        Me.checkforupdates.TabIndex = 3
        Me.checkforupdates.Text = "Check For Updates on Start"
        Me.ToolTip1.SetToolTip(Me.checkforupdates, "Checks for a new version on startup")
        Me.checkforupdates.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TrackBar1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 137)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(208, 62)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opacity"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(164, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "100%"
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(6, 15)
        Me.TrackBar1.Maximum = 100
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(152, 45)
        Me.TrackBar1.TabIndex = 3
        Me.TrackBar1.TickFrequency = 5
        Me.ToolTip1.SetToolTip(Me.TrackBar1, "Changes the opacity of the main Twitch Chat Form")
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 205)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(206, 69)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Hotkeys"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 39)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "F3 = User Settings" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "F4 = Change Chat" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "F5 = Check For Updates" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(230, 283)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents showmenustrip As CheckBox
    Friend WithEvents checkforupdates As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents showadvancedsettings As CheckBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label2 As Label
End Class
