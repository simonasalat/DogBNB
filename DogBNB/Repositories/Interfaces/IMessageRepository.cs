using DogBNB.Models;
namespace DogBNB.Repositories.Interfaces
{
    public interface IMessageRepository
    {
        public Message AddMessage(Message message);
        public void DeleteMessage(int id);

    }
}
