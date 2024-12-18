using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace LINQDOC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new NorthwindContext())
            {
                var cusQuery =
                    from cust in db.Customers
                    where cust.City == "London"
                    select cust;

                foreach (var customer in cusQuery)
                {
                    Console.WriteLine($"{customer.CustomerID} - {customer.CompanyName}");
                }
            }
        }
    }

    public class Customer
    {
        [Key]
        public string? CustomerID { get; set; }
        public string? CompanyName { get; set; }
        public string? City { get; set; } // Other properties
    }

    public class NorthwindContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=DESKTOP-ELER3NF\DEPIR2;Database=Northwind;Trusted_Connection=True;MultipleActiveResultSets=true",
                sqlOptions =>
                {
                    sqlOptions.EnableRetryOnFailure(
                        maxRetryCount: 5, // Default is 5
                        maxRetryDelay: TimeSpan.FromSeconds(30), // Default is 30 seconds
                        errorNumbersToAdd: null
                    );
                }
            );
        }
    }
}