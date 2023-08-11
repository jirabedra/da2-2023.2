using BusinessLogic;
using DataAccessInterface;
using Domain;
using IDataAccess.Interfaces;
using LogicInterface;
using LogicInterface.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace BusinessLogicTest
{
    [TestClass]
    public class ReviewLogicTest
    {
        [TestMethod]
        public void GetAllReviewsTestOk()
        {
            //Arrange
            Movie movie = new Movie()
            {
                Title = "Barbie",
                Genres = { },
                Id = new Guid("00000000-0000-0000-0000-000000000000")
            };
            IEnumerable<Review> reviews = new List<Review>()
            {
                new Review()
                {
                    Movie = movie,
                    Rating = 3.7
                }
            };
            Mock<IReviewRepository> reviewRepositoryMock = new Mock<IReviewRepository>(MockBehavior.Strict);
            reviewRepositoryMock.Setup(repository => repository.GetAllReviews())
                .Returns(reviews);

            IReviewLogic logic = new ReviewLogic(reviewRepositoryMock.Object);
            //Act
            IEnumerable<Review> result = logic.GetAllReviews();
            //Assert
            reviewRepositoryMock.VerifyAll();
            Assert.IsTrue(result.SequenceEqual(reviews));
        }

       
    }
}