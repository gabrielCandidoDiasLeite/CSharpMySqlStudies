using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TestsCSharpMySQL.Connection
{
    public class ConnectionInfo
    {
        public string MySQLConnectionString()
        {
            string dataSource = "127.0.0.1";
            string port = "3306";
            string username = "root";
            string password = "";
            string database = "csharpmysql";

            string mySQLConnectionString = new string($"datasource={dataSource};port={port};username={username};password={password};database={database};");

            return mySQLConnectionString;
        }
        
    }
}
