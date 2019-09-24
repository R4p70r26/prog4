Public Class VentanaInicioArte
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Audio.Play(My.Resources.Play, AudioPlayMode.Background)
        My.Computer.Audio.Play(My.Resources.Question_Appears, AudioPlayMode.Background)
        My.Forms.VentArte.Show()
    End Sub

    Private Sub VentanaInicioArte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        My.Computer.Audio.Play(My.Resources.Letter_Fall, AudioPlayMode.Background)
        My.Computer.Audio.Play(My.Resources.Categories_Rules, AudioPlayMode.Background)

    End Sub
End Class