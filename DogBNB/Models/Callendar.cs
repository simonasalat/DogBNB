using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogBNB.Models
{
    public class Callendar
    {
        public short Id { get; set; }
        public List<DateTime> BookedDays { get; set; }

        public List<DateTime> Weekends { get; set; }
    }
}
