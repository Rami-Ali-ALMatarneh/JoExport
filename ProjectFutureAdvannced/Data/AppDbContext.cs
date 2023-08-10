using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectFutureAdvannced.Extensions;
using ProjectFutureAdvannced.Models.Model;
using ProjectFutureAdvannced.Models.Model.AccountUser;

namespace ProjectFutureAdvannced.Data
{
    public class AppDbContext:IdentityDbContext<Account>
        {
        public DbSet<Admin> Admin { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Shop> Shop { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> products  { get; set; }
        public DbSet<ProductImg> productImgs { get; set; }

        public AppDbContext( DbContextOptions<AppDbContext> options ) : base(options)
            {
            }
        protected override void OnModelCreating( ModelBuilder modelBuilder )
            {
            base.OnModelCreating(modelBuilder);
            modelBuilder.CreateTable();
            modelBuilder.SetSeedRoles();
            modelBuilder.setUniqueName_Category();
            modelBuilder.setRShipShop_Category();
            modelBuilder.setRShipProduct_Shoper();
            modelBuilder.SetSeedCategory();
            }
        }
    }
