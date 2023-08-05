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
        }
    }
