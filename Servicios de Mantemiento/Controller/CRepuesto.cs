using Servicios_de_Mantemiento.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios_de_Mantemiento.Controller
{
    class CRepuesto
    {
        public static DataTable Ver_Repuestos()
        {
            return DRepuesto.Ver_Repuesto();
        } 
    }
}
