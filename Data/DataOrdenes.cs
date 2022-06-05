using MySql.Data.MySqlClient;
using System.Data;

namespace Data
{
    public static class DataOrdenes
    {
        private static readonly Connection connection = new Connection();

        public static DataTable Select()
        {
            try
            {
                DataTable table = new DataTable();
                string sql = "SELECT ordenes.id, ordenes.cliente, ordenes.mascota, ordenes.tipo, ordenes.articulo, (CASE ordenes.tipo WHEN 'Productos' THEN (SELECT productos.valor FROM productos WHERE productos.id = ordenes.articulo) WHEN 'Servicios' THEN (SELECT servicios.valor FROM servicios WHERE servicios.id = ordenes.articulo) END) AS valor, ordenes.fecha, ordenes.notas FROM ordenes";
                MySqlCommand command = new MySqlCommand(sql, connection.Open());
                MySqlDataReader reader = command.ExecuteReader();
                table.Load(reader);
                connection.Close();

                return table;
            }
            catch
            {
                return null;
            }
        }

        public static DataTable SelectId(int id)
        {
            try
            {
                DataTable table = new DataTable();
                string sql = $"SELECT ordenes.id, ordenes.cliente, ordenes.mascota, ordenes.tipo, ordenes.articulo, (CASE ordenes.tipo WHEN 'Productos' THEN (SELECT productos.valor FROM productos WHERE productos.id = ordenes.articulo) WHEN 'Servicios' THEN (SELECT servicios.valor FROM servicios WHERE servicios.id = ordenes.articulo) END) AS valor, ordenes.fecha, ordenes.notas FROM ordenes WHERE ordenes.id = {id}";
                MySqlCommand command = new MySqlCommand(sql, connection.Open());
                MySqlDataReader reader = command.ExecuteReader();
                table.Load(reader);
                connection.Close();

                return table;
            }
            catch
            {
                return null;
            }
        }

        public static bool Create(string cliente, string mascota, string tipo, string articulo, string notas)
        {
            try
            {
                string sql = $"INSERT INTO ordenes VALUES(NULL, {cliente}, {mascota}, '{tipo}', {articulo}, CURRENT_TIMESTAMP(), '{notas}')";
                MySqlCommand command = new MySqlCommand(sql, connection.Open());
                int rows = command.ExecuteNonQuery();
                connection.Close();

                return rows > 0;
            }
            catch
            {
                return false;
            }
        }

        public static bool UpdateById(int id, string cliente, string mascota, string tipo, string articulo, string notas)
        {
            try
            {
                string sql = $"UPDATE ordenes SET cliente = {cliente}, mascota = {mascota}, tipo = '{tipo}', articulo = {articulo}, notas = '{notas}' WHERE id = {id}";
                MySqlCommand command = new MySqlCommand(sql, connection.Open());
                int rows = command.ExecuteNonQuery();
                connection.Close();

                return rows > 0;
            }
            catch
            {
                return false;
            }
        }

        public static bool DeleteById(int id)
        {
            try
            {
                string sql = $"DELETE FROM ordenes WHERE id = {id}";
                MySqlCommand command = new MySqlCommand(sql, connection.Open());
                int rows = command.ExecuteNonQuery();
                connection.Close();

                return rows > 0;
            }
            catch
            {
                return false;
            }
        }
    }
}
