namespace MicroSvc.Product.Infrastructure
{
    using Microsoft.EntityFrameworkCore;

    using MicroSvc.Product.Domain.Entities;

    using System;
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product() { Id = Guid.NewGuid(), Name = "Caco-cala", Company = "The Caco-cala ltd", Stock = 9000 },
                new Product() { Id = Guid.NewGuid(), Name = "Indie-mie", Company = "Indiemie ltd", Stock = 1500 },
                new Product() { Id = Guid.NewGuid(), Name = "Galus Mix", Company = "PT Torubaka", Stock = 756 },
                new Product() { Id = Guid.NewGuid(), Name = "Katas-Katas", Company = "PT Sehat walafiat", Stock = 75 }
                );
        }
    }
}
