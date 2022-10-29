using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogBNB.Services.Interfaces
{
    public interface IReviewService
    {
        public bool DeleteReview(int id);
        public bool EditReview(int id, int ownerId, string text);
        public bool AddReview(int sitterId, int ownerId, string text);
    }
}
