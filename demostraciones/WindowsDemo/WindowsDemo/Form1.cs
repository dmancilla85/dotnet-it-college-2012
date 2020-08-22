using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void mensaje()
        {

            MessageBox.Show("Hola");
        }

        void mensaje(string nombre)
        {

            MessageBox.Show("Hola "+ nombre);
        }

        private void btnMensaje_Click(object sender, EventArgs e)
        {
            mensaje("gaby");
            mensaje();
        }
    }
}
