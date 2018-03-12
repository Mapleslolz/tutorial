using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PTT_Crawler
{
    class DB
    {
        MySqlConnection myConn;

        public DB(string dbHost, string dbUser, string dbPass, string dbName)
        {
            string connStr = "server=" + dbHost + ";uid=" + dbUser + ";pwd=" 
                                       + dbPass + ";database=" + dbName + ";charset=utf8;";
            myConn = new MySqlConnection(connStr);
        }

        public void open()
        {
          myConn.Open();
        }

        public void insertData(string tableName, string field, string value)
        {
            try
            {
                MySqlCommand cmd = myConn.CreateCommand();
                cmd.CommandText = "INSERT INTO " + tableName + "(" + field + ") VALUES ('" + value + "')"; ;
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {

            }
        }
        public void close()
        {
            myConn.Close();
        }
    }
}