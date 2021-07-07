'Your code crashes with these set to on - TJR
Option Strict On
Option Explicit On
Option Compare Text

'Justine Hoffa
'RCET0265
'Fall2020
'SimpleCalculator
'https://github.com/justinehoffa/SimpleCalculator.git

Module SimpleCalculator

    Sub Main()

        Dim userSelect As String
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim badInput As Boolean

        Do
            Console.Clear()
            Try 'Converting user input to a number can result in an exception - TJR
                'Text prompting the user to input two integers
                Console.WriteLine("Choose a number: ")
                firstNumber = CInt(Console.ReadLine()) ' Conversions must be explicit - TJR
                Console.WriteLine("Choose a number: ")
                secondNumber = CInt(Console.ReadLine()) ' Conversions must be explicit - TJR
                badInput = False
            Catch e As Exception
                badInput = True
            End Try
        Loop While badInput = True

        Console.WriteLine("Choose one of the following options: ")
        Console.WriteLine("1. Sum.")
        Console.WriteLine("2. Product.")
        Console.WriteLine("3. Subtract.")
        Console.WriteLine("4. Divide.")
        userSelect = Console.ReadLine()

        'Comparing a string to an integer won't work with option strict on - TJR
        If userSelect = "1" Then
            Console.WriteLine(firstNumber & " + " & secondNumber & " = " & firstNumber + secondNumber)
        ElseIf userSelect = "2" Then
            Console.WriteLine(firstNumber & " * " & secondNumber & " = " & firstNumber * secondNumber)
        ElseIf userSelect = "3" Then
            Console.WriteLine(firstNumber & " - " & secondNumber & " = " & firstNumber - secondNumber)
        ElseIf userSelect = "4" Then
            Console.WriteLine(firstNumber & " / " & secondNumber & " = " & firstNumber / secondNumber)
        End If

        Console.ReadLine()

    End Sub


End Module
