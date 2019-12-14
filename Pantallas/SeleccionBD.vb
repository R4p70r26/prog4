Public Class SeleccionBD
    Private Sub SeleccionBD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'VentanaPrincipal.Hide() 'en el momento en que la ventana se carga se esconde la ventana principal

    End Sub

    Private Sub SeleccionBD_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'VentanaPrincipal.Show() 'si esta ventana se cierra muestra la ventana principal

    End Sub

    Private Sub AccessButton1_Click(sender As Object, e As EventArgs) Handles AccessButton1.Click
        Try
            tipodb = "\conexionA.udl" 'direccion de la bd access
            My.Computer.Audio.Play(My.Resources.Play, AudioPlayMode.Background)
            My.Forms.NombreUsuraio.Show()
            Me.Close() 'cierra la ventana
        Catch ex As Exception
            MsgBox("Error al conectar con access", vbCritical, "Preguntados")
        End Try

    End Sub

    Private Sub SqlButton2_Click(sender As Object, e As EventArgs) Handles sqlButton2.Click
        Try
            tipodb = "\conexion.udl" 'direccion de la bd nube
            My.Computer.Audio.Play(My.Resources.Play, AudioPlayMode.Background)
            My.Forms.NombreUsuraio.Show()
            Me.Close() 'cierra la ventana
        Catch ex As Exception
            MsgBox("Error al conectar con sql", vbCritical, "Preguntados")
        End Try

    End Sub

End Class