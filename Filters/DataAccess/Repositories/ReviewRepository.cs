using Domain;
using IDataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class ReviewRepository : IReviewRepository
    {
        public IEnumerable<Review> GetAllReviews()
        {
            throw new NotImplementedException();
        }
    }
}
