Module Program
    Sub Main()
        Dim name As String
        Dim age As Integer
        Console.Write("Enter your name: ")
        name = Console.ReadLine()
        
        Console.Write("Enter your age: ")
        age = Integer.Parse(Console.ReadLine())

        Console.WriteLine("Hello, " & name & "!")
        Console.WriteLine("You are " & age & " years old.")

        Console.ReadLine()
    End Sub
End Module
