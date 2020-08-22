Public Class Form1

    Public Delegate Sub delegadoFuncion(ByVal valor As String)


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
       

        Dim d1 As delegadoFuncion
        d1 = New delegadoFuncion(AddressOf funciones.F1)

        d1(Me.TextBox1.Text)

        Dim d2 As delegadoFuncion
        d2 = New delegadoFuncion(AddressOf funciones.F2)

        Dim d3 As delegadoFuncion
        d3 = [Delegate].Combine(d1, d2)

        d3(Me.TextBox1.Text)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class

Public Class funciones

    Public Shared Sub F1(ByVal strvalor As String)
        MessageBox.Show("Hola: " + strvalor)
    End Sub

    Public Shared Sub F2(ByVal strvalor As String)
        MessageBox.Show("CHau: " + strvalor)
    End Sub

End Class
'        private void button1_Click(object sender, EventArgs e)
'        {
'            delegadoFuncion d1 = new delegadoFuncion(new Funciones().F1);
'            delegadoFuncion d2 = new delegadoFuncion(new Funciones().F2);
'            delegadoFuncion d3 = (delegadoFuncion)Delegate.Combine(d1, d2);
'            d3(this.textBox1.Text);
'        }

'    }

'Public Class Funciones
'    {

'        public void F1(string strValor)
'        {

'            MessageBox.Show("Hola: " + strValor);
'        }


'        public void F2(string strValor)
'        {

'            MessageBox.Show("Chau "+ strValor);
'        }

'    }
'}
