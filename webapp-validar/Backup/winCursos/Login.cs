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
    /// <summary>
    /// Para seleccionar el form inicial, hay que modificarlo en Program
    /// </summary>

    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Libreria.ValidarUsuario vu = new Libreria.ValidarUsuario();

            vu.Nombre = "David";
            vu.Password = "123789";

            if (vu.autenticar())
                lblMensaje.Text = "Usuario autenticado.";
            else
                lblMensaje.Text = "Usuario inválido.";
        }
    }
}
