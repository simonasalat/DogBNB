using DogBNB.Models;
using DogBNB.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogBNB.Services
{
    internal class SitterService : ISitterService

    {
        public List<Review> GetReviewsBySitterId(int id)
        {
            throw new NotImplementedException();
        }

        public Sitter GetSitterbyId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Sitter> GetSitters()
        {
            throw new NotImplementedException();
        }

        public List<Sitter> GetSittersByService(Service service)
        {
            throw new NotImplementedException();
        }
    }
}
