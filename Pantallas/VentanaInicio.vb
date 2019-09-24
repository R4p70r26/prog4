Public Class VentanaInicio
    Private Sub VentanaInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Muestra la ventana de inicio, nesesario que aparesca antes de empezar con la preproduccion del audio
        Me.Visible = True

        'Reproduce el audio del inicio de la App, no continua con la siguiente linea hasta reproducirlo por completo ( AudioPlayMode.WaitToComplete )
        My.Computer.Audio.Play(My.Resources.Startup_App, AudioPlayMode.WaitToComplete)

        'Abre la siguiente ventana(VentanaPrincipal) y cierra la ventana actual
        My.Forms.VentanaPrincipal.Show()
        Me.Close()


    End Sub
End Class