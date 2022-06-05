using MySql.Data.MySqlClient;
using System.Data;

namespace Data
{
    public static class DataProductos
    {
        private static readonly Connection connection = new Connection();

        public static DataTable Select()
        {
            try
            {
                DataTable table = new DataTable();
                string sql = "SELECT * FROM productos";
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
                string sql = $"SELECT * FROM productos WHERE id = {id}";
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
                string sql = $"INSERT INTO productos VALUES(NULL, '{nombre}', {valor}, '{notas}')";
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
                string sql = $"UPDATE productos SET nombre = '{nombre}', valor = {valor}, notas = '{notas}' WHERE id = {id}";
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
                string sql = $"DELETE FROM productos WHERE id = '{id}'";
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
