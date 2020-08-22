Module Module1
    Public Delegate Sub delegatetype(ByVal S As String)

    Public Sub Display(ByVal str As String)
        System.Console.WriteLine("esto es una prueba")
        Console.ReadKey()
    End Sub

    Sub Main()
        Dim del1 As delegatetype

        del1 = AddressOf Display
        del1.Invoke("")          '//this wil call the sub program Display
    End Sub

End Module
