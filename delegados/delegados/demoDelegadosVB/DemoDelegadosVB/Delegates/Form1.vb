Public Class Form1

    Private Delegate Sub MyDelSub()

    Private Sub Write()
        MessageBox.Show("Delegate Window")
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim del As MyDelSub
        del = New MyDelSub(AddressOf Write)
        del.Invoke()

    End Sub

    Private Sub Write2()
        MessageBox.Show("Delegate Window 2")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim del As MyDelSub
        Dim del2 As MyDelSub
        Dim delAll As [Delegate]

        del = New MyDelSub(AddressOf Write)
        del2 = New MyDelSub(AddressOf Write2)
        delAll = MulticastDelegate.Combine(del, del2)
        delAll.DynamicInvoke(Nothing)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim bk1 As Bulldog.BarkMethod
        Dim bk2 As Bulldog.BarkMethod
        Dim MyDog As Bulldog
        MyDog = New Bulldog

        bk1 = New Bulldog.BarkMethod(AddressOf Bark1)
        bk2 = New Bulldog.BarkMethod(AddressOf Bark2)
        MyDog.DoBark(bk1)
        MyDog.DoBark(bk2)

    End Sub

    Private Sub Bark1()
        MessageBox.Show("Woof Woof")
    End Sub
    Private Sub Bark2()
        MessageBox.Show("Yip Yip")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim bk1 As Bulldog1.BarkMethod
        Dim bk2 As Bulldog1.BarkMethod
        Dim MyDog As Bulldog1
        MyDog = New Bulldog1
        bk1 = New Bulldog1.BarkMethod(AddressOf Bark1)
        bk2 = New Bulldog1.BarkMethod(AddressOf Bark2)
        MyDog.AddBark(bk1)
        MyDog.AddBark(bk2)
        MyDog.DoBark()
        MyDog.RemoveBark(bk2)
        MyDog.DoBark()

    End Sub
End Class
