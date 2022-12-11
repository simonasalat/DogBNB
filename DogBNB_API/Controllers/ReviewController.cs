using DogBNB.Models;
using DogBNB.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DogBNB_API.Controllers
{
    [Route("api/review")]
    [ApiController]
    public class ReviewController : Controller
    {
        private readonly IReviewService _reviewService;


        public ReviewController(IReviewService reviewService)
        {
            _reviewService = reviewService;
        }
        [HttpPost]
        public string AddReview([FromBody] Review review)
        {
            return _reviewService.AddReview(review);
        }
        [HttpDelete("delete/{id}")]
        public string deleteReview(int id)
        {
            return _reviewService.deleteReview(id);
        }
        [HttpGet("by-owner/{id}")]
        public List<Review> GetReviewsByOwner(int id)
        {
            return _reviewService.GetReviewsByOwner(id);
        }
        [HttpGet("by-sitter/{id}")]
        public List<Review> GetReviewsBySitter(int id)
        {
            return _reviewService.GetReviewsBySitter(id);
        }
        [HttpPost]
        public string UpdateReview([FromBody]Review review)
        {
            return _reviewService.UpdateReview(review);
        }
    }
}
