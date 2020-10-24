Public Class Form1

    Dim drawPen As New System.Drawing.Pen(Color.Black, 1)
    Dim erasePen As New System.Drawing.Pen(Color.FromName("Control"), 10)
    Dim g As System.Drawing.Graphics
    Dim LastX As Integer
    Dim LastY As Integer


    Sub Draw(x As Integer, y As Integer)
        g = DrawBox.CreateGraphics
        If LastX = Nothing Then
            g.DrawLine(drawPen, x, y, x, y)

        Else
            g.DrawLine(drawPen, x, y, LastX, LastY)


        End If
        LastX = x
        LastY = y


    End Sub

    Sub ColorChooser()
        ChooseColor.ShowDialog()
        drawPen.Color = ChooseColor.Color
    End Sub


    Sub Eraser(x As Integer, y As Integer)
        g = DrawBox.CreateGraphics()
        g.DrawLine(erasePen, x, y, x - 1, y - 1)
    End Sub

    Private Sub DrawBox_MouseHoldMove(sender As Object, e As MouseEventArgs) Handles DrawBox.MouseDown, DrawBox.MouseMove
        If e.Button.ToString = "Left" Then
            Draw(e.X, e.Y)
        ElseIf e.Button.ToString = "Right" Then
            Eraser(e.X, e.Y)
        ElseIf e.Button.ToString = "Middle" Then
            ColorChooser()
        End If
    End Sub

    Private Sub ChooseColorButton_Click(sender As Object, e As EventArgs) Handles ChooseColorButton.Click
        ColorChooser()
    End Sub
End Class
