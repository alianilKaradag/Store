using Entities.Models;
using Entities.RequestParameters;

namespace Repositories.Contracts
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        public IQueryable<Product> GetAllProducts(bool trackChanges);
        public IQueryable<Product> GetAllProductsWithDetails(ProductRequestParameters p);
        public IQueryable<Product> GetShowcaseProducts(bool trackChanges);
        public Product? GetOneProduct(int id, bool trackChanges);
        public void CreateOneProduct(Product product);
        public void DeleteOneProduct(Product product);
        void UpdateOneProduct(Product entity);
    }
}