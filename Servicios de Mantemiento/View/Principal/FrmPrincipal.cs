using Servicios_de_Mantemiento.View.Principal.FrmContainers;
using Servicios_de_Mantemiento.View.Principal.Seguridad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servicios_de_Mantemiento.View.Principal
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void matenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = (FrmCliente)this.MdiChildren.FirstOrDefault(x => x is FrmCliente);

            if (frmCliente == null)
            {
                frmCliente = new FrmCliente();
                frmCliente.MdiParent = this;
                frmCliente.Show();
            }
            else
            {
                frmCliente.BringToFront();
            }
        }

        private void mniVehiculos_Click(object sender, EventArgs e)
        {
            FrmVehiculo frmVehiculo = (FrmVehiculo)this.MdiChildren.FirstOrDefault(x => x is FrmVehiculo);

            if (frmVehiculo == null)
            {
                frmVehiculo = new FrmVehiculo();
                frmVehiculo.MdiParent = this;
                frmVehiculo.Show();
            }
            else
            {
                frmVehiculo.BringToFront();
            }
        }

        private void mniServicios_Click(object sender, EventArgs e)
        {
            FrmServicio frmServicio = (FrmServicio)this.MdiChildren.FirstOrDefault(x => x is FrmServicio);

            if (frmServicio == null)
            {
                frmServicio = new FrmServicio();
                frmServicio.MdiParent = this;
                frmServicio.Show();
            }
            else
            {
                frmServicio.BringToFront();
            }
        }

        private void mniRepuestos_Click(object sender, EventArgs e)
        {
            FrmRepuesto frmRepuesto = (FrmRepuesto)this.MdiChildren.FirstOrDefault(x => x is FrmRepuesto);
            
            if (frmRepuesto == null)
            {
                frmRepuesto = new FrmRepuesto();
                frmRepuesto.MdiParent = this;
                frmRepuesto.Show();
            }
            else
            {
                frmRepuesto.BringToFront();
            }
        }

        private void verRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario frmUsuario = (FrmUsuario)this.MdiChildren.FirstOrDefault(x => x is FrmUsuario);
            
            if (frmUsuario != null)
            {
                frmUsuario.BringToFront();
            }
            else
            {
                frmUsuario = new FrmUsuario();
                frmUsuario.MdiParent = this;
                frmUsuario.Show();
            }
        }
    }
}
