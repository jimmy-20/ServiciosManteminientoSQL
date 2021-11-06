using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servicios_de_Mantemiento.Data
{
    class DCliente
    {
        public static DataTable Ver_Clientes()
        {
            DataTable dt = new DataTable("Clientes");

            try
            {
                SqlConnection conexion = DConexion.Open();

                SqlCommand comando = new SqlCommand()
                {
                    Connection = conexion,
                    CommandText = "Ver_Clientes",
                    CommandType = CommandType.StoredProcedure
                };

                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                adapter.Fill(dt);

            }catch (Exception e)
            {
                dt = null;
            }

            return dt;
        }
        
        public static void Insertar_Cliente(string PNombre, string SNombre, string PApellido, string SApellido, string telefono)
        {
            try
            {
                SqlConnection conexion = DConexion.Open();

                SqlCommand comando = new SqlCommand()
                {
                    Connection = conexion,
                    CommandText = "Insertar_Cliente",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter parametro1 = new SqlParameter()
                {
                    ParameterName = "PNombre",
                    Value = PNombre,
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50
                };

                SqlParameter parametro2 = new SqlParameter()
                {
                    ParameterName = "SNombre",
                    Value = SNombre,
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50
                };

                SqlParameter parametro3 = new SqlParameter()
                {
                    ParameterName = "PApellido",
                    Value = PApellido,
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50
                };

                SqlParameter parametro4 = new SqlParameter()
                {
                    ParameterName = "SApellido",
                    Value = SApellido,
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50
                };

                SqlParameter parametro5 = new SqlParameter()
                {
                    ParameterName = "Telefono",
                    Value = telefono,
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50
                };

                comando.Parameters.Add(parametro1);
                comando.Parameters.Add(parametro2);
                comando.Parameters.Add(parametro3);
                comando.Parameters.Add(parametro4);
                comando.Parameters.Add(parametro5);

                comando.ExecuteNonQuery();

                MessageBox.Show("Cliente registrado", "Servicios de Mantenimiento");

            }catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message ,"Error interno en BD",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        public static void Editar_Cliente(int idCliente, string PNombre, string SNombre, string PApellido, string SApellido, string Telefono)
        {
            try
            {
                SqlConnection conexion = DConexion.Open();

                SqlCommand comando = new SqlCommand()
                {
                    Connection = conexion,
                    CommandText = "Editar_Cliente",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter parametro1 = new SqlParameter()
                {
                    ParameterName = "IdCliente",
                    Value = idCliente,
                    SqlDbType = SqlDbType.Int
                };

                SqlParameter parametro2 = new SqlParameter()
                {
                    ParameterName = "PNombre",
                    Value = PNombre,
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50
                };

                SqlParameter parametro3 = new SqlParameter()
                {
                    ParameterName = "SNombre",
                    Value = SNombre,
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50
                };

                SqlParameter parametro4 = new SqlParameter()
                {
                    ParameterName = "PApellido",
                    Value = PApellido,
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50
                };

                SqlParameter parametro5 = new SqlParameter()
                {
                    ParameterName = "SApellido",
                    Value = SApellido,
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50
                };

                SqlParameter parametro6 = new SqlParameter()
                {
                    ParameterName = "Telefono",
                    Value = Telefono,
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50
                };

                comando.Parameters.Add(parametro1);
                comando.Parameters.Add(parametro2);
                comando.Parameters.Add(parametro3);
                comando.Parameters.Add(parametro4);
                comando.Parameters.Add(parametro5);
                comando.Parameters.Add(parametro6);

                comando.ExecuteNonQuery();

                MessageBox.Show("Cliente Editado", "Servicios de Mantenimiento");

            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Error interno en BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
