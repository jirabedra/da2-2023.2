using DataAccessInterface;
using Domain;
using LogicInterface;
using LogicInterface.Interfaces;

namespace BusinessLogic
{
    public class MovieLogic : IMovieLogic
    {
        private IMovieRepository _movieRepository;

        public MovieLogic(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public Movie CreateMovie(Movie movie)
        {
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
                    Genres = new List<string>()
                }
            };
        }
    }
}