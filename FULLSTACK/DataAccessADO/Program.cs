using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace DataAccessADO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=DESKTOP-NAUIN65\DEPIR2_2024;Integrated Security=True;Trust Server Certificate=True;Initial Catalog=nortwind";

            try
            {
                using SqlConnection con = new(connectionString);
                con.Open();
                Console.WriteLine("✅ Connection Open");

                string query = "SELECT CustomerID, CompanyName FROM Customers";

                using SqlCommand cmd = new(query, con);
                using SqlDataReader reader = cmd.ExecuteReader();

                Console.WriteLine("\n--- Customers ---");
                while (reader.Read())
                {
                    Console.WriteLine($"ID: {reader["CustomerID"]}, Name: {reader["CompanyName"]}");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"❌ SQL Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error: {ex.Message}");
            }
        }
    }
}
