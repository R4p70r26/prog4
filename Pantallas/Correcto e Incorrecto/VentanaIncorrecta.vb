Public Class VentanaIncorrecta

    Private Sub Btn_Continuar_Click(sender As Object, e As EventArgs) Handles Btn_Continuar.Click
        If esDuelo Then 'pregunta si es duelo
            contadorPreguntaduelo += 1 'aumenta al contador del duelo
            If jugadorduelo1 Then 'pregunta si es el jugador 1 en duelo

                My.Forms.DueloSeleccionPers.dueloJugador1(contadorPreguntaduelo)
                Me.Close()

            Else ' sino es el jugador 2 en duelo

                My.Forms.DueloSeleccionPers.dueloJugador2(contadorPreguntaduelo)
                Me.Close()

            End If
        Else
            respuestasmalasc()
            My.Forms.MuestraNombresJugadores.Show() 'sino es duelo muestra ruleta
            Me.Close()
        End If




    End Sub

    Private Sub VentanaIncorrecta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Pregunta.Text = Me.Tag.ToString
    End Sub
End Class