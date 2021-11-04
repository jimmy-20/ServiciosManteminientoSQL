using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
