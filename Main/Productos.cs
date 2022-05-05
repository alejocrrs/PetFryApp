using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Main
{
    public abstract class Productos
    {
        public static List<List<string>> Buscar()
        {
            return Convertir.ListListString(DataProductos.Select());
        }

        public static List<string> BuscarPorId(int id)
        {
            return Convertir.ListString(DataProductos.SelectById(id));
        }

        public static bool Crear(string nombre, string valor, string notas)
        {
            return DataProductos.Create(nombre, valor, notas);
        }

        public static bool ActualizarPorId(int id, string nombre, string valor, string notas)
        {
            return DataProductos.UpdateById(id, nombre, valor, notas);
        }

        public static bool EliminarPorId(int id)
        {
            return DataProductos.DeleteById(id);
        }
    }
}
