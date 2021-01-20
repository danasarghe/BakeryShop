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
                Image = "https://onedrive.live.com/?cid=880317F0636F898D&id=880317F0636F898D%21317&parId=880317F0636F898D%21316&o=OneUp",
                ImageThumbnail = "https://onedrive.live.com/?cid=880317F0636F898D&id=880317F0636F898D%21317&parId=880317F0636F898D%21316&o=OneUp",
                CategoryId = 2
            });
            modelBuilder.Entity<Bread>().HasData(new Bread
            {
                BreadId = 2,
                Name = "Spelt Bread",
                Description = "Faina alba de grau,Faina spelta, apa, sare, 5% maia naturala din faina de grau, 600 g.",
                Price = 12M,
                Image = "https://onedrive.live.com/?cid=880317F0636F898D&id=880317F0636F898D%21325&parId=880317F0636F898D%21316&o=OneUp",
                ImageThumbnail = "https://onedrive.live.com/?cid=880317F0636F898D&id=880317F0636F898D%21325&parId=880317F0636F898D%21316&o=OneUp",
                CategoryId = 1
            });
            modelBuilder.Entity<Bread>().HasData(new Bread
            {
                BreadId = 3,
                Name = "Whole Weat Bread",
                Description = "Prin faina 100% integrala din care este dospita, aceasta paine aduce numeroase beneficii sanatatii: regleaza tranzitul intestinal datorita cantitatii ridicate de fibre, are indice glicemic scazut, fiind astfel potrivita si pentru diabetici, contine o multitudine de vitamine, precum B1, B2, B3, B5 si ofera senzatia de satietate pe termen lung",
                Price = 11M,
                Image = "https://onedrive.live.com/?cid=880317F0636F898D&id=880317F0636F898D%21320&parId=880317F0636F898D%21316&o=OneUp",
                ImageThumbnail = "https://onedrive.live.com/?cid=880317F0636F898D&id=880317F0636F898D%21320&parId=880317F0636F898D%21316&o=OneUp",
                CategoryId = 2
            });
            modelBuilder.Entity<Bread>().HasData(new Bread
            {
                BreadId = 4,
                Name = "Rustic Bread",
                Description = "Paine intermediara cu maia naturala, fara drojdie si fara aditivi. Incearca si tu savuroasa paine rustica ",
                Price = 12M,
                Image = "https://onedrive.live.com/?cid=880317F0636F898D&id=880317F0636F898D%21318&parId=880317F0636F898D%21316&o=OneUp",
                ImageThumbnail = "https://onedrive.live.com/?cid=880317F0636F898D&id=880317F0636F898D%21318&parId=880317F0636F898D%21316&o=OneUp",
                CategoryId = 2
            });
            modelBuilder.Entity<Bread>().HasData(new Bread
            {
                BreadId = 5,
                Name = "Leaven Bread",
                Description = "Se spune că simplitatea este cea mai înalta formă a sofisticării, iar această pâine susţine această afirmaţie în mod categoric. Gustul bogat si simplu o face extrem de versatilă pentru toate ideile de masă.",
                Price = 13M,
                Image = "https://onedrive.live.com/?cid=880317F0636F898D&id=880317F0636F898D%21323&parId=880317F0636F898D%21316&o=OneUp",
                ImageThumbnail = "https://onedrive.live.com/?cid=880317F0636F898D&id=880317F0636F898D%21323&parId=880317F0636F898D%21316&o=OneUp",
                CategoryId = 1
            });
            modelBuilder.Entity<Bread>().HasData(new Bread
            {
                BreadId = 6,
                Name = "Baquette Bread",
                Description = "Baghetă tradițională franţuzească, cu miez puţin, alveolat şi o crustă crocantă şi subţire. Alegerea perfectă pentru toate mesele.",
                Price = 6.5M,
                Image = "https://onedrive.live.com/?cid=880317F0636F898D&id=880317F0636F898D%21330&parId=880317F0636F898D%21316&o=OneUp",
                ImageThumbnail = "https://onedrive.live.com/?cid=880317F0636F898D&id=880317F0636F898D%21330&parId=880317F0636F898D%21316&o=OneUp",
                CategoryId = 1
            });
            modelBuilder.Entity<Bread>().HasData(new Bread
            {
                BreadId = 7,
                Name = "Ciabata Bread",
                Description = "O pâine moale şi fină, de inspiraţie italienească, conţine ulei de măsline extravirgin din belşug, contribuind decisiv la gustul agreabil.",
                Price = 13M,
                Image = "https://onedrive.live.com/?cid=880317F0636F898D&id=880317F0636F898D%21329&parId=880317F0636F898D%21316&o=OneUp",
                ImageThumbnail = "https://onedrive.live.com/?cid=880317F0636F898D&id=880317F0636F898D%21329&parId=880317F0636F898D%21316&o=OneUp",
                CategoryId = 1
            });
        }
    }
}
