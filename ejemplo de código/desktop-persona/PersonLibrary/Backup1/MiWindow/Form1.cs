using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MiWindow
{
    public partial class Form1 : Form
    {
        private PersonLibrary.basePersona usr;
        
        public Form1()
        {
            InitializeComponent();
            cboGenero.Items.Add("Masculino");
            cboGenero.Items.Add("Femenino");
            usr = new PersonLibrary.basePersona();
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
            if (usr != null)
                usr.Edad = Int32.Parse(txtEdad.Text);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (usr != null)
                usr.Nombre = txtNombre.Text;
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            if (usr != null)
                usr.Apellido = txtApellido.Text;
        }

        private void cboGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cboGenero.SelectedItem.Equals("Masculino"))
                usr.Genero = PersonLibrary.basePersona.Gender.Masculino;
            else
                usr.Genero = PersonLibrary.basePersona.Gender.Femenino;
        }

        private void chkMger_CheckedChanged(object sender, EventArgs e)
        {
            if (usr == null)
                usr = new PersonLibrary.Manager();
            else
                usr = new PersonLibrary.Manager(usr);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(usr.ToString());
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
