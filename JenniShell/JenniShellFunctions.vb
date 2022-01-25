Imports Herbrich.JenniShell
Public Enum UserInputFormat
    Generic = 0
    YesNo = 1
End Enum
Public Class JenniShellFunctions
    Implements IJenniShellFunctions
    Public Function AskUser(ByVal Quastion As String) As String Implements IJenniShellFunctions.AskUser
        Console.ForegroundColor = ConsoleColor.Red
        Console.Write(String.Format("{0} :> ", Quastion))
        Console.ForegroundColor = ConsoleColor.Magenta
        Dim answer As String = Console.ReadLine
        Console.ForegroundColor = ConsoleColor.DarkRed
        Return answer
    End Function
    Public Function AskUser(ByVal Quastion As String, ByVal Format As UserInputFormat) As String Implements IJenniShellFunctions.AskUser
        Select Case Format
            Case UserInputFormat.YesNo
                Console.ForegroundColor = ConsoleColor.Red
                Console.Write(String.Format("{0}:[J/N]> ", Quastion))
                Console.ForegroundColor = ConsoleColor.Magenta
                Dim answer As String = Console.ReadLine
                Console.ForegroundColor = ConsoleColor.DarkRed
                Return answer
            Case UserInputFormat.Generic
                Return Me.AskUser(Quastion)
            Case Nothing
                Return Me.AskUser(Quastion)
            Case Else
                Return Me.AskUser(Quastion)
        End Select
    End Function
End Class
