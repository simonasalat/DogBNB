using DogBNB.Models;
using DogBNB.Repositories.Interfaces;
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
        private readonly IReviewRepository _reviewRepository;
        public ReviewService(IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }      
        public string AddReview(Review review)
        {
            return _reviewRepository.AddReview(review);
        }

        public string deleteReview(int id)
        {
            return _reviewRepository.deleteReview(id);
        }

        public List<Review> GetReviewsByOwner(int id)
        {
            return _reviewRepository.GetReviewsByOwner(id);
        }

        public List<Review> GetReviewsBySitter(int id)
        {
            return _reviewRepository.GetReviewsBySitter(id);
        }

        public string UpdateReview(Review review)
        {
           return _reviewRepository.UpdateReview(review);
        }
    }
}
