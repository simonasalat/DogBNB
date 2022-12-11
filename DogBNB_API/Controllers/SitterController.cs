using DogBNB.IServices;
using DogBNB.Models;
using DogBNB.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DogBNB_API.Controllers
{
    [Route("api/sitter")]
    [ApiController]
    public class SitterController : Controller
    {
        private readonly ISitterService _sitterService;

        public SitterController (ISitterService sitterService)
        {
            _sitterService = sitterService;
        }
        [HttpPost("create/{id}")]
        public Sitter CreateSitter([FromBody]Sitter sitter, int userId)
        {
            return _sitterService.CreateSitter(sitter, userId);
        }
        [HttpDelete("delete/{id}")]
        public void DeleteSitter(int id)
        {
            _sitterService.DeleteSitter(id);
        }
        [HttpGet("{id}")]
        public Sitter GetSitterById(int id)
        {
            return _sitterService.GetSitterById(id);
        }
        [HttpGet]
        public List<Sitter> GetSitters()
        {
            return _sitterService.GetSitters();
        }
        [HttpPut("edit/{id}")]
        public Sitter UpdateSitter([FromBody]Sitter sitter, int id)
        {
            return _sitterService.UpdateSitter(sitter, id);
        }
    }
}
