using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebModels.Models.Out
{
    public class ReviewResponseModel
    {
        public double Rating { get; set; }
        public GetMovieResponse Movie { get; set; }
        public ReviewResponseModel(Review review)
        {
            Rating = review.Rating;
            Movie = new GetMovieResponse(review.Movie);
        }
    }
}
