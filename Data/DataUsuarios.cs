using MySql.Data.MySqlClient;
using System.Data;

namespace Data
{
    public static class DataUsuarios
    {
        private static readonly Connection connection = new Connection();

        public static DataTable SelecIdByDocumento(string documento)
        {
            try
            {
                DataTable table = new DataTable();
                string sql = $"SELECT id FROM usuarios WHERE documento = '{documento}'";
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

        public static DataTable SelecIdByDocumentoAndClave(string documento, string clave)
        {
            try
            {
                DataTable table = new DataTable();
                string sql = $"SELECT id FROM usuarios WHERE documento = '{documento}' AND clave = '{clave}'";
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

        public static DataTable SelectBloqueoById(string id)
        {
            try
            {
                DataTable table = new DataTable();
                string sql = $"SELECT bloqueo FROM usuarios WHERE id = {id}";
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
