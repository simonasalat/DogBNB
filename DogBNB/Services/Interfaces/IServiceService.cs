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
        public List<Sitter> GetSittersByService();//KLAUSIMAS: Ar situs metodus daryt cia ir service repository ar tsg userio repositorijoj
        public List<Service> GetSitterServices(int userId);
        public void AddService(Service service);
        public void DeleteService(int id);
    }
}
