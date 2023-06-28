using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace HomeWork_15
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var ctx = new StoresContext())
                {
                    //var stor = new Network() { Name = "Novus", NetworkID = 1};
                    var product = new Product() { Name = "Onion" };
                    //ctx.Networks.Add(stor);
                    ctx.Products.Add(product);
                    ctx.SaveChanges();
                }
            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
        }
    }
}