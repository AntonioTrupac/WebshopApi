using System;
using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Infrastructure
{
    public class ChristmasDbContext : DbContext
    {
        public ChristmasDbContext(DbContextOptions<ChristmasDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set;}
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
        
}

