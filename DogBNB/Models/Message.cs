﻿

namespace DogBNB.Models
{
    public class Message
    {
        public int SenderId { get; set; }
        public int ChatId { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }

    }
}