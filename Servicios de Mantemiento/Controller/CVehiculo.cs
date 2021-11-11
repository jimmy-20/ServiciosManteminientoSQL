using Servicios_de_Mantemiento.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios_de_Mantemiento.Controller
{
    class CVehiculo
    {
        public static DataTable Ver_Vehiculos()
        {
            return DVehiculo.Ver_Vehiculos();
        }
        
        public static void Insertar_Vehiculo(int IdCliente, string Marca, string Modelo, int Año)
        {
            DVehiculo.Insertar_Vehiculo(IdCliente,Marca,Modelo,Año);
        }

        public static void Editar_Vehiculo(int IdVehiculo,int IdCliente, string Modelo, string Marca, int Año)
        {
            DVehiculo.Editar_Vehiculo(IdVehiculo, IdCliente, Marca, Modelo, Año);
        }

        public static void Cambiar_Estado()
        {
            DVehiculo.Cambiar_Estado(); 
        }
    }
}
