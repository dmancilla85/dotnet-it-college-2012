Public Class Form1

    Delegate Function somefun() As String 'Declate type of delegate
    Dim delsomfun1 As somefun  'create a reference for the somefun delegate type

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Instantiate the somefun delegate type and assign it some function
        Dim delsomfun1 As New somefun(AddressOf Nice)

        delsomfun1.BeginInvoke(AddressOf callbackfun, delsomfun1)

        'delsomfun1.Invoke()


        MsgBox("Nice Funcion is Executing")



    End Sub

    Function Nice() As String
        Return MsgBox("We are in Nice function")
    End Function

    Sub callbackfun(ByVal ar As System.IAsyncResult)

        MsgBox("callback called and nice function execution is complete")

    End Sub
End Class


