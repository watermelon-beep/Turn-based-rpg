Public Class battleField
    Private Sub battleField_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        heroAvatar.BorderStyle = BorderStyle.FixedSingle

    End Sub

    Private Sub healthBar_Paint(sender As Object, e As PaintEventArgs) Handles healthBar.Paint

    End Sub

    Private Sub heroAvatar_Paint(sender As Object, e As PaintEventArgs) Handles heroAvatar.Paint
        Using pen As New Pen(Color.FromArgb(255, 200, 50), 2)
            e.Graphics.DrawRectangle(
            pen,
            0,
            0,
            heroAvatar.Width - 2,
            heroAvatar.Height - 2
        )
        End Using
    End Sub
End Class