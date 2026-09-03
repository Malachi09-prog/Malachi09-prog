Module Program
    Sub Main()
        Dim name As String
        Dim age As Integer
        Dim Question As Boolean
        Dim answer As String
        

        Console.Write("Enter your name: ")
        name = Console.ReadLine()

        Console.Write("Enter your age: ")
        age = Integer.Parse(Console.ReadLine())

        Console.Write("Do you like ice cream? (true/false): ")
        Question = Boolean.Parse(Console.ReadLine())
        if Question = True Then
            Console.WriteLine("You like ice cream!")
        Else
            Console.WriteLine("You don't like ice cream.")
        End If
        Console.Write("What your favorite color?: ")
        answer = Console.ReadLine()

        Console.WriteLine("Hello, " & name & "!")
        Console.WriteLine("You are " & age & " years old.")
        Console.WriteLine("Answer: " & Question)
        Console.WriteLine("Favorite Color: " & answer)

        Console.ReadLine()
    End Sub
End Module
