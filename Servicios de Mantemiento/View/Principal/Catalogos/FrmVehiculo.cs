using Servicios_de_Mantemiento.Controller;
using System;
using System.Data;
using System.Windows.Forms;

namespace Servicios_de_Mantemiento.View.Principal.FrmContainers
{
    public partial class FrmVehiculo : Form
    {
        private int IdCliente;
        private bool flag;
        public FrmVehiculo()
        {
            InitializeComponent();
        }

        private void FrmVehiculo_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        public void Mostrar()
        {
            DataTable dt = CVehiculo.Ver_Vehiculos();
            DataTable dtClientes = CCliente.Ver_Clientes();

            if (dt != null)
            {
                dgvVehiculos.DataSource = dt;
                dgvVehiculos.Columns[0].Visible = false;
                dgvVehiculos.Columns[1].Visible = false;
            }
            else
            {
                MessageBox.Show("La tabla vehiculos no contiene datos a mostrar", "Servicios de Mantenimiento",
                                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (dtClientes != null)
            {
                dgvClientes.DataSource = dtClientes;
                dgvClientes.Columns[0].Visible = false;
            }
            else
            {
                MessageBox.Show("La tabla Clientes no contiene datos a mostrar", "Servicios de Mantenimiento",
                                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            flag = true;

            BotonesVisibles();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            SeleccionarFila(dgvClientes);           
        }

        private void SeleccionarFila(DataGridView data)
        {
            if (data.SelectedRows.Count != 1)
            {
                if (data.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione una fila para el vehiculo", "Servicio de Mantenimiento");
                    return;
                }

                MessageBox.Show("Seleccione solamente una fila", "Servicios de Mantenimiento");
                return;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                string Marca = txtMarca.Text;
                string Modelo = txtModelo.Text;
                int Año = ((int)nudAnio.Value);

                CVehiculo.Insertar_Vehiculo(IdCliente, Marca, Modelo, Año);
            }
            else
            {
                DataGridViewRow row = dgvClientes.SelectedRows[0];

                IdCliente = Convert.ToInt32(row.Cells[0].Value.ToString());

                txtCliente.Text = row.Cells[1].Value.ToString() + " " + row.Cells[3].Value.ToString();
            }

            Mostrar();
        }

        private void BotonesVisibles()
        {
            if (btnAgregar.Visible == false)
            {
                btnAgregar.Visible = true;
                btnEditar.Visible = true;

                btnGuardar.Visible = false;
                btnCancelar.Visible = false;
                return;
            }
            btnAgregar.Visible = false;
            btnEditar.Visible = false;

            btnGuardar.Visible = true;
            btnCancelar.Visible = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            BotonesVisibles();
            flag = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            BotonesVisibles();
        }
    }
}
