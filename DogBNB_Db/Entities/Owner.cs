
using System.Collections.Generic;

namespace DogBNB_Db.Entities
{
    public class Owner 
    {
        public int OwnerId { get; set; }
        public int UserId { get; set; }
        public virtual List<Dog> Dogs { get; set; }
    }
}
