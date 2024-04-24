using Entities.Dtos;
using Entities.Models;
using Entities.RequestParameters;

namespace Services.Contracts
{
    public interface IProductService
    {
        public IEnumerable<Product> GetAllProducts(bool trackChanges);
        public IEnumerable<Product> GetAllProductsWithDetails(ProductRequestParameters p);
        public IEnumerable<Product> GetShowcaseProducts(bool trackChanges);
        public Product? GetOneProduct(int id, bool trackChanges);

        public void CreateProduct(ProductDtoForInsertion productDto);
        public void UpdateOneProduct(ProductDtoForUpdate productDto);

        public void DeleteOneProduct(int id);
        ProductDtoForUpdate GetOneProductForUpdate(int id, bool trackChanges);
    }
}