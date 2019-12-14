Module FuncionesGlobales

    Public tipodb = "\conexion.udl" 'default db nube
    'variables globales
    Public esDuelo As Boolean = False
    Public jugadorduelo1 As Boolean = True
    Public jugadorduelo2 As Boolean = False
    Public contadorJugador1 As Integer
    Public contadorJugador2 As Integer
    Public contadorPreguntaduelo As Integer = 1

    Public contadorPreguntasCorona1 As Integer
    Public NombrePersonajeCorona As String

    Public esCorona As Boolean = False


    Public Sub setNombrepersonaje(ByVal nombre As String) 'guarda nombre personajes
        NombrePersonajeCorona = nombre
    End Sub

    Public Function getNombrePersonaje() As String 'return el nombre
        Return NombrePersonajeCorona
    End Function

    Public Sub aumentoPreguntasGanadas() 'aumento de preguntas ganadas
        contadorPreguntasCorona1 += 1
    End Sub


    Public Function respuestasbuenasc() As Integer 'return total respuestas buenas
        Return contadorPreguntasCorona1
    End Function

    Public Function respuestasmalasc() As Integer 'resetea las preguntas y devuelve 0
        contadorPreguntasCorona1 = 0
        Return contadorPreguntasCorona1
    End Function


    Public Sub MuestraCoronaPreguntas(ByVal preg As Integer) 'metodo que muestra corona si hay 3 preg buenas
        If preg = 3 Then
            VentCorona.Show()
        End If
    End Sub


    Public Sub ComprobarRondaGlobal(ByRef Timer1 As Timer) 'llamar cuando se contesta de manera incorrecta

        If Persona1EstaJugando Then 'cambia el jugador activo
            Persona1EstaJugando = False
            Persona2EstaJugando = True
            Timer1.Enabled = False



            'MsgBox("Turno del jugador " & NombreJugador2Global)
        ElseIf Persona2EstaJugando Then 'cambia el jugador activo
            Persona1EstaJugando = True
            Persona2EstaJugando = False
            Timer1.Enabled = False



            'MsgBox("Turno del jugador " & NombreJugador1Global)
        End If

        If Persona1EstaJugando Then 'aumento de rondas
            RondaGlobal += 1
        End If
        'My.Forms.MuestraNombresJugadores.LRonda.Text = "Ronda " & RondaGlobal & "/25"
        My.Forms.MuestraNombresJugadores.Rondas(RondaGlobal)


    End Sub

    Function ComprobarPersonajes() As Boolean 'comprobar si los dos jugadores tienen personajes

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
