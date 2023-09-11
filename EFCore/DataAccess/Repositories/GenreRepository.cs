using DataAccess.Context;
using DataAccessInterface.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class GenreRepository : IGenreRepository
    {
        private readonly MoviesContext _moviesContext;

        public GenreRepository(MoviesContext moviesContext)
        {
            _moviesContext = moviesContext;
        }

        public Genre CreateGenre(Genre genre)
        {
            if(_moviesContext.Genres.FirstOrDefault(p => p.Name.Equals(genre.Name)) is null)
            {
                _moviesContext.Genres.Add(genre);
                _moviesContext.SaveChanges();
                return genre;
            }
            throw new ArgumentException($"Genre {genre.Name} already exists.");
        }

        public IEnumerable<Genre> GetAllGenres()
        {
            return _moviesContext.Genres;
        }

        public Genre GetGenre(string title)
        {
            throw new NotImplementedException();
        }
    }
}
