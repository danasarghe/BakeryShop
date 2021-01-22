﻿// <auto-generated />
using BakeryShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BakeryShop.Migrations
{
    [DbContext(typeof(BakeryDbContext))]
    [Migration("20210121070104_Update")]
    partial class Update
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("BakeryShop.Models.Bread", b =>
                {
                    b.Property<int>("BreadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageThumbnail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("BreadId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Breads");

                    b.HasData(
                        new
                        {
                            BreadId = 1,
                            CategoryId = 2,
                            Description = "100% faina alba de grau, apa, sare, 5% maia naturala din faina de grau, 600 g.",
                            Image = "https://onedrive.live.com/?cid=880317F0636F898D&id=880317F0636F898D%21317&parId=880317F0636F898D%21316&o=OneUp",
                            ImageThumbnail = "https://onedrive.live.com/?cid=880317F0636F898D&id=880317F0636F898D%21317&parId=880317F0636F898D%21316&o=OneUp",
                            Name = "White Bread",
                            Price = 10m
                        },
                        new
                        {
                            BreadId = 2,
                            CategoryId = 1,
                            Description = "Faina alba de grau,Faina spelta, apa, sare, 5% maia naturala din faina de grau, 600 g.",
                            Image = "https://onedrive.live.com/?cid=880317F0636F898D&id=880317F0636F898D%21325&parId=880317F0636F898D%21316&o=OneUp",
                            ImageThumbnail = "https://onedrive.live.com/?cid=880317F0636F898D&id=880317F0636F898D%21325&parId=880317F0636F898D%21316&o=OneUp",
                            Name = "Spelt Bread",
                            Price = 12m
                        },
                        new
                        {
                            BreadId = 3,
                            CategoryId = 2,
                            Description = "Prin faina 100% integrala din care este dospita, aceasta paine aduce numeroase beneficii sanatatii: regleaza tranzitul intestinal datorita cantitatii ridicate de fibre, are indice glicemic scazut, fiind astfel potrivita si pentru diabetici, contine o multitudine de vitamine, precum B1, B2, B3, B5 si ofera senzatia de satietate pe termen lung",
                            Image = "https://onedrive.live.com/?cid=880317F0636F898D&id=880317F0636F898D%21320&parId=880317F0636F898D%21316&o=OneUp",
                            ImageThumbnail = "https://onedrive.live.com/?cid=880317F0636F898D&id=880317F0636F898D%21320&parId=880317F0636F898D%21316&o=OneUp",
                            Name = "Whole Weat Bread",
                            Price = 11m
                        },
                        new
                        {
                            BreadId = 4,
                            CategoryId = 2,
                            Description = "Paine intermediara cu maia naturala, fara drojdie si fara aditivi. Incearca si tu savuroasa paine rustica ",
                            Image = "https://onedrive.live.com/?cid=880317F0636F898D&id=880317F0636F898D%21318&parId=880317F0636F898D%21316&o=OneUp",
                            ImageThumbnail = "https://onedrive.live.com/?cid=880317F0636F898D&id=880317F0636F898D%21318&parId=880317F0636F898D%21316&o=OneUp",
                            Name = "Rustic Bread",
                            Price = 12m
                        },
                        new
                        {
                            BreadId = 5,
                            CategoryId = 1,
                            Description = "Se spune că simplitatea este cea mai înalta formă a sofisticării, iar această pâine susţine această afirmaţie în mod categoric. Gustul bogat si simplu o face extrem de versatilă pentru toate ideile de masă.",
                            Image = "https://onedrive.live.com/?cid=880317F0636F898D&id=880317F0636F898D%21323&parId=880317F0636F898D%21316&o=OneUp",
                            ImageThumbnail = "https://onedrive.live.com/?cid=880317F0636F898D&id=880317F0636F898D%21323&parId=880317F0636F898D%21316&o=OneUp",
                            Name = "Leaven Bread",
                            Price = 13m
                        },
                        new
                        {
                            BreadId = 6,
                            CategoryId = 1,
                            Description = "Baghetă tradițională franţuzească, cu miez puţin, alveolat şi o crustă crocantă şi subţire. Alegerea perfectă pentru toate mesele.",
                            Image = "https://onedrive.live.com/?cid=880317F0636F898D&id=880317F0636F898D%21330&parId=880317F0636F898D%21316&o=OneUp",
                            ImageThumbnail = "https://onedrive.live.com/?cid=880317F0636F898D&id=880317F0636F898D%21330&parId=880317F0636F898D%21316&o=OneUp",
                            Name = "Baquette Bread",
                            Price = 6.5m
                        },
                        new
                        {
                            BreadId = 7,
                            CategoryId = 1,
                            Description = "O pâine moale şi fină, de inspiraţie italienească, conţine ulei de măsline extravirgin din belşug, contribuind decisiv la gustul agreabil.",
                            Image = "https://onedrive.live.com/?cid=880317F0636F898D&id=880317F0636F898D%21329&parId=880317F0636F898D%21316&o=OneUp",
                            ImageThumbnail = "https://onedrive.live.com/?cid=880317F0636F898D&id=880317F0636F898D%21329&parId=880317F0636F898D%21316&o=OneUp",
                            Name = "Ciabata Bread",
                            Price = 13m
                        });
                });

            modelBuilder.Entity("BakeryShop.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypeOfBread")
                        .HasColumnType("int");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Special Bread",
                            TypeOfBread = 0
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Regular Bread",
                            TypeOfBread = 0
                        });
                });

            modelBuilder.Entity("BakeryShop.Models.Bread", b =>
                {
                    b.HasOne("BakeryShop.Models.Category", "Category")
                        .WithMany("Breads")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BakeryShop.Models.Category", b =>
                {
                    b.Navigation("Breads");
                });
#pragma warning restore 612, 618
        }
    }
}