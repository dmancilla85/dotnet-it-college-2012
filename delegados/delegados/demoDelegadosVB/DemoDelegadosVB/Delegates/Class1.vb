Public Class Bulldog
    Public Delegate Sub BarkMethod()
    Public Sub DoBark(ByVal BarksToRun As BarkMethod)
        BarksToRun.DynamicInvoke(Nothing)
    End Sub
End Class
