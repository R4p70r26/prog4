Public Class VentDuelo
    Private Sub BtnCorona_Click(sender As Object, e As EventArgs) Handles BtnCorona.Click
        My.Computer.Audio.Play(My.Resources.Play, AudioPlayMode.Background)
        VentCorona.Show() 'muestra corona
        Me.Close() 'cierra ventana
    End Sub

    Private Sub BtnDuelo_Click(sender As Object, e As EventArgs) Handles BtnDuelo.Click
        My.Computer.Audio.Play(My.Resources.Play, AudioPlayMode.Background)
        DueloSeleccionPers.Show() 'muestra duelo
        Me.Close() 'cierra ventana

    End Sub

    Private Sub VentDuelo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Deul_Request, AudioPlayMode.Background) 'repro audio

    End Sub
End Class

