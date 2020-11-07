'Ian Gunter
'RCET 0265
'Fall 2020
'Etch-A-Sketch
'https://github.com/IanGunter/Etch-a-Sketch.git

Option Strict On
Option Explicit On
Option Compare Text


Public Class EtchASketchForm

    Dim drawPen As New System.Drawing.Pen(Color.Black, 1)
    Dim erasePen As New System.Drawing.Pen(Color.FromName("Control"), 10)
    Dim g As System.Drawing.Graphics
    Dim lastX As Integer
    Dim lastY As Integer

    Sub Draw(x As Integer, y As Integer)
        'Performs the drawing action
        g = DrawBox.CreateGraphics
        If lastX = Nothing Then
            g.DrawLine(drawPen, x, y, x, y)

        Else
            g.DrawLine(drawPen, x, y, lastX, lastY)

        End If
        lastX = x
        lastY = y

    End Sub

    Sub DrawWaveforms()
        Dim SinPen As New System.Drawing.Pen(Color.Black, 4)
        Dim CoSinPen As New System.Drawing.Pen(Color.Red, 4)
        Dim TangentPen As New System.Drawing.Pen(Color.Blue, 4)
        Dim LinePen As New System.Drawing.Pen(Color.Black, 1)
        Dim x As Double
        Dim y As Double
        Dim LastX As Integer
        Dim LastY As Integer

        g = DrawBox.CreateGraphics

        For i = 1 To 10
            g.DrawLine(LinePen, 58 * i, 500, 58 * i, -500)
            g.DrawLine(LinePen, 1000, 30 * i, -1000, 30 * i)

        Next

        'Draw SinWave
        For Cycles As Double = 0 To 1000


            y = Math.Sin(Cycles / 550 * 2 * Math.PI) * 100 + 150
            x = Cycles
            g.DrawLine(SinPen, CType(x, Single), CType(y, Single), CType(x, Single) + 1, CType(y, Single))
        Next

        'Draw CoSinWave
        For Cycles As Double = 0 To 1000


            y = Math.Cos(Cycles / 550 * 2 * Math.PI) * 100 + 150
            x = Cycles
            g.DrawLine(CoSinPen, CType(x, Single), CType(y, Single), CType(x, Single) + 1, CType(y, Single))
        Next

        'Draw Tangent Wave
        For Cycles As Double = 0 To 1000


            y = Math.Tan(Cycles / 550 * 2 * Math.PI) * 20 + 150
            x = Cycles

            If LastX = Nothing Then
                LastX = CInt(x)
                LastY = CInt(y)
            ElseIf y - LastY < -50 Then
                LastX = CInt(x)
                LastY = CInt(y)
            End If
            g.DrawLine(TangentPen, CType(x, Single), CType(y, Single), LastX, LastY)

            LastY = CInt(y)
            LastX = CInt(x)

        Next

    End Sub

    Sub ClearPictureBox()

        'Skake Picture Box
        For i = 1 To 100
            DrawBox.Left = DrawBox.Left + 5
            BackgroundPictureBox.Left = BackgroundPictureBox.Left + 5

            DrawBox.Top = DrawBox.Top + 5
            BackgroundPictureBox.Top = BackgroundPictureBox.Top + 5

            DrawBox.Left = DrawBox.Left - 10
            BackgroundPictureBox.Left = BackgroundPictureBox.Left - 10

            DrawBox.Top = DrawBox.Top - 10
            BackgroundPictureBox.Top = BackgroundPictureBox.Top - 10

            DrawBox.Left = DrawBox.Left + 10
            BackgroundPictureBox.Left = BackgroundPictureBox.Left + 10

            DrawBox.Top = DrawBox.Top + 10
            BackgroundPictureBox.Top = BackgroundPictureBox.Top + 10

            DrawBox.Left = DrawBox.Left - 5
            BackgroundPictureBox.Left = BackgroundPictureBox.Left - 5

            DrawBox.Top = DrawBox.Top - 5
            BackgroundPictureBox.Top = BackgroundPictureBox.Top - 5
        Next

        'Clears Picture Box
        DrawBox.Image = Nothing


    End Sub

    Sub ColorChooser()
        'Displays Color Box with colors to choose from.
        ChooseColor.ShowDialog()
        drawPen.Color = ChooseColor.Color
    End Sub


    Sub Eraser(x As Integer, y As Integer)
        g = DrawBox.CreateGraphics
        If lastX = 0 Then
            g.DrawLine(erasePen, x, y, x, y)

        Else
            g.DrawLine(erasePen, x, y, lastX, lastY)

        End If
        lastX = x
        lastY = y
    End Sub

    Private Sub DrawBox_MouseHoldMove(sender As Object, e As MouseEventArgs) Handles DrawBox.MouseDown, DrawBox.MouseMove
        'Sequence is used to determin when to draw, erase, or open color menu.
        If e.Button.ToString = "Left" Then
            Draw(e.X, e.Y)
        ElseIf e.Button.ToString = "Right" Then
            Eraser(e.X, e.Y)

        End If
    End Sub
    Private Sub DrawBox_MouseClick(sender As Object, e As MouseEventArgs) Handles DrawBox.MouseDown
        'Summon ColorBox
        If e.Button.ToString = "Middle" Then
            ColorChooser()
        End If

    End Sub
    Private Sub DrawBox_MouseMove(sender As Object, e As MouseEventArgs) Handles DrawBox.MouseUp
        'Removes Refernce point to draw if mouse is unclicked
        lastX = 0
        lastY = 0
    End Sub

    Private Sub ChooseColorButton_Click(sender As Object, e As EventArgs) Handles SelectColorButton.Click, SelectColorToolStripMenuItem.Click
        ColorChooser()
    End Sub

    Sub Closeprogram() Handles ExitButton.Click, ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub DrawWaveformsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DrawWaveformsToolStripMenuItem.Click
        If g IsNot Nothing Then
            g.Clear(Color.FromName("Control"))
        End If
        DrawWaveforms()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click, ClearButton.Click
        ClearPictureBox()
    End Sub

    Private Sub DrawWaveformButton_Click(sender As Object, e As EventArgs) Handles DrawWaveformButton.Click
        If g IsNot Nothing Then
            g.Clear(Color.FromName("Control"))
        End If
        DrawWaveforms()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Etch-A-Sketch " & vbNewLine & "      Press the buttons to do what they say!")
    End Sub

End Class
