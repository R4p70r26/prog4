
Public Class VentanaRespuesta
    Private Sub Btn_Continuar_Click(sender As Object, e As EventArgs) Handles Btn_Continuar.Click
        If esDuelo Then 'pregunta si es duelo
            contadorPreguntaduelo += 1 'aumenta al contador del duelo
            If jugadorduelo1 Then 'pregunta si es el jugador 1 en duelo
                contadorJugador1 += 1
                My.Forms.DueloSeleccionPers.dueloJugador1(contadorPreguntaduelo)
            Else ' sino es el jugador 2 en duelo
                contadorJugador2 += 1
                My.Forms.DueloSeleccionPers.dueloJugador2(contadorPreguntaduelo)
            End If
        Else
            My.Forms.MuestraNombresJugadores.Show() 'sino es duelo muestra ruleta
            Me.Close()
        End If


    End Sub

    Private Sub VentanaRespuesta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextoPregunta.Text = Me.Tag.ToString
    End Sub
End Class