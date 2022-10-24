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
        public bool addReview(int sitterId, int ownerId, string text)
        {
            throw new NotImplementedException();
        }

        public bool deleteReview(int id)
        {
            throw new NotImplementedException();
        }

        public bool editReview(int id, int ownerId, string text)
        {
            throw new NotImplementedException();
        }
    }
}
