using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace ZEgor362.Class
{
    internal class Connection
    {
        private static NpgsqlConnection connection;

        public static void Connecting(string host, int port, string username, string password, string database) 
        {
            string cs = string.Format("Server={0}; Port={1};User ID={2}; Password={3}; DataBase={4}", host, port, username, password, database);
            connection = new NpgsqlConnection(cs);
            connection.Open();
          
        }




    }
}
