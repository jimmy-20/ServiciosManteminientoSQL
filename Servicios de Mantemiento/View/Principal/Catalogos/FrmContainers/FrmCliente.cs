using Servicios_de_Mantemiento.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servicios_de_Mantemiento.View.Principal.FrmContainers
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            DataTable dt = CCliente.Ver_Clientes();

            if (dt != null)
            {
                dgvClientes.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Sin datos en la tabla clientes","Servicios de Mantenimientos",
                                 MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string PNombre = txtPrimerNombre.Text;
            string SNombre = txtSegundoNombre.Text;
            string PApellido = txtPrimerApellido.Text;
            string SApellido = txtSegundoApellido.Text;
            string telefono = mtbTelefono.Text;

            CCliente.Insertar_Cliente(PNombre, SNombre, PApellido, SApellido, telefono);

            dgvClientes.Refresh();
        }
    }
}
