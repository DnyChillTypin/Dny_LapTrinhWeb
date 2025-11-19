using Day08Lab_231210730.Models;
using Microsoft.EntityFrameworkCore;

namespace Day08Lab_231210730.Entities
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}
