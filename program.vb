Imports System

Module TheHollow
    Private manName As Object
    Private characterName As String

    Sub Main()
        Dim intentos As Integer = 5
        Dim nombres(9) As String
        Dim seleccionados(2) As String
        Dim hombres As Integer = 0
        Dim mujeres As Integer = 0

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

        Console.WriteLine("Encuentra a los protagonistas (2 hombres y 1 mujer)")
        Console.WriteLine("Selecciona 3 personajes misteriosos... tienes 5 intentos.")

        While intentos > 0 And (hombres < 2 Or mujeres < 1)
            Console.Write("Selecciona un número del 0 al 9: ")
            Dim entrada As String = Console.ReadLine()
            Dim eleccion As Integer

            If Integer.TryParse(entrada, eleccion) Then
                If eleccion >= 0 And eleccion <= 9 Then
                    Dim yaSeleccionado As Boolean = False
                    For Each nombre In seleccionados
                        If nombre = nombres(eleccion) Then
                            yaSeleccionado = True
                        End If
                    Next

                    If yaSeleccionado Then
                        Console.WriteLine("Ese personaje ya fue elegido, intenta con otro número.")
                    Else
                        If hombres + mujeres < 3 Then
                            seleccionados(hombres + mujeres) = nombres(eleccion)
                        End If

                        If eleccion < 3 Then
                            hombres += 1
                        ElseIf eleccion < 5 Then
                            mujeres += 1
                        End If
                    End If
                Else
                    Console.WriteLine("Número fuera de rango. Elige entre 0 y 9.")
                End If
            Else
                Console.WriteLine("Entrada inválida.")
            End If

            intentos -= 1
        End While

        Console.WriteLine()

        If hombres = 2 And mujeres = 1 Then
            Console.WriteLine("¡Has elegido correctamente a los protagonistas!")
            For Each nombre In seleccionados
                Console.WriteLine("✔ " & nombre)
            Next
        Else
            Console.WriteLine("THE HOLLOW CANNOT BE INITIALIZED, GAME OVER")
        End If

        ' Segunda parte: Validación de palabra palíndroma
        intentos = 5
        While intentos > 0
            Console.Write("Ahora debes ingresar una palabra palíndroma para salir de la habitación, no hay tiempo que perder: ")
            Dim palabra As String = Console.ReadLine()

            ' Verificar si la entrada está vacía
            If String.IsNullOrWhiteSpace(palabra) Then
                intentos -= 1
                Console.WriteLine("No has ingresado ninguna palabra. Intentos restantes: " & intentos)
                Continue While
            End If

            ' Limpiar la palabra (convertir a minúsculas y eliminar espacios)
            Dim limpio As String = palabra.ToLower().Replace(" ", "")
            Dim invertido As String = ""

            ' Construir la palabra invertida
            Dim i As Integer = limpio.Length - 1
            While i >= 0
                invertido &= limpio(i)
                i -= 1
            End While

            ' Verificar si la palabra es palíndroma
            If limpio = invertido Then
                Console.WriteLine("¡La palabra es palíndroma!")
                Exit While
            Else
                intentos -= 1
                Console.WriteLine("No es una palabra palíndroma. Intentos restantes: " & intentos)
            End If
        End While

        ' Si se agotan los intentos, mostrar mensaje de GAME OVER y terminar el juego
        If intentos = 0 Then
            Console.WriteLine("THE HOLLOW CANNOT BE INITIALIZED, GAME OVER")
            End ' Termina el programa inmediatamente
        End If

        Console.ReadKey()

        'Desafio 1
        Dim num1, num2 As Double
        Console.WriteLine("Despues de ingresar la palabra palindroma, nuestro grupo de aventureros atraviensan la puerta de la habitacion. Al cruzar, ven que se encuentran en medio de un camino helado y desconocido, en el mismo identificaron un tipo de placa extraña.")
        Console.WriteLine("Nuestro grupo comprende que esto es un mapa hacia una llave que los llevara de regreso a su mundo y deciden buscar las 2 piezas que faltan en la placa.")
        Console.WriteLine("En camino a buscar la segunda pieza nuestro grupo se afronta a su primer desafio, una colina congelada, mas grande que un rascacielos y tan lejos que la neblina cubre la base de la misma.")
        Console.Write("Ingrese el primer número: ")
        num1 = Convert.ToDouble(Console.ReadLine())
        Console.Write("Ingrese el segundo número: ")
        num2 = Convert.ToDouble(Console.ReadLine())

        'Aqui comienza el calculo de la primera condicion'

        If num1 > num2 Then
            Dim suma As Double = num1 + num2
            If suma Mod num1 = 0 Or suma Mod num2 = 0 Then
                Console.WriteLine("Uno de los números divide exactamente la suma.")
            Else
                Dim sumaCuadrados As Double = num1 ^ 2 + num2 ^ 2
                Dim promedio As Double = (num1 + num2 + suma + sumaCuadrados) / 4
                Dim resultado As Double = promedio + suma + sumaCuadrados

                If resultado > 100 Then
                    Dim tiempo, velocidad, distancia As Double
                    Console.Write("Ingrese el tiempo de viaje (en horas): ")
                    tiempo = Convert.ToDouble(Console.ReadLine())
                    Console.Write("Ingrese la velocidad de viaje (en km/h): ")
                    velocidad = Convert.ToDouble(Console.ReadLine())
                    distancia = tiempo * velocidad
                    Console.WriteLine("La distancia a recorrer de nuestro grupo es: " & distancia & " km.")
                Else
                    Console.WriteLine("GAME OVER")
                    End

                End If
            End If

            'Calculo de la segunda condicion'

        Else
            Dim A, B, C, D, E As Double
            Console.Write("Ingrese el valor A: ")
            A = Convert.ToDouble(Console.ReadLine())
            Console.Write("Ingrese el valor B: ")
            B = Convert.ToDouble(Console.ReadLine())
            Console.Write("Ingrese el valor C: ")
            C = Convert.ToDouble(Console.ReadLine())
            Console.Write("Ingrese el valor D: ")
            D = Convert.ToDouble(Console.ReadLine())
            Console.Write("Ingrese el valor E: ")
            E = Convert.ToDouble(Console.ReadLine())

            Dim media As Double = (A + B + D + E) / 4
            Dim condicion1 As Boolean = (C > media)
            Dim condicion2 As Boolean = (E = (A + B) * D)

            If condicion1 Or condicion2 Then
                Dim valores() As Double = {A, B, C, D, E}
                Dim mediaTotal As Double = (A + B + C + D + E) / 5
                Dim sumaDiferencias As Double = 0
                For Each valor As Double In valores
                    sumaDiferencias += (valor - mediaTotal) ^ 2
                Next
                Dim desviacionEstandar As Double = Math.Sqrt(sumaDiferencias / 5)
                Dim distancia As Double = desviacionEstandar * 10
                Console.WriteLine("La distancia a recorrer es: " & distancia & " km.")
            Else
                Console.WriteLine("Our Friends are already frozen, this is a GAME OVER")
                End
            End If
        End If

        'Desafio 2

        Dim letra1, letra2, letra3 As Integer

        Console.WriteLine("Resuelve el acertijo para obtener la lanza de ARES.")
        Console.WriteLine("Introduce los valores para A, B y C")

        Console.WriteLine("Inserte el numero correspondiente a la letra A: ")
        letra1 = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("Inserte el numero correspondiente a la letra B: ")
        letra2 = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("Inserte el numero correspondiente a la letra C: ")
        letra3 = Convert.ToInt32(Console.ReadLine())

        If (letra1 = 8 And letra2 = 0 And letra3 = 4) Then
            Console.WriteLine("¡Correcto! ARES te entrega la lanza negra.")
        Else
            Console.WriteLine("THIS IS AN END GAME POINT, THE ISSUE CANNOT BE RESOLVED.")
            End

        End If

        Console.ReadLine()

        ' DESAFÍO NÚMERO 3: Seleccionar al luchador contra el dragón
        Console.WriteLine("DESAFÍO NÚMERO 3: Seleccionar al luchador contra el dragón")

        ' Paso 1: Solicitar dos letras al usuario
        Dim letter1 As Char = GetLetter("Primera")
        Dim letter2 As Char = GetLetter("Segunda")

        ' Paso 2: Convertir letras a binario
        Dim binary1 As String = Convert.ToString(Asc(letter1), 2).PadLeft(8, "0"c)
        Dim binary2 As String = Convert.ToString(Asc(letter2), 2).PadLeft(8, "0"c)

        ' Paso 3: Comparar dígitos binarios y seleccionar el personaje
        Dim characterName As String = If(binary1(0) = binary2(binary2.Length - 1), "Mujer", If("Hombre".Length > "Mujer".Length, "Hombre", "Mujer"))
        Console.WriteLine($"El personaje seleccionado es: {characterName}")

        ' Paso 4: Resolver la ecuación para encontrar el punto débil del dragón
        Console.WriteLine("Para vencer al dragón, debes encontrar su punto débil con la siguiente formula: Igresa valores entre 500 y 1000 ")
        Console.WriteLine("d = √((x₂ - x₁)² + (y₂ - y₁)²)")
        Dim x1 As Integer = GetValidInput("X1")
        Dim x2 As Integer = GetValidInput("X2")
        Dim y1 As Integer = GetValidInput("Y1")
        Dim y2 As Integer = GetValidInput("Y2")

        Dim distance As Double = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2))
        Console.WriteLine($"La distancia calculada es: {distance}")
        Console.WriteLine("Con un lanzamiento certero el dragon ZU recibe un golpe mortal y antes de morir, el dragón con sus poderes para comunicarse con los humanos le dice al personaje que pudo vencerso: 'Hay un monstruo más poderoso que yo y es mejor no enfrentarlo,
Para evitar luchar con ese mounstro deberan pronunciar su nombre 3 veces, una vez cada persona!'")


        ' ACCIÓN NÚMERO 2: Formar la palabra "DEMOGORGON"
        Console.WriteLine("Ahora los protagonistas deben descifrar cuál es el nombre del enemigo y pronunciarlo 3 veces.")
        Console.WriteLine("Las letras son: E, D, M, O, G, R, O, G, O, N")
        Console.WriteLine("Organiza las letras para formar la palabra correcta.")

        Dim palabraCorrecta As String = "DEMOGORGON"

        ' Bucle para formar la palabra correctamente
        While True
            Console.Write("Ingresa tu intento: ")
            Dim palabraFormada As String = Console.ReadLine().ToUpper()
            If palabraFormada = palabraCorrecta Then
                Console.WriteLine("¡Correcto! Has formado la palabra DEMOGORGON.")
                Exit While
            Else
                Console.WriteLine("Incorrecto. Intenta nuevamente.")
            End If
        End While

        ' Solicitar al usuario que ingrese la palabra "DEMOGORGON" tres veces
        Console.WriteLine("Para que los protagonistas sean teletransportados a la cima de la montaña, cada personaje debe pronunciar la palabra DEMOGORGON:")
        Dim intento As Integer = 3
        Dim ingresosCorrectos As Integer = 0

        While ingresosCorrectos < intento
            Console.Write($"Intento {ingresosCorrectos + 1}: ")
            Dim entradaUsuario As String = Console.ReadLine().ToUpper()

            If entradaUsuario = palabraCorrecta Then
                ingresosCorrectos += 1
                Console.WriteLine("¡Correcto!")
            Else
                Console.WriteLine("Incorrecto. Debes ingresar la palabra DEMOGORGON.")
            End If
        End While

        Console.WriteLine("En ese momento los protagonistas serán teletransportados a la cima de la montaña.")
        Console.ReadLine() ' Para mantener la ventana abierta

        ' ACCIÓN FINAL: Entrega de la Llave por Venger
        Console.WriteLine("HABIENDO CUMPLIDO LOS 3 DESAFÍOS, LA LLAVE ES ENTREGADA A ELLOS POR EL VENGER.")
        Console.WriteLine("Con la llave en mano, pueden continuar su camino hacia su hogar.")

        Console.ReadLine() ' Para mantener la ventana abierta
    End Sub

    ' Función para obtener una letra válida
    Function GetLetter(prompt As String) As Char
        Console.WriteLine($"Ingresa la {prompt} letra:")
        Return Console.ReadLine().ToUpper()(0)
    End Function

    ' Función para obtener entrada válida dentro de un rango
    Function GetValidInput(prompt As String) As Integer
        Dim input As Integer
        While True
            Console.Write($"{prompt}: ")
            If Integer.TryParse(Console.ReadLine(), input) AndAlso input >= 500 AndAlso input <= 1000 Then
                Return input
            Else
                Console.WriteLine("Por favor, ingrese un número entero entre 500 y 1000.")
            End If
        End While
    End Function

End Module



