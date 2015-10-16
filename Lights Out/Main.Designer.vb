<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.mainmenu = New System.Windows.Forms.MenuStrip
        Me.menufile = New System.Windows.Forms.ToolStripMenuItem
        Me.menurestart = New System.Windows.Forms.ToolStripMenuItem
        Me.menuselect = New System.Windows.Forms.ToolStripMenuItem
        Me.menucleard = New System.Windows.Forms.ToolStripMenuItem
        Me.menuexit = New System.Windows.Forms.ToolStripMenuItem
        Me.menuhelp = New System.Windows.Forms.ToolStripMenuItem
        Me.menuinst = New System.Windows.Forms.ToolStripMenuItem
        Me.menusolve = New System.Windows.Forms.ToolStripMenuItem
        Me.menuabout = New System.Windows.Forms.ToolStripMenuItem
        Me.restartbttn = New System.Windows.Forms.Button
        Me.previousbttn = New System.Windows.Forms.Button
        Me.nextbttn = New System.Windows.Forms.Button
        Me.levellbl = New System.Windows.Forms.Label
        Me.movesleftlbl = New System.Windows.Forms.Label
        Me.starpb = New System.Windows.Forms.PictureBox
        Me.LS11 = New System.Windows.Forms.Button
        Me.LS55 = New System.Windows.Forms.Button
        Me.LS45 = New System.Windows.Forms.Button
        Me.LS35 = New System.Windows.Forms.Button
        Me.LS25 = New System.Windows.Forms.Button
        Me.LS15 = New System.Windows.Forms.Button
        Me.LS54 = New System.Windows.Forms.Button
        Me.LS44 = New System.Windows.Forms.Button
        Me.LS34 = New System.Windows.Forms.Button
        Me.LS24 = New System.Windows.Forms.Button
        Me.LS14 = New System.Windows.Forms.Button
        Me.LS53 = New System.Windows.Forms.Button
        Me.LS43 = New System.Windows.Forms.Button
        Me.LS33 = New System.Windows.Forms.Button
        Me.LS23 = New System.Windows.Forms.Button
        Me.LS13 = New System.Windows.Forms.Button
        Me.LS52 = New System.Windows.Forms.Button
        Me.LS42 = New System.Windows.Forms.Button
        Me.LS32 = New System.Windows.Forms.Button
        Me.LS22 = New System.Windows.Forms.Button
        Me.LS12 = New System.Windows.Forms.Button
        Me.LS51 = New System.Windows.Forms.Button
        Me.LS41 = New System.Windows.Forms.Button
        Me.LS31 = New System.Windows.Forms.Button
        Me.LS21 = New System.Windows.Forms.Button
        Me.mainmenu.SuspendLayout()
        CType(Me.starpb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mainmenu
        '
        Me.mainmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menufile, Me.menuhelp})
        Me.mainmenu.Location = New System.Drawing.Point(0, 0)
        Me.mainmenu.Name = "mainmenu"
        Me.mainmenu.Size = New System.Drawing.Size(223, 24)
        Me.mainmenu.TabIndex = 26
        Me.mainmenu.Text = "MenuStrip"
        '
        'menufile
        '
        Me.menufile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menurestart, Me.menuselect, Me.menucleard, Me.menuexit})
        Me.menufile.Name = "menufile"
        Me.menufile.Size = New System.Drawing.Size(37, 20)
        Me.menufile.Text = "File"
        '
        'menurestart
        '
        Me.menurestart.Name = "menurestart"
        Me.menurestart.Size = New System.Drawing.Size(140, 22)
        Me.menurestart.Text = "Restart Level"
        '
        'menuselect
        '
        Me.menuselect.Name = "menuselect"
        Me.menuselect.Size = New System.Drawing.Size(140, 22)
        Me.menuselect.Text = "Select Level"
        '
        'menucleard
        '
        Me.menucleard.Name = "menucleard"
        Me.menucleard.Size = New System.Drawing.Size(140, 22)
        Me.menucleard.Text = "Clear Data"
        '
        'menuexit
        '
        Me.menuexit.Name = "menuexit"
        Me.menuexit.Size = New System.Drawing.Size(140, 22)
        Me.menuexit.Text = "Exit"
        '
        'menuhelp
        '
        Me.menuhelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuinst, Me.menusolve, Me.menuabout})
        Me.menuhelp.Name = "menuhelp"
        Me.menuhelp.Size = New System.Drawing.Size(44, 20)
        Me.menuhelp.Text = "Help"
        '
        'menuinst
        '
        Me.menuinst.Name = "menuinst"
        Me.menuinst.Size = New System.Drawing.Size(147, 22)
        Me.menuinst.Text = "Instructions"
        '
        'menusolve
        '
        Me.menusolve.Name = "menusolve"
        Me.menusolve.Size = New System.Drawing.Size(147, 22)
        Me.menusolve.Text = "ShowSolution"
        '
        'menuabout
        '
        Me.menuabout.Name = "menuabout"
        Me.menuabout.Size = New System.Drawing.Size(147, 22)
        Me.menuabout.Text = "About"
        '
        'restartbttn
        '
        Me.restartbttn.Location = New System.Drawing.Point(12, 249)
        Me.restartbttn.Name = "restartbttn"
        Me.restartbttn.Size = New System.Drawing.Size(80, 23)
        Me.restartbttn.TabIndex = 27
        Me.restartbttn.Text = "Restart"
        Me.restartbttn.UseVisualStyleBackColor = True
        '
        'previousbttn
        '
        Me.previousbttn.Location = New System.Drawing.Point(136, 249)
        Me.previousbttn.Name = "previousbttn"
        Me.previousbttn.Size = New System.Drawing.Size(36, 23)
        Me.previousbttn.TabIndex = 29
        Me.previousbttn.Text = "<"
        Me.previousbttn.UseVisualStyleBackColor = True
        '
        'nextbttn
        '
        Me.nextbttn.Location = New System.Drawing.Point(176, 249)
        Me.nextbttn.Name = "nextbttn"
        Me.nextbttn.Size = New System.Drawing.Size(36, 23)
        Me.nextbttn.TabIndex = 30
        Me.nextbttn.Text = ">"
        Me.nextbttn.UseVisualStyleBackColor = True
        '
        'levellbl
        '
        Me.levellbl.AutoSize = True
        Me.levellbl.Location = New System.Drawing.Point(73, 287)
        Me.levellbl.Name = "levellbl"
        Me.levellbl.Size = New System.Drawing.Size(33, 13)
        Me.levellbl.TabIndex = 32
        Me.levellbl.Text = "Level"
        '
        'movesleftlbl
        '
        Me.movesleftlbl.AutoSize = True
        Me.movesleftlbl.Location = New System.Drawing.Point(121, 287)
        Me.movesleftlbl.Name = "movesleftlbl"
        Me.movesleftlbl.Size = New System.Drawing.Size(85, 13)
        Me.movesleftlbl.TabIndex = 33
        Me.movesleftlbl.Text = "Moves Available"
        '
        'starpb
        '
        Me.starpb.Image = Global.WindowsApplication1.My.Resources.Resources._0star
        Me.starpb.Location = New System.Drawing.Point(12, 287)
        Me.starpb.Name = "starpb"
        Me.starpb.Size = New System.Drawing.Size(57, 13)
        Me.starpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.starpb.TabIndex = 34
        Me.starpb.TabStop = False
        '
        'LS11
        '
        Me.LS11.BackColor = System.Drawing.Color.Blue
        Me.LS11.BackgroundImage = CType(resources.GetObject("LS11.BackgroundImage"), System.Drawing.Image)
        Me.LS11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.LS11.Location = New System.Drawing.Point(12, 37)
        Me.LS11.Margin = New System.Windows.Forms.Padding(0)
        Me.LS11.Name = "LS11"
        Me.LS11.Size = New System.Drawing.Size(40, 40)
        Me.LS11.TabIndex = 1
        Me.LS11.Tag = "11"
        Me.LS11.UseVisualStyleBackColor = False
        '
        'LS55
        '
        Me.LS55.BackColor = System.Drawing.Color.Blue
        Me.LS55.BackgroundImage = CType(resources.GetObject("LS55.BackgroundImage"), System.Drawing.Image)
        Me.LS55.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.LS55.Location = New System.Drawing.Point(172, 197)
        Me.LS55.Margin = New System.Windows.Forms.Padding(0)
        Me.LS55.Name = "LS55"
        Me.LS55.Size = New System.Drawing.Size(40, 40)
        Me.LS55.TabIndex = 25
        Me.LS55.Tag = "55"
        Me.LS55.UseVisualStyleBackColor = False
        '
        'LS45
        '
        Me.LS45.BackColor = System.Drawing.Color.Blue
        Me.LS45.BackgroundImage = CType(resources.GetObject("LS45.BackgroundImage"), System.Drawing.Image)
        Me.LS45.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.LS45.Location = New System.Drawing.Point(132, 197)
        Me.LS45.Margin = New System.Windows.Forms.Padding(0)
        Me.LS45.Name = "LS45"
        Me.LS45.Size = New System.Drawing.Size(40, 40)
        Me.LS45.TabIndex = 24
        Me.LS45.Tag = "45"
        Me.LS45.UseVisualStyleBackColor = False
        '
        'LS35
        '
        Me.LS35.BackColor = System.Drawing.Color.Blue
        Me.LS35.BackgroundImage = CType(resources.GetObject("LS35.BackgroundImage"), System.Drawing.Image)
        Me.LS35.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.LS35.Location = New System.Drawing.Point(92, 197)
        Me.LS35.Margin = New System.Windows.Forms.Padding(0)
        Me.LS35.Name = "LS35"
        Me.LS35.Size = New System.Drawing.Size(40, 40)
        Me.LS35.TabIndex = 23
        Me.LS35.Tag = "35"
        Me.LS35.UseVisualStyleBackColor = False
        '
        'LS25
        '
        Me.LS25.BackColor = System.Drawing.Color.Blue
        Me.LS25.BackgroundImage = CType(resources.GetObject("LS25.BackgroundImage"), System.Drawing.Image)
        Me.LS25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.LS25.Location = New System.Drawing.Point(52, 197)
        Me.LS25.Margin = New System.Windows.Forms.Padding(0)
        Me.LS25.Name = "LS25"
        Me.LS25.Size = New System.Drawing.Size(40, 40)
        Me.LS25.TabIndex = 22
        Me.LS25.Tag = "25"
        Me.LS25.UseVisualStyleBackColor = False
        '
        'LS15
        '
        Me.LS15.BackColor = System.Drawing.Color.Blue
        Me.LS15.BackgroundImage = CType(resources.GetObject("LS15.BackgroundImage"), System.Drawing.Image)
        Me.LS15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.LS15.Location = New System.Drawing.Point(12, 197)
        Me.LS15.Margin = New System.Windows.Forms.Padding(0)
        Me.LS15.Name = "LS15"
        Me.LS15.Size = New System.Drawing.Size(40, 40)
        Me.LS15.TabIndex = 21
        Me.LS15.Tag = "15"
        Me.LS15.UseVisualStyleBackColor = False
        '
        'LS54
        '
        Me.LS54.BackColor = System.Drawing.Color.Blue
        Me.LS54.BackgroundImage = CType(resources.GetObject("LS54.BackgroundImage"), System.Drawing.Image)
        Me.LS54.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.LS54.Location = New System.Drawing.Point(172, 157)
        Me.LS54.Margin = New System.Windows.Forms.Padding(0)
        Me.LS54.Name = "LS54"
        Me.LS54.Size = New System.Drawing.Size(40, 40)
        Me.LS54.TabIndex = 20
        Me.LS54.Tag = "54"
        Me.LS54.UseVisualStyleBackColor = False
        '
        'LS44
        '
        Me.LS44.BackColor = System.Drawing.Color.Blue
        Me.LS44.BackgroundImage = CType(resources.GetObject("LS44.BackgroundImage"), System.Drawing.Image)
        Me.LS44.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.LS44.Location = New System.Drawing.Point(132, 157)
        Me.LS44.Margin = New System.Windows.Forms.Padding(0)
        Me.LS44.Name = "LS44"
        Me.LS44.Size = New System.Drawing.Size(40, 40)
        Me.LS44.TabIndex = 19
        Me.LS44.Tag = "44"
        Me.LS44.UseVisualStyleBackColor = False
        '
        'LS34
        '
        Me.LS34.BackColor = System.Drawing.Color.Blue
        Me.LS34.BackgroundImage = CType(resources.GetObject("LS34.BackgroundImage"), System.Drawing.Image)
        Me.LS34.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.LS34.Location = New System.Drawing.Point(92, 157)
        Me.LS34.Margin = New System.Windows.Forms.Padding(0)
        Me.LS34.Name = "LS34"
        Me.LS34.Size = New System.Drawing.Size(40, 40)
        Me.LS34.TabIndex = 18
        Me.LS34.Tag = "34"
        Me.LS34.UseVisualStyleBackColor = False
        '
        'LS24
        '
        Me.LS24.BackColor = System.Drawing.Color.Blue
        Me.LS24.BackgroundImage = CType(resources.GetObject("LS24.BackgroundImage"), System.Drawing.Image)
        Me.LS24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.LS24.Location = New System.Drawing.Point(52, 157)
        Me.LS24.Margin = New System.Windows.Forms.Padding(0)
        Me.LS24.Name = "LS24"
        Me.LS24.Size = New System.Drawing.Size(40, 40)
        Me.LS24.TabIndex = 17
        Me.LS24.Tag = "24"
        Me.LS24.UseVisualStyleBackColor = False
        '
        'LS14
        '
        Me.LS14.BackColor = System.Drawing.Color.Blue
        Me.LS14.BackgroundImage = CType(resources.GetObject("LS14.BackgroundImage"), System.Drawing.Image)
        Me.LS14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.LS14.Location = New System.Drawing.Point(12, 157)
        Me.LS14.Margin = New System.Windows.Forms.Padding(0)
        Me.LS14.Name = "LS14"
        Me.LS14.Size = New System.Drawing.Size(40, 40)
        Me.LS14.TabIndex = 16
        Me.LS14.Tag = "14"
        Me.LS14.UseVisualStyleBackColor = False
        '
        'LS53
        '
        Me.LS53.BackColor = System.Drawing.Color.Blue
        Me.LS53.BackgroundImage = CType(resources.GetObject("LS53.BackgroundImage"), System.Drawing.Image)
        Me.LS53.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.LS53.Location = New System.Drawing.Point(172, 117)
        Me.LS53.Margin = New System.Windows.Forms.Padding(0)
        Me.LS53.Name = "LS53"
        Me.LS53.Size = New System.Drawing.Size(40, 40)
        Me.LS53.TabIndex = 15
        Me.LS53.Tag = "53"
        Me.LS53.UseVisualStyleBackColor = False
        '
        'LS43
        '
        Me.LS43.BackColor = System.Drawing.Color.Blue
        Me.LS43.BackgroundImage = CType(resources.GetObject("LS43.BackgroundImage"), System.Drawing.Image)
        Me.LS43.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.LS43.Location = New System.Drawing.Point(132, 117)
        Me.LS43.Margin = New System.Windows.Forms.Padding(0)
        Me.LS43.Name = "LS43"
        Me.LS43.Size = New System.Drawing.Size(40, 40)
        Me.LS43.TabIndex = 14
        Me.LS43.Tag = "43"
        Me.LS43.UseVisualStyleBackColor = False
        '
        'LS33
        '
        Me.LS33.BackColor = System.Drawing.Color.Blue
        Me.LS33.BackgroundImage = CType(resources.GetObject("LS33.BackgroundImage"), System.Drawing.Image)
        Me.LS33.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.LS33.Location = New System.Drawing.Point(92, 117)
        Me.LS33.Margin = New System.Windows.Forms.Padding(0)
        Me.LS33.Name = "LS33"
        Me.LS33.Size = New System.Drawing.Size(40, 40)
        Me.LS33.TabIndex = 13
        Me.LS33.Tag = "33"
        Me.LS33.UseVisualStyleBackColor = False
        '
        'LS23
        '
        Me.LS23.BackColor = System.Drawing.Color.Blue
        Me.LS23.BackgroundImage = CType(resources.GetObject("LS23.BackgroundImage"), System.Drawing.Image)
        Me.LS23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.LS23.Location = New System.Drawing.Point(52, 117)
        Me.LS23.Margin = New System.Windows.Forms.Padding(0)
        Me.LS23.Name = "LS23"
        Me.LS23.Size = New System.Drawing.Size(40, 40)
        Me.LS23.TabIndex = 12
        Me.LS23.Tag = "23"
        Me.LS23.UseVisualStyleBackColor = False
        '
        'LS13
        '
        Me.LS13.BackColor = System.Drawing.Color.Blue
        Me.LS13.BackgroundImage = CType(resources.GetObject("LS13.BackgroundImage"), System.Drawing.Image)
        Me.LS13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.LS13.Location = New System.Drawing.Point(12, 117)
        Me.LS13.Margin = New System.Windows.Forms.Padding(0)
        Me.LS13.Name = "LS13"
        Me.LS13.Size = New System.Drawing.Size(40, 40)
        Me.LS13.TabIndex = 11
        Me.LS13.Tag = "13"
        Me.LS13.UseVisualStyleBackColor = False
        '
        'LS52
        '
        Me.LS52.BackColor = System.Drawing.Color.Blue
        Me.LS52.BackgroundImage = CType(resources.GetObject("LS52.BackgroundImage"), System.Drawing.Image)
        Me.LS52.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.LS52.Location = New System.Drawing.Point(172, 77)
        Me.LS52.Margin = New System.Windows.Forms.Padding(0)
        Me.LS52.Name = "LS52"
        Me.LS52.Size = New System.Drawing.Size(40, 40)
        Me.LS52.TabIndex = 10
        Me.LS52.Tag = "52"
        Me.LS52.UseVisualStyleBackColor = False
        '
        'LS42
        '
        Me.LS42.BackColor = System.Drawing.Color.Blue
        Me.LS42.BackgroundImage = CType(resources.GetObject("LS42.BackgroundImage"), System.Drawing.Image)
        Me.LS42.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.LS42.Location = New System.Drawing.Point(132, 77)
        Me.LS42.Margin = New System.Windows.Forms.Padding(0)
        Me.LS42.Name = "LS42"
        Me.LS42.Size = New System.Drawing.Size(40, 40)
        Me.LS42.TabIndex = 9
        Me.LS42.Tag = "42"
        Me.LS42.UseVisualStyleBackColor = False
        '
        'LS32
        '
        Me.LS32.BackColor = System.Drawing.Color.Blue
        Me.LS32.BackgroundImage = CType(resources.GetObject("LS32.BackgroundImage"), System.Drawing.Image)
        Me.LS32.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.LS32.Location = New System.Drawing.Point(92, 77)
        Me.LS32.Margin = New System.Windows.Forms.Padding(0)
        Me.LS32.Name = "LS32"
        Me.LS32.Size = New System.Drawing.Size(40, 40)
        Me.LS32.TabIndex = 8
        Me.LS32.Tag = "32"
        Me.LS32.UseVisualStyleBackColor = False
        '
        'LS22
        '
        Me.LS22.BackColor = System.Drawing.Color.Blue
        Me.LS22.BackgroundImage = CType(resources.GetObject("LS22.BackgroundImage"), System.Drawing.Image)
        Me.LS22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.LS22.Location = New System.Drawing.Point(52, 77)
        Me.LS22.Margin = New System.Windows.Forms.Padding(0)
        Me.LS22.Name = "LS22"
        Me.LS22.Size = New System.Drawing.Size(40, 40)
        Me.LS22.TabIndex = 7
        Me.LS22.Tag = "22"
        Me.LS22.UseVisualStyleBackColor = False
        '
        'LS12
        '
        Me.LS12.BackColor = System.Drawing.Color.Blue
        Me.LS12.BackgroundImage = CType(resources.GetObject("LS12.BackgroundImage"), System.Drawing.Image)
        Me.LS12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.LS12.Location = New System.Drawing.Point(12, 77)
        Me.LS12.Margin = New System.Windows.Forms.Padding(0)
        Me.LS12.Name = "LS12"
        Me.LS12.Size = New System.Drawing.Size(40, 40)
        Me.LS12.TabIndex = 6
        Me.LS12.Tag = "12"
        Me.LS12.UseVisualStyleBackColor = False
        '
        'LS51
        '
        Me.LS51.BackColor = System.Drawing.Color.Blue
        Me.LS51.BackgroundImage = CType(resources.GetObject("LS51.BackgroundImage"), System.Drawing.Image)
        Me.LS51.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.LS51.Location = New System.Drawing.Point(172, 37)
        Me.LS51.Margin = New System.Windows.Forms.Padding(0)
        Me.LS51.Name = "LS51"
        Me.LS51.Size = New System.Drawing.Size(40, 40)
        Me.LS51.TabIndex = 5
        Me.LS51.Tag = "51"
        Me.LS51.UseVisualStyleBackColor = False
        '
        'LS41
        '
        Me.LS41.BackColor = System.Drawing.Color.Blue
        Me.LS41.BackgroundImage = CType(resources.GetObject("LS41.BackgroundImage"), System.Drawing.Image)
        Me.LS41.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.LS41.Location = New System.Drawing.Point(132, 37)
        Me.LS41.Margin = New System.Windows.Forms.Padding(0)
        Me.LS41.Name = "LS41"
        Me.LS41.Size = New System.Drawing.Size(40, 40)
        Me.LS41.TabIndex = 4
        Me.LS41.Tag = "41"
        Me.LS41.UseVisualStyleBackColor = False
        '
        'LS31
        '
        Me.LS31.BackColor = System.Drawing.Color.Blue
        Me.LS31.BackgroundImage = CType(resources.GetObject("LS31.BackgroundImage"), System.Drawing.Image)
        Me.LS31.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.LS31.Location = New System.Drawing.Point(92, 37)
        Me.LS31.Margin = New System.Windows.Forms.Padding(0)
        Me.LS31.Name = "LS31"
        Me.LS31.Size = New System.Drawing.Size(40, 40)
        Me.LS31.TabIndex = 3
        Me.LS31.Tag = "31"
        Me.LS31.UseVisualStyleBackColor = False
        '
        'LS21
        '
        Me.LS21.BackColor = System.Drawing.Color.Blue
        Me.LS21.BackgroundImage = CType(resources.GetObject("LS21.BackgroundImage"), System.Drawing.Image)
        Me.LS21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.LS21.Location = New System.Drawing.Point(52, 37)
        Me.LS21.Margin = New System.Windows.Forms.Padding(0)
        Me.LS21.Name = "LS21"
        Me.LS21.Size = New System.Drawing.Size(40, 40)
        Me.LS21.TabIndex = 2
        Me.LS21.Tag = "21"
        Me.LS21.UseVisualStyleBackColor = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(223, 305)
        Me.Controls.Add(Me.starpb)
        Me.Controls.Add(Me.movesleftlbl)
        Me.Controls.Add(Me.levellbl)
        Me.Controls.Add(Me.nextbttn)
        Me.Controls.Add(Me.previousbttn)
        Me.Controls.Add(Me.restartbttn)
        Me.Controls.Add(Me.LS11)
        Me.Controls.Add(Me.LS55)
        Me.Controls.Add(Me.LS45)
        Me.Controls.Add(Me.LS35)
        Me.Controls.Add(Me.LS25)
        Me.Controls.Add(Me.LS15)
        Me.Controls.Add(Me.LS54)
        Me.Controls.Add(Me.LS44)
        Me.Controls.Add(Me.LS34)
        Me.Controls.Add(Me.LS24)
        Me.Controls.Add(Me.LS14)
        Me.Controls.Add(Me.LS53)
        Me.Controls.Add(Me.LS43)
        Me.Controls.Add(Me.LS33)
        Me.Controls.Add(Me.LS23)
        Me.Controls.Add(Me.LS13)
        Me.Controls.Add(Me.LS52)
        Me.Controls.Add(Me.LS42)
        Me.Controls.Add(Me.LS32)
        Me.Controls.Add(Me.LS22)
        Me.Controls.Add(Me.LS12)
        Me.Controls.Add(Me.LS51)
        Me.Controls.Add(Me.LS41)
        Me.Controls.Add(Me.LS31)
        Me.Controls.Add(Me.LS21)
        Me.Controls.Add(Me.mainmenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mainmenu
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LightsOut"
        Me.mainmenu.ResumeLayout(False)
        Me.mainmenu.PerformLayout()
        CType(Me.starpb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LS21 As System.Windows.Forms.Button
    Friend WithEvents LS31 As System.Windows.Forms.Button
    Friend WithEvents LS41 As System.Windows.Forms.Button
    Friend WithEvents LS51 As System.Windows.Forms.Button
    Friend WithEvents LS12 As System.Windows.Forms.Button
    Friend WithEvents LS22 As System.Windows.Forms.Button
    Friend WithEvents LS32 As System.Windows.Forms.Button
    Friend WithEvents LS42 As System.Windows.Forms.Button
    Friend WithEvents LS52 As System.Windows.Forms.Button
    Friend WithEvents LS13 As System.Windows.Forms.Button
    Friend WithEvents LS23 As System.Windows.Forms.Button
    Friend WithEvents LS33 As System.Windows.Forms.Button
    Friend WithEvents LS43 As System.Windows.Forms.Button
    Friend WithEvents LS53 As System.Windows.Forms.Button
    Friend WithEvents LS14 As System.Windows.Forms.Button
    Friend WithEvents LS24 As System.Windows.Forms.Button
    Friend WithEvents LS34 As System.Windows.Forms.Button
    Friend WithEvents LS44 As System.Windows.Forms.Button
    Friend WithEvents LS54 As System.Windows.Forms.Button
    Friend WithEvents LS15 As System.Windows.Forms.Button
    Friend WithEvents LS25 As System.Windows.Forms.Button
    Friend WithEvents LS35 As System.Windows.Forms.Button
    Friend WithEvents LS45 As System.Windows.Forms.Button
    Friend WithEvents LS55 As System.Windows.Forms.Button
    Friend WithEvents LS11 As System.Windows.Forms.Button
    Friend WithEvents mainmenu As System.Windows.Forms.MenuStrip
    Friend WithEvents menufile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menurestart As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuselect As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuexit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuhelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menusolve As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuabout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents restartbttn As System.Windows.Forms.Button
    Friend WithEvents previousbttn As System.Windows.Forms.Button
    Friend WithEvents nextbttn As System.Windows.Forms.Button
    Friend WithEvents levellbl As System.Windows.Forms.Label
    Friend WithEvents movesleftlbl As System.Windows.Forms.Label
    Friend WithEvents starpb As System.Windows.Forms.PictureBox
    Friend WithEvents menucleard As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuinst As System.Windows.Forms.ToolStripMenuItem

End Class
