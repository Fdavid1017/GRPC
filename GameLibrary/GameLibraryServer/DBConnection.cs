using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace GameLibraryServer
{
    class DBConnection
    {
        const string userName = "root";
        const string password = "";

        private DBConnection()
        {
        }

        private string databaseName = string.Empty;
        public string DatabaseName
        {
            get { return databaseName; }
            set { databaseName = value; }
        }

        public string Password { get; set; }
        private MySqlConnection connection = null;
        public MySqlConnection Connection
        {
            get { return connection; }
        }

        private static DBConnection _instance = null;
        public static DBConnection Instance()
        {
            if (_instance == null)
                _instance = new DBConnection();
            return _instance;
        }

        public bool IsConnect()
        {
            if (Connection == null)
            {
                if (String.IsNullOrEmpty(databaseName))
                    return false;
                OpenConnection();
            }

            return true;
        }

        public void OpenConnection()
        {
            string connstring = string.Format("Server=localhost; database={0}; UID={1}; password={2}", databaseName, userName, password);
            connection = new MySqlConnection(connstring);
            connection.Open();
        }

        public void Close()
        {
            if (Connection != null)
            {
                connection.Close();
            }
        }
    }
}
