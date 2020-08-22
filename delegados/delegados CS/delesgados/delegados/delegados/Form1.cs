using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace delegados
{
    public delegate void delegadoFuncion(string valor);

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            delegadoFuncion d1 = new delegadoFuncion(new Funciones().F1);
            delegadoFuncion d2 = new delegadoFuncion(new Funciones().F2);
            delegadoFuncion d3 = (delegadoFuncion)Delegate.Combine(d1, d2);
            d3(this.textBox1.Text);
        }

    }

    public class Funciones
    {

        public void F1(string strValor)
        {

            MessageBox.Show("Hola: " + strValor);
        }


        public void F2(string strValor)
        {

            MessageBox.Show("Chau "+ strValor);
        }
    
    }
}