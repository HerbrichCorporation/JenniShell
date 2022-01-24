Public Class Foo
    Sub New()
        Console.ForegroundColor = ConsoleColor.DarkRed
        Me.baz = "Welt"
        Console.WriteLine(String.Format("Hallo {0}", Me.baz))

    End Sub
    Public Function AskUser(ByVal Quastion As String) As String
        Console.ForegroundColor = ConsoleColor.Red
        Console.Write(Quastion)
        Console.ForegroundColor = ConsoleColor.Magenta
        Dim answer As String = Console.ReadLine
        Console.ForegroundColor = ConsoleColor.DarkRed
        Return answer
    End Function
    Dim baz As String = Nothing
    Public Sub baa()
        Console.WriteLine("Jetzt zu Ali gehen?")

        Select Case Me.AskUser("FooBaa:[J/N]> ")
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