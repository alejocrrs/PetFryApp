using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Data;

namespace Main
{
    public class Ordenes
    {
        public static List<List<string>> Buscar()
        {
            return Convertir.ListListString(DataOrdenes.Select());
        }

        public static List<string> BuscarPorId(int id)
        {
            return Convertir.ListString(DataOrdenes.SelectId(id));
        }

        public static bool Crear(string cliente, string mascota, string tipo, string articulo, string notas)
        {
            return DataOrdenes.Create(cliente, mascota, tipo, articulo, notas);
        }

        public static bool ActualizarPorId(int id, string cliente, string mascota, string tipo, string articulo, string notas)
        {
            return DataOrdenes.UpdateById(id, cliente, mascota, tipo, articulo, notas);
        }

        public static bool EliminarPorId(int id)
        {
            return DataOrdenes.DeleteById(id);
        }
    }
}
