Module Module1

    Sub Main()
        Dim boolEndProgram As Boolean = False
        Dim intGuess As Integer
        Dim intNumber As Integer
        Dim intGuessCount As Integer
        Dim boolWin As Boolean
        Dim charPlayAgain As Char
        'Do
        'Initializing Variables
        Randomize()
        intNumber = Math.Floor(Rnd() * 10) + 1
        intGuessCount = 0
        boolWin = False
        Console.WriteLine("Welcome to the guessing game!")
        Console.WriteLine("You get three chances to guess the correct number")
        Console.WriteLine("Press Enter key to start:")
        Console.ReadLine()
        Console.Clear()
        Do
            Console.WriteLine("Pick a number from 1 to 10")
            intGuess = Console.ReadLine()
            intGuessCount = intGuessCount + 1
            If intGuess = intNumber Then
                boolWin = True
            ElseIf intGuess < intNumber Then
                Console.WriteLine("Too Low")
            Else
                Console.WriteLine("Too High")
            End If
        Loop While intGuessCount < 3 And boolWin = False
        If boolWin = True Then
            Console.WriteLine("You Got It!!")
        Else Console.WriteLine("Sorry, You Lose.")
        End If
        Console.WriteLine("Would you like to play again? y/n")
        charPlayAgain = Console.ReadLine()

        '  Loop Until boolEndProgram = True

    End Sub

End Module
