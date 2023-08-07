using Domain;

namespace WebModels.Models.Out
{
    public class CreateMovieResponse
    {
        public Guid GUID { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        public IEnumerable<string> Genres { get; set; }

        public CreateMovieResponse(Movie movie)       
        {
            this.GUID = movie.Id;
            this.Title = movie.Title;
            this.Genres = movie.Genres;
        }

    }
}
