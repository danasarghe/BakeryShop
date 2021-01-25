﻿// <auto-generated />
using System;
using BakeryShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BakeryShop.Migrations
{
    [DbContext(typeof(BakeryDbContext))]
    [Migration("20210123134110_AddBread")]
    partial class AddBread
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

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsBreadOfTheWeek")
                        .HasColumnType("bit");

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
                            ImageThumbnailUrl = "https://drive.google.com/file/d/1MFmOehz-SZVzCcIR515MaNwNLdzQFNLp/view?usp=sharing",
                            ImageUrl = "https://drive.google.com/file/d/1MFmOehz-SZVzCcIR515MaNwNLdzQFNLp/view?usp=sharing",
                            IsBreadOfTheWeek = true,
                            Name = "Paine alba",
                            Price = 10m
                        },
                        new
                        {
                            BreadId = 2,
                            CategoryId = 1,
                            Description = "Faina alba de grau,Faina spelta, apa, sare, 5% maia naturala din faina de grau, 600 g.",
                            ImageThumbnailUrl = "https://drive.google.com/file/d/1xJPc2Zj4MqpqWZ_7y2PC0EgZ7Hc74U2L/view?usp=sharing",
                            ImageUrl = "https://drive.google.com/file/d/1xJPc2Zj4MqpqWZ_7y2PC0EgZ7Hc74U2L/view?usp=sharing",
                            IsBreadOfTheWeek = false,
                            Name = "Paine cu faina spelta",
                            Price = 12m
                        },
                        new
                        {
                            BreadId = 3,
                            CategoryId = 2,
                            Description = "Prin faina 100% integrala din care este dospita, aceasta paine aduce numeroase beneficii sanatatii.",
                            ImageThumbnailUrl = "https://drive.google.com/file/d/1SaJtODcKIclXRiRzufvnWTKaaXqmgH6f/view?usp=sharing",
                            ImageUrl = "https://drive.google.com/file/d/1SaJtODcKIclXRiRzufvnWTKaaXqmgH6f/view?usp=sharing",
                            IsBreadOfTheWeek = true,
                            Name = "Paine integrala de grau",
                            Price = 11m
                        },
                        new
                        {
                            BreadId = 4,
                            CategoryId = 2,
                            Description = "Paine intermediara cu maia naturala, fara drojdie si fara aditivi. Incearca si tu savuroasa paine rustica ",
                            ImageThumbnailUrl = "https://drive.google.com/file/d/1LKKPFswosygLv_HS5_zhnLkVzAmtSv6f/view?usp=sharing",
                            ImageUrl = "https://drive.google.com/file/d/1LKKPFswosygLv_HS5_zhnLkVzAmtSv6f/view?usp=sharing",
                            IsBreadOfTheWeek = true,
                            Name = "Paine rustica",
                            Price = 12m
                        },
                        new
                        {
                            BreadId = 5,
                            CategoryId = 1,
                            Description = "Se spune că simplitatea este cea mai înalta formă a sofisticării, iar această pâine susţine această afirmaţie în mod categoric.",
                            ImageThumbnailUrl = "https://drive.google.com/file/d/1HvwU6ZQf5rsAPYBPprqNgDHKqksxvqZF/view?usp=sharing",
                            ImageUrl = "https://drive.google.com/file/d/1HvwU6ZQf5rsAPYBPprqNgDHKqksxvqZF/view?usp=sharing",
                            IsBreadOfTheWeek = true,
                            Name = "Paine cu maia",
                            Price = 13m
                        },
                        new
                        {
                            BreadId = 6,
                            CategoryId = 1,
                            Description = "Baghetă tradițională franţuzească, cu miez puţin, alveolat şi o crustă crocantă şi subţire. Alegerea perfectă pentru toate mesele.",
                            ImageThumbnailUrl = "https://drive.google.com/file/d/1vh-X6_ETQYgdb-zUA0JSUpzYYdXO-w0u/view?usp=sharing",
                            ImageUrl = "https://drive.google.com/file/d/1vh-X6_ETQYgdb-zUA0JSUpzYYdXO-w0u/view?usp=sharing",
                            IsBreadOfTheWeek = false,
                            Name = "Paine Baquette",
                            Price = 6.5m
                        },
                        new
                        {
                            BreadId = 7,
                            CategoryId = 1,
                            Description = "O pâine moale şi fină, de inspiraţie italienească, conţine ulei de măsline extravirgin din belşug, contribuind decisiv la gustul agreabil.",
                            ImageThumbnailUrl = "https://drive.google.com/file/d/1ZJPjA3tneKXqncoAXpmD63L35ybRaJ8D/view?usp=sharing",
                            ImageUrl = "https://drive.google.com/file/d/1ZJPjA3tneKXqncoAXpmD63L35ybRaJ8D/view?usp=sharing",
                            IsBreadOfTheWeek = false,
                            Name = "Paine Ciabata",
                            Price = 13m
                        },
                        new
                        {
                            BreadId = 8,
                            CategoryId = 1,
                            Description = "O pâine foarte săţioasă şi hrănitoare, nu încetează să ne încânte prin profunzimea gustului şi textura complexă.",
                            ImageThumbnailUrl = "https://drive.google.com/file/d/1xnbTQSSAVd_JaLvF2mtrf5aiR2RLc6Xf/view?usp=sharing",
                            ImageUrl = "https://drive.google.com/file/d/1xnbTQSSAVd_JaLvF2mtrf5aiR2RLc6Xf/view?usp=sharing",
                            IsBreadOfTheWeek = false,
                            Name = "Pâine integrală de grâu şi seminţe de dovleac",
                            Price = 14m
                        },
                        new
                        {
                            BreadId = 9,
                            CategoryId = 2,
                            Description = "Crusta este subţire şi gustoasă, iar miezul bogat, cu alveole mici şi regulate o fac o candidată perfectă pentru sandwichuri şi nu numai.",
                            ImageThumbnailUrl = "https://drive.google.com/file/d/1L1QCsR1YOoraTcz7hrh1qnvvxisQB_sc/view?usp=sharing",
                            ImageUrl = "https://drive.google.com/file/d/1L1QCsR1YOoraTcz7hrh1qnvvxisQB_sc/view?usp=sharing",
                            IsBreadOfTheWeek = true,
                            Name = "Pâine intermediară",
                            Price = 11m
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

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Special Bread"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Regular Bread"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("IdentityUser");
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
