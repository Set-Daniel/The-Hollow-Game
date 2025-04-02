Imports System
Imports System.Reflection.Metadata.Ecma335

Module ElPrincipio
    Sub Main(intentos As Integer)
        Dim nombres(9) As String
        Dim seleccionados(2) As String
        Dim intentos As Integer = 0
        Dim hombres As Integer = 0
        Dim mujeres As Integer = 0

        ' Inicialización de los nombres que posteriormente el algorimo pedirá que el usuario seleccion al azar.
        nombres(0) = "Luis"
        nombres(1) = "Lucas"
        nombres(2) = "Zack"
        nombres(3) = "Elizabeth"
        nombres(4) = "Charlotte"
        nombres(5) = "Espada"
        nombres(6) = "Llave"
        nombres(7) = "Linterna"
        nombres(8) = "Escudo"
        nombres(9) = "Mapa"

        Console.WriteLine("Encuentra los nombres de los protagonistas (2 hombres y 1 mujer)")

        While intentos < 5 And (hombres < 2 Or mujeres < 1)
            Console.Write("Selecciona un número del 0 al 9: ")
            Dim entrada As String = Console.ReadLine()
            Dim eleccion As Integer

            ' Validación de entrada numérica
            If Not Integer.TryParse(entrada, eleccion) OrElse eleccion < 0 OrElse eleccion > 9 Then
                Console.WriteLine("Número inválido, intenta nuevamente.")
            ElseIf seleccionados.Contains(nombres(eleccion)) Then
                Console.WriteLine("Este nombre ya fue seleccionado, elige otro.")
            Else
                ' Asignar nombre seleccionado
                seleccionados(hombres + mujeres) = nombres(eleccion)

                ' Contar género
                If eleccion < 3 Then
                    hombres += 1
                ElseIf eleccion < 5 Then
                    mujeres += 1
                End If
            End If

            intentos += 1
        End While

        ' Resultado final
        If hombres = 2 And mujeres = 1 Then
            Console.WriteLine("Has seleccionado correctamente a los protagonistas:")
            For Each nombre In seleccionados
                Console.WriteLine(nombre)
            Next
        Else
            Console.WriteLine("THE HOLLOW CANNOT BE INITIALIZED, GAME OVER")
        End If

        Console.ReadLine()

        While intentos < 5
            Console.Write("Ingrese una palabra: ")
            Dim palabra As String = Console.ReadLine()

            If EsPalindromo(palabra) Then
                Console.WriteLine("¡La palabra es palíndroma!")
                Exit While
            End If

            intentos -= 1
            Console.WriteLine($"No es una palabra palíndroma. Intentos restantes: {intentos}")
        End While

        If intentos = 0 Then Console.WriteLine("THE HOLLOW CANNOT BE INITIALIZED, GAME OVER")
        Console.ReadKey()

    End Sub

    Private Function EsPalindromo(palabra As String) As Boolean
        Throw New NotImplementedException()
    End Function
End Module
