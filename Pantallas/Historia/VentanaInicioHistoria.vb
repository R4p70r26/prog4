Public Class VentanaInicioHistoria
    Private Sub VentanaInicioHistoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        My.Computer.Audio.Play(My.Resources.Letter_Fall, AudioPlayMode.Background)
        My.Computer.Audio.Play(My.Resources.Categories_Rules, AudioPlayMode.Background)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Audio.Play(My.Resources.Play, AudioPlayMode.Background)
        My.Computer.Audio.Play(My.Resources.Question_Appears, AudioPlayMode.Background)
        My.Forms.VentHistoria.Show()
        Me.Close()
    End Sub
End Class