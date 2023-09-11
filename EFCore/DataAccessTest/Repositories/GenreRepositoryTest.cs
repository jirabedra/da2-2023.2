using DataAccess.Context;
using DataAccess.Repositories;
using DataAccessInterface.Interfaces;
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Moq.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTest.Repositories
{
    [TestClass]
    public class GenreRepositoryTest
    {
        [TestMethod]
        public void CreateGenreOk()
        {
            Genre genre = new Genre() { Movies = { }, Name = "Action" };
            var moviesContext = new Mock<MoviesContext>();
            moviesContext.Setup(ctx => ctx.Genres).ReturnsDbSet(new List<Genre>() { });
            IGenreRepository genreRepository = new GenreRepository(moviesContext.Object);
            var expectedReturn = genreRepository.CreateGenre(genre);
            Assert.AreEqual(expectedReturn, genre);
        }

        [TestMethod]
        public void CreateAlreadyExistingGenre()
        {
            Genre genre = new Genre() { Movies = { }, Name = "Action" };
            var moviesContext = new Mock<MoviesContext>();
            moviesContext.Setup(ctx => ctx.Genres).ReturnsDbSet(new List<Genre>() { genre });
            IGenreRepository genreRepository = new GenreRepository(moviesContext.Object);
            Exception catchedException = null;
            try
            {
                genreRepository.CreateGenre(genre);
            }
            catch (Exception ex)
            {
                catchedException = ex;
            };
            Assert.IsInstanceOfType(catchedException, typeof(ArgumentException));
            Assert.IsTrue(catchedException.Message.Equals("Genre Action already exists."));
        }

        [TestMethod]
        public void GetAllGenres()
        {
            Genre someGenre = new Genre() { Movies = { }, Name = "Action" };
            Genre someOtherGenre = new Genre() { Movies = { }, Name = "Drama" };
            var moviesContext = new Mock<MoviesContext>();
            moviesContext.Setup(ctx => ctx.Genres).ReturnsDbSet(new List<Genre>() { someGenre, someOtherGenre });
            IGenreRepository genreRepository = new GenreRepository(moviesContext.Object);
            var actualReturn = genreRepository.GetAllGenres();
            Assert.IsTrue(actualReturn.Contains(someGenre) && actualReturn.Contains(someOtherGenre));
        }
    }
}