using Main;

namespace Test
{
    public class General
    {
        [Fact]
        public void CrearCliente()
        {
            string documento = "101010";
            string nombre = "Andrés";
            string telefono = "000";
            string direccion = "xxx-yyy-zzz";
            string correo = "asdasd@asd.xd";
            var clienteCreado = Clientes.Crear(documento, nombre, telefono, direccion, correo);

            Assert.True(clienteCreado);
        }

        [Fact]
        public void CrearMascota()
        {
            string nombre = "Andrés";
            int propietario = 1;
            string animal = "Perro";
            string raza = "N/A";
            string peso = "16,5";
            string color = "Blanco";
            string notas = "N/A";
            var mascotaCreada = Mascotas.Crear(nombre, propietario, animal, raza, peso, color, notas);

            Assert.True(mascotaCreada);
        }

        [Fact]
        public void CrearProducto()
        {
            string nombre = "Espuma";
            string valor = "10500,99";
            string notas = "N/A";
            var productoCreado = Productos.Crear(nombre, valor, notas);

            Assert.True(productoCreado);
        }

        [Fact]
        public void CrearServicio()
        {
            string nombre = "Caricias diarias";
            string valor = "73630";
            string notas = "asd";
            var servicioCreado = Servicios.Crear(nombre, valor, notas);

            Assert.True(servicioCreado);
        }
    }
}