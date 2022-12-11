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
        public Dog GetDog(int id)
        {
            return _dogService.GetDogById(id);
        }

        [HttpGet("owner={id}")]
        public List<Dog> GetOwnerDogs(int ownerId)
        {
            return _dogService.GetDogList(ownerId);
        }

        [HttpPost]
        public Dog AddDog([FromBody]Dog dog)
        {
            return _dogService.AddDog(dog);
        }

        [HttpDelete("delete/{id}")]
        public string DeleteDog(int id)
        {
            _dogService.DeleteDog(id);
            return "Dog deleted successfully";
        }
        [HttpPut("edit/{id}")]
        public void EditDog(int id, [FromBody] Dog newDog)
        {
            _dogService.EditDog(id, newDog);
        }
    }
}
