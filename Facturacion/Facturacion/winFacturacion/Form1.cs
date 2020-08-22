using System;
using System.Data;
using System.Windows.Forms;

namespace winFacturacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = dacFacturacion.AdminCliente.TraerTodos();
            gridClientes.DataSource = ds.Tables["Clientes"];

            cboLocalidades.DataSource = dacFacturacion.Utiles.SoloLocalidades();
            cboLocalidades.DisplayMember = "Localidad";
            cboLocalidades.ValueMember = "Localidad";

        }

        private void gridClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboLocalidades_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string itemLocalidad = cboLocalidades.SelectedValue.ToString();
            
            DataSet ds = dacFacturacion.AdminCliente.TraerTodos(itemLocalidad);
            gridClientes.DataSource = ds.Tables["ClientesPorLocalidad"];
        }
    }
}
