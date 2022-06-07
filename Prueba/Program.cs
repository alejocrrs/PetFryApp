using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Main;

namespace Prueba
{
    internal class Program
    {
        static void CrearCliente()
        {
            string documento = "101010";
            string nombre = "Andrés";
            string telefono = "000";
            string direccion = "xxx-yyy-zzz";
            string correo = "asdasd@asd.xd";
            var clienteCreado = Clientes.Crear(documento, nombre, telefono, direccion, correo);

            if (clienteCreado)
            {
                Console.WriteLine("Cliente creado correctamente.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Error al crear el cliente.");
                Console.ReadLine();
            }
        }

        static void Main(string[] args)
        {
            CrearCliente();
        }
    }
}
