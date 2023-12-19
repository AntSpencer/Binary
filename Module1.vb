Imports System.Linq.Expressions
Imports System.Security.Cryptography.X509Certificates
Imports System.Xml.Schema

Module Module1
    Sub Main()
        Dim input As String
        Do
            Console.WriteLine("Please enter a D to covert decimal to binary, B to convert binary to decimal, or Q to quit >> ")
            input = Console.ReadLine()
            If input = "D" Then
                DTB()
            ElseIf input = "B" Then
                BTD()
            ElseIf input = "Q" Then
                Console.WriteLine("Have a good day!")
            End If
        Loop While input <> "Q"
    End Sub
    Function IntegerInput() As Integer
        Dim input As String
        Dim intinput As Integer = 0
        Do
            Console.Write("Enter your number >> ")
            input = Console.ReadLine
            Integer.TryParse(input, intinput)
            If intinput = 0 Then
                Console.WriteLine("Invalid input, please try again!!")
            End If
        Loop While intinput = 0
        Return intinput
    End Function 'Done
    Sub DTB()
        Dim input As String = IntegerInput()
        Dim div1 As Double
        Dim nate As String = input Mod 2
        Do
            div1 = Math.Floor(input / 2) ' divistion part
            input = div1
            nate = (input Mod 2) & nate
        Loop While input <> 0
        Console.WriteLine(nate)
    End Sub 'Done
    Sub BTD()
        Dim input As String = IntegerInput()
        input = StrReverse(input)
        Dim num(input.Length) As String
        Dim total As Integer
        For i As Integer = 0 To input.Length - 1
            Integer.TryParse(input(i), num(i))
            num(i) = num(i) + (2 ^ i)
            total += (num(i) - 1)

        Next
        Console.WriteLine(total)
    End Sub
End Module