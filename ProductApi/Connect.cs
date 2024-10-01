using MySql.Data.MySqlClient;

namespace ProductApi
{
    public class Connect
    {
        public MySqlConnection Connection { get; set; }
        public string ConnectionString { get; set; }

        public string Host;
        public string DataBase;
        public string User;
        public string Password;

        public Connect()
        {
            Host = "localhost";
            DataBase = "shop";
            User = "root";
            Password = "";

            ConnectionString = "SERVER=" + Host + ";DATABASE=" + DataBase + ";UID=" + User + ";PASSWORD=" + Password + ";SslMode=None";

            Connection = new MySqlConnection(ConnectionString);
        }
    }
}
