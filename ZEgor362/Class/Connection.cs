using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace ZEgor362.Class
{
    public class Connection
    {
        public static NpgsqlConnection connection;

        public static void Connecting(string host, string port, string database, string username, string password) 
        {
            Host = host;
            Port = port;
            Username = username;
            Password = password;
            Database = database;


            connection= new NpgsqlConnection
                (string.Format("Server={0}; Port={1};User ID={2}; Password={3}; DataBase={4}", Host, Port, Username, Password, Database));
            connection.Open();
        }

        public static NpgsqlCommand ExecuteComand(string sql)
        {
            NpgsqlCommand comand = new NpgsqlCommand();
            comand.Connection = connection;
            comand.CommandText = sql;
            return comand;
        }

        public static string Host { get; set; }
        public static string Port { get; set; }
        public static string Username { get; set; }
        public static string Password { get; set; } 
        public static string Database { get; set; }

    }
}
