using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectFutureAdvannced.Extensions;
using ProjectFutureAdvannced.Models.Model;

namespace ProjectFutureAdvannced.Data
{
    public class AppDbContext:IdentityDbContext<Admin>
        {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Admin> admin { get; set; }
        public DbSet<Shop> shop { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<User> user { get; set; }

        public AppDbContext( DbContextOptions<AppDbContext> options ) : base(options)
            {
            }
        protected override void OnModelCreating( ModelBuilder modelBuilder )
            {
            modelBuilder.setRShipProduct_Shoper();
            modelBuilder.setRShipProduct_Category();
            modelBuilder.SetUniqueId();
            base.OnModelCreating(modelBuilder);
            modelBuilder.SetCategory();
            modelBuilder.setRShipProduct_Img();
            modelBuilder.SetSeedShop();
            modelBuilder.setUniqueName_Category();
            modelBuilder.setRShipShop_Category();
            }
        }
    }
