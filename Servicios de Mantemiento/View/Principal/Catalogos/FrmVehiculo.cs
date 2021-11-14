using Servicios_de_Mantemiento.Controller;
using System;
using System.Data;
using System.Windows.Forms;

namespace Servicios_de_Mantemiento.View.Principal.FrmContainers
{
    public partial class FrmVehiculo : Form
    {
        private int IdVehiculo;
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

            btnGuardar.Visible = false;
            btnCancelar.Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            flag = true;

            BotonesVisibles();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (!SeleccionarFila(dgvClientes))
            {
                return;
            }

            DataGridViewRow row = dgvClientes.SelectedRows[0];

            IdCliente = Convert.ToInt32(row.Cells[0].Value.ToString());

            txtCliente.Text = row.Cells[1].Value.ToString() + " " + row.Cells[3].Value.ToString();
        }

        private bool SeleccionarFila(DataGridView data)
        {
            if (data.SelectedRows.Count != 1)
            {
                if (data.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione una fila para el vehiculo", "Servicio de Mantenimiento",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                MessageBox.Show("Seleccione solamente una fila", "Servicios de Mantenimiento",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            BotonesVisibles();
            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string Marca = txtMarca.Text;
            string Modelo = txtModelo.Text;
            int Año = ((int)nudAnio.Value);

            if (flag == true)
            {
                CVehiculo.Insertar_Vehiculo(IdCliente, Marca, Modelo, Año);
            }
            else
            {                
                CVehiculo.Editar_Vehiculo(IdVehiculo, IdCliente, Marca, Modelo, Año);
            }

            ClearTxt();
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
                btnEstado.Visible = true;
                return;
            }
            btnAgregar.Visible = false;
            btnEditar.Visible = false;
            btnEstado.Visible = false;

            btnGuardar.Visible = true;
            btnCancelar.Visible = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!SeleccionarFila(dgvVehiculos)){
                return;
            }

            flag = false;

            DataGridViewRow row = dgvVehiculos.SelectedRows[0];

            IdVehiculo = Convert.ToInt32(row.Cells[0].Value);
            IdCliente = Convert.ToInt32(row.Cells[1].Value);

            string cliente = row.Cells[2].Value.ToString();
            string marca = row.Cells[3].Value.ToString();
            string modelo = row.Cells[4].Value.ToString();
            string anio = row.Cells[5].Value.ToString();

            txtCliente.Text = cliente;
            txtMarca.Text = marca;
            txtModelo.Text = modelo;
            nudAnio.Value = Convert.ToInt32(anio);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            BotonesVisibles();
            ClearTxt();
        }

        private void ClearTxt()
        {
            txtCliente.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            nudAnio.Value = nudAnio.Minimum;
        }
    }
}
