Public Class VentCiencia
    Private tiempo As Integer
    Private id_pregunta As Integer
    Private Tmp_Respuestas As String(,) ' creacion de variable global

    Private Sub RespuestaCorrecta()


        My.Computer.Audio.Play(My.Resources.Correct, AudioPlayMode.WaitToComplete)
        My.Forms.VentanaRespuesta.Tag = TextoPregunta.Text
        My.Forms.VentanaRespuesta.Show()

        Me.Close()
    End Sub

    Private Sub RespuestaIncorrecta()

        MessageBox.Show("Incorrecto", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        My.Computer.Audio.Play(My.Resources.Incorrect, AudioPlayMode.WaitToComplete)
        My.Forms.VentanaIncorrecta.Tag = TextoPregunta.Text
        My.Forms.VentanaIncorrecta.Show()
        Me.Close()
    End Sub

    Private Sub BtnOpcion1_Click(sender As Object, e As EventArgs) Handles BtnOpcion1.Click
        Try
            Dim Respuesta = Tmp_Respuestas(0, 1)
            If (Respuesta = "True") Then
                BtnOpcion1.BackColor = Color.GreenYellow
                Timer1.Enabled = False
                Me.RespuestaCorrecta()
            Else
                BtnOpcion1.BackColor = Color.Red
                ComprobarRondaGlobal(Timer1) 'llamar cuando se contesta de manera incorrecta
                Me.RespuestaIncorrecta()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnOpcion3_Click(sender As Object, e As EventArgs) Handles BtnOpcion3.Click
        Try
            Dim Respuesta = Tmp_Respuestas(2, 1)
            If (Respuesta = "True") Then
                BtnOpcion3.BackColor = Color.GreenYellow
                Timer1.Enabled = False
                Me.RespuestaCorrecta()
            Else
                BtnOpcion3.BackColor = Color.Red
                ComprobarRondaGlobal(Timer1) 'llamar cuando se contesta de manera incorrecta
                Me.RespuestaIncorrecta()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnOpcion2_Click(sender As Object, e As EventArgs) Handles BtnOpcion2.Click
        Try
            Dim Respuesta = Tmp_Respuestas(1, 1)
            If (Respuesta = "True") Then
                BtnOpcion2.BackColor = Color.GreenYellow
                Timer1.Enabled = False
                Me.RespuestaCorrecta()
            Else
                BtnOpcion2.BackColor = Color.Red
                ComprobarRondaGlobal(Timer1) 'llamar cuando se contesta de manera incorrecta
                Me.RespuestaIncorrecta()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnOpcion4_Click(sender As Object, e As EventArgs) Handles BtnOpcion4.Click
        Try
            Dim Respuesta = Tmp_Respuestas(3, 1)
            If (Respuesta = "True") Then
                BtnOpcion4.BackColor = Color.GreenYellow
                Timer1.Enabled = False
                Me.RespuestaCorrecta()
            Else
                BtnOpcion4.BackColor = Color.Red
                ComprobarRondaGlobal(Timer1) 'llamar cuando se contesta de manera incorrecta
                Me.RespuestaIncorrecta()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextoPregunta_TextChanged(sender As Object, e As EventArgs) Handles TextoPregunta.TextChanged

    End Sub

    Private Sub conexion()

        Dim sql = "SELECT TOP 1 * FROM PRENGUNTAS where id_tema = 2 ORDER BY NEWID()"      'trae un pregunta al azar(TEMA  = ciencia)
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
        If tiempo > 0 Then
            tiempo = tiempo - 1
            Ltiempo.Text = tiempo
        Else
            Timer1.Enabled = False
            TiempoPregunta()
        End If



    End Sub

    Private Sub VentCiencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion()
        Timer1.Enabled = True
        pictiempofuera.Visible = False
    End Sub

    Private Sub TiempoPregunta()

        If tiempo = 0 Then
            If Persona1EstaJugando Then
                Persona1EstaJugando = False
                Persona2EstaJugando = True
            ElseIf Persona2EstaJugando Then
                Persona1EstaJugando = True
                Persona2EstaJugando = False

            End If

            BtnOpcion1.Enabled = False
            BtnOpcion2.Enabled = False
            BtnOpcion3.Enabled = False
            BtnOpcion4.Enabled = False

            pictiempofuera.Visible = True

            MsgBox("Tiempo agotado", MsgBoxStyle.Information, "Preguntados")
            ComprobarRondaGlobal(Timer1)
            Me.Close()
            MuestraNombresJugadores.Show()


        End If

    End Sub


End Class