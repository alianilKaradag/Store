using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;

namespace Repositories
{
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public IQueryable<Order> Orders => _context.Orders
                    .Include(x=> x.Lines)
                    .ThenInclude(x=> x.Product)
                    .OrderBy(x=> x.Shipped)
                    .ThenByDescending(x=> x.OrderId);

        public int NumberOfInProcess => _context.Orders.Count(x=>x.Shipped.Equals(false));

        public OrderRepository(RepositoryContext context) : base(context)
        {
            
        }

        public void Complete(int id)
        {
            var order = FindByCondition(x=> x.OrderId.Equals(id), true);
            if (order is null) throw new Exception("Order could not found!");

            order.Shipped = true;
        }

        public Order? GetOneOrder(int id)
        {
            return FindByCondition(x=> x.OrderId.Equals(id), false);
        }

        public void SaveOrder(Order order)
        {
            _context.AttachRange(order.Lines.Select(x=> x.Product));
            if (order.OrderId == 0) _context.Orders.Add(order);
            _context.SaveChanges();
        }
    }
}