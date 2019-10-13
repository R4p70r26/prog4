Module FuncionesGlobales

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

End Module
