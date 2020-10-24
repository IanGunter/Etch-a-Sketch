<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.DrawBox = New System.Windows.Forms.PictureBox()
        Me.ChooseColor = New System.Windows.Forms.ColorDialog()
        Me.ChooseColorButton = New System.Windows.Forms.Button()
        CType(Me.DrawBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DrawBox
        '
        Me.DrawBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DrawBox.Location = New System.Drawing.Point(119, 33)
        Me.DrawBox.Name = "DrawBox"
        Me.DrawBox.Size = New System.Drawing.Size(579, 299)
        Me.DrawBox.TabIndex = 0
        Me.DrawBox.TabStop = False
        '
        'ChooseColorButton
        '
        Me.ChooseColorButton.Location = New System.Drawing.Point(138, 356)
        Me.ChooseColorButton.Name = "ChooseColorButton"
        Me.ChooseColorButton.Size = New System.Drawing.Size(123, 50)
        Me.ChooseColorButton.TabIndex = 1
        Me.ChooseColorButton.Text = "Choose Color"
        Me.ChooseColorButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ChooseColorButton)
        Me.Controls.Add(Me.DrawBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DrawBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DrawBox As PictureBox
    Friend WithEvents ChooseColor As ColorDialog
    Friend WithEvents ChooseColorButton As Button
End Class
