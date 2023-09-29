Module Module1

    Sub Main()
        ' Solicitar al usuario que ingrese los dos números
        Console.Write("Ingresa el primer número entero: ")
        Dim numero1 As Integer = Console.ReadLine()

        Console.Write("Ingresa el segundo número entero: ")
        Dim numero2 As Integer = Console.ReadLine()

        Console.WriteLine()

        ' Verificar si numero1 es divisor de numero2
        If numero2 Mod numero1 = 0 Then
            Console.WriteLine(numero1 & " si es divisor de " & numero2)
        Else
            Console.WriteLine(numero1 & " no es divisor de " & numero2)
        End If

        Console.WriteLine("********************************************")

        ' Verificar si numero2 es divisor de numero1
        If numero1 Mod numero2 = 0 Then
            Console.WriteLine(numero2 & " si es divisor de " & numero1)
        Else
            Console.WriteLine(numero2 & " no es divisor de " & numero1)
        End If

        ' Pausar la consola
        Console.ReadLine()
    End Sub

End Module
