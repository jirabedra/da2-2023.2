using DataAccess.Context;
using DataAccess.Repositories;
using DataAccessInterface.Interfaces;
using Domain;
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
            moviesContext.Setup(ctx => ctx.Genres.FirstOrDefault(genre)).Returns(genre);
            IGenreRepository genreRepository = new GenreRepository(moviesContext.Object);
            genreRepository.CreateGenre(genre);
        }
    }
}
