using DogBNB.Models;

namespace DogBNB_Db
{
    public class Dog
    {
        public string OwnerId { get; set; }
        public string Name { get; set; }
        public string? Breed { get; set; }
        public int? Age { get; set; }
        public DogSize Size { get; set; }

        public List<string>? Traits { get; set; }


    }
}
