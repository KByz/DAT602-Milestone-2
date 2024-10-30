using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace dust2dustpart3
{
    internal class DatabaseAccessObject
    {
        private static string ConnectionString
        {
            get { return "Server=localhost;Port=3306;database=dust2dust;Uid=root;password=Kn1ght51987!"; }

        }

        private static MySqlConnection? _mySqlConnection = null;
        protected static MySqlConnection MySqlConnection
        {
            get
            {
                if (_mySqlConnection == null)
                {
                    _mySqlConnection = new MySqlConnection(ConnectionString);
                }

                return _mySqlConnection;

            }
        }
    }
}