Public Class Form1
    Dim blnButtonDown, blnButtonDown_
    Private Sub Button1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Button1.Paint
        If blnButtonDown = False Then
            ControlPaint.DrawBorder3D(e.Graphics, sender.ClientRectangle,
                    Border3DStyle.Raised)
        Else
            ControlPaint.DrawBorder3D(e.Graphics, sender.ClientRectangle,
                    Border3DStyle.Sunken)
        End If
    End Sub
    Private Sub Button1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseDown
        blnButtonDown = True
        sender.Invalidate()
    End Sub

    Private Sub Button1_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseUp
        blnButtonDown = False
        sender.Invalidate()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub
    Private Sub Button2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Button2.Paint
        If blnButtonDown_ = False Then
            ControlPaint.DrawBorder3D(e.Graphics, sender.ClientRectangle,
                    Border3DStyle.Raised)
        Else
            ControlPaint.DrawBorder3D(e.Graphics, sender.ClientRectangle,
                    Border3DStyle.Sunken)
        End If
    End Sub
    Private Sub Button2_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button2.MouseDown
        blnButtonDown_ = True
        sender.Invalidate()
    End Sub

    Private Sub Button2_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button2.MouseUp
        blnButtonDown_ = False
        sender.Invalidate()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        RichTextBox1.Text = "Install Patch First For Generate Your Keys"
    End Sub
End Class
