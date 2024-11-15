using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Data_Base
{
    internal class DataBase
    {
        private static readonly string DB_HOST = "localhost";
        private static readonly string DB_DATABASE = "UTS PBO";
        private static readonly string DB_USERNAME = "postgres";
        private static readonly string DB_PASSWORD = "1234";
        private static readonly string DB_PORT = "5432";

        private static NpgsqlConnection connection;
        private static NpgsqlCommand command;

        public static void openConnection()
        {
            connection = new NpgsqlConnection($"Host={DB_HOST};" +
                $"Username={DB_USERNAME};Password={DB_PASSWORD};" +
                $"Database={DB_DATABASE};Port={DB_PORT}");
            connection.Open();
            command = new NpgsqlCommand();
            command.Connection = connection;
        }

        public static void closeConnection()
        {
            connection.Close();
            command.Parameters.Clear();
        }

        public static DataTable queryExecutor(string query, NpgsqlParameter[] parameters = null)//
        {
            try
            {
                openConnection();
                DataTable dataTable = new DataTable();
                command.CommandText = query;
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                    command.Prepare();
                }
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command);
                dataAdapter.Fill(dataTable);
                closeConnection();
                return dataTable;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static void commandExecutor(string query, NpgsqlParameter[] parameters = null)// method ini
                                                                                             //digunakan untuk INSERT, DELETE, AND UPDATE
        {
            try
            {
                openConnection();
                command.CommandText = query;
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                    command.Prepare();
                }
                command.ExecuteNonQuery();
                closeConnection();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static bool cekLogin(string username, string password)
        {
            string query = "select count(*) from pengguna where username = @username and password = @password";
            NpgsqlParameter[] parameter = new NpgsqlParameter[]
            {
                new NpgsqlParameter("username", username),
                new NpgsqlParameter("password", password),
            };
            openConnection();
            command.CommandText= query;
            command.Parameters.AddRange (parameter);
            int hasil =Convert.ToInt32 (command.ExecuteScalar());
            closeConnection();
            return hasil > 0;
        }
        public static void registrasi_(string nama,string nohp,string username, string password) 
        {
            string query = "insert into pengguna (nama, nohp, username, password) values" +
                "(@nama,@nohp,@username,@password)";
            NpgsqlParameter[] paramater = new NpgsqlParameter[]
            {
                new NpgsqlParameter ("nama",nama),
                new NpgsqlParameter ("nohp", nohp),
                new NpgsqlParameter ("username",username),
                new NpgsqlParameter ("password",password),
            };
            openConnection();
            command.CommandText= query;
            command.Parameters.AddRange (paramater);
            command.ExecuteNonQuery();
            closeConnection();


        }
        public static DataTable readeData() 
        {
            string query = "select * from pengguna order by id asc";
            try
            {
                openConnection();
                DataTable dt = new DataTable();
                command.CommandText = query;
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command);
                dataAdapter.Fill(dt);
                
                closeConnection();
                return dt;

            }
            catch (Exception ex) { throw new Exception("Gagal membaca: " + ex.Message); }
            
        }
        private static void updateData(string nama, string nohp, string username, string password)
        {
            string query = "update pengguna set nama = @nama, " +
                "nohp = @nohp, username = @username, password = @password where id = @id";
            NpgsqlParameter[] paramater = new NpgsqlParameter[]
             {
                new NpgsqlParameter ("nama",nama),
                new NpgsqlParameter ("nohp", nohp),
                new NpgsqlParameter ("username",username),
                new NpgsqlParameter ("password",password),
             };
            openConnection();
            command.CommandText = query;
            command.Parameters.AddRange (paramater);
            command.ExecuteNonQuery();
            closeConnection();
        }
        private static void pilihData(int id, out string nama, out string nohp,out string username, out string password)
        {
            nama = "";
            nohp = "";
            username = "";
            password = "";
            string query = " select * from pengguna where id = @id";
            command.CommandText = query;
            command.Parameters.AddWithValue("@id", id);
            var reader= command.ExecuteReader();
            if (reader != null) 
            {
                nama = reader["nama"].ToString();
                nohp = reader["nohp"].ToString();
                username = reader["username"].ToString();
                password = reader["password"].ToString();
            }
            
        }    
    }
}
