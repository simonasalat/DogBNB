using DogBNB.Models;
using DogBNB.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DogBNB_API.Controllers
{
    [Route("api/service")]
    [ApiController]
    public class ServiceController : Controller
    {

        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        [HttpPost]
        public Service AddService([FromBody]Service service)
        {
            return _serviceService.AddService(service);
        }
        [HttpDelete("delete/{id}")]
        public string DeleteService(int id)
        {
            return _serviceService.DeleteService(id);
        }
        [HttpGet("sitters-by-service/{serviceType}")]
        public List<Sitter> GetSittersByService(string serviceType)
        {
            return _serviceService.GetSittersByService(serviceType);
        }
        [HttpGet("{userId}")]
        public List<Service> GetSitterServices(int userId)
        {
            return _serviceService.GetSitterServices(userId);
        }
    }
}
