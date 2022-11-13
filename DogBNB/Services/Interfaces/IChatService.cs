using DogBNB.Models;

namespace DogBNB.Services.Interfaces
{
    public interface IChatService
    {
        public Chat AddChat(Chat chat);
        public Chat GetChatById(int id);
        public List<Message> GetAllChatMessages(int chatId);
        public List<Message> GetSenderMessages(int chatId, int senderId);
        public void DeleteChat(int id);
    }
}
