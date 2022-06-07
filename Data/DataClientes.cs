using MySql.Data.MySqlClient;
using System.Data;

namespace Data
{
    public static class DataClientes
    {
        private static readonly Connection connection = new Connection();

        public static DataTable Select()
        {
            try
            {
                DataTable table = new DataTable();
                string sql = "SELECT * FROM clientes";
                MySqlCommand command = new MySqlCommand(sql, connection.Open()) { CommandType = CommandType.Text };
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
                string sql = $"SELECT * FROM clientes WHERE id = {id}";
                MySqlCommand command = new MySqlCommand(sql, connection.Open()) { CommandType = CommandType.Text };
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

        public static DataTable SelectByDocumento(string documento)
        {
            try
            {
                DataTable table = new DataTable();
                string sql = $"SELECT * FROM clientes WHERE documento = '{documento}'";
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

        public static DataTable SelecIdByDocumento(string documento)
        {
            try
            {
                DataTable table = new DataTable();
                string sql = $"SELECT id FROM clientes WHERE documento = '{documento}'";
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

        public static bool Create(string documento, string nombre, string telefono, string direccion, string correo)
        {
            try
            {
                string sql = $"INSERT INTO clientes VALUES(NULL, '{documento}', '{nombre}', '{telefono}', '{direccion}', '{correo}')";
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

        public static bool UpdateById(int id, string documento, string nombre, string telefono, string direccion, string correo)
        {
            try
            {
                string sql = $"UPDATE clientes SET documento = '{documento}', nombre = '{nombre}', telefono = '{telefono}', direccion = '{direccion}', correo = '{correo}' WHERE id = {id}";
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
                string sql = $"DELETE FROM clientes WHERE id = '{id}'";
                MySqlCommand command = new MySqlCommand(sql, connection.Open()) { CommandType = CommandType.Text };
                int rows = command.ExecuteNonQuery();
                connection.Close();

                return rows > 0;
            }
            catch
            {
                return false;
            }
        }

        public static DataTable SelectMascotas(int id)
        {
            try
            {
                DataTable table = new DataTable();
                string sql = $"SELECT id FROM mascotas WHERE propietario = {id}";
                MySqlCommand command = new MySqlCommand(sql, connection.Open()) { CommandType = CommandType.Text };
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

        public static DataTable SelectOrdenes(int id)
        {
            try
            {
                DataTable table = new DataTable();
                string sql = $"SELECT id FROM ordenes WHERE cliente = {id}";
                MySqlCommand command = new MySqlCommand(sql, connection.Open()) { CommandType = CommandType.Text };
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
