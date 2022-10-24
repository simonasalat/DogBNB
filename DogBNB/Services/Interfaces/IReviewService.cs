using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogBNB.Services.Interfaces
{
    public interface IReviewService
    {
        public bool deleteReview(int id);
        public bool editReview(int id, int ownerId, string text);
        public bool addReview(int sitterId, int ownerId, string text);
    }
}
