Imports System

Module TheHollow
    Sub Main()
        Dim nombres(9) As String
        Dim seleccionados(2) As String
        Dim hombres As Integer = 0
        Dim mujeres As Integer = 0
        Dim intentos As Integer = 0

        ' Inicialización de nombres
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

            If Not Integer.TryParse(entrada, eleccion) OrElse eleccion < 0 OrElse eleccion > 9 Then
                Console.WriteLine("Número inválido, intenta nuevamente.")
            ElseIf seleccionados.Contains(nombres(eleccion)) Then
                Console.WriteLine("Este nombre ya fue seleccionado, elige otro.")
            Else
                seleccionados(hombres + mujeres) = nombres(eleccion)
                If eleccion < 3 Then
                    hombres += 1
                ElseIf eleccion < 5 Then
                    mujeres += 1
                End If
            End If

            intentos += 1
        End While

        If hombres = 2 And mujeres = 1 Then
            Console.WriteLine("Has seleccionado correctamente a los protagonistas:")
            For Each nombre In seleccionados
                Console.WriteLine(nombre)
            Next
        Else
            Console.WriteLine("THE HOLLOW CANNOT BE INITIALIZED, GAME OVER")
        End If

        ' Parte 2 - Palíndromo
        Dim intentosPalindromo As Integer = 3
        While intentosPalindromo > 0
            Console.Write("Ingrese una palabra: ")
            Dim palabra As String = Console.ReadLine()

            If EsPalindromo(palabra) Then
                Console.WriteLine("¡La palabra es palíndroma!")
                Exit While
            Else
                intentosPalindromo -= 1
                Console.WriteLine($"No es una palabra palíndroma. Intentos restantes: {intentosPalindromo}")
            End If
        End While

        If intentosPalindromo = 0 Then
            Console.WriteLine("THE HOLLOW CANNOT BE INITIALIZED, GAME OVER")
        End If

        Console.ReadKey()
    End Sub

    Function EsPalindromo(texto As String) As Boolean
        If String.IsNullOrWhiteSpace(texto) Then Return False

        Dim limpio = texto.ToLower().Replace(" ", "")
        Dim invertido = New String(limpio.Reverse().ToArray())

        Return limpio = invertido
    End Function
End Module



