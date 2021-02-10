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
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<IdentityUser> IdentityUser { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Special Bread" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Regular Bread" });

            modelBuilder.Entity<Bread>().HasData(new Bread
            {
                BreadId = 1,
                Name = "Paine alba",
                Description = "100% faina alba de grau, apa, sare, 5% maia naturala din faina de grau, 600 g.",
                Price = 10M,
                IsBreadOfTheWeek = true,
                ImageUrl = "https://localhost:5001/Images/whitebread.png",
                ImageThumbnailUrl = "https://localhost:5001/Images/whitebread.png",
                CategoryId = 2
            });
            modelBuilder.Entity<Bread>().HasData(new Bread
            {
                BreadId = 2,
                Name = "Paine cu faina spelta",
                Description = "Faina alba de grau,Faina spelta, apa, sare, 5% maia naturala din faina de grau, 600 g.",
                Price = 12M,
                IsBreadOfTheWeek = false,
                ImageUrl = "https://localhost:5001/Images/semola.jpg",
                ImageThumbnailUrl = "https://localhost:5001/Images/semola.jpg",
                CategoryId = 1
            });
            modelBuilder.Entity<Bread>().HasData(new Bread
            {
                BreadId = 3,
                Name = "Paine integrala",
                Description = "Prin faina 100% integrala din care este dospita, aceasta paine aduce numeroase beneficii sanatatii.",
                Price = 11M,
                IsBreadOfTheWeek = true,
                ImageUrl = "https://localhost:5001/Images/Integrala.jpg",
                ImageThumbnailUrl = "https://localhost:5001/Images/Integrala.jpg",
                CategoryId = 2
            });
            modelBuilder.Entity<Bread>().HasData(new Bread
            {
                BreadId = 4,
                Name = "Paine rustica",
                Description = "Paine intermediara cu maia naturala, fara drojdie si fara aditivi. Incearca si tu savuroasa paine rustica ",
                Price = 12M,
                IsBreadOfTheWeek = true,
                ImageUrl = "https://localhost:5001/Images/rustica.jpg",
                ImageThumbnailUrl = "https://localhost:5001/Images/rustica.jpg",
                CategoryId = 2
            });
            modelBuilder.Entity<Bread>().HasData(new Bread
            {
                BreadId = 5,
                Name = "Paine cu maia",
                Description = "Se spune că simplitatea este cea mai înalta formă a sofisticării, iar această pâine susţine această afirmaţie în mod categoric.",
                Price = 13M,
                IsBreadOfTheWeek = true,
                ImageUrl = "https://localhost:5001/Images/leavenBread.png",
                ImageThumbnailUrl = "https://localhost:5001/Images/leavenBread.png",
                CategoryId = 1
            });
            modelBuilder.Entity<Bread>().HasData(new Bread
            {
                BreadId = 6,
                Name = "Paine Baquette",
                Description = "Baghetă tradițională franţuzească, cu miez puţin, alveolat şi o crustă crocantă şi subţire. Alegerea perfectă pentru toate mesele.",
                Price = 6.5M,
                IsBreadOfTheWeek = false,
                ImageUrl = "https://localhost:5001/Images/French-baguette.jpg",
                ImageThumbnailUrl = "https://localhost:5001/Images/French-baguette.jpg",
                CategoryId = 1
            });
            modelBuilder.Entity<Bread>().HasData(new Bread
            {
                BreadId = 7,
                Name = "Paine Ciabata",
                Description = "O pâine moale şi fină, de inspiraţie italienească, conţine ulei de măsline extravirgin din belşug, contribuind decisiv la gustul agreabil.",
                Price = 13M,
                IsBreadOfTheWeek = false,
                ImageUrl = "https://localhost:5001/Images/ciabatta.jpg",
                ImageThumbnailUrl = "https://localhost:5001/Images/ciabatta.jpg",
                CategoryId = 1
            });
            modelBuilder.Entity<Bread>().HasData(new Bread
            {
                BreadId = 8,
                Name = "Pâine integrală cu seminţe de dovleac",
                Description = "O pâine foarte săţioasă şi hrănitoare, nu încetează să ne încânte prin profunzimea gustului şi textura complexă.",
                Price = 14M,
                IsBreadOfTheWeek = false,
                ImageUrl = "https://localhost:5001/Images/integralaSeminte.png",
                ImageThumbnailUrl = "https://localhost:5001/Images/integralaSeminte.png",
                CategoryId = 1

            });
            modelBuilder.Entity<Bread>().HasData(new Bread
            {
                BreadId = 9,
                Name = "Pâine intermediară",
                Description = "Crusta este subţire şi gustoasă, iar miezul bogat, cu alveole mici şi regulate o fac o candidată perfectă pentru sandwichuri şi nu numai.",
                Price = 11M,
                IsBreadOfTheWeek = true,
                ImageUrl = "https://localhost:5001/Images/round.jpg",
                ImageThumbnailUrl = "https://localhost:5001/Images/round.jpg",
                CategoryId = 2
            });

        }
    }
}
