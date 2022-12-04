
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DogBNB_Db.Entities
{
    public class Dog
    {
        public string DogId { get; set; }
        public string OwnerId { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        public string Size { get; set; }

        [NotMapped]
        public List<string> Traits { get; set; }
        public virtual Owner Owner { get; set; }  


    }
}
