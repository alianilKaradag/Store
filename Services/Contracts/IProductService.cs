using Entities.Dtos;
using Entities.Models;

namespace Services.Contracts
{
    public interface IProductService
    {
        public IEnumerable<Product> GetAllProducts(bool trackChanges);
        public Product? GetOneProduct(int id, bool trackChanges);

        public void CreateProduct(ProductDtoForInsertion product);
        public void UpdateOneProduct(Product product);

        public void DeleteOneProduct(int id);
    }
}