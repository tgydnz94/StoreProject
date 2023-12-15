using Microsoft.EntityFrameworkCore;
using StoreProject.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Dal.Context
{
    public class RepositoryContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {
        }

        public DbSet<Product> products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().
                HasData(
                new Product() { Id = 1, Name = "Bilgisayar", Price = 8000 }
                );
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-8EHVPE9\\SQLEXPRESS;Database=StoreApp;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
