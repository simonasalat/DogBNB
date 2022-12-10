
using DogBNB.Models;
using DogBNB.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DogBNB_API.Controllers
{
    [Route("api/message")]
    [ApiController]
    public class MessageController : Controller
    {
        private readonly IMessageService _messageService;

        public MessageController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        [HttpPost]
        public Message AddMessage([FromBody] Message message)
        {
            return _messageService.AddMessage(message);
        }

        [HttpDelete("delete/{id}")]
        public string Delete(int id)
        {
            _messageService.DeleteMessage(id);
            return "Message deleted successfully";
        }
        
    }
}
