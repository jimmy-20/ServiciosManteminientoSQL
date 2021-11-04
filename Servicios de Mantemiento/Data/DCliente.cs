using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
