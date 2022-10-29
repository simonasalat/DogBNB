using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogBNB.Models
{
    public class Sitter : User
    {
        public string Description { get; set; }

        public List<Service> ServiceList { get; set; }
    }
}
