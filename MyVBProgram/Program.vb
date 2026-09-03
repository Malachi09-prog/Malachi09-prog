Module Program
    Sub Main()
        ' Declaring each Variable
        Dim name As String
        Dim age As Integer
        Dim Question As Boolean
        Dim answer As String
        
        ' Asking the user for their name, age, and favorite color
        Console.Write("Enter your name: ")
        name = Console.ReadLine()

        Console.Write("Enter your age: ")
        if Not Integer.TryParse(Console.ReadLine(), age) Then
            Console.WriteLine("Invalid input. Please enter a valid integer for age.")
            Return
        End If
        age = Integer.Parse(Console.ReadLine())

        ' Using an if statement to determine the age group of the user
        if age < 13 Then
            Console.WriteLine("You are a child.")
        ElseIf age >= 13 And age < 20 Then
            Console.WriteLine("You are a teenager.")
        Else
            Console.WriteLine("You are an adult.")
        End If

        ' Asking the user if they like ice cream and storing their response in a boolean variable
        Console.Write("Do you like ice cream? (true/false): ")
        if Not Boolean.TryParse(Console.ReadLine(), Question) Then
            Console.WriteLine("Invalid input. Please enter 'true' or 'false'.")
            Return
        End If
        if age < 18 Then
            Console.WriteLine("You are too young to answer this. ")
        ElseIf age >= 18 And age < 65 Then
            Console.WriteLine("You Can Vote!")
        End If
        Question = Boolean.Parse(Console.ReadLine())
        if Question = True Then
            Console.WriteLine("You like ice cream!")
        Else
            Console.WriteLine("You don't like ice cream.")
        End If
        Console.Write("What is your favorite color?: ")
        answer = Console.ReadLine()

        ' Displaying the user's name, age, and favorite color
        Console.WriteLine("Hello, " & name & "!")
        Console.WriteLine("You are " & age & " years old.")
        Console.WriteLine("Answer: " & Question)
        Console.WriteLine("Favorite Color: " & answer)

        Console.ReadLine()
    End Sub
End Module
