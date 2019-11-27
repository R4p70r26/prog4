Public Class VentanaIncorrecta
    Private Sub Pregunta_TextChanged(sender As Object, e As EventArgs) Handles Pregunta.TextChanged

    End Sub



    Private Sub Btn_Continuar_Click(sender As Object, e As EventArgs) Handles Btn_Continuar.Click
        If esDuelo Then
            contadorPreguntaduelo += 1
            If jugadorduelo1 Then

                My.Forms.DueloSeleccionPers.dueloJugador1(contadorPreguntaduelo)
            Else

                My.Forms.DueloSeleccionPers.dueloJugador2(contadorPreguntaduelo)
            End If
        Else
            My.Forms.MuestraNombresJugadores.Show()
            Me.Close()
        End If




    End Sub

    Private Sub VentanaIncorrecta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Pregunta.Text = Me.Tag.ToString
    End Sub
End Class