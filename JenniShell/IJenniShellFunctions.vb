Public Interface IJenniShellFunctions
    Function AskUser(ByVal Quastion As String) As String
    Function AskUser(ByVal Quastion As String, ByVal Format As UserInputFormat) As String
End Interface
