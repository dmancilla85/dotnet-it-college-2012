using System;
using System.Web.UI;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // POSTBACK???
        if (!Page.IsPostBack)
        {
            cboPaises.Items.Add("ARG");
            cboPaises.Items.Add("BRA");
            cboPaises.Items.Add("URU");
        }
    }

    protected void btnMostrar_Click(object sender, EventArgs e)
    {
        lblPais.Text = cboPaises.SelectedItem.Text;
    }

    protected void cboPaises_SelectedIndexChanged(object sender, EventArgs e)
    {
    }
}