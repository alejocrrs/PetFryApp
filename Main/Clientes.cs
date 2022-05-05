using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Main
{
    public static class Clientes
    {
        public static List<List<string>> Buscar()
        {
            return Convertir.ListListString(DataClientes.Select());
        }

        public static List<string> BuscarPorId(int id)
        {
            return Convertir.ListString(DataClientes.SelectById(id));
        }

        public static List<string> BuscarPorDocumento(string documento)
        {
            return Convertir.ListString(DataClientes.SelectByDocumento(documento));
        }

        public static int BuscarIdPorDocumento(string documento)
        {
            return Convertir.Int(DataClientes.SelecIdByDocumento(documento));
        }

        public static bool Crear(string documento, string nombre, string telefono, string direccion, string correo)
        {
            return DataClientes.Create(documento, nombre, telefono, direccion, correo);
        }

        public static bool ActualizarPorId(int id, string documento, string nombre, string telefono, string direccion, string correo)
        {
            return DataClientes.UpdateById(id, documento, nombre, telefono, direccion, correo);
        }

        public static bool EliminarPorId(int id)
        {
            return DataClientes.DeleteById(id);
        }
    }
}
