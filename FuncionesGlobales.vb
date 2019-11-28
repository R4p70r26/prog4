Module FuncionesGlobales

    Public tipodb = "\conexion.udl"

    Public esDuelo As Boolean = False
    Public jugadorduelo1 As Boolean = True
    Public jugadorduelo2 As Boolean = False
    Public contadorJugador1 As Integer
    Public contadorJugador2 As Integer
    Public contadorPreguntaduelo As Integer = 1


    Public Sub ComprobarRondaGlobal(ByRef Timer1 As Timer) 'llamar cuando se contesta de manera incorrecta

        If Persona1EstaJugando Then
            Persona1EstaJugando = False
            Persona2EstaJugando = True
            Timer1.Enabled = False
            MsgBox("Turno jugador " & NombreJugador2Global)
        ElseIf Persona2EstaJugando Then
            Persona1EstaJugando = True
            Persona2EstaJugando = False
            Timer1.Enabled = False
            MsgBox("Turno jugador " & NombreJugador1Global)
        End If

        If Persona2EstaJugando Then
            RondaGlobal += 1
        End If
        My.Forms.MuestraNombresJugadores.LRonda.Text = "Ronda " & RondaGlobal & "/25"
        My.Forms.MuestraNombresJugadores.Rondas(RondaGlobal)


    End Sub

    Function ComprobarPersonajes() As Boolean

        If PersonajeArte1 = True Or PersonajeCiencia1 = True Or PersonajeDeportes1 = True Or PersonajeEntretenimiento1 = True Or PersonajeGeografia1 = True Or PersonajeHistoria1 = True Then
            If PersonajeArte2 = True Or PersonajeCiencia2 = True Or PersonajeDeportes2 = True Or PersonajeEntretenimiento2 = True Or PersonajeGeografia2 = True Or PersonajeHistoria2 = True Then
                Return True

            Else
                Return False
            End If

        Else
            Return False
        End If

    End Function




End Module
