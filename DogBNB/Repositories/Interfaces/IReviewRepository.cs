using DogBNB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogBNB.Repositories.Interfaces
{
    public interface IReviewRepository
    {
        public string AddReview(Review review);
        public string UpdateReview(Review review);
        public List<Review> GetReviewsBySitter(int id);
        public List <Review> GetReviewsByOwner(int id);
        public string deleteReview(int id); 
    }
}
