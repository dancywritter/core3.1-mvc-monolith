﻿// <auto-generated />
using System;
using core3._1_mvc_monolith.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

namespace core3._1_mvc_monolith.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0-preview6.19304.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("core3._1_mvc_monolith.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName");

                    b.Property<string>("Description");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Spicy Pizzas"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Meat Pizzas"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Vegetarian Pizzas"
                        });
                });

            modelBuilder.Entity("core3._1_mvc_monolith.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("AddressLine2");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("OrderPlaced");

                    b.Property<decimal>("OrderTotal");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("State")
                        .HasMaxLength(10);

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("core3._1_mvc_monolith.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount");

                    b.Property<int>("OrderId");

                    b.Property<int>("PizzaId");

                    b.Property<decimal>("Price");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("OrderId");

                    b.HasIndex("PizzaId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("core3._1_mvc_monolith.Models.Pizza", b =>
                {
                    b.Property<int>("PizzaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AllergyInformation");

                    b.Property<int>("CategoryId");

                    b.Property<string>("ImageThumbnailPath");

                    b.Property<string>("ImagePath");

                    b.Property<bool>("InStock");

                    b.Property<bool>("IsPizzaOfTheWeek");

                    b.Property<string>("LongDescription");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<string>("ShortDescription");

                    b.HasKey("PizzaId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Pizzas");

                    b.HasData(
                    new
                    { 
                      PizzaId = 1, 
                      AllergyInformation = "", 
                      CategoryId = 1, 
                      ImagePath = "~/Images/pizzas/cheese-pizza.png", 
                      ImageThumbnailPath = "~/Images/thumbnails/cheese-small.png", 
                      InStock = true, 
                      IsPizzaOfTheWeek = true, 
                      LongDescription = "In a glass or plastic bowl, combine yeast, water, and sugar (the water can just be water from the tap, make sure it's below 100°F). Stir to dissolve the yeast and let the yeast bloom for 15 minutes. Stir in 1 cup flour, add salt, and then stir in another cup of flour (the remaining cup of flour will be your bench flour and added flour). Dump mixture onto kneading board and work in last cup of flour, kneading until dough is soft and elastic, but not sticky. Form dough into a ball. In another bowl, pour in the 1 tbsp olive oil and spread around. Coat ball of dough with oil and cover bowl with a damp towel and let dough rise for 40 minutes.", 
                      Name = "Cheese Pizza", 
                      Price = 15.50m, 
                      ShortDescription = "Our famous Cheese Pizzas!" 
                    },
                    new
                    { 
                      PizzaId = 2, 
                      AllergyInformation = "", 
                      CategoryId = 1, 
                      ImagePath = "~/Images/pizzas/cheese-pizza.png", 
                      ImageThumbnailPath = "~/Images/thumbnails/cheese-small.png", 
                      InStock = true, 
                      IsPizzaOfTheWeek = false, 
                      LongDescription = "In a glass or plastic bowl, combine yeast, water, and sugar (the water can just be water from the tap, make sure it's below 100°F). Stir to dissolve the yeast and let the yeast bloom for 15 minutes. Stir in 1 cup flour, add salt, and then stir in another cup of flour (the remaining cup of flour will be your bench flour and added flour). Dump mixture onto kneading board and work in last cup of flour, kneading until dough is soft and elastic, but not sticky. Form dough into a ball. In another bowl, pour in the 1 tbsp olive oil and spread around. Coat ball of dough with oil and cover bowl with a damp towel and let dough rise for 40 minutes.", 
                      Name = "Cheese Pizza", 
                      Price = 16.00m, 
                      ShortDescription = "Our famous Cheese Pizzas!" 
                    },
                      new
                      {
                          PizzaId = 3,
                          AllergyInformation = "",
                          CategoryId = 1,
                          ImagePath = "~/Images/pizzas/chicken-cheese-pizza.png",
                          ImageThumbnailPath = "~/Images/thumbnails/chicken-small.png",
                          InStock = true,
                          IsPizzaOfTheWeek = true,
                          LongDescription = "In a glass or plastic bowl, combine yeast, water, and sugar (the water can just be water from the tap, make sure it's below 100°F). Stir to dissolve the yeast and let the yeast bloom for 15 minutes. Stir in 1 cup flour, add salt, and then stir in another cup of flour (the remaining cup of flour will be your bench flour and added flour). Dump mixture onto kneading board and work in last cup of flour, kneading until dough is soft and elastic, but not sticky. Form dough into a ball. In another bowl, pour in the 1 tbsp olive oil and spread around. Coat ball of dough with oil and cover bowl with a damp towel and let dough rise for 40 minutes.",
                          Name = "Chicken Trio Pizza",
                          Price = 15.00m,
                          ShortDescription = "3 Chickens made it!"
                      },
                        new
                        {
                            PizzaId = 4,
                            AllergyInformation = "",
                            CategoryId = 1,
                            ImagePath = "~/Images/pizzas/chicken-cheese-pizza.png",
                            ImageThumbnailPath = "~/Images/thumbnails/chicken-small.png",
                            InStock = true,
                            IsPizzaOfTheWeek = false,
                            LongDescription = "In a glass or plastic bowl, combine yeast, water, and sugar (the water can just be water from the tap, make sure it's below 100°F). Stir to dissolve the yeast and let the yeast bloom for 15 minutes. Stir in 1 cup flour, add salt, and then stir in another cup of flour (the remaining cup of flour will be your bench flour and added flour). Dump mixture onto kneading board and work in last cup of flour, kneading until dough is soft and elastic, but not sticky. Form dough into a ball. In another bowl, pour in the 1 tbsp olive oil and spread around. Coat ball of dough with oil and cover bowl with a damp towel and let dough rise for 40 minutes.",
                            Name = "Chicken Trio Pizza",
                            Price = 18.95m,
                            ShortDescription = "3 Chickens made it!"
                        },
                          new
                          {
                              PizzaId = 5,
                              AllergyInformation = "",
                              CategoryId = 1,
                              ImagePath = "~/Images/pizzas/pepperoni-pizza.png",
                              ImageThumbnailPath = "~/Images/thumbnails/pepperoni-small.png",
                              InStock = true,
                              IsPizzaOfTheWeek = true,
                              LongDescription = "In a glass or plastic bowl, combine yeast, water, and sugar (the water can just be water from the tap, make sure it's below 100°F). Stir to dissolve the yeast and let the yeast bloom for 15 minutes. Stir in 1 cup flour, add salt, and then stir in another cup of flour (the remaining cup of flour will be your bench flour and added flour). Dump mixture onto kneading board and work in last cup of flour, kneading until dough is soft and elastic, but not sticky. Form dough into a ball. In another bowl, pour in the 1 tbsp olive oil and spread around. Coat ball of dough with oil and cover bowl with a damp towel and let dough rise for 40 minutes.",
                              Name = "Pepparoni Chedder Pizza",
                              Price = 17.50m,
                              ShortDescription = "Have a party with this Pizza!"
                          },
                            new
                            {
                                PizzaId = 6,
                                AllergyInformation = "",
                                CategoryId = 1,
                                ImagePath = "~/Images/pizzas/meat-pizza.png",
                                ImageThumbnailPath = "~/Images/thumbnails/meat-small.png",
                                InStock = true,
                                IsPizzaOfTheWeek = false,
                                LongDescription = "In a glass or plastic bowl, combine yeast, water, and sugar (the water can just be water from the tap, make sure it's below 100°F). Stir to dissolve the yeast and let the yeast bloom for 15 minutes. Stir in 1 cup flour, add salt, and then stir in another cup of flour (the remaining cup of flour will be your bench flour and added flour). Dump mixture onto kneading board and work in last cup of flour, kneading until dough is soft and elastic, but not sticky. Form dough into a ball. In another bowl, pour in the 1 tbsp olive oil and spread around. Coat ball of dough with oil and cover bowl with a damp towel and let dough rise for 40 minutes.",
                                Name = "Spicy Meat Pizza",
                                Price = 12.95m,
                                ShortDescription = "If you can handle spice!"
                            },
                              new
                              {
                                  PizzaId = 7,
                                  AllergyInformation = "",
                                  CategoryId = 1,
                                  ImagePath = "~/Images/pizzas/meat-pizza.png",
                                  ImageThumbnailPath = "~/Images/thumbnails/meat-small.png",
                                  InStock = true,
                                  IsPizzaOfTheWeek = true,
                                  LongDescription = "In a glass or plastic bowl, combine yeast, water, and sugar (the water can just be water from the tap, make sure it's below 100°F). Stir to dissolve the yeast and let the yeast bloom for 15 minutes. Stir in 1 cup flour, add salt, and then stir in another cup of flour (the remaining cup of flour will be your bench flour and added flour). Dump mixture onto kneading board and work in last cup of flour, kneading until dough is soft and elastic, but not sticky. Form dough into a ball. In another bowl, pour in the 1 tbsp olive oil and spread around. Coat ball of dough with oil and cover bowl with a damp towel and let dough rise for 40 minutes.",
                                  Name = "Spicy Meat Pizza",
                                  Price = 19.00m,
                                  ShortDescription = "Real Spice Real Pizza!"
                              },
                                new
                                {
                                    PizzaId = 8,
                                    AllergyInformation = "",
                                    CategoryId = 1,
                                    ImagePath = "~/Images/pizzas/veg-pizza.png",
                                    ImageThumbnailPath = "~/Images/thumbnails/veg-small.png",
                                    InStock = true,
                                    IsPizzaOfTheWeek = true,
                                    LongDescription = "In a glass or plastic bowl, combine yeast, water, and sugar (the water can just be water from the tap, make sure it's below 100°F). Stir to dissolve the yeast and let the yeast bloom for 15 minutes. Stir in 1 cup flour, add salt, and then stir in another cup of flour (the remaining cup of flour will be your bench flour and added flour). Dump mixture onto kneading board and work in last cup of flour, kneading until dough is soft and elastic, but not sticky. Form dough into a ball. In another bowl, pour in the 1 tbsp olive oil and spread around. Coat ball of dough with oil and cover bowl with a damp towel and let dough rise for 40 minutes.",
                                    Name = "Vegetarian Pizza",
                                    Price = 14.50m,
                                    ShortDescription = "We care about all!"
                                }
                    );
                });

            modelBuilder.Entity("core3._1_mvc_monolith.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount");

                    b.Property<int?>("PizzaId");

                    b.Property<string>("ShoppingCartId");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("PizzaId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("core3._1_mvc_monolith.Models.OrderDetail", b =>
                {
                    b.HasOne("core3._1_mvc_monolith.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("core3._1_mvc_monolith.Models.Pizza", "Pizza")
                        .WithMany()
                        .HasForeignKey("PizzaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("core3._1_mvc_monolith.Models.Pizza", b =>
                {
                    b.HasOne("core3._1_mvc_monolith.Models.Category", "Category")
                        .WithMany("Pizzas")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("core3._1_mvc_monolith.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("core3._1_mvc_monolith.Models.Pizza", "Pizza")
                        .WithMany()
                        .HasForeignKey("PizzaId");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
