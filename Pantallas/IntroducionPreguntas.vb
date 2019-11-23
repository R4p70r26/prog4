Public Class IntroducionPreguntas

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Validacion() Then
            IngresaPregunta()

            Limpiar()

        End If


    End Sub

    Private Sub Limpiar()
        TxtPregunta.Text = ""
        Txtrespuesta1.Text = ""
        Txtrespuesta2.Text = ""
        Txtrespuesta3.Text = ""
        Txtrespuesta4.Text = ""

        Rb15sec.Checked = False
        Rb30sec.Checked = False
        Rb45sec.Checked = False
        Rb60sec.Checked = False
        RbRespuesta1.Checked = False
        RbRespuesta2.Checked = False
        RbRespuesta3.Checked = False
        RbRespuesta4.Checked = False

        CbxTemas.SelectedIndex = 0


    End Sub


    Private Function Validacion() As Boolean

        If TxtPregunta.Text <> String.Empty Then
            If Txtrespuesta1.Text <> String.Empty And Txtrespuesta2.Text <> String.Empty And Txtrespuesta3.Text <> String.Empty And Txtrespuesta4.Text <> String.Empty Then
                If RbRespuesta1.Checked = True Or RbRespuesta2.Checked = True Or RbRespuesta3.Checked = True Or RbRespuesta4.Checked = True Then
                    If Rb15sec.Checked = True Or Rb30sec.Checked = True Or Rb45sec.Checked = True Or Rb60sec.Checked = True Then
                        If CbxTemas.SelectedIndex <> 0 Then

                            Return True

                        Else
                            MsgBox("Seleccione el tema", MsgBoxStyle.Information, "Seleccione el tema")
                        End If
                    Else
                        MsgBox("Seleccione el tiempo", MsgBoxStyle.Information, "Seleccione el tiempo")
                    End If
                Else
                    MsgBox("Marque la respuesta", MsgBoxStyle.Information, "Marque la respuesta")
                End If
            Else
                MsgBox("Ingrese las cuatro respuestas", MsgBoxStyle.Information, "Ingrese las respuestas")
            End If
        Else
            MsgBox("Ingrese la pregunta", MsgBoxStyle.Information, "Ingrese la pregunta")
        End If

        Return False
    End Function

    Private Function validarTiempo() As Integer
        If Rb15sec.Checked Then
            Return 15
        ElseIf Rb30sec.Checked Then
            Return 30
        ElseIf Rb45sec.Checked Then
            Return 45
        Else
            Return 60
        End If

    End Function


    Private Sub IngresaPregunta()
        Dim currentId As Integer

        'query insercion de pregunta
        Dim sql = "insert into prenguntas(id_tema, pregunta, tiempo) values(" & CbxTemas.SelectedIndex & ", '" & TxtPregunta.Text & "', " & validarTiempo() & "); select scope_identity()"

        Try 'ejecuta el queri en la bd
            'ejecutar(sql)
            currentId = ejecutarScalar(sql) 'regresa la id de pregunta
            MsgBox("La pregunta ha sido almacenada", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Guardando")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
            desconectar()
        End Try

        'query insercion de pregunta
        sql = "insert into respuesta(id_pregunta, opcion, resp_correcta) values(" & currentId & ", '" & Txtrespuesta1.Text & "', " & ReturnRespuestaCorrecta(1) & ")"

        Try
            ejecutar(sql)

        Catch ex As Exception
            Console.WriteLine(ex.Message)
            desconectar()

        End Try

        'query insercion de respuestas
        sql = "insert into respuesta(id_pregunta, opcion, resp_correcta) values(" & currentId & ", '" & Txtrespuesta2.Text & "', " & ReturnRespuestaCorrecta(2) & ")"

        Try
            ejecutar(sql)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            desconectar()
        End Try

        'query insercion de respuestas
        sql = "insert into respuesta(id_pregunta, opcion, resp_correcta) values(" & currentId & ", '" & Txtrespuesta3.Text & "', " & ReturnRespuestaCorrecta(3) & ")"

        Try
            ejecutar(sql)

        Catch ex As Exception
            Console.WriteLine(ex.Message)
            desconectar()
        End Try

        'query insercion de respuestas
        sql = "insert into respuesta(id_pregunta, opcion, resp_correcta) values(" & currentId & ", '" & Txtrespuesta4.Text & "', " & ReturnRespuestaCorrecta(4) & ")"

        Try
            ejecutar(sql)

        Catch ex As Exception
            Console.WriteLine(ex.Message)
            desconectar()
        End Try


    End Sub

    Private Function ReturnRespuestaCorrecta(ByVal respuesta) As Integer 'funcion regresa 1 si es true o false si es 0
        Select Case respuesta
            Case 1
                If RbRespuesta1.Checked Then
                    Return 1
                Else
                    Return 0
                End If
            Case 2
                If RbRespuesta2.Checked Then
                    Return 1
                Else
                    Return 0
                End If
            Case 3
                If RbRespuesta3.Checked Then
                    Return 1
                Else
                    Return 0
                End If
            Case 4
                If RbRespuesta4.Checked Then
                    Return 1
                Else
                    Return 0
                End If

        End Select

        Return 0
    End Function

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()

    End Sub
End Class