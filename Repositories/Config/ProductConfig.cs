using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.ProductId);
            builder.Property(x=> x.ProductName).IsRequired();
            builder.Property(x=> x.Price).IsRequired();
            
            builder.HasData(
                new Product() { ProductId = 1, CategoryId = 2, ImageUrl="/images/computer.jpg", ProductName = "Computer", Price = 17_000, ShowCase = false },
                new Product() { ProductId = 2, CategoryId = 2, ImageUrl="/images/keyboard.jpg", ProductName = "Keyboard", Price = 1_000, ShowCase = false },
                new Product() { ProductId = 3, CategoryId = 2, ImageUrl="/images/mouse.jpg", ProductName = "Mouse", Price = 500, ShowCase = false },
                new Product() { ProductId = 4, CategoryId = 2, ImageUrl="/images/monitor.jpg", ProductName = "Monitor", Price = 7_000, ShowCase = false },
                new Product() { ProductId = 5, CategoryId = 2, ImageUrl="/images/deck.jpg", ProductName = "Deck", Price = 1_500, ShowCase = false },
                new Product() { ProductId = 6, CategoryId = 1, ImageUrl="/images/history.jpg", ProductName = "History", Price = 50, ShowCase = false },
                new Product() { ProductId = 7, CategoryId = 1, ImageUrl="/images/hamlet.jpg", ProductName = "Hamlet", Price = 75, ShowCase = false },
                new Product() { ProductId = 8, CategoryId = 1, ImageUrl="/images/hamlet.jpg", ProductName = "XP-Pen", Price = 765, ShowCase = true },
                new Product() { ProductId = 9, CategoryId = 2, ImageUrl="/images/hamlet.jpg", ProductName = "Galaxy FE", Price = 10555, ShowCase = true },
                new Product() { ProductId = 10, CategoryId = 1, ImageUrl="/images/hamlet.jpg", ProductName = "HP Mouse", Price = 750, ShowCase = true }

            );
        }
    }
}