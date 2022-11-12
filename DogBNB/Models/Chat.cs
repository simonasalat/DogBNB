

namespace DogBNB.Models
{
    public class Chat
    {
        public int Id { get; set; }
        public int SitterId { get; set; }
        public int OwnerId { get; set; }
        public string ChatName { get; set; }
    }
}
