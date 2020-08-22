using System;
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

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            Libreria.ValidarUsuario vu = new Libreria.ValidarUsuario
            {
                Nombre = this.lblNombre.Text,
                Password = this.lblPassword.Text
            };

            if (vu.Autenticar())
                lblMensaje.Text = "Usuario autenticado.";
            else
                lblMensaje.Text = "Usuario inválido.";
        }
    }
}