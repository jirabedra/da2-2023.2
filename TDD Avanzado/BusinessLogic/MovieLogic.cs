using Domain;
using LogicInterface;
using LogicInterface.Interfaces;

namespace BusinessLogic
{
    public class MovieLogic : IMovieLogic
    {
        public Movie CreateMovie(Movie movie)
        {
            Console.WriteLine("Creating movie!");
            return movie;
        }

        public Movie GetMovieByTitle(string title)
        {
            return new Movie()
            {
               Title = title,
               Genres = new List<string>()
            };
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