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
        int IdCliente;
        bool flag;
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            DataTable dt = CCliente.Ver_Clientes();

            if (dt != null)
            {
                Mostrar();
            }
            else
            {
                MessageBox.Show("Sin datos en la tabla clientes","Servicios de Mantenimientos",
                                 MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            BotonesCancelOk(false);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            flag = true;

            btnEditar.Visible = false;
            btnAgregar.Visible = false;

            dgvClientes.Enabled = false;

            BotonesCancelOk(true);
        }

        private void Mostrar()
        {
            dgvClientes.DataSource = CCliente.Ver_Clientes();
            dgvClientes.Columns[0].Visible = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (VerificarFila() == false)
            {
                return;
            }
            
            DataGridViewRow row = dgvClientes.SelectedRows[0];

            txtPrimerNombre.Text = (row.Cells[1].Value).ToString();
            txtSegundoNombre.Text = (row.Cells[2].Value).ToString();
            txtPrimerApellido.Text = (row.Cells[3].Value).ToString();
            txtSegundoApellido.Text = (row.Cells[4].Value).ToString();
            mtbTelefono.Text = (row.Cells[5].Value).ToString();

            IdCliente = Convert.ToInt32((row.Cells[0].Value).ToString());

            flag = false;

            btnAgregar.Visible = false;
            btnEditar.Visible = false;
            dgvClientes.Enabled = false;

            BotonesCancelOk(true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ClearTxt();

            btnAgregar.Visible = true;
            btnEditar.Visible = true;
            dgvClientes.Enabled = true;

            BotonesCancelOk(false);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                Agregar();
            }
            else
            {
                Editar();
            }

            ClearTxt();
            btnAgregar.Visible = true;
            btnEditar.Visible = true;
            dgvClientes.Enabled = true;

            BotonesCancelOk(true);
        }
        
        // Funciones
        private void btnEstado_Click(object sender, EventArgs e)
        {
            if (VerificarFila() == false)
            {
                return;
            }

            DataGridViewRow row = dgvClientes.SelectedRows[0];

            IdCliente = Convert.ToInt32((row.Cells[0].Value).ToString());

            CCliente.Cambiar_Estado(IdCliente);

            Mostrar();
        }

        private void Agregar()
        {

            string PNombre = txtPrimerNombre.Text;
            string SNombre = txtSegundoNombre.Text;
            string PApellido = txtPrimerApellido.Text;
            string SApellido = txtSegundoApellido.Text;
            string telefono = mtbTelefono.Mask;

            CCliente.Insertar_Cliente(PNombre, SNombre, PApellido, SApellido, telefono);

            Mostrar();
        }

        private void Editar()
        {
            string PNombre = txtPrimerNombre.Text;
            string SNombre = txtSegundoNombre.Text;
            string PApellido = txtPrimerApellido.Text;
            string SApellido = txtSegundoApellido.Text;
            string Telefono = mtbTelefono.Text;

            CCliente.Editar_Cliente(IdCliente, PNombre, SNombre, PApellido, SApellido, Telefono);
            btnAgregar.Visible = false;
            btnEditar.Visible = false;

            Mostrar();
        }

        private void ClearTxt()
        {
            txtPrimerNombre.Clear();
            txtSegundoNombre.Clear();
            txtPrimerApellido.Clear();
            txtSegundoApellido.Clear();

            mtbTelefono.Clear();
        }

        private bool VerificarFila()
        {
            if (dgvClientes.SelectedRows.Count != 1)
            {
                if (dgvClientes.SelectedRows.Count > 1)
                {
                    MessageBox.Show("Seleccione una sola fila", "Servicios de Mantenimiento",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ninguna fila", "Servicios de Mantenimiento",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return false;
            }

            return true;
        }

        private void BotonesCancelOk(bool flag)
        {

            if (flag == true)
            {
                btnGuardar.Visible = true;
                btnCancelar.Visible = true;
                btnEstado.Visible = false;
            }
            else
            {
                btnGuardar.Visible = false;
                btnCancelar.Visible = false;
                btnEstado.Visible = true;
            }
            
        }

        private void EsCaracter(KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!(char.IsLetter(c)) && (c != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPrimerNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            EsCaracter(e);
        }

        private void txtPrimerApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            EsCaracter(e);
        }

        private void txtSegundoApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            EsCaracter(e);
        }

        private void txtSegundoNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ( ( !(char.IsLetter(c)) && (c != (char)Keys.Back) ))
            {
                if (c ==  (char)Keys.Space)
                {
                    return;
                }
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
