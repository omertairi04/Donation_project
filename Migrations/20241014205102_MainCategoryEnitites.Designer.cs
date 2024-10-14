﻿// <auto-generated />
using System;
using D_Project.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace D_Project.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241014205102_MainCategoryEnitites")]
    partial class MainCategoryEnitites
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("D_Project.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("D_Project.Models.MainCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("MainCategory");

                    b.HasData(
                        new
                        {
                            Id = new Guid("760f7733-7179-4331-b547-d0d543c404d8"),
                            Description = "Apparel and accessories",
                            Icon = "wwwroot/images/mainCategories/category.jpg",
                            Name = "Clothing"
                        },
                        new
                        {
                            Id = new Guid("61468241-641e-4146-a7be-4b15b7ee338b"),
                            Description = "Every day house hold items",
                            Icon = "wwwroot/images/mainCategories/category.jpg",
                            Name = "Household Items"
                        },
                        new
                        {
                            Id = new Guid("dd9b40e5-3af8-495a-8e89-974949f4f51f"),
                            Description = "Electronics",
                            Icon = "wwwroot/images/mainCategories/category.jpg",
                            Name = "Electronics"
                        },
                        new
                        {
                            Id = new Guid("f573225d-2181-4083-8a2a-8a4317b3fca9"),
                            Description = "Donate your books or medias.",
                            Icon = "wwwroot/images/mainCategories/category.jpg",
                            Name = "Books and Media"
                        },
                        new
                        {
                            Id = new Guid("8638f166-0389-409a-88ef-c7d26389da75"),
                            Description = "Donate your Toys and Games.",
                            Icon = "wwwroot/images/mainCategories/category.jpg",
                            Name = "Toys and Games"
                        },
                        new
                        {
                            Id = new Guid("dc48daff-cd3d-477d-a21e-52c830b61006"),
                            Description = "Donate your sport or fitness equipment.",
                            Icon = "wwwroot/images/mainCategories/category.jpg",
                            Name = "Sports of Fitness Equipment"
                        },
                        new
                        {
                            Id = new Guid("d413b22e-7fcd-4978-adc1-8c32406695a0"),
                            Description = "Donate your food and groceries.",
                            Icon = "wwwroot/images/mainCategories/category.jpg",
                            Name = "Food and Groceries"
                        });
                });

            modelBuilder.Entity("D_Project.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("AppUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("Exparation")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("MainCategoryId")
                        .HasColumnType("uuid");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("MainCategoryId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "61a513ae-58e7-44b9-83ed-bb74b4d5f103",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "5744c482-4977-4167-aee4-df2edfcd8b82",
                            Name = "Client",
                            NormalizedName = "CLIENT"
                        },
                        new
                        {
                            Id = "70351cba-1cd5-49a5-9857-f1793a895a63",
                            Name = "Donator",
                            NormalizedName = "DONATOR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ProductSubCategory", b =>
                {
                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("SubCategoryId")
                        .HasColumnType("uuid");

                    b.HasKey("ProductId", "SubCategoryId");

                    b.HasIndex("SubCategoryId");

                    b.ToTable("ProductSubCategory");
                });

            modelBuilder.Entity("SubCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("MainCategoryId")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("SubCategory");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5691d3de-7a07-4afb-a303-e18da5d2133b"),
                            Description = "Apparel for men",
                            Icon = "wwwroot/images/mainCategories/category.jpg",
                            MainCategoryId = new Guid("760f7733-7179-4331-b547-d0d543c404d8"),
                            Name = "Men's Clothing"
                        },
                        new
                        {
                            Id = new Guid("af52bd61-4722-49db-993f-6a92d61f56bb"),
                            Description = "Apparel for women",
                            Icon = "wwwroot/images/mainCategories/category.jpg",
                            MainCategoryId = new Guid("760f7733-7179-4331-b547-d0d543c404d8"),
                            Name = "Women's Clothing"
                        },
                        new
                        {
                            Id = new Guid("1fdb90bf-a0f2-4468-b44b-6f6fa5299a31"),
                            Description = "Apparel for children",
                            Icon = "wwwroot/images/mainCategories/category.jpg",
                            MainCategoryId = new Guid("760f7733-7179-4331-b547-d0d543c404d8"),
                            Name = "Children's Clothing"
                        },
                        new
                        {
                            Id = new Guid("0ddc2c2d-ee9c-43f0-a6ae-87fbe049c6cf"),
                            Description = "Footwear for all",
                            Icon = "wwwroot/images/mainCategories/category.jpg",
                            MainCategoryId = new Guid("760f7733-7179-4331-b547-d0d543c404d8"),
                            Name = "Shoes & Footwear"
                        },
                        new
                        {
                            Id = new Guid("4196a922-1e7d-432a-a4e2-cc20bfd31104"),
                            Description = "Hats, scarves, belts, etc.",
                            Icon = "wwwroot/images/mainCategories/category.jpg",
                            MainCategoryId = new Guid("760f7733-7179-4331-b547-d0d543c404d8"),
                            Name = "Accessories"
                        },
                        new
                        {
                            Id = new Guid("b1d2f97e-7b70-4223-b400-568cc138cee8"),
                            Description = "Household furniture",
                            Icon = "wwwroot/images/mainCategories/category.jpg",
                            MainCategoryId = new Guid("61468241-641e-4146-a7be-4b15b7ee338b"),
                            Name = "Furniture"
                        },
                        new
                        {
                            Id = new Guid("5ad0a04f-9eaf-4ba6-8ee5-1bd9453a1961"),
                            Description = "Utensils and appliances for the kitchen",
                            Icon = "wwwroot/images/mainCategories/category.jpg",
                            MainCategoryId = new Guid("61468241-641e-4146-a7be-4b15b7ee338b"),
                            Name = "Kitchenware"
                        },
                        new
                        {
                            Id = new Guid("bbe1c35d-3299-408e-b228-2b13bdbc6582"),
                            Description = "Bedding essentials",
                            Icon = "wwwroot/images/mainCategories/category.jpg",
                            MainCategoryId = new Guid("61468241-641e-4146-a7be-4b15b7ee338b"),
                            Name = "Bedding & Linens"
                        },
                        new
                        {
                            Id = new Guid("6995368a-c749-48ea-87c3-6c6f84b4a708"),
                            Description = "Cleaning essentials",
                            Icon = "wwwroot/images/mainCategories/category.jpg",
                            MainCategoryId = new Guid("61468241-641e-4146-a7be-4b15b7ee338b"),
                            Name = "Cleaning Supplies"
                        },
                        new
                        {
                            Id = new Guid("7b5872f9-cceb-4584-bb84-3bd0ec4a1d74"),
                            Description = "Decorative items for the home",
                            Icon = "wwwroot/images/mainCategories/category.jpg",
                            MainCategoryId = new Guid("61468241-641e-4146-a7be-4b15b7ee338b"),
                            Name = "Home Décor"
                        },
                        new
                        {
                            Id = new Guid("67412f37-685a-4394-8e2d-3d802b743ecd"),
                            Description = "Computers and laptops",
                            Icon = "wwwroot/images/mainCategories/category.jpg",
                            MainCategoryId = new Guid("dd9b40e5-3af8-495a-8e89-974949f4f51f"),
                            Name = "Computers & Laptops"
                        },
                        new
                        {
                            Id = new Guid("afe15908-a50f-435b-a3e1-b48275c1c256"),
                            Description = "Smartphones and tablets",
                            Icon = "wwwroot/images/mainCategories/category.jpg",
                            MainCategoryId = new Guid("dd9b40e5-3af8-495a-8e89-974949f4f51f"),
                            Name = "Mobile Phones & Tablets"
                        },
                        new
                        {
                            Id = new Guid("a991cf5d-712d-43dd-a2f6-49ec2db08b9d"),
                            Description = "Appliances for home use",
                            Icon = "wwwroot/images/mainCategories/category.jpg",
                            MainCategoryId = new Guid("dd9b40e5-3af8-495a-8e89-974949f4f51f"),
                            Name = "Home Appliances"
                        },
                        new
                        {
                            Id = new Guid("f7d9ae3f-8fa5-4b18-ba8d-a7718738c18f"),
                            Description = "Televisions and audio equipment",
                            Icon = "wwwroot/images/mainCategories/category.jpg",
                            MainCategoryId = new Guid("dd9b40e5-3af8-495a-8e89-974949f4f51f"),
                            Name = "TVs & Audio Systems"
                        },
                        new
                        {
                            Id = new Guid("48e2afba-1eee-4612-b70e-3e9ade302439"),
                            Description = "Fiction, non-fiction, educational",
                            Icon = "wwwroot/images/mainCategories/category.jpg",
                            MainCategoryId = new Guid("f573225d-2181-4083-8a2a-8a4317b3fca9"),
                            Name = "Books"
                        },
                        new
                        {
                            Id = new Guid("44c1366e-7c0c-45c4-917d-d124016f6a4e"),
                            Description = "Various magazines",
                            Icon = "wwwroot/images/mainCategories/category.jpg",
                            MainCategoryId = new Guid("f573225d-2181-4083-8a2a-8a4317b3fca9"),
                            Name = "Magazines"
                        },
                        new
                        {
                            Id = new Guid("fdd80bdf-e15c-4658-a851-32770b8e3c88"),
                            Description = "Media collection",
                            Icon = "wwwroot/images/mainCategories/category.jpg",
                            MainCategoryId = new Guid("f573225d-2181-4083-8a2a-8a4317b3fca9"),
                            Name = "CDs, DVDs, Blu-rays"
                        },
                        new
                        {
                            Id = new Guid("e7ee9b9c-bb31-4cfc-8b9e-b005754c681a"),
                            Description = "Games for fun and challenges",
                            Icon = "wwwroot/images/mainCategories/category.jpg",
                            MainCategoryId = new Guid("8638f166-0389-409a-88ef-c7d26389da75"),
                            Name = "Board Games & Puzzles"
                        },
                        new
                        {
                            Id = new Guid("464c608f-d435-4c24-b1bf-2e2b0f066e77"),
                            Description = "Toys for young children",
                            Icon = "wwwroot/images/mainCategories/category.jpg",
                            MainCategoryId = new Guid("8638f166-0389-409a-88ef-c7d26389da75"),
                            Name = "Baby & Toddler Toys"
                        },
                        new
                        {
                            Id = new Guid("ee52126a-dc5c-41cb-9977-e2744ee3199f"),
                            Description = "Toys that promote learning",
                            Icon = "wwwroot/images/mainCategories/category.jpg",
                            MainCategoryId = new Guid("8638f166-0389-409a-88ef-c7d26389da75"),
                            Name = "Educational Toys"
                        },
                        new
                        {
                            Id = new Guid("42a3bde9-4f4e-4547-832f-2f34dd2c53e8"),
                            Description = "Gaming systems and games",
                            Icon = "wwwroot/images/mainCategories/category.jpg",
                            MainCategoryId = new Guid("8638f166-0389-409a-88ef-c7d26389da75"),
                            Name = "Video Games & Consoles"
                        },
                        new
                        {
                            Id = new Guid("05344845-cb56-4d17-8f6a-81dbb3f64cf4"),
                            Description = "Equipment for gym workouts",
                            Icon = "wwwroot/images/mainCategories/category.jpg",
                            MainCategoryId = new Guid("dc48daff-cd3d-477d-a21e-52c830b61006"),
                            Name = "Gym Equipment"
                        },
                        new
                        {
                            Id = new Guid("7c86f696-e777-45bc-be6a-a3e3ad30d82d"),
                            Description = "Gear for various sports",
                            Icon = "wwwroot/images/mainCategories/category.jpg",
                            MainCategoryId = new Guid("dc48daff-cd3d-477d-a21e-52c830b61006"),
                            Name = "Sports Gear"
                        },
                        new
                        {
                            Id = new Guid("df26de71-c0ed-4710-bbf9-115bdfddc99f"),
                            Description = "Bicycles and scooters for all ages",
                            Icon = "wwwroot/images/mainCategories/category.jpg",
                            MainCategoryId = new Guid("dc48daff-cd3d-477d-a21e-52c830b61006"),
                            Name = "Bicycles & Scooters"
                        },
                        new
                        {
                            Id = new Guid("ae2814e3-953c-4333-8089-3cb0ae9dc5dc"),
                            Description = "Equipment for outdoor activities",
                            Icon = "wwwroot/images/mainCategories/category.jpg",
                            MainCategoryId = new Guid("dc48daff-cd3d-477d-a21e-52c830b61006"),
                            Name = "Camping & Outdoor Gear"
                        },
                        new
                        {
                            Id = new Guid("aba87aea-2bf6-4341-ac5f-5a572fa9cee8"),
                            Description = "Canned food items",
                            Icon = "wwwroot/images/mainCategories/category.jpg",
                            MainCategoryId = new Guid("d413b22e-7fcd-4978-adc1-8c32406695a0"),
                            Name = "Canned Goods"
                        },
                        new
                        {
                            Id = new Guid("131e6f0d-098a-417e-a86e-dd479b62c638"),
                            Description = "Non-perishable food products",
                            Icon = "wwwroot/images/mainCategories/category.jpg",
                            MainCategoryId = new Guid("d413b22e-7fcd-4978-adc1-8c32406695a0"),
                            Name = "Non-Perishable Items"
                        },
                        new
                        {
                            Id = new Guid("abd616ce-a2dd-49ed-b0f3-0691bc680491"),
                            Description = "Food and formula for infants",
                            Icon = "wwwroot/images/mainCategories/category.jpg",
                            MainCategoryId = new Guid("d413b22e-7fcd-4978-adc1-8c32406695a0"),
                            Name = "Baby Food & Formula"
                        });
                });

            modelBuilder.Entity("D_Project.Models.Product", b =>
                {
                    b.HasOne("D_Project.Models.AppUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("D_Project.Models.MainCategory", "MainCategory")
                        .WithMany()
                        .HasForeignKey("MainCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");

                    b.Navigation("MainCategory");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("D_Project.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("D_Project.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("D_Project.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("D_Project.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProductSubCategory", b =>
                {
                    b.HasOne("D_Project.Models.Product", "Product")
                        .WithMany("ProductSubCategories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SubCategory", "SubCategory")
                        .WithMany()
                        .HasForeignKey("SubCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("SubCategory");
                });

            modelBuilder.Entity("D_Project.Models.Product", b =>
                {
                    b.Navigation("ProductSubCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
