using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondapp
{
    class Dbconnection
    {
        private static object adapter;

        public static SqlConnection Dbconnect()
        {
            var conn = new SqlConnection();
            //conn.connectionstring = "SERVER = localhost:8000;Database
            conn.ConnectionString = "Data Source=CTRLSOFT-BJMIA6\\SQLEXPRESS;Initial Catalog=DBecontact;Integrated Security=True";
            //; User Id=sa;Password=leo;Multiple"
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();

            }

            return conn;
        }

        public static DataTable GetTableByQuery(string SqlQuery)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = Dbconnect();
                command.CommandText = SqlQuery;
                command.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;

            }

            catch (Exception)
            {
                throw;

            }
        }
            public static void ExecuteNonQuery(string SqlQuery)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = Dbconnect();
                command.CommandText = SqlQuery;
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
            }
            catch (Exception)
            { 
            }
        }
        }

            }
        
    

