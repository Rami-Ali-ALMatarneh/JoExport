using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ProjectFutureAdvannced.Models.Enums;
using ProjectFutureAdvannced.Models.Model;
using System.Net.Mail;
using System.Numerics;

namespace ProjectFutureAdvannced.Extensions
{
    public static class ModelBuilderExtension
        {
        public static void SetUniqueId( this ModelBuilder modelBuilder )
            {
            modelBuilder.Entity<Admin>().HasIndex(x => x.AdminId).IsUnique();
            /****************************************************************/
            modelBuilder.HasSequence<int>("UniqueAdminId").StartsAt(1).IncrementsBy(1);
            modelBuilder.Entity<Admin>().Property(e => e.AdminId).HasDefaultValueSql("NEXT VALUE FOR UniqueAdminId");
            }

        public static void setRShipProduct_Shoper( this ModelBuilder modelBuilder ) {

            modelBuilder.Entity<Product>()
                    .HasOne(e => e.shop)
                    .WithMany(e => e.products)
                    .HasPrincipalKey(e => e.Id)
                    .HasForeignKey(e => e.ShoperId);

            }
        public static void setRShipShop_Category( this ModelBuilder modelBuilder )
            {
            modelBuilder.Entity<Shop>()
           .HasOne(shop => shop.category)
           .WithOne(category => category.shop)
           .HasForeignKey<Shop>(shop => shop.CategorysType)
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
        public static void setUniqueName_Category( this ModelBuilder modelBuilder )
            {
            modelBuilder.Entity<Category>()
                   .HasIndex(e => e.Name)
                   .IsUnique();
            }
        public static void setRShipProduct_Img( this ModelBuilder modelBuilder )
            {
            modelBuilder.Entity<Product>()
                   .HasMany(e => e.Imgs)
                   .WithOne(e => e.Product)
                   .HasForeignKey(e => e.productId);
            }
        public static void SetSeedShop( this ModelBuilder modelBuilder )
            {
            modelBuilder.Entity<Shop>().HasData(new Shop
                {
                Id=1,
                ShopName="BMW",
                EmailAddress="bmw1@gmail.com",
                Password="bmwcar12345@",
                ConfirmPassword= "bmwcar12345@",
                TypeOfUser=TypeOfUser.Shop,
                phone="776924478",
                imgShop="bmw.jpg",
                CategorysType = Categorys.Cars,
                });
            modelBuilder.Entity<Shop>().HasData(new Shop
                {
                Id = 2,
                ShopName = "Hp",
                EmailAddress = "hp1@gmail.com",
                Password = "hpElectronic12345@",
                ConfirmPassword = "hpElectronic12345@",
                TypeOfUser = TypeOfUser.Shop,
                phone = "776924478",
                imgShop = "hp.jpg",
                CategorysType = Categorys.Electronic,
                });
            modelBuilder.Entity<Shop>().HasData(new Shop
                {
                Id = 3,
                ShopName = "Adidas",
                EmailAddress = "Adidas@gmail.com",
                Password = "Adidas12345@",
                ConfirmPassword = "Adidas12345@",
                TypeOfUser = TypeOfUser.Shop,
                phone = "7888888888",
                imgShop = "Adidas.jpg",
                CategorysType = Categorys.Sport_Fitness,

                });
            modelBuilder.Entity<Shop>().HasData(new Shop
                {
                Id = 4,
                ShopName = "IKEA",
                EmailAddress = "IKEA@gmail.com",
                Password = "IKEA123456@",
                ConfirmPassword = "IKEA123456@",
                TypeOfUser = TypeOfUser.Shop,
                phone = "776924478",
                imgShop = "IKEA.jpg",
                CategorysType = Categorys.Home,
                });
            modelBuilder.Entity<Shop>().HasData(new Shop
                {
                Id = 5,
                ShopName = "LOREAL",
                EmailAddress = "LOREAL@gmail.com",
                Password = "LOREAL12345",
                ConfirmPassword = "LOREAL12345",
                TypeOfUser = TypeOfUser.Shop,
                phone = "776924458",
                imgShop = "LOreal.jpg",
                CategorysType = Categorys.Beauty,

                });
            modelBuilder.Entity<Shop>().HasData(new Shop
                {
                Id = 6,
                ShopName = "BABY2BABY",
                EmailAddress = "BABY2BABY@gmail.com",
                Password = "BABY2BABY123",
                ConfirmPassword = "BABY2BABY123",
                TypeOfUser = TypeOfUser.Shop,
                phone = "776924478",
                imgShop = "baby2baby.jpg",
                CategorysType = Categorys.Baby_Kids,

                });
            }
        public static void SetCategory(this ModelBuilder modelBuilder) {
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
