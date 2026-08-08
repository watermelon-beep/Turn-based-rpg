Imports System.Drawing.Drawing2D
Public Class Form1

    Private Sub Roundbtn(btn As Button, radius As Integer)

        Dim path As New GraphicsPath()

        path.StartFigure()
        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, btn.Height - radius, radius, radius, 90, 90)
        path.CloseFigure()

        btn.Region = New Region(path)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Roundbtn(BtnPlay, 50)
        Roundbtn(btnSetting, 50)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnPlay.Click
        Me.Hide()
        levels.Show()

    End Sub
End Class
