Public Class VentanaInicionCiencia
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Audio.Play(My.Resources.Play, AudioPlayMode.Background) 'reproduce audio y gif
        My.Computer.Audio.Play(My.Resources.Question_Appears, AudioPlayMode.Background)
        My.Forms.VentCiencia.Show() 'muestra ventana ciencia 
        Me.Close() 'cierra ventana

    End Sub

    Private Sub VentanaInicionCiencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show() 'muestra ventana
        My.Computer.Audio.Play(My.Resources.Letter_Fall, AudioPlayMode.Background) 'reproduce audio y gif
        My.Computer.Audio.Play(My.Resources.Categories_Rules, AudioPlayMode.Background)
    End Sub
End Class