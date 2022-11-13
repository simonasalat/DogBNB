using DogBNB.Models;

namespace DogBNB.Services.Interfaces
{
    public interface IMessageService
    {
        public Message AddMessage(Message message);
        public void DeleteMessage(int id);
    }
}
