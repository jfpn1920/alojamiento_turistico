Imports System
Module alojamiento_turistico
    Sub Main(args As String())
        Dim ids(9) As Integer
        Dim huespedes(9) As String
        Dim alojamientos(9) As String
        Dim tiposHabitacion(9) As String
        Dim fechasEntrada(9) As String
        Dim fechasSalida(9) As String
        Dim noches(9) As Integer
        Dim preciosNoche(9) As Double
        Dim totales(9) As Double
        Dim estados(9) As String
        Dim observaciones(9) As String
        Dim cantidad As Integer = 0
        Dim opcion As Integer
        '---------------------------------------------'
        '--|menu_principal_de_alojamiento_turistico|--'
        '---------------------------------------------'
        Do
            Console.WriteLine("menu principal de alojamiento turistico")
            Console.WriteLine("1) Registrar reserva")
            Console.WriteLine("2) Editar reserva")
            Console.WriteLine("3) Listar reservas")
            Console.WriteLine("4) Buscar reserva")
            Console.WriteLine("5) Eliminar reserva")
            Console.WriteLine("6) Mostrar resumen")
            Console.WriteLine("7) Salir")
            Console.Write("Seleccione una opcion: ")
            opcion = Convert.ToInt32(Console.ReadLine())
            Select Case opcion
                '-----------------------'
                '--|registrar_reserva|--'
                '-----------------------'
                Case 1
                    If cantidad >= ids.Length Then
                        Console.WriteLine("No hay espacio para registrar mas reservas.")
                    Else
                        ids(cantidad) = cantidad + 1
                        Console.Write("Huesped: ")
                        huespedes(cantidad) = Console.ReadLine()
                        Console.Write("Alojamiento: ")
                        alojamientos(cantidad) = Console.ReadLine()
                        Console.Write("Tipo de habitacion: ")
                        tiposHabitacion(cantidad) = Console.ReadLine()
                        Console.Write("Fecha de entrada: ")
                        fechasEntrada(cantidad) = Console.ReadLine()
                        Console.Write("Fecha de salida: ")
                        fechasSalida(cantidad) = Console.ReadLine()
                        Console.Write("Cantidad de noches: ")
                        noches(cantidad) = Convert.ToInt32(Console.ReadLine())
                        Console.Write("Precio por noche: ")
                        preciosNoche(cantidad) = Convert.ToDouble(Console.ReadLine())
                        totales(cantidad) = noches(cantidad) * preciosNoche(cantidad)
                        Console.Write("Estado: ")
                        estados(cantidad) = Console.ReadLine()
                        Console.Write("Observacion: ")
                        observaciones(cantidad) = Console.ReadLine()
                        cantidad += 1
                        Console.WriteLine("Reserva registrada correctamente.")
                    End If
                '--------------------'
                '--|editar_reserva|--'
                '--------------------'
                Case 2
                    If cantidad = 0 Then
                        Console.WriteLine("No existen reservas registradas.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Huesped: " & huespedes(i) & " | Alojamiento: " & alojamientos(i) & " | Tipo: " & tiposHabitacion(i) & " | Entrada: " & fechasEntrada(i) & " | Salida: " & fechasSalida(i) & " | Noches: " & noches(i) & " | Precio por noche: " & preciosNoche(i) & " | Total: " & totales(i) & " | Estado: " & estados(i) & " | Observacion: " & observaciones(i))
                        Next
                        Console.Write("Ingrese el ID de la reserva a editar: ")
                        Dim idEditar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEditar >= 1 And idEditar <= cantidad Then
                            Dim posicion As Integer = idEditar - 1
                            Console.Write("Nuevo huesped: ")
                            huespedes(posicion) = Console.ReadLine()
                            Console.Write("Nuevo alojamiento: ")
                            alojamientos(posicion) = Console.ReadLine()
                            Console.Write("Nuevo tipo de habitacion: ")
                            tiposHabitacion(posicion) = Console.ReadLine()
                            Console.Write("Nueva fecha de entrada: ")
                            fechasEntrada(posicion) = Console.ReadLine()
                            Console.Write("Nueva fecha de salida: ")
                            fechasSalida(posicion) = Console.ReadLine()
                            Console.Write("Nueva cantidad de noches: ")
                            noches(posicion) = Convert.ToInt32(Console.ReadLine())
                            Console.Write("Nuevo precio por noche: ")
                            preciosNoche(posicion) = Convert.ToDouble(Console.ReadLine())
                            totales(posicion) = noches(posicion) * preciosNoche(posicion)
                            Console.Write("Nuevo estado: ")
                            estados(posicion) = Console.ReadLine()
                            Console.Write("Nueva observacion: ")
                            observaciones(posicion) = Console.ReadLine()
                            Console.WriteLine("Reserva actualizada correctamente.")
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '---------------------'
                '--|listar_reservas|--'
                '---------------------'
                Case 3
                    If cantidad = 0 Then
                        Console.WriteLine("No existen reservas registradas.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Huesped: " & huespedes(i) & " | Alojamiento: " & alojamientos(i) & " | Tipo: " & tiposHabitacion(i) & " | Entrada: " & fechasEntrada(i) & " | Salida: " & fechasSalida(i) & " | Noches: " & noches(i) & " | Precio por noche: " & preciosNoche(i) & " | Total: " & totales(i) & " | Estado: " & estados(i) & " | Observacion: " & observaciones(i))
                        Next
                    End If
                '--------------------'
                '--|buscar_reserva|--'
                '--------------------'
                Case 4

                    If cantidad = 0 Then
                        Console.WriteLine("No existen reservas registradas.")
                    Else
                        Console.Write("Ingrese el ID de la reserva a buscar: ")
                        Dim idBuscar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idBuscar >= 1 And idBuscar <= cantidad Then
                            Dim posicion As Integer = idBuscar - 1
                            Console.WriteLine("ID: " & ids(posicion) & " | Huesped: " & huespedes(posicion) & " | Alojamiento: " & alojamientos(posicion) & " | Tipo: " & tiposHabitacion(posicion) & " | Entrada: " & fechasEntrada(posicion) & " | Salida: " & fechasSalida(posicion) & " | Noches: " & noches(posicion) & " | Precio por noche: " & preciosNoche(posicion) & " | Total: " & totales(posicion) & " | Estado: " & estados(posicion) & " | Observacion: " & observaciones(posicion))
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '----------------------'
                '--|eliminar_reserva|--'
                '----------------------'
                Case 5

                    If cantidad = 0 Then
                        Console.WriteLine("No existen reservas registradas.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Huesped: " & huespedes(i) & " | Alojamiento: " & alojamientos(i) & " | Tipo: " & tiposHabitacion(i) & " | Entrada: " & fechasEntrada(i) & " | Salida: " & fechasSalida(i) & " | Noches: " & noches(i) & " | Precio por noche: " & preciosNoche(i) & " | Total: " & totales(i) & " | Estado: " & estados(i) & " | Observacion: " & observaciones(i))
                        Next
                        Console.Write("Ingrese el ID de la reserva a eliminar: ")
                        Dim idEliminar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEliminar >= 1 And idEliminar <= cantidad Then
                            Dim posicion As Integer = idEliminar - 1
                            For i As Integer = posicion To cantidad - 2
                                ids(i) = ids(i + 1)
                                huespedes(i) = huespedes(i + 1)
                                alojamientos(i) = alojamientos(i + 1)
                                tiposHabitacion(i) = tiposHabitacion(i + 1)
                                fechasEntrada(i) = fechasEntrada(i + 1)
                                fechasSalida(i) = fechasSalida(i + 1)
                                noches(i) = noches(i + 1)
                                preciosNoche(i) = preciosNoche(i + 1)
                                totales(i) = totales(i + 1)
                                estados(i) = estados(i + 1)
                                observaciones(i) = observaciones(i + 1)
                            Next
                            cantidad -= 1
                            Console.WriteLine("Reserva eliminada correctamente.")
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '---------------------'
                '--|mostrar_resumen|--'
                '---------------------'
                Case 6
                    If cantidad = 0 Then
                        Console.WriteLine("No existen reservas registradas.")
                    Else
                        Dim pendientes As Integer = 0
                        Dim confirmadas As Integer = 0
                        Dim enCurso As Integer = 0
                        Dim finalizadas As Integer = 0
                        Dim canceladas As Integer = 0
                        Dim individuales As Integer = 0
                        Dim dobles As Integer = 0
                        Dim familiares As Integer = 0
                        Dim suites As Integer = 0
                        Dim totalNoches As Integer = 0
                        Dim totalIngresos As Double = 0
                        For i As Integer = 0 To cantidad - 1
                            totalNoches += noches(i)
                            totalIngresos += totales(i)
                            If estados(i).ToLower() = "pendiente" Then
                                pendientes += 1
                            ElseIf estados(i).ToLower() = "confirmada" Then
                                confirmadas += 1
                            ElseIf estados(i).ToLower() = "en curso" Then
                                enCurso += 1
                            ElseIf estados(i).ToLower() = "finalizada" Then
                                finalizadas += 1
                            ElseIf estados(i).ToLower() = "cancelada" Then
                                canceladas += 1
                            End If
                            If tiposHabitacion(i).ToLower() = "individual" Then
                                individuales += 1
                            ElseIf tiposHabitacion(i).ToLower() = "doble" Then
                                dobles += 1
                            ElseIf tiposHabitacion(i).ToLower() = "familiar" Then
                                familiares += 1
                            ElseIf tiposHabitacion(i).ToLower() = "suite" Then
                                suites += 1
                            End If
                        Next
                        Console.WriteLine("Reservas: " & cantidad & " | Pendientes: " & pendientes & " | Confirmadas: " & confirmadas & " | En curso: " & enCurso & " | Finalizadas: " & finalizadas & " | Canceladas: " & canceladas & " | Individuales: " & individuales & " | Dobles: " & dobles & " | Familiares: " & familiares & " | Suites: " & suites & " | Total noches: " & totalNoches & " | Total ingresos: " & totalIngresos)
                    End If
                '------------------------------'
                '--|salir_del_menu_principal|--'
                '------------------------------'
                Case 7
                    Console.WriteLine("Gracias por utilizar Alojamiento Turistico.")
                Case Else
                    Console.WriteLine("Opcion no valida.")
            End Select
        Loop While opcion <> 7
    End Sub
End Module