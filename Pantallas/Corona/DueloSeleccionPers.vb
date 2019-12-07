Public Class DueloSeleccionPers

    Private Sub DueloSeleccionPers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Muestra en las etiquetas el nombre de los jugadores ingresados en el formulario anterior
            NombreJugador1.Text = NombreJugador1Global
            NombreJugador2.Text = NombreJugador2Global

            'establece cuales personajes ha obtenido el jugador
            'de acuerdo al estado de los personajes (true - false)
            'habilitando los que este halla ganado durante el juego

            'jugador 1
            ' si el estado del personaje representado en la variable global es true
            'habilitamos el boton para ver la imagen del personaje a colores
            BtnArte1.Enabled = PersonajeArte1
            BtnCiencia1.Enabled = PersonajeCiencia1
            BtnDeportes1.Enabled = PersonajeDeportes1
            BtnEntretenimiento1.Enabled = PersonajeEntretenimiento1
            BtnGeografia1.Enabled = PersonajeGeografia1
            BtnHistoria1.Enabled = PersonajeHistoria1


            'jugador 2
            ' si el estado del personaje representado en la variable global es true
            'habilitamos el boton para ver la imagen del personaje a colores
            BtnArte2.Enabled = PersonajeArte2
            BtnCiencia2.Enabled = PersonajeCiencia2
            BtnDeportes2.Enabled = PersonajeDeportes2
            BtnEntretenimiento2.Enabled = PersonajeEntretenimiento2
            BtnGeografia2.Enabled = PersonajeGeografia2
            BtnHistoria2.Enabled = PersonajeHistoria2
        Catch ex As Exception

        End Try
    End Sub

    'variable del estado de los personajes del jugador 1
    Private PersonajeArte1temp As Boolean = False
    Private PersonajeHistoria1temp As Boolean = False
    Private PersonajeCiencia1temp As Boolean = False
    Private PersonajeDeportes1temp As Boolean = False
    Private PersonajeEntretenimiento1temp As Boolean = False
    Private PersonajeGeografia1temp As Boolean = False

    'variable del estado de los personajes del jugador 2
    Private PersonajeArte2temp As Boolean = False
    Private PersonajeHistoria2temp As Boolean = False
    Private PersonajeCiencia2temp As Boolean = False
    Private PersonajeDeportes2temp As Boolean = False
    Private PersonajeEntretenimiento2temp As Boolean = False
    Private PersonajeGeografia2temp As Boolean = False

    Private ContadorJug1 = 0
    Private ContadorJug2 = 0

    'metodos que selecciona el presonaje que el jugador seleccione
    Private Sub BtnEntretenimiento1_Click(sender As Object, e As EventArgs) Handles BtnEntretenimiento1.Click

        BtnArte1.Enabled = False
        BtnCiencia1.Enabled = False
        BtnDeportes1.Enabled = False
        BtnGeografia1.Enabled = False
        BtnHistoria1.Enabled = False
        BtnEntretenimiento1.Enabled = True

        PersonajeEntretenimiento1temp = True

    End Sub

    Private Sub BtnArte1_Click(sender As Object, e As EventArgs) Handles BtnArte1.Click
        BtnArte1.Enabled = True
        BtnCiencia1.Enabled = False
        BtnDeportes1.Enabled = False
        BtnGeografia1.Enabled = False
        BtnHistoria1.Enabled = False
        BtnEntretenimiento1.Enabled = False

        PersonajeArte1temp = True

    End Sub

    Private Sub BtnDeportes1_Click(sender As Object, e As EventArgs) Handles BtnDeportes1.Click
        BtnArte1.Enabled = False
        BtnCiencia1.Enabled = False
        BtnDeportes1.Enabled = True
        BtnGeografia1.Enabled = False
        BtnHistoria1.Enabled = False
        BtnEntretenimiento1.Enabled = False

        PersonajeDeportes1temp = True

    End Sub

    Private Sub BtnHistoria1_Click(sender As Object, e As EventArgs) Handles BtnHistoria1.Click
        BtnArte1.Enabled = False
        BtnCiencia1.Enabled = False
        BtnDeportes1.Enabled = False
        BtnGeografia1.Enabled = False
        BtnHistoria1.Enabled = True
        BtnEntretenimiento1.Enabled = False

        PersonajeHistoria1temp = True
    End Sub

    Private Sub BtnCiencia1_Click(sender As Object, e As EventArgs) Handles BtnCiencia1.Click
        BtnArte1.Enabled = False
        BtnCiencia1.Enabled = True
        BtnDeportes1.Enabled = False
        BtnGeografia1.Enabled = False
        BtnHistoria1.Enabled = False
        BtnEntretenimiento1.Enabled = False

        PersonajeCiencia1temp = True

    End Sub

    Private Sub BtnGeografia1_Click(sender As Object, e As EventArgs) Handles BtnGeografia1.Click
        BtnArte1.Enabled = False
        BtnCiencia1.Enabled = False
        BtnDeportes1.Enabled = False
        BtnGeografia1.Enabled = True
        BtnHistoria1.Enabled = False
        BtnEntretenimiento1.Enabled = False

        PersonajeGeografia1temp = True

    End Sub

    Private Sub BtnGeografia2_Click(sender As Object, e As EventArgs) Handles BtnGeografia2.Click
        BtnArte2.Enabled = False
        BtnCiencia2.Enabled = False
        BtnDeportes2.Enabled = False
        BtnGeografia2.Enabled = True
        BtnHistoria2.Enabled = False
        BtnEntretenimiento2.Enabled = False

        PersonajeGeografia2temp = True

    End Sub

    Private Sub BtnCiencia2_Click(sender As Object, e As EventArgs) Handles BtnCiencia2.Click
        BtnArte2.Enabled = False
        BtnCiencia2.Enabled = True
        BtnDeportes2.Enabled = False
        BtnGeografia2.Enabled = False
        BtnHistoria2.Enabled = False
        BtnEntretenimiento2.Enabled = False

        PersonajeCiencia2temp = True

    End Sub

    Private Sub BtnHistoria2_Click(sender As Object, e As EventArgs) Handles BtnHistoria2.Click
        BtnArte2.Enabled = False
        BtnCiencia2.Enabled = False
        BtnDeportes2.Enabled = False
        BtnGeografia2.Enabled = False
        BtnHistoria2.Enabled = True
        BtnEntretenimiento2.Enabled = False

        PersonajeHistoria2temp = True

    End Sub

    Private Sub BtnDeportes2_Click(sender As Object, e As EventArgs) Handles BtnDeportes2.Click
        BtnArte2.Enabled = False
        BtnCiencia2.Enabled = False
        BtnDeportes2.Enabled = True
        BtnGeografia2.Enabled = False
        BtnHistoria2.Enabled = False
        BtnEntretenimiento2.Enabled = False

        PersonajeDeportes2temp = True

    End Sub

    Private Sub BtnArte2_Click(sender As Object, e As EventArgs) Handles BtnArte2.Click
        BtnArte2.Enabled = True
        BtnCiencia2.Enabled = False
        BtnDeportes2.Enabled = False
        BtnGeografia2.Enabled = False
        BtnHistoria2.Enabled = False
        BtnEntretenimiento2.Enabled = False

        PersonajeArte2temp = True

    End Sub

    Private Sub BtnEntretenimiento2_Click(sender As Object, e As EventArgs) Handles BtnEntretenimiento2.Click
        BtnArte2.Enabled = False
        BtnCiencia2.Enabled = False
        BtnDeportes2.Enabled = False
        BtnGeografia2.Enabled = False
        BtnHistoria2.Enabled = False
        BtnEntretenimiento2.Enabled = True

        PersonajeEntretenimiento2temp = True

    End Sub

    Private Sub BtnInicoDuelo_Click(sender As Object, e As EventArgs) Handles BtnInicoDuelo.Click

        esDuelo = True 'activa el duelo
        dueloJugador1(contadorPreguntaduelo)

        Me.Close()


    End Sub

    Public Sub dueloJugador1(ByRef index As Integer)

        'abre las preguntas 
        Select Case index
            Case 1
                VentCiencia.Show()
            Case 2
                VentDeporte.Show()
            Case 3
                VentEntretenimiento.Show()
            Case 4
                VentGeografia.Show()
            Case 5
                VentHistoria.Show()
            Case 6
                VentArte.Show()
            Case Else
                jugadorduelo1 = False 'duelo de jugador 1 acaba
                jugadorduelo2 = True 'duelo de jugador 2 inicia
                contadorPreguntaduelo = 1 'reset al contador de las preguntas
                dueloJugador2(contadorPreguntaduelo) 'inicia el duelo jugador 2

        End Select




    End Sub

    Public Sub dueloJugador2(ByRef index As Integer)
        'abre las preguntas 
        Select Case index
            Case 1
                MsgBox("Turno del jugador " + NombreJugador2Global, vbInformation)
                VentCiencia.Show()
            Case 2
                VentDeporte.Show()
            Case 3
                VentEntretenimiento.Show()
            Case 4
                VentGeografia.Show()
            Case 5
                VentHistoria.Show()
            Case 6
                VentArte.Show()
            Case Else
                jugadorduelo1 = False 'duelo de jugador 1 acaba
                jugadorduelo2 = False 'duelo de jugador 2 inicia
                esDuelo = False 'termina el duelo
                contadorPreguntaduelo = 1 'reset al contador de las preguntas

                ganadorDuelo()
        End Select



    End Sub

    Private Sub ganadorDuelo()
        If contadorJugador1 < contadorJugador2 Then 'comprueba quien gano mas preguntas
            MsgBox("El jugador " + NombreJugador1Global + " ha ganado el duelo", vbInformation)

            'activa el personaje seleccionado 
            If PersonajeArte2temp Then
                PersonajeArte1 = True
                PersonajeArte2 = False
            End If
            If PersonajeCiencia2temp Then
                PersonajeCiencia1 = True
                PersonajeCiencia2 = False
            End If
            If PersonajeDeportes2temp Then
                PersonajeDeportes1 = True
                PersonajeDeportes2 = False
            End If
            If PersonajeEntretenimiento2temp Then
                PersonajeEntretenimiento1 = True
                PersonajeEntretenimiento2 = False
            End If
            If PersonajeGeografia2temp Then
                PersonajeGeografia1 = True
                PersonajeGeografia2 = False
            End If
            If PersonajeHistoria2temp Then
                PersonajeHistoria1 = True
                PersonajeHistoria2 = False
            End If

        Else
            MsgBox("El jugador " + NombreJugador2Global + " ha ganado el duelo", MsgBoxStyle.Information)

            'activa el personaje seleccionado 
            If PersonajeArte1temp Then
                PersonajeArte1 = False
                PersonajeArte2 = True
            End If
            If PersonajeCiencia2temp Then
                PersonajeCiencia1 = False
                PersonajeCiencia2 = True
            End If
            If PersonajeDeportes2temp Then
                PersonajeDeportes1 = False
                PersonajeDeportes2 = True
            End If
            If PersonajeEntretenimiento2temp Then
                PersonajeEntretenimiento1 = False
                PersonajeEntretenimiento2 = True
            End If
            If PersonajeGeografia2temp Then
                PersonajeGeografia1 = False
                PersonajeGeografia2 = True
            End If
            If PersonajeHistoria2temp Then
                PersonajeHistoria1 = False
                PersonajeHistoria2 = True
            End If

        End If
    End Sub

End Class


