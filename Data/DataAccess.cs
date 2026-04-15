using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace QuanLyRapPhim.Data
{
    internal class CDataAccess
    {
        private string connectionString = "Server=localhost;Database=quanlyrapphim;User Id=root;Password=khanh206;";

        // Đọc dữ liệu
        public DataTable Doc(string query)
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand(query, con);

            try
            {
                con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                DataTable tb = new DataTable();
                tb.Load(dr, LoadOption.OverwriteChanges);

                con.Close();
                return tb;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                if (con.State == ConnectionState.Open)
                    con.Close();
                return null;
            }
        }

        // Ghi dữ liệu (INSERT, UPDATE, DELETE)
        public int Ghi(string query)
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand(query, con);

            try
            {
                con.Open();
                int count = cmd.ExecuteNonQuery();
                con.Close();
                return count;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                if (con.State == ConnectionState.Open)
                    con.Close();
                return -2;
            }
        }
    }
}