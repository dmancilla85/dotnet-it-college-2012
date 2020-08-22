Public Class Bulldog1
    Private _Barks As [Delegate]
    Public Delegate Sub BarkMethod()
    Public Sub DoBark()
        If Not IsNothing(_Barks) Then 'check to see if there is anthing to Invoke
            _Barks.DynamicInvoke(Nothing)
        End If
    End Sub
    Public Sub AddBark(ByVal Bark As BarkMethod)
        _Barks = MulticastDelegate.Combine(_Barks, Bark)
    End Sub
    Public Sub RemoveBark(ByVal Bark As BarkMethod)
        _Barks = MulticastDelegate.Remove(_Barks, Bark)
    End Sub
End Class
