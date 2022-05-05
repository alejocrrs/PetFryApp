using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Data;

namespace Main
{
    public class Mascotas
    {
        public static List<List<string>> Buscar()
        {
            return Convertir.ListListString(DataMascotas.Select());
        }

        public static List<string> BuscarPorId(int id)
        {
            return Convertir.ListString(DataMascotas.SelectId(id));
        }

        public static bool Crear(string nombre, int propietario, string animal, string raza, string peso, string color, string notas)
        {
            return DataMascotas.Create(nombre, propietario, animal, raza, peso, color, notas);
        }

        public static bool ActualizarPorId(int id, string nombre, int propietario, string animal, string raza, string peso, string color, string notas)
        {
            return DataMascotas.UpdateById(id, nombre, propietario, animal, raza, peso, color, notas);
        }

        public static bool EliminarPorId(int id)
        {
            return DataMascotas.DeleteById(id);
        }
    }
}
