Public Class IntroducionPreguntas

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Validacion() Then
            IngresaPregunta()


        End If


    End Sub



    Private Function Validacion() As Boolean

        If TxtPregunta.Text <> String.Empty Then
            If Txtrespuesta1.Text <> String.Empty And Txtrespuesta2.Text <> String.Empty And Txtrespuesta3.Text <> String.Empty And Txtrespuesta4.Text <> String.Empty Then
                If RbRespuesta1.Checked = True Or RbRespuesta2.Checked = True Or RbRespuesta3.Checked = True Or RbRespuesta4.Checked = True Then
                    If Rb15sec.Checked = True Or Rb30sec.Checked = True Or Rb45sec.Checked = True Or Rb60sec.Checked = True Then
                        If CbxTemas.SelectedIndex <> 0 Then

                            Return True

                        Else
                            MsgBox("Seleccione el tema")
                        End If
                    Else
                        MsgBox("Seleccione el tiempo")
                    End If
                Else
                    MsgBox("Marque la respuesta")
                End If
            Else
                MsgBox("Ingrese las cuatro respuestas")
            End If
        Else
            MsgBox("Ingrese la pregunta")
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
        Dim oleconex = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=preguntadosDB;Data Source=DESKTOP-UQHUGC6\RAPTRSQLEXPRESS"

        Using conexOle As New OleDb.OleDbConnection(oleconex) 'declara la conexion
            conexOle.Open() 'abre la conexion
            Dim Sql = "insert into prenguntas(id_tema, pregunta, tiempo) values(?,?,?); SELECT SCOPE_IDENTITY()"


            Using cmand As New OleDb.OleDbCommand(Sql, conexOle) 'declara los comandos
                With cmand.Parameters 'añade los parametros
                    ''.Add("@id", oleDbType:=OleDb.OleDbType.Integer).Value = id
                    .Add("@id_tema", oleDbType:=OleDb.OleDbType.Integer).Value = CbxTemas.SelectedIndex

                    .Add("@pregunta", oleDbType:=OleDb.OleDbType.Char).Value = TxtPregunta.Text
                    .Add("@tiempo", oleDbType:=OleDb.OleDbType.Integer).Value = validarTiempo()
                End With

                Try
                    cmand.ExecuteNonQuery()
                    MsgBox("la informacion ha sido almacenada", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Guardando")
                    currentId = cmand.ExecuteScalar()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
                End Try

                Dim query = "insert into respuesta (id_pregunta, opcion, resp_correcta) values(?,?,?)"


                'Try

                '    Using cmd As New OleDb.OleDbCommand(query, conexOle)

                '        For index = 1 To 5
                '            With cmd.Parameters
                '                .Add("@id_pregunta", oleDbType:=OleDb.OleDbType.Integer).Value = currentId
                '                .Add("@opcion", oleDbType:=OleDb.OleDbType.Char).Value = retornaRespuesta(index)
                '                .Add("@resp_correcta", oleDbType:=OleDb.OleDbType.Boolean).Value = retornaRespCorrecta(index)
                '            End With
                '            cmd.ExecuteNonQuery()
                '        Next

                '    End Using
                'Catch ex As Exception
                '    MsgBox(ex.ToString)
                'End Try

                Try

                    Using cmd As New OleDb.OleDbCommand(query, conexOle)

                        With cmd.Parameters
                            .Add("@id_pregunta", oleDbType:=OleDb.OleDbType.Integer).Value = currentId
                            .Add("@opcion", oleDbType:=OleDb.OleDbType.Char).Value = Txtrespuesta1.Text
                            .Add("@resp_correcta", oleDbType:=OleDb.OleDbType.Boolean).Value = RbRespuesta1.Checked
                        End With
                        cmd.ExecuteNonQuery()
                    End Using
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try

                Try

                    Using cmd As New OleDb.OleDbCommand(query, conexOle)

                        With cmd.Parameters
                                .Add("@id_pregunta", oleDbType:=OleDb.OleDbType.Integer).Value = currentId
                                .Add("@opcion", oleDbType:=OleDb.OleDbType.Char).Value = Txtrespuesta2.Text
                                .Add("@resp_correcta", oleDbType:=OleDb.OleDbType.Boolean).Value = RbRespuesta2.Checked
                            End With
                        cmd.ExecuteNonQuery()
                    End Using
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try

                Try

                    Using cmd As New OleDb.OleDbCommand(query, conexOle)

                        With cmd.Parameters
                                .Add("@id_pregunta", oleDbType:=OleDb.OleDbType.Integer).Value = currentId
                            .Add("@opcion", oleDbType:=OleDb.OleDbType.Char).Value = Txtrespuesta3.Text
                            .Add("@resp_correcta", oleDbType:=OleDb.OleDbType.Boolean).Value = RbRespuesta3.Checked
                        End With
                        cmd.ExecuteNonQuery()

                    End Using
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try

                Try

                    Using cmd As New OleDb.OleDbCommand(query, conexOle)

                        With cmd.Parameters
                            .Add("@id_pregunta", oleDbType:=OleDb.OleDbType.Integer).Value = currentId
                            .Add("@opcion", oleDbType:=OleDb.OleDbType.Char).Value = Txtrespuesta4.Text
                            .Add("@resp_correcta", oleDbType:=OleDb.OleDbType.Boolean).Value = RbRespuesta4.Checked
                        End With
                        cmd.ExecuteNonQuery()

                    End Using
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try

            End Using

        End Using

    End Sub

    Private Function retornaRespuesta(ByRef indice) As String
        Select Case indice
            Case 1
                Return Txtrespuesta1.Text
            Case 2
                Return Txtrespuesta2.Text
            Case 3
                Return Txtrespuesta3.Text
            Case 4
                Return Txtrespuesta4.Text

        End Select

        Return ""
    End Function

    Private Function retornaRespCorrecta(ByVal indice As Integer) As Boolean

        Select Case indice
            Case 1
                Return RbRespuesta1.Checked
            Case 2
                Return RbRespuesta2.Checked
            Case 3
                Return RbRespuesta3.Checked
            Case 4
                Return RbRespuesta4.Checked

        End Select
        Return False
    End Function

End Class