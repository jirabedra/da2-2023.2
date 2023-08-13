using Domain;

namespace DataAccessInterface
{
    public interface IMovieRepository
    {
        Movie GetMovieByTitle(string title);
    }
}