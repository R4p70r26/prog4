Module procedimientos
    'DECLARA VAR GLOBAL
    Public db As New OleDb.OleDbConnection
    'esta variable sera la encargada de conectarnos con la base de datos creada

    'este procedimiento nos conectara con la base de datos usando el archivo udl

    Friend Sub conectar()
        Dim ruta As String ' esta variable guarda la ruta de la bd, es una var local al salir del proceso desaparece

        ruta = "File Name= " & Application.StartupPath + tipodb
        db.ConnectionString = ruta

        db.Open() 'abre la conexion

        Exit Sub
    End Sub 'sub es procedimiento

    Friend Sub conectarAgregapreg()
        Dim ruta As String ' esta variable guarda la ruta de la bd, es una var local al salir del proceso desaparece

        ruta = "File Name= " & Application.StartupPath & "\conexion.udl"
        db.ConnectionString = ruta

        db.Open() 'abre la conexion

        Exit Sub
    End Sub 'sub es procedimiento


    Friend Sub desconectar()
        db.Close() ' cierra bd
    End Sub

    ' este procedimiento carga los datos del a tabla de la base de datos en la memoria de la pc
    Friend Sub cargar_tabla(ByRef tabla_temporal As DataSet, ByVal sql As String)
        conectar()
        'se usa para los select
        Dim consulta As New OleDb.OleDbDataAdapter(sql, db) 'adapta ls datos parametros hacer sql en db

        consulta.Fill(tabla_temporal) 'llene la tabla temporal

        desconectar()
    End Sub

    Friend Sub ejecutar(ByVal sql As String)
        conectar()
        Dim comando As New OleDb.OleDbCommand(sql, db) 'declara el comando insertar borrar actualizar como parametro
        comando.ExecuteNonQuery() 'ejecuta el comando
        desconectar()

    End Sub

    Friend Function ejecutarScalar(ByVal sql As String) As Integer ' ejecuta el query y regresa la id de pregunta
        conectar()
        Dim comando As New OleDb.OleDbCommand(sql, db)
        Dim valor = comando.ExecuteScalar()
        desconectar()
        Return valor
    End Function

    Friend Function LeeValorPregunta(ByVal sql As String) As String() 'lee el valor de las preguntas y la almacena en un array

        Dim arr(4) As String 'array

        conectar()
        Dim comando As New OleDb.OleDbCommand(sql, db)
        Dim lector As OleDb.OleDbDataReader

        lector = comando.ExecuteReader()
        If lector.Read Then

            arr(0) = lector(0) 'id de pregunta
            arr(1) = lector(2) 'texto de la pregunta
            arr(2) = lector(3) 'tiempo

        End If
        desconectar()

        Return arr
    End Function

    Friend Function LeeValorRespuestas(ByVal sql As String) As String(,) 'lee las respusestas y las guarda en un array
        Dim respuesta(4, 2) As String 'declara un arreglo de 4*2
        Dim tabla As New DataSet()

        Try
            conectar()
            Dim adaptador As New OleDb.OleDbDataAdapter(sql, db)

            adaptador.Fill(tabla)

            respuesta(0, 0) = tabla.Tables(0).Rows(0).Item(0) 'guarda la opcion'
            respuesta(1, 0) = tabla.Tables(0).Rows(1).Item(0)
            respuesta(2, 0) = tabla.Tables(0).Rows(2).Item(0)
            respuesta(3, 0) = tabla.Tables(0).Rows(3).Item(0)

            respuesta(0, 1) = tabla.Tables(0).Rows(0).Item(1) 'guarda la respuestas '
            respuesta(1, 1) = tabla.Tables(0).Rows(1).Item(1)
            respuesta(2, 1) = tabla.Tables(0).Rows(2).Item(1)
            respuesta(3, 1) = tabla.Tables(0).Rows(3).Item(1)
            desconectar()



        Catch ex As Exception
            MsgBox("Error al extraer las respuestas", vbInformation, "Preguntados")
            desconectar()

        End Try

        Return respuesta

    End Function


    Friend Function LeeJugadores(ByVal sql As String) As DataSet 'lee los juagadore de la base de datos
        Dim respuesta(5) As String
        Dim tabla As New DataSet()

        Try
            conectar()
            Dim adaptador As New OleDb.OleDbDataAdapter(sql, db)

            adaptador.Fill(tabla)

            desconectar()

        Catch ex As Exception
            MsgBox("Error al extraer jugadores", vbInformation, "Preguntados")
            desconectar()

        End Try

        Return tabla

    End Function


End Module
