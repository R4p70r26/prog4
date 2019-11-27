
Public Class VentanaRespuesta
    Private Sub Btn_Continuar_Click(sender As Object, e As EventArgs) Handles Btn_Continuar.Click
        If esDuelo Then
            contadorPreguntaduelo += 1
            If jugadorduelo1 Then
                contadorJugador1 += 1
                My.Forms.DueloSeleccionPers.dueloJugador1(contadorPreguntaduelo)
            Else
                contadorJugador2 += 1
                My.Forms.DueloSeleccionPers.dueloJugador2(contadorPreguntaduelo)
            End If
        Else
            My.Forms.MuestraNombresJugadores.Show()
            Me.Close()
        End If


    End Sub

    Private Sub VentanaRespuesta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextoPregunta.Text = Me.Tag.ToString
    End Sub
End Class