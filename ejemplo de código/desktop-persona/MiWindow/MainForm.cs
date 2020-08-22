using System;
using System.Windows.Forms;

namespace MiWindow
{
    public partial class MainForm : Form
    {
        private PersonLibrary.BasePersona usr;

        public MainForm()
        {
            InitializeComponent();
            cboGenero.Items.Add("Masculino");
            cboGenero.Items.Add("Femenino");
            usr = new PersonLibrary.BasePersona();
        }

        private void TxtEdad_TextChanged(object sender, EventArgs e)
        {
            if (usr != null)
                usr.Edad = Int32.Parse(txtEdad.Text);
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            if (usr != null)
                usr.Nombre = txtNombre.Text;
        }

        private void TxtApellido_TextChanged(object sender, EventArgs e)
        {
            if (usr != null)
                usr.Apellido = txtApellido.Text;
        }

        private void CboGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGenero.SelectedItem.Equals("Masculino"))
                usr.Genero = PersonLibrary.BasePersona.Gender.Masculino;
            else
                usr.Genero = PersonLibrary.BasePersona.Gender.Femenino;
        }

        private void ChkMger_CheckedChanged(object sender, EventArgs e)
        {
            if (usr == null)
                usr = new PersonLibrary.Manager();
            else
                usr = new PersonLibrary.Manager(usr);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(usr.ToString());
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            if (usr != null)
                usr.Telefono = txtTelefono.Text;
        }
    }
}