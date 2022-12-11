using DogBNB.Models;
using DogBNB.Repositories.Interfaces;
using DogBNB.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogBNB.Services
{
    public class ServiceService : IServiceService
    {

        private readonly IServiceRepository _serviceRepository;
        public ServiceService(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }
        public Service AddService(Service service)
        {
            return _serviceRepository.AddService(service);
        }

        public string DeleteService(int id)
        {
            return _serviceRepository.DeleteService(id);
        }

        public List<Sitter> GetSittersByService(string serviceType)
        {
            return _serviceRepository.GetSittersByService(serviceType);
        }

        public List<Service> GetSitterServices(int userId)
        {
            return _serviceRepository.GetSitterServices(userId);
        }
    }
}
