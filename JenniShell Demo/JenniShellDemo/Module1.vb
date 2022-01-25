Imports Herbrich.JenniShell
Public Class FooBaaGame
    Inherits Statemant
    Sub New()
        MyBase.New("foobaa")
        Me.Name = "Welt"
        Console.WriteLine(String.Format("Hallo {0}", Me.Name))
        Console.WriteLine("Wie heißt du?")
        Me.Name = Me.AskUser("Name?")
        Console.WriteLine(String.Format("Herzlich willkommen im Foo Baa Game lie(r) {0}!", Me.Name))
    End Sub
    Protected Name As String
    Protected Overrides Sub Trigger()
        While True
            Console.WriteLine("Jetzt zu Aldi gehen?")

            Select Case Me.AskUser("FooBaa:", UserInputFormat.YesNo)
                Case "y", "j", "J", "Y"
                    Console.WriteLine("Go")
                Case "n", "N"
                    Console.WriteLine("Dannn hlt nicht!")
                Case Else
                    Console.WriteLine("Falsche Eingabe. Verpiss dich Christopher Strunk du Script Kiddy")
            End Select
        End While
    End Sub
End Class
Module JenniDemoConsoleModule
    Dim JenniJenni As New JenniConsoleController
    Sub Main()
        JenniJenni.AddStatemant(New FooBaaGame)
        JenniJenni.Hall()
    End Sub

End Module
