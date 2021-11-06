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
    public partial class FrmVehiculo : Form
    {
        public FrmVehiculo()
        {
            InitializeComponent();
        }

        private void FrmVehiculo_Load(object sender, EventArgs e)
        {
            DataTable dt = CVehiculo.Ver_Vehiculos();

            if (dt != null)
            {
                dgvVehiculos.DataSource = dt;
            }
            else
            {
                MessageBox.Show("La tabla vehiculos no contiene datos a mostrar", "Servicios de Mantenimiento",
                                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
