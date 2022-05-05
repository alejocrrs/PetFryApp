using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class Connection
    {
        private readonly SqlConnection _con = new SqlConnection("Server=ALEJANDRO\\SQLEXPRESS;Database=petfry;Integrated Security=True");

        public SqlConnection Con => _con;

        public SqlConnection Open()
        {
            try
            {
                Con.Open();
                return Con;
            }
            catch
            {
                return null;
            }
        }

        public bool Close()
        {
            try
            {
                Con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
