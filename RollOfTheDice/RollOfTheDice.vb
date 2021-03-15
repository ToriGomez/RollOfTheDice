'Tori Gomez
'RCET 0265
'Spring 2021
'Roll of the Dice
'https://github.com/ToriGomez/RollOfTheDice.git

Option Explicit On
Option Strict On
Module RollOfTheDice
    Sub Main()
        Dim rollsResult As Integer
        Dim diceValue As Integer = 1
        Dim numbers(12) As Integer
        'Generates the sum of two dice rolled values. Min of 2, Max of 12.
        'Accumulates the amount of times each value is rolled from 1000 rolls.
        For i = 1 To 1000
            rollsResult = RandomNumber(6) + RandomNumber(6)
            Select Case rollsResult
                Case 2
                    numbers(2) += diceValue
                Case 3
                    numbers(3) += diceValue
                Case 4
                    numbers(4) += diceValue
                Case 5
                    numbers(5) += diceValue
                Case 6
                    numbers(6) += diceValue
                Case 7
                    numbers(7) += diceValue
                Case 8
                    numbers(8) += diceValue
                Case 9
                    numbers(9) += diceValue
                Case 10
                    numbers(10) += diceValue
                Case 11
                    numbers(11) += diceValue
                Case 12
                    numbers(12) += diceValue
                Case Else
                    MsgBox($"Error!: {rollsResult}")
            End Select
        Next
        'Rows Formatting to create table of Roll of the Dice values
        Console.WriteLine(Space(35) & ("Roll of The Dice"))
        Console.Write(StrDup(84, "-") & vbNewLine)
        For i = 2 To 12
            Console.Write(($"{i}|").PadLeft(4) & vbTab)
        Next
        Console.WriteLine(vbNewLine & StrDup(84, "-"))
        For i = 2 To UBound(numbers)
            Console.Write($"{numbers(i)}|".PadLeft(4) & vbTab)
        Next
        Console.ReadLine()
    End Sub
    'Random value of a rolled dice
    Function RandomNumber(maxNumber As Integer) As Integer
        Randomize(DateTime.Now.Millisecond)
        Return CInt(Math.Ceiling(Rnd() * maxNumber))
    End Function
End Module
