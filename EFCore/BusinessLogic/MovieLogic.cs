using DataAccessInterface;
using DataAccessInterface.Interfaces;
using Domain;
using LogicInterface;
using LogicInterface.Interfaces;

namespace BusinessLogic
{
    public class MovieLogic : IMovieLogic
    {
        private IMovieRepository _movieRepository;
        private IGenreRepository _genreRepository;

        public MovieLogic(IMovieRepository movieRepository, IGenreRepository genreRepository)
        {
            _movieRepository = movieRepository;
            _genreRepository = genreRepository;
        }

        public Movie CreateMovie(Movie movie)
        {
            foreach(var genre in movie.Genres)
            {
                _genreRepository.CreateGenre(genre);
            }
            Console.WriteLine("Creating movie!");
            return movie;
        }

        public Movie GetMovieByTitle(string title)
        {
            return _movieRepository.GetMovieByTitle(title); 
        }

        public IEnumerable<Movie> GetMoviesByPostix(string postfix)
        {
            return new List<Movie>()
            {
                new Movie()
                {
                    Title = "The " + postfix,
                    Genres = new List<Genre>()
                }
            };
        }
    }
}