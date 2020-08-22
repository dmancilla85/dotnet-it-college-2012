using System;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void btnEnviar_Click(object sender, EventArgs e)
    {
        Libreria.Mensajes objMsj = new Libreria.Mensajes();
        lblMensaje.Text = objMsj.msg(txtNombre.Text);
    }
}