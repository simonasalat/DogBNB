using DogBNB.Models;
using DogBNB.Repositories.Interfaces;
using DogBNB_Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogBNB.Repositories
{
    public class ChatRepository : IChatRepository
    {
        private readonly DogBNBDbContext _context;
        public ChatRepository(DogBNBDbContext context)
        {
            _context = context;
        }
        public ChatRepository()
        {

        }
        public void DeleteChat(int id)
        {
            var chat = _context.Chats.Where(x => x.ChatId == id).First();
            var messages = _context.Messages.Where(x => x.ChatId == id);
           
            foreach(var message in messages)
            {
                _context.Messages.Remove(message);
            }
            _context.Chats.Remove(chat);

            _context.SaveChanges();
        }

        public List<Message> GetAllChatMessages(int chatId)
        {
            var list = _context.Messages.Where(x => x.ChatId == chatId).ToList();

            var messages = new List<Message>();

            foreach (var item in list)
            {
                var message = new Message
                {
                    Id = item.MessageId,
                    SenderId = item.SenderId,
                    ChatId = item.ChatId,
                    Date = item.Date,
                    Text = item.Text,
                };
                messages.Add(message);
            }

            return messages;
        }

        public Chat GetChatById(int id)
        {
            var c = _context.Chats.Where(x => x.ChatId == id).First();

            var chat = new Chat
            {
                Id = c.ChatId,
                SitterId = c.SitterId,
                OwnerId = c.OwnerId,
                ChatName = c.ChatName
            };

            return chat;
        }

        public List<Message> GetSenderMessages(int chatId, int senderId)
        {
            var list = _context.Messages.Where(x => x.ChatId == chatId && x.SenderId == senderId).ToList();

            var messages = new List<Message>();

            foreach (var item in list)
            {
                var message = new Message
                {
                    Id = item.MessageId,
                    SenderId = item.SenderId,
                    ChatId = item.ChatId,
                    Date = item.Date,
                    Text = item.Text,
                };
                messages.Add(message);
            }

            return messages;
        }

        public Chat AddChat(Chat chat)
        {
            var c = new DogBNB_Db.Entities.Chat
            {
                SitterId = chat.SitterId,
                OwnerId = chat.OwnerId,
                ChatName = chat.ChatName
            };

            _context.Chats.Add(c);
            _context.SaveChanges();

            return chat;
        }

    }
}
