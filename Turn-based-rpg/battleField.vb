Public Class battleField

    Private enemyMaxHealth As Integer = 400
    Private enemyCurrentHealth As Integer = 400
    Private Sub battleField_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        heroAvatar.BorderStyle = BorderStyle.FixedSingle

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

    Private Sub attackBtn_MouseHover(sender As Object, e As EventArgs) Handles attackBtn.MouseHover
        attacklbl.Text = "choose your attack"
    End Sub

    Private Sub attackBtn_MouseLeave(sender As Object, e As EventArgs) Handles attackBtn.MouseLeave
        attacklbl.Text = ""
    End Sub

    Private Sub attackBtn_Click(sender As Object, e As EventArgs) Handles attackBtn.Click
        Dim heroAttack = 100
        Dim attackCount As Integer = useAttack(heroAttack)

        damageCountlbl.Text = CStr(attackCount)
    End Sub

    Function useAttack(attack As Integer) As Integer
        enemyCurrentHealth -= attack
        enemyHealth.Width = CInt(enemyCurrentHealth)
        enemy1
        Return enemyHealth.Width
    End Function
End Class