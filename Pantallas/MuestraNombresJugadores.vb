Public Class MuestraNombresJugadores

    Private picnum As Integer = 0
    Private randomNum As Integer
    Private randomObjeto As New Random()

    Private Sub MuestraNombresJugadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            'Muestra en las etiquetas el nombre de los jugadores ingresados en el formulario anterior
            NombreJugador1.Text = My.Forms.NombreUsuraio.Jugardor1.Text
            NombreJugador2.Text = My.Forms.NombreUsuraio.Jugador2.Text

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

    Private Sub EmpezarButton1_Click(sender As Object, e As EventArgs) Handles empezarButton1.Click


    End Sub

    Private Sub PicBoxRuleta_Click(sender As Object, e As EventArgs) Handles picBoxRuleta.Click
        TVueltas.Enabled = Not (TVueltas.Enabled)
    End Sub

    Private Sub TVueltas_Tick(sender As Object, e As EventArgs) Handles TVueltas.Tick
        Select Case picnum'select case que cambia las imagenes como si rotara
            Case 1
                'picBoxRuleta.Image = My.Resources.arte1
            Case 2
                'picBoxRuleta.Image = My.Resources.entreten1
            Case 3
                'picBoxRuleta.Image = My.Resources.corona1
            Case 4
                'picBoxRuleta.Image = My.Resources.geogra1
            Case 5
                'picBoxRuleta.Image = My.Resources.ciencia1
            Case 6
                'picBoxRuleta.Image = My.Resources.historia1
            Case 7
                'picBoxRuleta.Image = My.Resources.deporte1
                TVueltas.Interval += 1 'aumenta el intervalo del tiempo
            Case Else
                picnum = 0 'resetea el valor para que vuelva a la imagen original
        End Select
        picnum += 1 'aumenta para cambiar la imagen

        If TVueltas.Interval >= 10 Then 'si el contador del tiempo llega a 10 detiene la rotacion de imagenes
            TVueltas.Enabled = Not (TVueltas.Enabled)
            TVueltas.Interval = 1 'vuelve a poner el intervalo en 1 para siguiente turno

            'Randomize()
            'randomNum = Int((8 * Rnd() + 1)) 'una forma de usar el random
            randomNum = randomObjeto.Next(1, 8) 'otra forma con random para que me de una numero entre 1 y 7
            Select Case randomNum 'cambia la imagen segun el numero dado 
                Case 1
                    'picBoxRuleta.Image = My.Resources.arte1

                    VentanaInicioArte.Show() 'muestra ventana categoria
                    Me.Close() 'cierra esta ventana


                Case 2
                    'picBoxRuleta.Image = My.Resources.entreten1

                    VentanaInicioEntretenimiento.Show() 'muestra ventana categoria
                    Me.Close()'cierra esta ventana


                Case 3
                    'picBoxRuleta.Image = My.Resources.corona1

                    VentCorona.Show() 'muestra ventana categoria
                    Me.Close()'cierra esta ventana


                Case 4
                    'picBoxRuleta.Image = My.Resources.geogra1

                    VentanaInicioGeografia.Show() 'muestra ventana categoria
                    Me.Close()'cierra esta ventana


                Case 5
                    'picBoxRuleta.Image = My.Resources.ciencia1

                    VentanaInicionCiencia.Show() 'muestra ventana categoria
                    Me.Close()'cierra esta ventana


                Case 6
                    'picBoxRuleta.Image = My.Resources.historia1

                    VentanaInicioHistoria.Show() 'muestra ventana categoria
                    Me.Close()'cierra esta ventana


                Case 7
                    'picBoxRuleta.Image = My.Resources.deporte1

                    VentanaInicioDeportes.Show() 'muestra ventana categoria
                    Me.Close() 'cierra esta ventana


            End Select

        End If
    End Sub
End Class