<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Instructionsform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Instructionsform))
        Me.Label1 = New System.Windows.Forms.Label
        Me.InstCB = New System.Windows.Forms.CheckBox
        Me.instructionsok = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(269, 187)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'InstCB
        '
        Me.InstCB.AutoSize = True
        Me.InstCB.Checked = True
        Me.InstCB.CheckState = System.Windows.Forms.CheckState.Checked
        Me.InstCB.Location = New System.Drawing.Point(12, 221)
        Me.InstCB.Name = "InstCB"
        Me.InstCB.Size = New System.Drawing.Size(164, 17)
        Me.InstCB.TabIndex = 1
        Me.InstCB.Text = "Show Instructions On Startup"
        Me.InstCB.UseVisualStyleBackColor = True
        '
        'instructionsok
        '
        Me.instructionsok.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.instructionsok.Location = New System.Drawing.Point(215, 215)
        Me.instructionsok.Name = "instructionsok"
        Me.instructionsok.Size = New System.Drawing.Size(66, 23)
        Me.instructionsok.TabIndex = 0
        Me.instructionsok.Text = "OK"
        Me.instructionsok.UseVisualStyleBackColor = True
        '
        'Instructionsform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 250)
        Me.Controls.Add(Me.instructionsok)
        Me.Controls.Add(Me.InstCB)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Instructionsform"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Instructions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents InstCB As System.Windows.Forms.CheckBox
    Friend WithEvents instructionsok As System.Windows.Forms.Button
End Class
