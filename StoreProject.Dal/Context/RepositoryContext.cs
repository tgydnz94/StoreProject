using Microsoft.EntityFrameworkCore;
using StoreProject.Dal.Config;
using StoreProject.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
            optionsBuilder.UseSqlServer("Server=DESKTOP-8EHVPE9\\SQLEXPRESS;Database=StoreProject;Trusted_Connection=True; Encrypt=False;");
        }




        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ProductConfig());
            modelBuilder.ApplyConfiguration(new CategoryConfig());
        }



    }
}
