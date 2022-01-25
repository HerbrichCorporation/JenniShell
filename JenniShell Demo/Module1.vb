
Public Class Foo
    Sub New()
        Console.ForegroundColor = ConsoleColor.DarkRed
        Me.baz = "Welt"
        Console.WriteLine(String.Format("Hallo {0}", Me.baz))
        Console.WriteLine("Wie heißt du?")
        Me.baz = Me.AskUser("Name?")
        Console.WriteLine(String.Format("Herzlich willkommen im Foo Baa Game lie(r) {0}!", Me.baz))
    End Sub
    Public Function AskUser(ByVal Quastion As String) As String
        Console.ForegroundColor = ConsoleColor.Red
        Console.Write(String.Format("{0} :> ", Quastion))
        Console.ForegroundColor = ConsoleColor.Magenta
        Dim answer As String = Console.ReadLine
        Console.ForegroundColor = ConsoleColor.DarkRed
        Return answer
    End Function
    Public Function AskUser(ByVal Quastion As String, ByVal Format As UserInputFormat) As String
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
    Dim baz As String = Nothing
    Public Sub baa()
        Console.WriteLine("Jetzt zu Ali gehen?")

        Select Case Me.AskUser("FooBaa:", UserInputFormat.YesNo)
            Case "y", "j", "J", "Y"
                Console.WriteLine("Go")
            Case "n", "N"
                Console.WriteLine("Dannn hlt nicht!")
            Case Else
                Console.WriteLine("Falsche Eingabe. Verpiss dich Christopher Strunk du Script Kiddy")
        End Select
    End Sub
End Class
Public Module FooBaaGameModule
    Sub Main()
        Dim fb As New Foo
        While True
            fb.baa()
        End While
    End Sub
End Module