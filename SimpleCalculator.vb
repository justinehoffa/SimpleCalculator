Option Strict Off
Option Explicit On
Option Compare Text

'Justine Hoffa
'RCET0265
'Fall2020
'SimpleCalculator
'https://github.com/justinehoffa/SimpleCalculator

Module SimpleCalculator

    Sub Main()

        Dim userSelect As String
        Dim firstNumber As Integer
        Dim secondNumber As Integer

        Console.Clear()
        Console.WriteLine("Choose a number: ")
        firstNumber = Console.ReadLine()
        Console.WriteLine("Choose a number: ")
        secondNumber = Console.ReadLine()

        Console.WriteLine("Choose one of the following options: ")
        Console.WriteLine("1. Sum.")
        Console.WriteLine("2. Product.")
        Console.WriteLine("3. Subtract.")
        Console.WriteLine("4. Divide.")
        userSelect = Console.ReadLine()

        If userSelect = 1 Then
            Console.WriteLine(firstNumber & " + " & secondNumber & " = " & firstNumber + secondNumber)
        ElseIf userSelect = 2 Then
            Console.WriteLine(firstNumber & " * " & secondNumber & " = " & firstNumber * secondNumber)
        ElseIf userSelect = 3 Then
            Console.WriteLine(firstNumber & " - " & secondNumber & " = " & firstNumber - secondNumber)
        ElseIf userSelect = 4 Then
            Console.WriteLine(firstNumber & " / " & secondNumber & " = " & firstNumber / secondNumber)
        End If

        Console.ReadLine()

    End Sub


End Module
