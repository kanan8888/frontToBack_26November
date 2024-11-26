using Microsoft.EntityFrameworkCore;
using WebApp_FrontToBack_25November.Models;

namespace WebApp_FrontToBack_25November.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Product>Products { get; set; }

    }
}
