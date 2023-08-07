using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebModels.Models.Out
{
    public class GetMovieResponse
    {
        public string Title { get; set; }
        public IEnumerable<string> Genres { get; set; }

        public GetMovieResponse(Movie movie)
        {
            Title = movie.Title;    
            Genres = movie.Genres;
        }
    }
}
