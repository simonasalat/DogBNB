using DogBNB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogBNB.Services.Interfaces
{
    public interface IServiceService
    {
        public List<Sitter> GetSittersByService(string serviceType);//KLAUSIMAS: Ar situs metodus daryt cia ir service repository ar tsg userio repositorijoj
        public List<Service> GetSitterServices(int userId);
        public Service AddService(Service service);
        public String DeleteService(int id);
    }
}
