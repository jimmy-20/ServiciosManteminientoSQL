using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios_de_Mantemiento.Data
{
    class DLogin
    {
        public static DataTable Validar_Acceso(String usuario, String contrasena)
        {
            DataTable dt = new DataTable("Acceso");
            try
            {
                SqlConnection conexion = DConexion.Open();

                SqlCommand comando = new SqlCommand
                {
                    Connection = conexion,
                    CommandText = "Validar_Acceso",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter parametro1 = new SqlParameter
                {
                    Value = usuario,
                    ParameterName = "Usuario",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50
                };

                SqlParameter parametro2 = new SqlParameter
                {
                    ParameterName = "Contra",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    Value = contrasena
                };

                comando.Parameters.Add(parametro1);
                comando.Parameters.Add(parametro2);

                SqlDataAdapter data = new SqlDataAdapter(comando);
                data.Fill(dt);
            }
            catch (Exception e)
            {
                dt = null;
            }

            return dt;
        } 
    }
}
