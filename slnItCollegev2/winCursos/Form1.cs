using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace winCursos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Libreria.Mensajes objMsj = new Libreria.Mensajes();

            lblMensaje.Text = objMsj.msj(txtNombre.Text);
        }

        //private void btnEnviar_Click(object sender, EventArgs e)
        //{
        //   // lblMensaje.Text = "Bienvenido " + txtNombre.Text;
        //}
    }
}
