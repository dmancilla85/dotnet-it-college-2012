Public Class impresora
    Private texto As String

    Public Event ImpresionOK As EventHandler

    Public Sub impresora(ByVal texto As String)
        Me.texto = texto
    End Sub

    Public Sub imprimir()
        MsgBox(Me.texto)
        RaiseEvent ImpresionOK(texto, Nothing)
    End Sub


End Class

'Class impresora
'    {
'        private string _texto;

'        //declaración del evento
'        public event EventHandler ImpresionOK;

'        public impresora(string texto)
'        {
'            this._texto = texto;
'        }

'        public void Imprimir()
'        {
'            Console.Write(this._texto);
'            //invocación del evento
'            ImpresionOK(_texto, null);

'        }