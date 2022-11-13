using DogBNB.Models;
using DogBNB.Repositories.Interfaces;
using DogBNB.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogBNB.Services
{
    public class ChatService : IChatService
    {
        private readonly IChatRepository _chatRepository;
        public ChatService(IChatRepository chatRepository)
        {
            _chatRepository = chatRepository;
        }
        public Chat AddChat(Chat chat) => _chatRepository.AddChat(chat);

        public void DeleteChat(int id) => _chatRepository.DeleteChat(id);

        public List<Message> GetAllChatMessages(int chatId) => _chatRepository.GetAllChatMessages(chatId);  

        public Chat GetChatById(int id) => _chatRepository.GetChatById(id);

        public List<Message> GetSenderMessages(int chatId, int senderId) => _chatRepository.GetSenderMessages(chatId, senderId);
    }
}
