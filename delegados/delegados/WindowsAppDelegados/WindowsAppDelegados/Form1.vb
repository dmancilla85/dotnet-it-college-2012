Public Class Form1
    'Dim WithEvents obj As New impresora
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim obj As New impresora
        obj.impresora(Me.txtMensaje.Text)
        AddHandler obj.ImpresionOK, AddressOf metodoevento
        obj.imprimir()
    End Sub

    'Private Sub obj_ImpresionOK(ByVal sender As Object, ByVal e As System.EventArgs) Handles obj.ImpresionOK
    '    MessageBox.Show("Evento impresionOK")
    'End Sub

    Private Sub metodoevento(ByVal s As Object, ByVal e As System.EventArgs)
        MessageBox.Show("Evento dinámico")
    End Sub
End Class
