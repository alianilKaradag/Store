using Entities.Models;

namespace Services.Contracts
{
    public interface IOrderService
    {
         public IQueryable<Order> Orders { get; }   
        public Order? GetOneOrder(int id);
        public void Complete(int id);
        public void SaveOrder(Order order);
        public int NumberOfInProcess {get; }
    }
}