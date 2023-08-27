using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicInterface.Interfaces
{
    public interface IMovieLogic
    {
        IEnumerable<Movie> GetMoviesByPostix(string postfix);
        Movie GetMovieByTitle(string title);
        Movie CreateMovie(Movie movie);
    }
}
