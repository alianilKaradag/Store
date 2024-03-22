using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=> x.ProductName).IsRequired();
            builder.Property(x=> x.Price).IsRequired();
            
            builder.HasData(
                new Product() { Id = 1, CategoryId = 2, ProductName = "Computer", Price = 17_000 },
                new Product() { Id = 2, CategoryId = 2, ProductName = "Keyboard", Price = 1_000 },
                new Product() { Id = 3, CategoryId = 2, ProductName = "Mouse", Price = 500 },
                new Product() { Id = 4, CategoryId = 2, ProductName = "Monitor", Price = 7_000 },
                new Product() { Id = 5, CategoryId = 2, ProductName = "Deck", Price = 1_500 },
                new Product() { Id = 6, CategoryId = 1, ProductName = "History", Price = 50 },
                new Product() { Id = 7, CategoryId = 1, ProductName = "Hamlet", Price = 75 }

            );
        }
    }
}