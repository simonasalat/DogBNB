using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogBNB.Models
{
    public class Service
    {
        public int Id { get; set; }
        public ServiceType ServiceType { get; set; }
        public decimal Price { get; set; }

    }
}
