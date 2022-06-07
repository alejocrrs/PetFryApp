using MySql.Data.MySqlClient;
using System.Data;

namespace Data
{
    public static class DataServicios
    {
        private static readonly Connection connection = new Connection();

        public static DataTable Select()
        {
            try
            {
                DataTable table = new DataTable();
                string sql = "SELECT * FROM servicios";
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

        public static DataTable SelectById(int id)
        {
            try
            {
                DataTable table = new DataTable();
                string sql = $"SELECT * FROM servicios WHERE id = {id}";
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

        public static bool Create(string nombre, string valor, string notas)
        {
            try
            {
                string sql = $"INSERT INTO servicios VALUES(NULL, '{nombre}', {valor}, '{notas}')";
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

        public static bool UpdateById(int id, string nombre, string valor, string notas)
        {
            try
            {
                string sql = $"UPDATE servicios SET nombre = '{nombre}', valor = {valor}, notas = '{notas}' WHERE id = {id}";
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
                string sql = $"DELETE FROM servicios WHERE id = '{id}'";
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

        public static DataTable SelectOrdenes(int id)
        {
            try
            {
                DataTable table = new DataTable();
                string sql = $"SELECT id FROM ordenes WHERE tipo = 'Servicios' AND articulo = {id}";
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
    }
}
