using Servicios_de_Mantemiento.Controller;
using Servicios_de_Mantemiento.View.Principal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servicios_de_Mantemiento
{
    public partial class Form1 : Form
    {
        private string Usuario;
        private string Rol;
        private FrmPrincipal frmPrincipal;
        public Form1()
        {
            InitializeComponent();
            frmPrincipal = new FrmPrincipal();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ptbLogin.BackColor = Color.Transparent;
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length == 0 || txtNombre.Text == "Nombre")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
            
        }

        private void txtContra_Enter(object sender, EventArgs e)
        {
            if (txtContra.Text.Length == 0 || txtContra.Text == "Contrasena")
            {
                txtContra.Text = "";
                txtContra.ForeColor = Color.Black;
            }
            
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre";
                txtNombre.ForeColor = Color.Gray;
            }
        }

        private void txtContra_Leave(object sender, EventArgs e)
        {
            if (txtContra.Text == "")
            {
                txtContra.Text = "Contrasena";
                txtContra.ForeColor = Color.Gray;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtNombre.Text;
            string contra = txtContra.Text;

            DataTable dt = CLogin.Validar_Acceso(usuario, contra);

            if (dt != null)
            {
                if (dt.Rows[0][0].ToString() == "Acceso Permitido")
                {

                    frmPrincipal.ShowDialog();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nombre de usuario o contrasena incorrecto", "ServiPlus S.A",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            }
            else
            {
                MessageBox.Show("No hay conexión al servidor", "ServiPlus S.A",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
