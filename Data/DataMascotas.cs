using MySql.Data.MySqlClient;
using System.Data;

namespace Data
{
    public static class DataMascotas
    {
        private static readonly Connection connection = new Connection();

        public static DataTable Select()
        {
            try
            {
                DataTable table = new DataTable();
                string sql = "SELECT * FROM mascotas";
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
                string sql = $"SELECT * FROM mascotas WHERE id = {id}";
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

        public static bool Create(string nombre, int propietario, string animal, string raza, string peso, string color, string notas)
        {
            try
            {
                string sql = $"INSERT INTO mascotas VALUES(NULL, '{nombre}', {propietario}, '{animal}', '{raza}', '{peso}', '{color}', '{notas}')";
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

        public static bool UpdateById(int id, string nombre, int propietario, string animal, string raza, string peso, string color, string notas)
        {
            try
            {
                string sql = $"UPDATE mascotas SET nombre = '{nombre}', propietario = {propietario}, animal = '{animal}', raza = '{raza}', peso = {peso}, color = '{color}', notas = '{notas}' WHERE id = {id}";
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
                string sql = $"DELETE FROM mascotas WHERE id = '{id}'";
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
                string sql = $"SELECT id FROM ordenes WHERE mascota = {id}";
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
