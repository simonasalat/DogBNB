using DogBNB.Models;
using System.Collections.Generic;

namespace DogBNB.Services.IServices
{
    public interface IOrderService
    {
        public Order AddOrder(Order order);

        public List<Order> GetOrders(string userId);

        public void DeleteOrder(int id);
    }
}
