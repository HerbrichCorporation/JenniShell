Imports Herbrich.JenniShell
Public MustInherit Class Statemant
    Inherits JenniShellFunctions
    Protected InnerName As String
    Sub New(ByVal Syntax As String)
        If (Syntax = String.Empty AndAlso Syntax = Nothing) Then
            Throw New ArgumentNullException("Syntax", "Es muss ein Namen für den Syntax des Statemants angegeben werden!")
        End If
        Me.InnerName = (Syntax)
    End Sub
    Protected Friend ReadOnly Property SyntaxKeyword
        Get
            Return Me.InnerName
        End Get
    End Property
    Protected Friend MustOverride Sub Trigger()
    Protected ConsoleController As JenniConsoleController
    Protected Friend Sub SetJenniConsole(ByVal jh As JenniConsoleController)
        Me.ConsoleController = (jh)
    End Sub
End Class
