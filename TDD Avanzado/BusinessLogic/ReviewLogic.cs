using Domain;
using IDataAccess.Interfaces;
using LogicInterface;

namespace BusinessLogic
{
    public class ReviewLogic : IReviewLogic
    {
        private IReviewRepository _reviewRepository;
        public ReviewLogic(IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }
        public IEnumerable<Review> GetAllReviews()
        {
            return _reviewRepository.GetAllReviews();
        }
    }
}