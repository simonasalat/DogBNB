
using System;

namespace DogBNB_Db.Entities
{
    public class Message
    {
        public int MessageId { get; set; }
        public int SenderId { get; set; }
        public int ChatId { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
        public virtual Chat Chat { get; set; }

    }
}
