Public Class VentanaPrincipal
    'este form no se puede cerrar porque sino se cierra todo el programa(por el momento)
    Private Sub JugarAhoraButton1_Click(sender As Object, e As EventArgs) Handles JugarAhoraButton1.Click

        'Reproduce el audio al dar click en el boton JUGAR
        My.Computer.Audio.Play(My.Resources.Play, AudioPlayMode.Background)

        SeleccionBD.Show() 'llama a la ventana seleccionBD
        'Me.Close()

    End Sub

    Private Sub VentanaPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Audio.Play(My.Resources.Play, AudioPlayMode.Background)
        IntroducionPreguntas.Show() 'llama ventana agregar preguntas

    End Sub


End Class
