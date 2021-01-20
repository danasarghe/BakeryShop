using Microsoft.EntityFrameworkCore;

namespace BakeryShop.Models
{
    public class BakeryDbContext : DbContext
    {
        public BakeryDbContext(DbContextOptions<BakeryDbContext> options) : base(options)
        {

        }

        public DbSet<Bread> Breads { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
