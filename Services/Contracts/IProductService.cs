using Entities.Models;

namespace Services.Contracts
{
    public interface IProductService
    {
        public IEnumerable<Product> GetAllProducts(bool trackChanges);
        public Product? GetOneProduct(int id, bool trackChanges);

        public void CreateProduct(Product product);
        public void UpdateOneProduct(Product product);
    }
}