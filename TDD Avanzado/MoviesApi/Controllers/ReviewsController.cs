using LogicInterface;
using Microsoft.AspNetCore.Mvc;
using WebModels.Models.Out;

namespace MoviesApi
{
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private IReviewLogic _reviewsLogic;

        public ReviewsController(IReviewLogic reviewsLogic)
        {
            _reviewsLogic = reviewsLogic;
        }

        [HttpGet]
        public IActionResult GetAllReviews()
        {
            return Ok(_reviewsLogic.GetAllReviews()
                .Select(review => new ReviewResponseModel(review)).ToList());
        }
    }
}