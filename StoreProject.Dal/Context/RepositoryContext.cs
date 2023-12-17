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

        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {
        }



        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasKey(a => a.Id);
            modelBuilder.Entity<Product>().
                HasData(
                new Product() { Id = 1, Name = "Bilgisayar", Price = 8000 }
                );
            modelBuilder.Entity<Category>().HasData(
                new Category() { ID = 1, CategoryName = "Elektronik" }
                );
        }

        
    }
}
