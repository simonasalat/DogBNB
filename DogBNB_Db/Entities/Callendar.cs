using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogBNB_Db.Entities
{
    public class Callendar
    {
        public int CallendarId { get; set; }
        public int UserId { get; set; }
        public DateTime BookedDayStart { get; set; }
        public DateTime BookedDayEnd { get; set; }
    }
}
