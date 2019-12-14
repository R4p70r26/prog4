Public Class VentanaInicioHistoria
    Private Sub VentanaInicioHistoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show() 'muestra ventana
        My.Computer.Audio.Play(My.Resources.Letter_Fall, AudioPlayMode.Background) 'reproduce audio y gif
        My.Computer.Audio.Play(My.Resources.Categories_Rules, AudioPlayMode.Background)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Audio.Play(My.Resources.Play, AudioPlayMode.Background) 'reproduce audio y gif
        My.Computer.Audio.Play(My.Resources.Question_Appears, AudioPlayMode.Background)
        My.Forms.VentHistoria.Show() 'muestra ventana
        Me.Close() 'çierra
    End Sub
End Class