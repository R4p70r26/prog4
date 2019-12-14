
Public Class VentanaRespuesta
    Private Sub Btn_Continuar_Click(sender As Object, e As EventArgs) Handles Btn_Continuar.Click

        My.Computer.Audio.Play(My.Resources.Play, AudioPlayMode.Background)

        If esDuelo Then 'pregunta si es duelo
            contadorPreguntaduelo += 1 'aumenta al contador del duelo
            If jugadorduelo1 Then 'pregunta si es el jugador 1 en duelo
                contadorJugador1 += 1
                My.Forms.DueloSeleccionPers.dueloJugador1(contadorPreguntaduelo)
                Me.Close()

            Else ' sino es el jugador 2 en duelo
                contadorJugador2 += 1
                My.Forms.DueloSeleccionPers.dueloJugador2(contadorPreguntaduelo)
                Me.Close()

            End If
        Else 'si no es duelo
            If esCorona And Persona1EstaJugando Then 'si es corona y es persona 1
                Select Case getNombrePersonaje()'obtiene el nombre personaje seleccionado
                    Case "Entretenimiento" 'activa personajes
                        PersonajeEntretenimiento1 = True
                    Case "Historia"
                        PersonajeHistoria1 = True
                    Case "Geografia"
                        PersonajeGeografia1 = True
                    Case "Ciencia"
                        PersonajeCiencia1 = True
                    Case "Deporte"
                        PersonajeDeportes1 = True
                    Case "Arte"
                        PersonajeArte1 = True
                    Case Else

                End Select
                setNombrepersonaje("")
            End If
            'si es corona y es persona 1
            If esCorona And Persona2EstaJugando Then
                Select Case getNombrePersonaje()'obtiene el nombre personaje seleccionado
                    Case "Entretenimiento" 'activa personajes
                        PersonajeEntretenimiento2 = True
                    Case "Historia"
                        PersonajeHistoria2 = True
                    Case "Geografia"
                        PersonajeGeografia2 = True
                    Case "Ciencia"
                        PersonajeCiencia2 = True
                    Case "Deporte"
                        PersonajeDeportes2 = True
                    Case "Arte"
                        PersonajeArte2 = True
                    Case Else

                End Select
                setNombrepersonaje("")
            End If

            aumentoPreguntasGanadas() 'metodo aumento preguntas ganadas

            MuestraNombresJugadores.Show() 'sino es duelo muestra ruleta

            Me.Close() 'cierra ventana
        End If


    End Sub

    Private Sub VentanaRespuesta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextoPregunta.Text = Me.Tag.ToString
    End Sub

End Class


