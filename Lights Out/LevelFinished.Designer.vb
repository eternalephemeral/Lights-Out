<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LevelFinishedform
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
        Me.LFRestart = New System.Windows.Forms.Button
        Me.LFContinue = New System.Windows.Forms.Button
        Me.LFSelect = New System.Windows.Forms.Button
        Me.LFStar = New System.Windows.Forms.PictureBox
        Me.LFlbl = New System.Windows.Forms.Label
        CType(Me.LFStar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LFRestart
        '
        Me.LFRestart.Location = New System.Drawing.Point(123, 97)
        Me.LFRestart.Name = "LFRestart"
        Me.LFRestart.Size = New System.Drawing.Size(62, 23)
        Me.LFRestart.TabIndex = 0
        Me.LFRestart.Text = "Try Again"
        Me.LFRestart.UseVisualStyleBackColor = True
        '
        'LFContinue
        '
        Me.LFContinue.Location = New System.Drawing.Point(191, 97)
        Me.LFContinue.Name = "LFContinue"
        Me.LFContinue.Size = New System.Drawing.Size(62, 23)
        Me.LFContinue.TabIndex = 1
        Me.LFContinue.Text = "Continue"
        Me.LFContinue.UseVisualStyleBackColor = True
        '
        'LFSelect
        '
        Me.LFSelect.Location = New System.Drawing.Point(12, 97)
        Me.LFSelect.Name = "LFSelect"
        Me.LFSelect.Size = New System.Drawing.Size(79, 23)
        Me.LFSelect.TabIndex = 2
        Me.LFSelect.Text = "Select Level"
        Me.LFSelect.UseVisualStyleBackColor = True
        '
        'LFStar
        '
        Me.LFStar.Image = Global.WindowsApplication1.My.Resources.Resources._0star
        Me.LFStar.Location = New System.Drawing.Point(44, 12)
        Me.LFStar.Name = "LFStar"
        Me.LFStar.Size = New System.Drawing.Size(171, 39)
        Me.LFStar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LFStar.TabIndex = 3
        Me.LFStar.TabStop = False
        '
        'LFlbl
        '
        Me.LFlbl.AutoSize = True
        Me.LFlbl.Location = New System.Drawing.Point(93, 66)
        Me.LFlbl.Name = "LFlbl"
        Me.LFlbl.Size = New System.Drawing.Size(75, 13)
        Me.LFlbl.TabIndex = 4
        Me.LFlbl.Text = "Level Cleared!"
        '
        'LevelFinishedform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(265, 132)
        Me.Controls.Add(Me.LFlbl)
        Me.Controls.Add(Me.LFStar)
        Me.Controls.Add(Me.LFSelect)
        Me.Controls.Add(Me.LFContinue)
        Me.Controls.Add(Me.LFRestart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LevelFinishedform"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "LevelFinished"
        CType(Me.LFStar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LFRestart As System.Windows.Forms.Button
    Friend WithEvents LFContinue As System.Windows.Forms.Button
    Friend WithEvents LFSelect As System.Windows.Forms.Button
    Friend WithEvents LFStar As System.Windows.Forms.PictureBox
    Friend WithEvents LFlbl As System.Windows.Forms.Label
End Class
