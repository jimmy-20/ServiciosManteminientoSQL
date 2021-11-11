using Servicios_de_Mantemiento.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios_de_Mantemiento.Controller
{
    class CCliente
    {
        public static DataTable Ver_Clientes()
        {
            return DCliente.Ver_Clientes();
        }
        
        public static void Insertar_Cliente(string PNombre, string SNombre, string PApellido, string SApellido, string telefono)
        {
            DCliente.Insertar_Cliente(PNombre, SNombre, PApellido, SApellido, telefono);
        }

        public static void Editar_Cliente(int IdCliente, string PNombre, string SNombre, string PApellido, string SApellido, string telefono)
        {
            DCliente.Editar_Cliente(IdCliente,PNombre,SNombre,PApellido,SApellido,telefono);
        }

        public static void Cambiar_Estado(int IdCliente)
        {
            DCliente.Cambiar_Estado(IdCliente);
        }
    }
}
