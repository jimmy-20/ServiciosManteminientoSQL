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
    class DVehiculo
    {
        public static DataTable Ver_Vehiculos()
        {
            DataTable dt = new DataTable("Vehiculos");

            try
            {
                SqlConnection conexion = DConexion.Open();

                SqlCommand comando = new SqlCommand()
                {

                    Connection = conexion,
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "Ver_Vehiculos"
                };

                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                adapter.Fill(dt);
            }catch (Exception e)
            {
                dt = null;
            }

            return dt;
        }

        public static void Insertar_Vehiculo(int IdCliente, string Marca, string Modelo, int Año)
        {
            try
            {
                SqlConnection conexion = DConexion.Open();

                SqlCommand comando = new SqlCommand()
                {
                    Connection = conexion,
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "Insertar_Vehiculo"
                };

                SqlParameter parametro2 = new SqlParameter()
                {
                    ParameterName = "IdCliente",
                    Value = IdCliente,
                    SqlDbType = SqlDbType.Int
                };

                SqlParameter parametro3 = new SqlParameter()
                {
                    ParameterName = "Marca",
                    Value = Marca,
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50
                };

                SqlParameter parametro4 = new SqlParameter()
                {
                    ParameterName = "Modelo",
                    Value = Modelo,
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50
                };

                SqlParameter parametro5 = new SqlParameter()
                {
                    ParameterName = "Año",
                    Value = Año,
                    SqlDbType = SqlDbType.Int,
                };

                comando.Parameters.Add(parametro2);
                comando.Parameters.Add(parametro3);
                comando.Parameters.Add(parametro4);
                comando.Parameters.Add(parametro5);

                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: "+e.Message,"Base de Datos");
            }
        }

        public static void Editar_Vehiculo(int IdVehiculo, int IdCliente, string Marca, string Modelo, int Año)
        {
            try
            {
                SqlConnection conexion = DConexion.Open();

                SqlCommand comando = new SqlCommand()
                {
                    Connection = conexion,
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "Editar_Vehiculo"
                };

                SqlParameter parametro1 = new SqlParameter()
                {
                    ParameterName = "IdVehiculo",
                    Value = IdVehiculo,
                    SqlDbType = SqlDbType.Int
                };

                SqlParameter parametro2 = new SqlParameter()
                {
                    ParameterName = "IdCliente",
                    Value = IdCliente,
                    SqlDbType = SqlDbType.Int
                };

                SqlParameter parametro3 = new SqlParameter()
                {
                    ParameterName = "Marca",
                    Value = Marca,
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50
                };

                SqlParameter parametro4 = new SqlParameter()
                {
                    ParameterName = "Modelo",
                    Value = Modelo,
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50
                };

                SqlParameter parametro5 = new SqlParameter()
                {
                    ParameterName = "Año",
                    Value = Año,
                    SqlDbType = SqlDbType.Int,
                };

                comando.Parameters.Add(parametro1);
                comando.Parameters.Add(parametro2);
                comando.Parameters.Add(parametro3);
                comando.Parameters.Add(parametro4);
                comando.Parameters.Add(parametro5);

                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Base de Datos");
            }
        }

        public static void Cambiar_Estado()
        {
            try
            {
                SqlConnection conexion = DConexion.Open();

                SqlCommand comando = new SqlCommand()
                {
                    Connection = conexion,
                    CommandText = "Cambiar_Estado_Vehiculo",
                    CommandType = CommandType.StoredProcedure
                };

                comando.ExecuteNonQuery();

            }catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Base de Datos");
            }
        }
    }

    
}
