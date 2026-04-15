using MySql.Data.MySqlClient;
using System;
using System.Data.SqlClient;

class TestDB
{
    static void Main()
    {
        string connectionString = "Server=localhost;Database=quanlyrapphim;User Id=root;Password=khanh206;";

        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            try
            {
                conn.Open();
                Console.WriteLine("Kết nối thành công!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Kết nối thất bại!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}