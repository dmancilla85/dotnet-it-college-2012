
Namespace pruebaDelegados
    'Declaration
    Public Delegate Sub simpleDelagate(ByVal v As String)

    Public Class SimpleDelegate

        Public Shared Sub MiFuncion()
            Console.WriteLine("I was called by delegate ...")
            Console.ReadLine()
        End Sub
       
        Public Shared Sub main()
            '        // Instantiation
            Dim simpleDelegate As New SimpleDelegate(MiFuncion)

            '        // Invocation
            simpleDelegate()

        End Sub


    End Class
End Namespace