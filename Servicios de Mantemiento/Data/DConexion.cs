using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Servicios_de_Mantemiento.Data
{
    class DConexion
    {
        private static string host = "Data Source = DESKTOP-ATV4JNH ;Initial Catalog = Servicios_Mantenimiento;" +
            "                         user = AdminSistemasJaso; password = Sistema123";
        private static SqlConnection conexion;
        public static SqlConnection Open()
        {
            conexion = new SqlConnection(host);
            conexion.Open();

            return conexion;
        }

    }
}
