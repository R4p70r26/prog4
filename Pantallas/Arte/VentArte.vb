Public Class VentArte

    Private tiempo As Integer 'tiempo global
    Private id_pregunta As Integer 'id pregunta global
    Private Tmp_Respuestas As String(,) ' temperal creacion de variable global 

    Private Sub VentArte_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conexion() 'carga preguntas
        Timer1.Enabled = True 'activa el timer
        pictiempofuera.Visible = False 'desabilita label tiempo

    End Sub

    Private Sub RespuestaCorrecta()

        My.Computer.Audio.Play(My.Resources.Correct, AudioPlayMode.WaitToComplete) 'sonido 
        My.Forms.VentanaRespuesta.Tag = TextoPregunta.Text 'guarda el texto de la pregunta
        My.Forms.VentanaRespuesta.Show() 'muestra ventana 
        Me.Close() 'cierra ventana

    End Sub

    Private Sub RespuestaIncorrecta()

        'MessageBox.Show("Incorrecto", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        My.Computer.Audio.Play(My.Resources.Incorrect, AudioPlayMode.WaitToComplete) 'sonido
        My.Forms.VentanaIncorrecta.Tag = TextoPregunta.Text 'guarda el texto de la pregunta
        My.Forms.VentanaIncorrecta.Show() 'muestra ventana
        Me.Close() 'cierra ventana
    End Sub

    Private Sub BtnOpcion1_Click(sender As Object, e As EventArgs) Handles BtnOpcion1.Click
        Try
            Dim Respuesta = Tmp_Respuestas(0, 1) 'almacena la respuesta 
            If (Respuesta = "True") Then 'compara si es la correcta
                BtnOpcion1.BackColor = Color.Green
                Timer1.Enabled = False 'desactiva el tiempo
                Me.RespuestaCorrecta()
            Else
                BtnOpcion1.BackColor = Color.Red
                ComprobarRondaGlobal(Timer1) 'llamar cuando se contesta de manera incorrecta
                Me.RespuestaIncorrecta()

            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub BtnOpcion4_Click(sender As Object, e As EventArgs) Handles BtnOpcion4.Click
        Try
            Dim Respuesta = Tmp_Respuestas(3, 1) 'almacena la respuesta 
            If (Respuesta = "True") Then 'compara si es la correcta
                BtnOpcion4.BackColor = Color.Green
                Timer1.Enabled = False 'desactiva el tiempo
                Me.RespuestaCorrecta()
            Else
                BtnOpcion4.BackColor = Color.Red
                ComprobarRondaGlobal(Timer1) 'llamar cuando se contesta de manera incorrecta
                Me.RespuestaIncorrecta()
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub BtnOpcion2_Click(sender As Object, e As EventArgs) Handles BtnOpcion2.Click
        Try
            Dim Respuesta = Tmp_Respuestas(1, 1) 'almacena la respuesta 
            If (Respuesta = "True") Then 'compara si es la correcta
                BtnOpcion2.BackColor = Color.Green
                Timer1.Enabled = False 'desactiva el tiempo
                Me.RespuestaCorrecta()
            Else
                BtnOpcion2.BackColor = Color.Red
                ComprobarRondaGlobal(Timer1) 'llamar cuando se contesta de manera incorrecta
                Me.RespuestaIncorrecta()

            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub BtnOpcion3_Click(sender As Object, e As EventArgs) Handles BtnOpcion3.Click
        Try
            Dim Respuesta = Tmp_Respuestas(2, 1) 'almacena la respuesta 
            If (Respuesta = "True") Then 'compara si es la correcta
                BtnOpcion3.BackColor = Color.Green
                Timer1.Enabled = False 'desactiva el tiempo
                Me.RespuestaCorrecta()
            Else
                BtnOpcion3.BackColor = Color.Red
                ComprobarRondaGlobal(Timer1) 'llamar cuando se contesta de manera incorrecta
                Me.RespuestaIncorrecta()

            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub conexion()

        Dim num As System.Random = New System.Random()

        Dim sql
        If tipodb = "\conexionA.udl" Then 'si access esta seleccionado eje cute este query
            sql = "SELECT TOP 1 * FROM PRENGUNTAS where id_tema = 1 and id_pregunta = " & num.Next(46, 61 + 1) 'selecciona una pregunta al azar
        Else
            sql = "SELECT TOP 1 * FROM PRENGUNTAS where id_tema = 1 ORDER BY NEWID()"      'trae un pregunta al azar(TEMA 1 = ARTE)
        End If

        Dim arrPregu = LeeValorPregunta(sql)

        id_pregunta = arrPregu(0)
        TextoPregunta.Text = arrPregu(1)
        tiempo = arrPregu(2)

        Dim sqlResp = "select opcion,Resp_correcta from Respuesta where id_pregunta = " & id_pregunta 'selecciona la opcion y el estado de respuesta'
        Tmp_Respuestas = LeeValorRespuestas(sqlResp)

        BtnOpcion1.Text = Tmp_Respuestas(0, 0) ' esto da el texto de las opciones'
        BtnOpcion2.Text = Tmp_Respuestas(1, 0)
        BtnOpcion3.Text = Tmp_Respuestas(2, 0)
        BtnOpcion4.Text = Tmp_Respuestas(3, 0)

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If tiempo > 0 Then 'disminuye el tiempo
            tiempo = tiempo - 1
            LTiempo.Text = tiempo
        Else
            Timer1.Enabled = False 'desactiva el tiempo
            TiempoPregunta()

        End If

    End Sub

    Private Sub TiempoPregunta() 'cambio de jugador si se acaba el tiempo

        If tiempo = 0 Then 'si tiempo es 0
            If Persona1EstaJugando Then 'si persona 1 esta jugando cambia al persona 2
                Persona1EstaJugando = False
                Persona2EstaJugando = True
            ElseIf Persona2EstaJugando Then 'si persona 2 esta jugando cambia al persona 1
                Persona1EstaJugando = True
                Persona2EstaJugando = False

            End If

            'deshabilita los botones
            BtnOpcion1.Enabled = False
            BtnOpcion2.Enabled = False
            BtnOpcion3.Enabled = False
            BtnOpcion4.Enabled = False

            pictiempofuera.Visible = True

            MsgBox("Tiempo agotado", vbInformation, "Preguntados")

            ComprobarRondaGlobal(Timer1)
            Me.Close() 'cerrar ventana
            MuestraNombresJugadores.Show() 'llama a la ruleta

        End If

    End Sub



End Class