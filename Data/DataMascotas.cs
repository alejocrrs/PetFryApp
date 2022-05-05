using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

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
                string cmd = "SELECT * FROM mascotas";
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

        public static DataTable SelectId(int id)
        {
            try
            {
                DataTable table = new DataTable();
                string cmd = $"SELECT * FROM mascotas WHERE id = {id}";
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

        public static bool Create(string nombre, int propietario, string animal, string raza, string peso, string color, string notas)
        {
            try
            {
                string cmd = $"INSERT INTO mascotas VALUES('{nombre}', {propietario}, '{animal}', '{raza}', '{peso}', '{color}', '{notas}')";
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

        public static bool UpdateById(int id, string nombre, int propietario, string animal, string raza, string peso, string color, string notas)
        {
            try
            {
                string cmd = $"UPDATE mascotas SET nombre = '{nombre}', propietario = {propietario}, animal = '{animal}', raza = '{raza}', peso = {peso}, color = '{color}', notas = '{notas}' WHERE id = {id}";
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
                string cmd = $"DELETE mascotas WHERE id = '{id}'";
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
