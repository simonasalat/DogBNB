
using System.Collections.Generic;

namespace DogBNB_Db.Entities
{
    public class Owner : User
    {
        public int OwnerId { get; set; }
        public virtual List<Dog> Dogs { get; set; }
    }
}
