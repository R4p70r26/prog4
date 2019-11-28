Public Class MuestraNombresJugadores

    Private picnum As Integer = 0
    Private randomNum As Integer
    Private randomObjeto As New Random()



    Private Sub MuestraNombresJugadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FindeRonda()

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

    Private Sub EmpezarButton1_Click(sender As Object, e As EventArgs) Handles btnPregunta1.Click


    End Sub

    Private Sub PicBoxRuleta_Click(sender As Object, e As EventArgs) Handles picBoxRuleta.Click
        TVueltas.Enabled = Not (TVueltas.Enabled)

    End Sub

    Private Sub TVueltas_Tick(sender As Object, e As EventArgs) Handles TVueltas.Tick
        Select Case picnum'select case que cambia las imagenes como si rotara
            Case 1
                picBoxRuleta.Image = My.Resources.ruletaarte
            Case 2
                picBoxRuleta.Image = My.Resources.ruletaEntretenimiento
            Case 3
                picBoxRuleta.Image = My.Resources.RuletaCorona
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
                    picBoxRuleta.Image = My.Resources.RuletaArte

                    VentanaInicioArte.Show() 'muestra ventana categoria
                    Me.Close() 'cierra esta ventana


                Case 2
                    picBoxRuleta.Image = My.Resources.ruletaEntretenimiento

                    VentanaInicioEntretenimiento.Show() 'muestra ventana categoria
                    Me.Close()'cierra esta ventana


                Case 3
                    picBoxRuleta.Image = My.Resources.ruletaCorona

                    VentCorona.Show() 'muestra ventana categoria
                    Me.Close()'cierra esta ventana


                Case 4
                    picBoxRuleta.Image = My.Resources.ruletaGeografia

                    VentanaInicioGeografia.Show() 'muestra ventana categoria
                    Me.Close()'cierra esta ventana


                Case 5
                    picBoxRuleta.Image = My.Resources.ruletaCiencia

                    VentanaInicionCiencia.Show() 'muestra ventana categoria
                    Me.Close()'cierra esta ventana


                Case 6
                    picBoxRuleta.Image = My.Resources.ruletaHistoria

                    VentanaInicioHistoria.Show() 'muestra ventana categoria
                    Me.Close()'cierra esta ventana


                Case 7
                    picBoxRuleta.Image = My.Resources.ruletaDeportes

                    VentanaInicioDeportes.Show() 'muestra ventana categoria
                    Me.Close() 'cierra esta ventana


            End Select

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        VentArte.Show() 'muestra ventana categoria
    End Sub

    Public Sub Rondas(ByVal ronda)

        LRonda.Text = "Ronda " & ronda & "/25"

    End Sub

    Private Sub FindeRonda()

        If RondaGlobal > 25 Then

            If personajeJugador1() > PersonajeJugador2() Then
                MsgBox(NombreJugador1Global & " Gano", MsgBoxStyle.Information, "Felicidades")
                VentanaPrincipal.Show()
                Me.Close()
            Else
                MsgBox(NombreJugador2Global & " Gano", MsgBoxStyle.Information, "Felicidades")
                VentanaPrincipal.Show()
                Me.Close()
            End If

        End If

    End Sub

    Private Function personajeJugador1() As Integer
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

    Private Function PersonajeJugador2() As Integer
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