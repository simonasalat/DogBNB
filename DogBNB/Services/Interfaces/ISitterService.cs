using DogBNB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogBNB.Services.Interfaces
{
    public interface ISitterService
    {
        public List<Sitter> GetSitters();
        public Sitter GetSitterbyId(int id);
        public List<Review> GetReviewsBySitterId(int id);
        public List<Sitter> GetSittersByService(Service service);


    }
}
