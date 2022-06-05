using MySql.Data.MySqlClient;

namespace Data
{
    public class Connection
    {
        private readonly MySqlConnection _con = new MySqlConnection("server=localhost; port=3306; user id=root; password=; database=petfry");

        public MySqlConnection Con => _con;

        public MySqlConnection Open()
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
