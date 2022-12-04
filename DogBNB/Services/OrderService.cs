using DogBNB.Models;
using DogBNB.Repositories.Interfaces;
using DogBNB.Services.IServices;
using System.Collections.Generic;

namespace DogBNB.Services
{
    public class OrderService : IOrderService
    {
        
        private readonly IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public Order AddOrder(Order order) => _orderRepository.Add(order);

        public List<Order> GetOrders(string userId) => _orderRepository.GetOrders(userId);
        public void DeleteOrder(int id) => _orderRepository.DeleteOrder(id);
    }
}
