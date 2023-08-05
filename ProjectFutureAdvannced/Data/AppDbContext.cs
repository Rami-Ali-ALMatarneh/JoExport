﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectFutureAdvannced.Extensions;
using ProjectFutureAdvannced.Models.Model;

namespace ProjectFutureAdvannced.Data
{
    public class AppDbContext:IdentityDbContext
        {
        public DbSet<Admin> Admin { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Shop> Shop { get; set; }
        public AppDbContext( DbContextOptions<AppDbContext> options ) : base(options)
            {
            }
        protected override void OnModelCreating( ModelBuilder modelBuilder )
            {
            base.OnModelCreating(modelBuilder);
            modelBuilder.CreateTable();
            modelBuilder.SetSeedRoles();
            }
        }
    }