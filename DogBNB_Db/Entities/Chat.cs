using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogBNB_Db.Entities
{
    public class Chat
    {
        public int Id { get; set; }
        public int SitterId { get; set; }
        public int OwnerId { get; set; }
        public string ChatName { get; set; }
    }
}
