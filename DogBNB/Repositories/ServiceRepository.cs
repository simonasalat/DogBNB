using DogBNB.Models;
using DogBNB.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogBNB.Repositories
{
    public class ServiceRepository : IServiceRepository
    {
        public void AddService(Service service)
        {
            throw new NotImplementedException();
        }

        public void DeleteService(int id)
        {
            throw new NotImplementedException();
        }

        public List<Sitter> GetSittersByService()
        {
            throw new NotImplementedException();
        }

        public List<Service> GetSitterServices(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
