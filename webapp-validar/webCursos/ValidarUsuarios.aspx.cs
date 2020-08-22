using System;

public partial class ValidarUsuarios : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void btnEnviar_Click(object sender, EventArgs e)
    {
        Libreria.ValidarUsuario vu = new Libreria.ValidarUsuario();

        if (txtPassword.Text != string.Empty && txtNombre.Text != string.Empty)
        {
            vu.Nombre = txtNombre.Text;
            vu.Password = txtPassword.Text;

            if (vu.Autenticar())
                lblMensaje.Text = "Usuario autenticado.";
            else
                lblMensaje.Text = "Usuario inválido.";
        }
    }

    protected void txtNombre_TextChanged(object sender, EventArgs e)
    {
    }
}