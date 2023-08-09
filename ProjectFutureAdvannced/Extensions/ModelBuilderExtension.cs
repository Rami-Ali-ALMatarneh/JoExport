using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ProjectFutureAdvannced.Models.Enums;
using ProjectFutureAdvannced.Models.Model;
using ProjectFutureAdvannced.Models.Model.AccountUser;
using System.Net.Mail;
using System.Numerics;

namespace ProjectFutureAdvannced.Extensions
{
    public static class ModelBuilderExtension
        {
        public static void CreateTable( this ModelBuilder modelBuilder )
            {
            modelBuilder.Entity<Admin>(entity => { entity.ToTable("Admin"); });
            modelBuilder.Entity<Shop>(entity => { entity.ToTable("Shop"); });
            modelBuilder.Entity<User>(entity => { entity.ToTable("User"); });
            }
        public static void SetSeedRoles( this ModelBuilder modelBuilder )
            {
            var roles = new List<string>
                {
                "Admin",
                "User",
                "Shop"
                };
            foreach (var roleName in roles)
                {
                modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
                    {
                    Id = Guid.NewGuid().ToString(),
                    Name = roleName,
                    NormalizedName = roleName.ToUpper()
                    });
                }
            }
        public static void setUniqueName_Category( this ModelBuilder modelBuilder )
            {
            modelBuilder.Entity<Category>()
                   .HasIndex(e => e.Name)
                   .IsUnique();
            }
        public static void setRShipShop_Category( this ModelBuilder modelBuilder )
            {
            modelBuilder.Entity<Shop>()
           .HasOne(shop => shop.Category)
           .WithOne(category => category.shop)
           .HasForeignKey<Shop>(shop => shop.CategoryName)
           .HasPrincipalKey<Category>(category => category.Name);
            }
        public static void setRShipProduct_Category( this ModelBuilder modelBuilder )
            {

            modelBuilder.Entity<Product>()
                    .HasOne(e => e.category)
                    .WithMany(e => e.Products)
                    .HasPrincipalKey(e => e.Id)
                    .HasForeignKey(e => e.CategoryId);
            }
        public static void setRShipProduct_Shoper( this ModelBuilder modelBuilder )
            {

            modelBuilder.Entity<Product>()
                    .HasOne(e => e.shop)
                    .WithMany(e => e.Products)
                    .HasPrincipalKey(e => e.Id)
                    .HasForeignKey(e => e.ShoperId);
            }
        public static void SetSeedCategory( this ModelBuilder modelBuilder )
            {
            modelBuilder.Entity<Category>().HasData(new Category
                {
                Id = 1,
                Name = Categorys.Cars,
                CategoryImg = "cars.png",
                });
            modelBuilder.Entity<Category>().HasData(new Category
                {
                Id = 2,
                Name = Categorys.Electronic,
                CategoryImg = "Electronic.png",
                });
            modelBuilder.Entity<Category>().HasData(new Category
                {
                Id = 3,
                Name = Categorys.Home,
                CategoryImg = "home.png",
                });
            modelBuilder.Entity<Category>().HasData(new Category
                {
                Id = 4,
                Name = Categorys.Baby_Kids,
                CategoryImg = "Baby.png",
                });
            modelBuilder.Entity<Category>().HasData(new Category
                {
                Id = 5,
                Name = Categorys.Beauty,
                CategoryImg = "Beauty.png",
                });
            modelBuilder.Entity<Category>().HasData(new Category
                {
                Id = 6,
                Name = Categorys.Clothes,
                CategoryImg = "Clothes.png",
                });
            modelBuilder.Entity<Category>().HasData(new Category
                {
                Id = 7,
                Name = Categorys.Bags,
                CategoryImg = "Bags.png",
                });
            modelBuilder.Entity<Category>().HasData(new Category
                {
                Id = 8,
                Name = Categorys.Books,
                CategoryImg = "Books.png",
                });
            modelBuilder.Entity<Category>().HasData(new Category
                {
                Id = 9,
                Name = Categorys.Health_and_Personal_Care,
                CategoryImg = "Health.png",
                });
            modelBuilder.Entity<Category>().HasData(new Category
                {
                Id = 10,
                Name = Categorys.Jewelry,
                CategoryImg = "Jewelry.png",
                });
            modelBuilder.Entity<Category>().HasData(new Category
                {
                Id = 11,
                Name = Categorys.pets,
                CategoryImg = "pets.png",
                });
            modelBuilder.Entity<Category>().HasData(new Category
                {
                Id = 12,
                Name = Categorys.Sport_Fitness,
                CategoryImg = "Sport.png",
                });
            }
         }
    }
