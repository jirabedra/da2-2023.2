using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessInterface.Interfaces
{
    public interface IGenreRepository
    {
        public Genre GetGenre(string title);
        public Genre CreateGenre(Genre genre);
    }
}
