using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace HomeWork_15
{
    public class StoresContext : DbContext
    {

        public StoresContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\hnitetskyini\Documents\Chain_Stores.mdf; Integrated Security = True; Connect Timeout = 30");
        }
        public DbSet<Network> Networks { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
