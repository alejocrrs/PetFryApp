using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

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
                string cmd = "SELECT * FROM clientes";
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
                string cmd = $"SELECT * FROM clientes WHERE id = {id}";
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

        public static DataTable SelectByDocumento(string documento)
        {
            try
            {
                DataTable table = new DataTable();
                string cmd = $"SELECT * FROM clientes WHERE documento = '{documento}'";
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

        public static DataTable SelecIdByDocumento(string documento)
        {
            try
            {
                DataTable table = new DataTable();
                string cmd = $"SELECT id FROM clientes WHERE documento = '{documento}'";
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

        public static bool Create(string documento, string nombre, string telefono, string direccion, string correo)
        {
            try
            {
                string cmd = $"INSERT INTO clientes VALUES('{documento}', '{nombre}', '{telefono}', '{direccion}', '{correo}')";
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

        public static bool UpdateById(int id, string documento, string nombre, string telefono, string direccion, string correo)
        {
            try
            {
                string cmd = $"UPDATE clientes SET documento = '{documento}', nombre = '{nombre}', telefono = '{telefono}', direccion = '{direccion}', correo = '{correo}' WHERE id = {id}";
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
                string cmd = $"DELETE clientes WHERE id = '{id}'";
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
