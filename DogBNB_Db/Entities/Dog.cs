
using System.Collections.Generic;

namespace DogBNB_Db.Entities
{
    public class Dog
    {
        public string Id { get; set; }
        public string OwnerId { get; set; }
        public string Name { get; set; }
        public string? Breed { get; set; }
        public int? Age { get; set; }
        public string Size { get; set; }

        public List<string>? Traits { get; set; }


    }
}
