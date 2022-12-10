using DogBNB.IServices;
using DogBNB.Models;
using Microsoft.AspNetCore.Mvc;

namespace DogBNB_API.Controllers
{
    [Route("api/dog")]
    [ApiController]
    public class DogController : ControllerBase
    {
        private readonly IDogService _dogService;

        public DogController(IDogService dogService)
        {
            _dogService = dogService;
        }

        [HttpGet]
        public List<Dog> GetDogs()
        {
            return _dogService.GetAllDogs();
        }

        [HttpGet("{id}")]
        public Dog GetDog(string id)
        {
            return _dogService.GetDogById(id);
        }

        [HttpPost]
        public Dog AddDog([FromBody]Dog dog)
        {
            return _dogService.AddDog(dog);
        }

        //[HttpDelete("delete/{id}")]
        //public string DeleteDog(string id)
        //{
        //    _dogService.DeleteDog(id);
        //    return "dog deleted successfully";
        //}
    }
}
