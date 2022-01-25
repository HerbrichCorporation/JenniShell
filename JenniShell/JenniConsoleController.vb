Imports Herbrich.JenniShell
Public Class JenniConsoleController
    Inherits JenniShellFunctions
    Sub New()
        Console.ForegroundColor = ConsoleColor.DarkRed
        Me.ConsoleRunning = (False)
    End Sub
    Protected Statemands As New List(Of Statemant)
    Protected ConsoleRunning As Boolean
    Public ReadOnly Property Running As Boolean
        Get
            Return Me.ConsoleRunning
        End Get
    End Property
    Public Function StatemantExist(ByVal Syntax As String) As Boolean
        Dim enumerator As IEnumerable(Of Statemant) = (Me.Statemands.Where(Function(ByVal jh As Statemant) jh.SyntaxKeyword = Syntax))
        Return (enumerator.Count = 1)
    End Function
    Public Sub AddStatemant(ByVal Statemant As Statemant)
        Dim exsistException As New ArgumentException("Statemant", "Die übergebene Syntax existiert bereits!")
        If (Statemant Is Nothing) Then
            Throw New ArgumentNullException("Statemant", "Es muss eine Syntax übergeben werden!")
        End If
        If (Me.Statemands.Contains(Statemant)) Then
            Throw exsistException
        End If
        If (Me.StatemantExist(Statemant.SyntaxKeyword)) Then
            Throw exsistException
        End If
        Statemant.SetJenniConsole(Me)
        Me.Statemands.Add(Statemant)
    End Sub
    Public Sub Hall()
        Me.ConsoleRunning = (True)
        While Me.Running
            Dim syntax As String = (Console.ReadLine)
            Dim enumerator As IEnumerable(Of Statemant) = (Me.Statemands.Where(Function(ByVal jh As Statemant) jh.SyntaxKeyword = syntax))
            If (enumerator.Count = 1) Then
                enumerator(0).Trigger()
            End If
        End While
    End Sub
End Class
