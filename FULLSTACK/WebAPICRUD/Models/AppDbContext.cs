using Microsoft.EntityFrameworkCore;
namespace WebAPICRUD.Models
{
    //1- Inherit DbContext
    //2-Create CTOR
    //3- Create DbSet
    //4- Add Connection String in appsettings.json
    public class AppDbContext:DbContext
    {
        public AppDbContext()
        {
            
        }
        //Option Hard Coded
        public AppDbContext(DbContextOptions options):base(options)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        
    }
}
