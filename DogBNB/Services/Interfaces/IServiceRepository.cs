using DogBNB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogBNB.Services.Interfaces
{
    public interface IServiceRepository
    {
        public List<Sitter> GetSittersByService();
        public List<Service> GetSitterServices(int userId);
        public void AddService(Service service);
        public void DeleteService(int id);
    }
}
