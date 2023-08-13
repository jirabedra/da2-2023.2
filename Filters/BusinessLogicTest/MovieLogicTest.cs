using BusinessLogic;
using DataAccessInterface;
using LogicInterface.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicTest
{
    [TestClass]
    public class MovieLogicTest
    {
        [TestMethod]
        //otro buen nombre segun https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices seria 
        //GivenNonexistingTitle_WhenGetMovieByTitle_ThenThrowArgumentException
        public void GetMovieByTitleNonexistingTitle()
        {
            //Arrange
            string title = "Shrek 4"; //nos encantaria, pero no existe :(
            Mock<IMovieRepository> movieRepositoryMock = new Mock<IMovieRepository>(MockBehavior.Strict);
            movieRepositoryMock.Setup(repository => repository.GetMovieByTitle(It.IsAny<string>())).Throws(new ArgumentException("There is no such movie."));
            IMovieLogic movieLogic = new MovieLogic(movieRepositoryMock.Object);
            Exception exception = null;
            //Act
            try
            {
                movieLogic.GetMovieByTitle(title);
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            //Assert
            movieRepositoryMock.VerifyAll();
            Assert.IsInstanceOfType(exception, typeof(ArgumentException));
            Assert.IsTrue(exception.Message.Equals("There is no such movie."));
        }

        [TestMethod]
        //otro buen nombre segun https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices seria 
        //GivenNonexistingTitle_WhenGetMovieByTitle_ThenThrowArgumentException
        [ExpectedException(typeof(ArgumentException))]
        public void GetMovieByTitleNonexistingTitleWithSomeDifferentApproach()
        {
            //Arrange
            string title = "Shrek 4"; //nos encantaria, pero no existe :(
            Mock<IMovieRepository> movieRepositoryMock = new Mock<IMovieRepository>(MockBehavior.Strict);
            movieRepositoryMock.Setup(repository => repository.GetMovieByTitle(It.IsAny<string>())).Throws(new ArgumentException("There is no such movie."));
            IMovieLogic movieLogic = new MovieLogic(movieRepositoryMock.Object);
            //Act, Assert is represented via an attribute 
            movieLogic.GetMovieByTitle(title);        
            movieRepositoryMock.VerifyAll();
        }
    }
}
