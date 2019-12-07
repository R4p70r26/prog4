Public Class VentCorona

    'metodos que abre la ventana del personaje seleccionado
    Private Sub EntreteimientoButton1_Click(sender As Object, e As EventArgs) Handles EntreteimientoButton1.Click
        My.Forms.VentanaInicioEntretenimiento.Show()
        setNombrepersonaje("Entretenimiento")
        Me.Close()

    End Sub

    Private Sub HistoriaButton4_Click(sender As Object, e As EventArgs) Handles HistoriaButton4.Click
        My.Forms.VentanaInicioHistoria.Show()
        setNombrepersonaje("Historia")
        Me.Close()

    End Sub

    Private Sub GeografiaButton6_Click(sender As Object, e As EventArgs) Handles GeografiaButton6.Click
        My.Forms.VentanaInicioGeografia.Show()
        setNombrepersonaje("Geografia")
        Me.Close()

    End Sub

    Private Sub CienciaButton5_Click(sender As Object, e As EventArgs) Handles cienciaButton5.Click
        My.Forms.VentanaInicionCiencia.Show()
        setNombrepersonaje("Ciencia")
        Me.Close()

    End Sub

    Private Sub DeporteButton3_Click(sender As Object, e As EventArgs) Handles deporteButton3.Click
        My.Forms.VentanaInicioDeportes.Show()
        setNombrepersonaje("Deporte")
        Me.Close()

    End Sub

    Private Sub ArteButton2_Click(sender As Object, e As EventArgs) Handles ArteButton2.Click
        My.Forms.VentanaInicioArte.Show()
        setNombrepersonaje("Arte")
        Me.Close()

    End Sub

    Private Sub VentCorona_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
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

            If Persona1EstaJugando Then
                If PersonajeArte1 = False Then
                    ArteButton2.Enabled = True
                Else
                    ArteButton2.Enabled = False
                End If

                If PersonajeCiencia1 = False Then
                    cienciaButton5.Enabled = True
                Else
                    cienciaButton5.Enabled = False
                End If

                If PersonajeDeportes1 = False Then
                    deporteButton3.Enabled = True
                Else
                    deporteButton3.Enabled = False
                End If

                If PersonajeEntretenimiento1 = False Then
                    EntreteimientoButton1.Enabled = True
                Else
                    EntreteimientoButton1.Enabled = False
                End If

                If PersonajeGeografia1 = False Then
                    GeografiaButton6.Enabled = True
                Else
                    GeografiaButton6.Enabled = False
                End If

                If PersonajeHistoria1 = False Then
                    HistoriaButton4.Enabled = True
                Else
                    HistoriaButton4.Enabled = False
                End If

            ElseIf Persona2EstaJugando Then
                If PersonajeArte2 = False Then
                    ArteButton2.Enabled = True
                Else
                    ArteButton2.Enabled = False
                End If

                If PersonajeCiencia2 = False Then
                    cienciaButton5.Enabled = True
                Else
                    cienciaButton5.Enabled = False
                End If

                If PersonajeDeportes2 = False Then
                    deporteButton3.Enabled = True
                Else
                    deporteButton3.Enabled = False
                End If

                If PersonajeEntretenimiento2 = False Then
                    EntreteimientoButton1.Enabled = True
                Else
                    EntreteimientoButton1.Enabled = False
                End If

                If PersonajeGeografia2 = False Then
                    GeografiaButton6.Enabled = True
                Else
                    GeografiaButton6.Enabled = False
                End If

                If PersonajeHistoria2 = False Then
                    HistoriaButton4.Enabled = True
                Else
                    HistoriaButton4.Enabled = False
                End If

            End If

            esCorona = True
            respuestasmalasc()

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub
End Class