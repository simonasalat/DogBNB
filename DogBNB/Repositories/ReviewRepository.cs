using DogBNB.Models;
using DogBNB.Repositories.Interfaces;
using DogBNB_Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogBNB.Repositories
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly DogBNBDbContext _context;
        public ReviewRepository(DogBNBDbContext context)
        {
            _context = context;
        }
        public ReviewRepository()
        {

        }
        public string AddReview(Review review)
        {
            var r = new DogBNB_Db.Entities.Review
            {
                OwnerID=review.OwnerID,
                SitterID=review.SitterID,
                Rating=review.Rating,
                Text=review.Text             
            };
            _context.Reviews.Add(r);
            _context.SaveChanges();
            return "Review was deleted successfully";
        }

        public string deleteReview(int id)
        {
            var r = _context.Reviews.Where(r => r.ReviewId == id).First();
            _context.Remove(r);
            _context.SaveChanges();
            return "Review was successfully deleted";
        }

        public List<Review> GetReviewsByOwner(int id)
        {
            var reviews= _context.Reviews.Where(r => r.OwnerID == id).ToList();
            var result= new List<Review>();
            foreach(var review in reviews)
            {
                Review r = new Review()
                {
                    OwnerID = review.OwnerID,
                    SitterID = review.SitterID,
                    Rating = review.Rating,
                    Text = review.Text

                };
                result.Add(r);
            }
            return result;
        }

        public List<Review> GetReviewsBySitter(int id)
        {
            var reviews = _context.Reviews.Where(r => r.SitterID == id).ToList();
            var result = new List<Review>();
            foreach (var review in reviews)
            {
                Review r = new Review()
                {
                    OwnerID = review.OwnerID,
                    SitterID = review.SitterID,
                    Rating = review.Rating,
                    Text = review.Text

                };
                result.Add(r);
            }
            return result;
        }

        public string UpdateReview(Review review)
        {
            var r = _context.Reviews.Where(r => r.ReviewId == review.Id).First();
            if (r!=null)
            {
                r.Rating = review.Rating;
                r.Text = review.Text;
                return "Review was updated successfully.";

            }
            return "This Review does not exist anymore";
        }
    }
}
