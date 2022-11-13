using DogBNB.Models;

namespace DogBNB.Repositories.Interfaces
{
    public interface IChatRepository
    {
        public Chat AddChat(Chat chat);
        public Chat GetChatById(int id);
        public List<Message> GetAllChatMessages(int chatId);
        public List<Message> GetSenderMessages(int chatId, int senderId);
        public void DeleteChat(int id);
    }
}
