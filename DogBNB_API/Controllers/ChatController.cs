using DogBNB.Models;
using DogBNB.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DogBNB_API.Controllers
{
    [Route("api/chat")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        private readonly IChatService _chatService;

        public ChatController(IChatService chatService)
        {
            _chatService = chatService;
        }

        [HttpGet("{id}")]
        public Chat GetChatById(int id)
        {
            return _chatService.GetChatById(id);
        }

        [HttpGet("{id}/messages")]
        public List<Message> GetOwnerDogs(int id)
        {
            return _chatService.GetAllChatMessages(id);
        }

        [HttpPost]
        public Chat AddChat([FromBody] Chat chat)
        {
            return _chatService.AddChat(chat);
        }

        [HttpDelete("delete/{id}")]
        public string DeleteChat(int id)
        {
            _chatService.DeleteChat(id);
            return "Chat deleted successfully";
        }
    }
}

