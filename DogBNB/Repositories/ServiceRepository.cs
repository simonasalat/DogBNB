using DogBNB.Models;
using DogBNB.Repositories.Interfaces;
using DogBNB_Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogBNB.Repositories
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly DogBNBDbContext _context;
        public ServiceRepository(DogBNBDbContext context)
        {
            _context = context;
        }
        public ServiceRepository()
        {

        }
        public Service AddService(Service service)
        {
            var s = new DogBNB_Db.Entities.Service
            {
                UserId = service.UserId,
                ServiceType = service.ServiceType.ToString(),
                Price=service.Price

            };

            _context.Services.Add(s);
            _context.SaveChanges();

            return service;
        }

        public string DeleteService(int id)
        {
            var service = _context.Services.Where(x => x.ServiceId == id).First();
            _context.Services.Remove(service);
            _context.SaveChanges();
            return "Service was deleted successfully";
        }

        public List<Sitter> GetSittersByService(string serviceType)
        {
            var userList = _context.Services.Where(st => st.ServiceType == serviceType).Select(st => st.UserId).ToList();
            var users = _context.Users.Where(s => userList.Contains(s.UserId)).ToList();
            var sitters = _context.Sitters.Where(s => userList.Contains(s.UserId)).ToList();
            var result=new List<Sitter>();
            foreach(var user in users)
            {
                foreach(var s in sitters)
                {
                    if(s.UserId==user.UserId)
                    {
                        var sitter = new Sitter
                        {
                            Id=s.SitterId,
                            Name = user.Name,
                            Surname = user.Surname,
                            Email = user.Email,
                            Phone = user.Phone,
                            Description=s.Description
                        };
                        result.Add(sitter);
                    }
                }
            }
            return result;
        }

        public List<Service> GetSitterServices(int userId)
        {
           var services = _context.Services.Where(s => s.UserId == userId).ToList();
            var result = new List< Service > ();

            foreach(var service in services)
            {
                _ = Enum.TryParse(service.ServiceType, out ServiceType st);
                var s = new Service
                {
                    Id=service.ServiceId,
                    UserId = userId,
                    ServiceType = st,
                    Price = service.Price


                };
                result.Add(s);
            }
            return result;
        }
    }
}
