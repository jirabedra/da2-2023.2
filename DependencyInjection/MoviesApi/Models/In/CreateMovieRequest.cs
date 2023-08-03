namespace MoviesApi.Models.In
{
    public class CreateMovieRequest
    {
        public string Title { get; set; }
        public IEnumerable<string> Genres { get; set; }
    }
}
