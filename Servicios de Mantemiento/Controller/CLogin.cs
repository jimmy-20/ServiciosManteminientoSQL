using Servicios_de_Mantemiento.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios_de_Mantemiento.Controller
{
    class CLogin
    {
        public static DataTable Validar_Acceso(string nombre, string contrasena)
        {
            DataTable dt = DLogin.Validar_Acceso(nombre, contrasena);

            return dt;
        }
    }
}
