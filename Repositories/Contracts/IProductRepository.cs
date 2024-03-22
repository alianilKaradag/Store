using Entities.Models;

namespace Repositories.Contracts
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
         public IQueryable<Product> GetAllProducts(bool trackChanges);
         public Product? GetOneProduct(int id, bool trackChanges);
         public void CreateOneProduct(Product product);
        public void DeleteOneProduct(Product product);
    }
}