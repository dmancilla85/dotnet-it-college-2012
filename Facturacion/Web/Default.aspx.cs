using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
       if(!Page.IsPostBack)
       {
           DataSet ds = dacFacturacion.AdminCliente.TraerTodos();
           gridClientes.DataSource = ds.Tables["Clientes"];
           // Si en web no se coloca este método, no se visualizarán los datos.
           gridClientes.DataBind();

           cboLocalidades.DataSource = dacFacturacion.Utiles.SoloLocalidades();
           cboLocalidades.DataTextField = "Localidad";
           cboLocalidades.DataValueField = "Localidad";
           cboLocalidades.DataBind();

       }
    }
    protected void cboLocalidades_SelectedIndexChanged(object sender, EventArgs e)
    {
        string itemLocalidad = cboLocalidades.SelectedValue.ToString();

        DataSet ds = dacFacturacion.AdminCliente.TraerTodos(itemLocalidad);
        gridClientes.DataSource = ds.Tables[0];
        gridClientes.DataBind();

        Literal1.Text = "(*)" + ds.GetXmlSchema() + "(*)";
    }
}
