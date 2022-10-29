using DogBNB.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogBNB.Services
{
    public class ReviewService : IReviewService
    {
        public bool AddReview(int sitterId, int ownerId, string text)
        {
            throw new NotImplementedException();
        }

        public bool DeleteReview(int id)
        {
            throw new NotImplementedException();
        }

        public bool EditReview(int id, int ownerId, string text)
        {
            throw new NotImplementedException();
        }
    }
}
