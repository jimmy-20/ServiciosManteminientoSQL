using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios_de_Mantemiento.Data
{
    class DServicios
    {
        public static DataTable Ver_Servicios()
        {
            DataTable dt = new DataTable("Servicios");

            try
            {
                SqlConnection conexion = DConexion.Open();

                SqlCommand comando = new SqlCommand
                {
                    CommandText = "Ver_Servicios",
                    CommandType = CommandType.StoredProcedure,
                    Connection = conexion
                    
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
