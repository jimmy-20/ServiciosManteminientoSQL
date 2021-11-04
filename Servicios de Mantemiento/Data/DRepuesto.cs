using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios_de_Mantemiento.Data
{
    class DRepuesto
    {
        public static DataTable Ver_Repuesto()
        {
            DataTable dt = new DataTable("Repuestos");

            try
            {
                SqlConnection conexion = DConexion.Open();

                SqlCommand comando = new SqlCommand
                {
                    CommandText = "Ver_Repuesto",
                    CommandType = CommandType.StoredProcedure,
                    Connection = conexion
                };

                SqlDataAdapter adapter = new SqlDataAdapter
                {
                    SelectCommand = comando,
                };

                adapter.Fill(dt);

            }catch (Exception e)
            {
                dt = null;
            }

            return dt;
        } 
    }
}
