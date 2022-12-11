

using System.Collections.Generic;

namespace DogBNB.Models
{
    public class Dog
    {
        public int Id { get; set; }
        public int OwnerId { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        public DogSize Size { get; set; }

        public List<string> Traits { get; set; }


    }
}
