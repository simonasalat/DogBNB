using DogBNB.Models;
using DogBNB.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace DogBNB_API.Controllers
{
    [Route("api/order")]
    [ApiController]
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("{id}")]
        public List<Order> GetOrders(int id)
        {
            return _orderService.GetOrders(id);
        }

        [HttpPost]
        public Order AddOrder([FromBody] Order order)
        {
            return _orderService.AddOrder(order);
        }

        [HttpDelete("delete/{id}")]
        public string DeleteOrder(int id)
        {
            _orderService.DeleteOrder(id);
            return "Order deleted successfully";
        }
    }
}
