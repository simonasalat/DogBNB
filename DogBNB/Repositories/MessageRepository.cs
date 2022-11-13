using DogBNB.Models;
using DogBNB.Repositories.Interfaces;
using DogBNB_Db;

namespace DogBNB.Repositories
{
    public class MessageRepository : IMessageRepository
    {
        private readonly DogBNBDbContext _context;
        public MessageRepository(DogBNBDbContext context)
        {
            _context = context;
        }
        public MessageRepository()
        {

        }
        public Message AddMessage(Message message)
        {
            var m = new DogBNB_Db.Entities.Message
            {
                SenderId = message.SenderId,
                ChatId = message.ChatId,
                Date = message.Date,
                Text = message.Text,
            };

            _context.Messages.Add(m);
            _context.SaveChanges();

            return message;
        }

        public void DeleteMessage(int id)
        {
            var message = _context.Messages.Where(x => x.Id == id).First();
            _context.Messages.Remove(message);
            _context.SaveChanges();
        }
    }
}
