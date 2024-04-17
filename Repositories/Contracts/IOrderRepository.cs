using Entities.Models;

namespace Repositories.Contracts
{
    public interface IOrderRepository
    {
        public IQueryable<Order> Orders { get; }   
        public Order? GetOneOrder(int id);
        public void Complete(int id);
        public void SaveOrder(Order order);
        public int NumberOfInProcess {get; }
    }
}