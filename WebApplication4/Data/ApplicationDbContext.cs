using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplication4.Models;

namespace WebApplication4.Data
{
    public class ApplicationDbContext : IdentityDbContext<UserName>
    {
       
        public DbSet<Kategori> Kategoris { get; set; }
       
        public DbSet<UserName>userNames { get; set; }
        public DbSet<Berber> berbers { get; set; }
        public DbSet<Ogrenci> ogrenci{ get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasDefaultSchema("berbers");
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<WebApplication4.Models.Randevum> Randevum { get; set; }
        public DbSet<WebApplication4.Models.deneme> deneme { get; set; }
    }
}
