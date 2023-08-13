using Domain;

namespace LogicInterface
{
    public interface IReviewLogic
    {
        IEnumerable<Review> GetAllReviews();
    }
}