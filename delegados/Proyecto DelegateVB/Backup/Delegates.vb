Module Module1
    
    Public Class Wisdom 'Class containing Delegate
        Delegate Function GiveAdvice() As String
        Public Function OfferAdvice(ByVal Words As GiveAdvice) As String
            Return (Words())
        End Function
    End Class
    
    Public Class Parent 'Base type
        Public Overridable Function Message() As String
            Return ("You should listen to your elders")
        End Function
    End Class
    
    Public Class Dad 'derived from the base parent type
        Inherits Parent
        Public Overrides Function Message() As String
            Return ("You should listen to your Mom")
        End Function
    End Class
    
    Public Class Mom 'derived from the base parent type
        Inherits Parent
        Public Overrides Function Message() As String
            Return ("You should listen to your Dad")
        End Function
    End Class
    
    Public Class Daughter 'not derived from the base parent type
        Public Function Message() As String
            Return ("I know all there is to life")
        End Function
    End Class
    
    Public Function CallAdvice(ByVal p As Parent) As String
        Dim objParents As New Wisdom()
        Dim TeenAgeGirl As Wisdom.GiveAdvice = New Wisdom.GiveAdvice(AddressOf p.Message)
        
        Return (objparents.OfferAdvice(TeenAgeGirl))
    End Function
    
    Sub Main()
        
        Dim objDad As New Dad()
        Dim objMom As New Mom()
        Dim objDaughter As New Daughter()
        
        console.WriteLine(CallAdvice(objDad))
        console.WriteLine(CallAdvice(objMom))
        
        'will not work as this is not derived
        'console.WriteLine(CallAdvice(objDaughter))
    End Sub
    
End Module
