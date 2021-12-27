using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Playground.Data
{
    public class WebApiDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        

        public WebApiDbContext(DbContextOptions<WebApiDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // if (Database.EnsureCreated()) return;
            modelBuilder.Entity<Employee>().Property(p => p.Balance).HasColumnType("decimal(18,4)");
            modelBuilder.Entity<Customer>().Property(p => p.Balance).HasColumnType("decimal(18,4)");
            modelBuilder.Entity<Employee>().HasData(new Employee(2, "egor", "cooleshov"));
            modelBuilder.Entity<Employee>().HasData(new Employee(1, "lazy", "Jonny"));
            modelBuilder.Entity<Customer>().HasData(new Customer(2, "big", "dyadya", 1000m));
            modelBuilder.Entity<Customer>().HasData(new Customer(1, "poor", "guy", 100m));
        }
    }
}