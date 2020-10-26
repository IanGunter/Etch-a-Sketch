<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EtchASketchForm
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
        Me.DrawBox = New System.Windows.Forms.PictureBox()
        Me.ChooseColor = New System.Windows.Forms.ColorDialog()
        Me.SelectColorButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.DrawWaveformButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrawWaveformsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundPictureBox = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DrawBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.BackgroundPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DrawBox
        '
        Me.DrawBox.BackColor = System.Drawing.SystemColors.Control
        Me.DrawBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DrawBox.Location = New System.Drawing.Point(240, 192)
        Me.DrawBox.Margin = New System.Windows.Forms.Padding(6)
        Me.DrawBox.Name = "DrawBox"
        Me.DrawBox.Size = New System.Drawing.Size(1156, 573)
        Me.DrawBox.TabIndex = 0
        Me.DrawBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.DrawBox, "Draw a Picture in this area.")
        '
        'SelectColorButton
        '
        Me.SelectColorButton.BackColor = System.Drawing.Color.Khaki
        Me.SelectColorButton.Location = New System.Drawing.Point(228, 865)
        Me.SelectColorButton.Margin = New System.Windows.Forms.Padding(6)
        Me.SelectColorButton.Name = "SelectColorButton"
        Me.SelectColorButton.Size = New System.Drawing.Size(246, 96)
        Me.SelectColorButton.TabIndex = 1
        Me.SelectColorButton.Text = "&Color"
        Me.ToolTip1.SetToolTip(Me.SelectColorButton, "Select color to draw with.")
        Me.SelectColorButton.UseVisualStyleBackColor = False
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.Color.Khaki
        Me.ClearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ClearButton.Location = New System.Drawing.Point(554, 873)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(6)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(246, 96)
        Me.ClearButton.TabIndex = 2
        Me.ClearButton.Text = "C&lear"
        Me.ToolTip1.SetToolTip(Me.ClearButton, "Clear the picture ")
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'DrawWaveformButton
        '
        Me.DrawWaveformButton.BackColor = System.Drawing.Color.Khaki
        Me.DrawWaveformButton.Location = New System.Drawing.Point(848, 881)
        Me.DrawWaveformButton.Margin = New System.Windows.Forms.Padding(6)
        Me.DrawWaveformButton.Name = "DrawWaveformButton"
        Me.DrawWaveformButton.Size = New System.Drawing.Size(246, 88)
        Me.DrawWaveformButton.TabIndex = 3
        Me.DrawWaveformButton.Text = "Draw Waveforms"
        Me.ToolTip1.SetToolTip(Me.DrawWaveformButton, "Draw a SinWave, a CosinWave, and a TangetWave")
        Me.DrawWaveformButton.UseVisualStyleBackColor = False
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.Khaki
        Me.ExitButton.Location = New System.Drawing.Point(1164, 881)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(6)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(246, 88)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = " Exit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Close the program.")
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1600, 40)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(72, 36)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(186, 44)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectColorToolStripMenuItem, Me.DrawWaveformsToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(75, 36)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'SelectColorToolStripMenuItem
        '
        Me.SelectColorToolStripMenuItem.Name = "SelectColorToolStripMenuItem"
        Me.SelectColorToolStripMenuItem.Size = New System.Drawing.Size(329, 44)
        Me.SelectColorToolStripMenuItem.Text = "Select Color"
        '
        'DrawWaveformsToolStripMenuItem
        '
        Me.DrawWaveformsToolStripMenuItem.Name = "DrawWaveformsToolStripMenuItem"
        Me.DrawWaveformsToolStripMenuItem.Size = New System.Drawing.Size(329, 44)
        Me.DrawWaveformsToolStripMenuItem.Text = "Draw Waveforms"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(329, 44)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(85, 36)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(214, 44)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'BackgroundPictureBox
        '
        Me.BackgroundPictureBox.BackColor = System.Drawing.Color.Khaki
        Me.BackgroundPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BackgroundPictureBox.Location = New System.Drawing.Point(174, 127)
        Me.BackgroundPictureBox.Margin = New System.Windows.Forms.Padding(6)
        Me.BackgroundPictureBox.Name = "BackgroundPictureBox"
        Me.BackgroundPictureBox.Size = New System.Drawing.Size(1292, 702)
        Me.BackgroundPictureBox.TabIndex = 6
        Me.BackgroundPictureBox.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Khaki
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(600, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(436, 56)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ETCH-A-SKETCH 9000"
        '
        'EtchASketchForm
        '
        Me.AcceptButton = Me.DrawWaveformButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Firebrick
        Me.CancelButton = Me.ClearButton
        Me.ClientSize = New System.Drawing.Size(1600, 1012)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.DrawWaveformButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.SelectColorButton)
        Me.Controls.Add(Me.DrawBox)
        Me.Controls.Add(Me.BackgroundPictureBox)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "EtchASketchForm"
        Me.Text = "Etch-A-Sketch"
        CType(Me.DrawBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.BackgroundPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DrawBox As PictureBox
    Friend WithEvents ChooseColor As ColorDialog
    Friend WithEvents SelectColorButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents DrawWaveformButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DrawWaveformsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackgroundPictureBox As PictureBox
    Friend WithEvents Label1 As Label
End Class
