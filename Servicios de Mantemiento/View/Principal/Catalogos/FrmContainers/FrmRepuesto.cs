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
    public partial class FrmRepuesto : Form
    {
        public FrmRepuesto()
        {
            InitializeComponent();
        }

        private void FrmRepuesto_Load(object sender, EventArgs e)
        {
            DataTable dt = CRepuesto.Ver_Repuestos();
            
            if (dt != null)
            {
                dgvRepuestos.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No existe la tabla de Repuestos en la Base de Datos","Servicios de Mantenimiento",
                                 MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
