using DogBNB.Models;
using DogBNB.Repositories.Interfaces;
using DogBNB.Services.Interfaces;

namespace DogBNB.Services
{
    public class MessageService : IMessageService
    {
        private readonly IMessageRepository _messageRepository;
        public MessageService(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }
        public Message AddMessage(Message message) => _messageRepository.AddMessage(message);

        public void DeleteMessage(int id) => _messageRepository.DeleteMessage(id);
    }
}
