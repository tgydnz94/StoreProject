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

        //public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        //{
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-8EHVPE9\\SQLEXPRESS;Database=StoreApp;Trusted_Connection=True;");
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasKey(a => a.Id);
            modelBuilder.Entity<Product>().
                HasData(
                new Product() { Id = 1, Name = "Bilgisayar", Price = 8000 }
                );
        }

        
    }
}
