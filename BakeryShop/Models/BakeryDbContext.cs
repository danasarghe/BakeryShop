using Microsoft.AspNetCore.Identity;
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
        public DbSet<IdentityUser> IdentityUser { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Special Bread" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Regular Bread" });

            modelBuilder.Entity<Bread>().HasData(new Bread
            {
                BreadId = 1,
                Name = "White Bread",
                Description = "100% faina alba de grau, apa, sare, 5% maia naturala din faina de grau, 600 g.",
                Price = 10M,
                IsBreadOfTheWeek = true,
                ImageUrl = "https://drive.google.com/file/d/1MFmOehz-SZVzCcIR515MaNwNLdzQFNLp/view?usp=sharing",
                ImageThumbnailUrl = "https://drive.google.com/file/d/1MFmOehz-SZVzCcIR515MaNwNLdzQFNLp/view?usp=sharing",
                CategoryId = 2
            });
            modelBuilder.Entity<Bread>().HasData(new Bread
            {
                BreadId = 2,
                Name = "Spelt Bread",
                Description = "Faina alba de grau,Faina spelta, apa, sare, 5% maia naturala din faina de grau, 600 g.",
                Price = 12M,
                IsBreadOfTheWeek = false,
                ImageUrl = "https://drive.google.com/file/d/1xJPc2Zj4MqpqWZ_7y2PC0EgZ7Hc74U2L/view?usp=sharing",
                ImageThumbnailUrl = "https://drive.google.com/file/d/1xJPc2Zj4MqpqWZ_7y2PC0EgZ7Hc74U2L/view?usp=sharing",
                CategoryId = 1
            });
            modelBuilder.Entity<Bread>().HasData(new Bread
            {
                BreadId = 3,
                Name = "Whole Weat Bread",
                Description = "Prin faina 100% integrala din care este dospita, aceasta paine aduce numeroase beneficii sanatatii.",
                Price = 11M,
                IsBreadOfTheWeek = true,
                ImageUrl = "https://drive.google.com/file/d/1SaJtODcKIclXRiRzufvnWTKaaXqmgH6f/view?usp=sharing",
                ImageThumbnailUrl = "https://drive.google.com/file/d/1SaJtODcKIclXRiRzufvnWTKaaXqmgH6f/view?usp=sharing",
                CategoryId = 2
            });
            modelBuilder.Entity<Bread>().HasData(new Bread
            {
                BreadId = 4,
                Name = "Rustic Bread",
                Description = "Paine intermediara cu maia naturala, fara drojdie si fara aditivi. Incearca si tu savuroasa paine rustica ",
                Price = 12M,
                IsBreadOfTheWeek = true,
                ImageUrl = "https://drive.google.com/file/d/1LKKPFswosygLv_HS5_zhnLkVzAmtSv6f/view?usp=sharing",
                ImageThumbnailUrl = "https://drive.google.com/file/d/1LKKPFswosygLv_HS5_zhnLkVzAmtSv6f/view?usp=sharing",
                CategoryId = 2
            });
            modelBuilder.Entity<Bread>().HasData(new Bread
            {
                BreadId = 5,
                Name = "Leaven Bread",
                Description = "Se spune că simplitatea este cea mai înalta formă a sofisticării, iar această pâine susţine această afirmaţie în mod categoric.",
                Price = 13M,
                IsBreadOfTheWeek = true,
                ImageUrl = "https://drive.google.com/file/d/1HvwU6ZQf5rsAPYBPprqNgDHKqksxvqZF/view?usp=sharing",
                ImageThumbnailUrl = "https://drive.google.com/file/d/1HvwU6ZQf5rsAPYBPprqNgDHKqksxvqZF/view?usp=sharing",
                CategoryId = 1
            });
            modelBuilder.Entity<Bread>().HasData(new Bread
            {
                BreadId = 6,
                Name = "Baquette Bread",
                Description = "Baghetă tradițională franţuzească, cu miez puţin, alveolat şi o crustă crocantă şi subţire. Alegerea perfectă pentru toate mesele.",
                Price = 6.5M,
                IsBreadOfTheWeek = false,
                ImageUrl = "https://drive.google.com/file/d/1vh-X6_ETQYgdb-zUA0JSUpzYYdXO-w0u/view?usp=sharing",
                ImageThumbnailUrl = "https://drive.google.com/file/d/1vh-X6_ETQYgdb-zUA0JSUpzYYdXO-w0u/view?usp=sharing",
                CategoryId = 1
            });
            modelBuilder.Entity<Bread>().HasData(new Bread
            {
                BreadId = 7,
                Name = "Ciabata Bread",
                Description = "O pâine moale şi fină, de inspiraţie italienească, conţine ulei de măsline extravirgin din belşug, contribuind decisiv la gustul agreabil.",
                Price = 13M,
                IsBreadOfTheWeek = false,
                ImageUrl = "https://drive.google.com/file/d/1ZJPjA3tneKXqncoAXpmD63L35ybRaJ8D/view?usp=sharing",
                ImageThumbnailUrl = "https://drive.google.com/file/d/1ZJPjA3tneKXqncoAXpmD63L35ybRaJ8D/view?usp=sharing",
                CategoryId = 1
            });
        }
    }
}
