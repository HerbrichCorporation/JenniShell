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
    Protected ReadOnly Property YesKeys As String()
        Get
            Return {"y", "j", "J", "Y"}
        End Get
    End Property
    Protected ReadOnly Property NoKeys As String()
        Get
            Return {"n", "N"}
        End Get
    End Property
    Public Function AskYesNo() As Boolean 'TDO: While True und ein Event Handler implementieren
        If (Me.YesKeys.Contains(Console.ReadLine)) Then
            Return True
        ElseIf (Me.NoKeys.Contains(Console.ReadLine)) Then
            Return False
        Else
            Return False
        End If
    End Function
End Class
