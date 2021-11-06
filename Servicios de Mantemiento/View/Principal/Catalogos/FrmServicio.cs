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
    public partial class FrmServicio : Form
    {
        public FrmServicio()
        {
            InitializeComponent();
        }

        private void FrmServicio_Load(object sender, EventArgs e)
        {
            DataTable dt = CServicio.Ver_Servicios();
            
            if (dt != null)
            {
                dgvServicio.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Eror de carga de datos","Servicios de Mantenimiento");
            }
        }
    }
}
