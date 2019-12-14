Public Class MuestraNombresJugadores

    Private picnum As Integer = 0
    Private randomNum As Integer
    Private randomObjeto As New Random()


    Private Sub MuestraNombresJugadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FindeRonda()
        Rondas(RondaGlobal)

        Try
            'Muestra en las etiquetas el nombre de los jugadores ingresados en el formulario anterior
            NombreJugador1.Text = NombreJugador1Global
            NombreJugador2.Text = NombreJugador2Global

            '248; 179; 6 color boton respuestas

            If Persona1EstaJugando Then
                NombreJugador1.Enabled = True
                NombreJugador2.Enabled = False

                Select Case respuestasbuenasc()'calcula respu buenas y cambia color a lineas
                    Case 1
                        btnPregunta1.Enabled = True
                        btnPregunta1.BackColor = Color.Green
                    Case 2
                        btnPregunta1.Enabled = True
                        btnPregunta1.BackColor = Color.Green
                        btnPregunta2.Enabled = True
                        btnPregunta2.BackColor = Color.Green
                    Case 3
                        btnPregunta1.Enabled = True
                        btnPregunta1.BackColor = Color.Green
                        btnPregunta2.Enabled = True
                        btnPregunta2.BackColor = Color.Green
                        btnPregunta3.Enabled = True
                        btnPregunta3.BackColor = Color.Green

                        MuestraCoronaPreguntas(respuestasbuenasc()) 'muestra corona si llega a 3
                        Me.Close()

                    Case Else 'pone en blanco las botones
                        btnPregunta1.Enabled = False
                        btnPregunta1.BackColor = Color.White

                        btnPregunta2.Enabled = False
                        btnPregunta2.BackColor = Color.White

                        btnPregunta3.Enabled = False
                        btnPregunta3.BackColor = Color.White

                End Select

            Else
                NombreJugador2.Enabled = True
                NombreJugador1.Enabled = False

                Select Case respuestasbuenasc()'calcula respu buenas y cambia color a lineas
                    Case 1
                        btnPregunta1.Enabled = True
                        btnPregunta1.BackColor = Color.Green
                    Case 2
                        btnPregunta1.Enabled = True
                        btnPregunta1.BackColor = Color.Green
                        btnPregunta2.Enabled = True
                        btnPregunta2.BackColor = Color.Green
                    Case 3
                        btnPregunta1.Enabled = True
                        btnPregunta1.BackColor = Color.Green
                        btnPregunta2.Enabled = True
                        btnPregunta2.BackColor = Color.Green
                        btnPregunta3.Enabled = True
                        btnPregunta3.BackColor = Color.Green

                        MuestraCoronaPreguntas(respuestasbuenasc()) 'muestra corona si llega a 3
                        Me.Close()

                    Case Else 'pone en blanco las botones
                        btnPregunta1.Enabled = False
                        btnPregunta1.BackColor = Color.White

                        btnPregunta2.Enabled = False
                        btnPregunta2.BackColor = Color.White

                        btnPregunta3.Enabled = False
                        btnPregunta3.BackColor = Color.White

                End Select


            End If

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
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub PicBoxRuleta_Click(sender As Object, e As EventArgs) Handles picBoxRuleta.Click

        'sonido ruleta aqui
        TVueltas.Enabled = Not (TVueltas.Enabled) 'gira la ruleta

    End Sub

    Private Sub TVueltas_Tick(sender As Object, e As EventArgs) Handles TVueltas.Tick
        Select Case picnum'select case que cambia las imagenes como si rotara
            Case 1
                picBoxRuleta.Image = My.Resources.ruletaarte
            Case 2
                picBoxRuleta.Image = My.Resources.ruletaEntretenimiento
            Case 3
                picBoxRuleta.Image = My.Resources.ruletaCorona
            Case 4
                picBoxRuleta.Image = My.Resources.ruletaGeografia
            Case 5
                picBoxRuleta.Image = My.Resources.ruletaCiencia
            Case 6
                picBoxRuleta.Image = My.Resources.ruletaHistoria
            Case 7
                picBoxRuleta.Image = My.Resources.ruletaDeportes
                TVueltas.Interval += 1 'aumenta el intervalo del tiempo
            Case Else
                picnum = 0 'resetea el valor para que vuelva a la imagen original
        End Select
        picnum += 1 'aumenta para cambiar la imagen

        If TVueltas.Interval >= 20 Then 'si el contador del tiempo llega a 10 detiene la rotacion de imagenes
            TVueltas.Enabled = Not (TVueltas.Enabled)
            TVueltas.Interval = 1 'vuelve a poner el intervalo en 1 para siguiente turno

            'Randomize()
            'randomNum = Int((8 * Rnd() + 1)) 'una forma de usar el random
            randomNum = randomObjeto.Next(1, 8) 'otra forma con random para que me de una numero entre 1 y 7
            Select Case randomNum 'cambia la imagen segun el numero dado 
                Case 1
                    picBoxRuleta.Image = My.Resources.ruletaarte 'cambia imagen

                    VentanaInicioArte.Show() 'muestra ventana categoria
                    Me.Close() 'cierra esta ventana


                Case 2
                    picBoxRuleta.Image = My.Resources.ruletaEntretenimiento 'cambia imagen

                    VentanaInicioEntretenimiento.Show() 'muestra ventana categoria
                    Me.Close()'cierra esta ventana


                Case 3
                    picBoxRuleta.Image = My.Resources.ruletaCorona 'cambia imagen

                    If ComprobarPersonajes() Then
                        VentDuelo.Show()
                        Me.Close()
                    Else
                        VentCorona.Show() 'muestra ventana categoria
                        Me.Close() 'cierra esta ventana
                    End If


                Case 4
                    picBoxRuleta.Image = My.Resources.ruletaGeografia 'cambia imagen

                    VentanaInicioGeografia.Show() 'muestra ventana categoria
                    Me.Close()'cierra esta ventana


                Case 5
                    picBoxRuleta.Image = My.Resources.ruletaCiencia 'cambia imagen

                    VentanaInicionCiencia.Show() 'muestra ventana categoria
                    Me.Close()'cierra esta ventana


                Case 6
                    picBoxRuleta.Image = My.Resources.ruletaHistoria 'cambia imagen

                    VentanaInicioHistoria.Show() 'muestra ventana categoria
                    Me.Close()'cierra esta ventana


                Case 7
                    picBoxRuleta.Image = My.Resources.ruletaDeportes 'cambia imagen

                    VentanaInicioDeportes.Show() 'muestra ventana categoria
                    Me.Close() 'cierra esta ventana


            End Select

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'VentArte.Show() 'muestra ventana categoria

        'VentCorona.Show()
        'Me.Close()


    End Sub

    Public Sub Rondas(ByVal ronda)
        LRonda.Text = "Ronda " & ronda & "/25" 'actualiza ronda actual

    End Sub

    Private Sub FindeRonda() 'define el ganador al finalizar las fondas

        If RondaGlobal > 25 Then

            If personajeJugador1() > PersonajeJugador2() Then
                MsgBox(NombreJugador1Global & " Gano", vbInformation, "Felicidades")
                VentanaPrincipal.Show()
                Me.Close()
            Else
                MsgBox(NombreJugador2Global & " Gano", vbInformation, "Felicidades")
                VentanaPrincipal.Show()
                Me.Close()
            End If

        End If

    End Sub

    Private Function personajeJugador1() As Integer 'contador de personajes
        Dim contador As Integer = 0
        If PersonajeArte1 = True Then
            contador += 1

        ElseIf PersonajeCiencia1 = True Then
            contador += 1

        ElseIf PersonajeDeportes1 = True Then
            contador += 1

        ElseIf PersonajeEntretenimiento1 = True Then
            contador += 1

        ElseIf PersonajeGeografia1 = True Then
            contador += 1

        ElseIf PersonajeHistoria1 = True Then
            contador += 1
        End If
        Return contador
    End Function


    Private Function PersonajeJugador2() As Integer 'contador de personajes
        Dim contador As Integer = 0
        If PersonajeArte2 = True Then
            contador += 1

        ElseIf PersonajeCiencia2 = True Then
            contador += 1

        ElseIf PersonajeDeportes2 = True Then
            contador += 1

        ElseIf PersonajeEntretenimiento2 = True Then
            contador += 1

        ElseIf PersonajeGeografia2 = True Then
            contador += 1

        ElseIf PersonajeHistoria2 = True Then
            contador += 1
        End If
        Return contador
    End Function






End Class