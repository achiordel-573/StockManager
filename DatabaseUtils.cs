using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace StockManager
{
    internal class DatabaseUtils
    {
        NpgsqlConnection conn;
        string conn_string;

        public string PrepareConnection()
        {
            var builder = new NpgsqlConnectionStringBuilder();
            builder.Host = ConfigurationManager.AppSettings["DB_HOST"];
            builder.Port = Int32.Parse(ConfigurationManager.AppSettings["DB_PORT"]);
            builder.Username = ConfigurationManager.AppSettings["DB_USER"]; ;
            builder.Password = ConfigurationManager.AppSettings["DB_PSWD"]; ;
            builder.Database = ConfigurationManager.AppSettings["DB_NAME"]; ;

            return builder.ConnectionString;
        }

        public DataSet Select_Records(DataSet dataset)
        {
            if (conn_string == null)
            {
                conn_string = PrepareConnection();
            }
            using (conn = new NpgsqlConnection(conn_string))
            {
                conn.Open();
                string cmd = "SELECT * FROM products";
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd, conn);
                dataset.Reset();
                adapter.Fill(dataset);
                conn.Close();
                return dataset;
            }
        }

        public void Add_Record(string title, string count)
        {
            if (conn_string == null)
            {
                conn_string = PrepareConnection();
            }
            using (conn = new NpgsqlConnection(conn_string))
            {
                    conn.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO products (title, count) VALUES (:title, :count)", conn);
                    cmd.Parameters.AddWithValue("title", title);
                    cmd.Parameters.AddWithValue("count", Int32.Parse(count));
                    cmd.ExecuteNonQuery();
                    conn.Close();
            }
        }

        public void Delete_Record(int id)
        {
            if (conn_string == null)
            {
                conn_string = PrepareConnection();
            }
            using (conn = new NpgsqlConnection(conn_string))
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM products where id = :id", conn);
                cmd.Parameters.AddWithValue("id", id);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        } 

        public void Update_Record(int id, string title)
        {
            if (conn_string == null)
            {
                conn_string = PrepareConnection();
            }
            using (conn = new NpgsqlConnection(conn_string))
            {

            }
        }
    }
}
