using DogBNB.Models;
using DogBNB.Repositories.Interfaces;
using DogBNB_Db;

namespace DogBNB.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DogBNBDbContext _context;
        public OrderRepository(DogBNBDbContext context)
        {
            _context = context;
        }
        public OrderRepository()
        {

        }

        public Order Add(Order order)
        {
            var service = new DogBNB_Db.Entities.Service
            {

                Id = order.Service.Id,
                ServiceType = order.Service.ServiceType.ToString(),
                Price = order.Price
            };

            var o = new DogBNB_Db.Entities.Order
            {
                SitterId = order.SitterId,
                DogId = order.DogId,
                Price = order.Price,
                Service = service,
                StartDate = order.StartDate,
                EndDate = order.EndDate
            };

            _context.Orders.Add(o);
            _context.SaveChanges();

            return order;
        }

        public List<Order> GetOrders(string userId)
        {
            var list = _context.Orders.Where(x => (x.SitterId == userId || x.DogId == userId)).ToList();

            var orders = new List<Order>();
            foreach (var item in list)
            {
                _ = Enum.TryParse(item.Service.ServiceType, out ServiceType serviceType);
                
                var service = new Service {

                    Id = item.Service.Id,
                    ServiceType = serviceType,
                    Price = item.Price
                };

                var o = new Order
                {
                    Id = item.Id,
                    SitterId = item.SitterId,
                    DogId = item.DogId,
                    Price = item.Price,
                    Service = service,
                    StartDate = item.StartDate,
                    EndDate = item.EndDate
                };
                orders.Add(o);
            }

            return orders;
        }

        public void DeleteOrder(int id)
        {
            var order = _context.Orders.Where(x => x.Id == id).First();
            _context.Orders.Remove(order);
            _context.SaveChanges();
        }
    }
}
