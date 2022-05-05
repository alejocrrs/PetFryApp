using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

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
                string cmd = "SELECT * FROM productos";
                SqlCommand command = new SqlCommand(cmd, connection.Open()) { CommandType = CommandType.Text };
                SqlDataReader reader = command.ExecuteReader();
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
                string cmd = $"SELECT * FROM productos WHERE id = {id}";
                SqlCommand command = new SqlCommand(cmd, connection.Open()) { CommandType = CommandType.Text };
                SqlDataReader reader = command.ExecuteReader();
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
                string cmd = $"INSERT INTO productos VALUES('{nombre}', {valor}, '{notas}')";
                SqlCommand command = new SqlCommand(cmd, connection.Open()) { CommandType = CommandType.Text };
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
                string cmd = $"UPDATE productos SET nombre = '{nombre}', valor = {valor}, notas = '{notas}' WHERE id = {id}";
                SqlCommand command = new SqlCommand(cmd, connection.Open()) { CommandType = CommandType.Text };
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
                string cmd = $"DELETE productos WHERE id = '{id}'";
                SqlCommand command = new SqlCommand(cmd, connection.Open()) { CommandType = CommandType.Text };
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
