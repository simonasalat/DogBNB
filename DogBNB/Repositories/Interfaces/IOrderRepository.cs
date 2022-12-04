using DogBNB.Models;
using System.Collections.Generic;

namespace DogBNB.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        public Order Add(Order order);

        public List<Order> GetOrders(string userId);

        public void DeleteOrder(int id);
    }
}
