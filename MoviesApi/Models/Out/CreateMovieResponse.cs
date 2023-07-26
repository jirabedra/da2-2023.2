namespace MoviesApi.Models.Out
{
    public class CreateMovieResponse
    {
        public Guid GUID { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        public IEnumerable<string> Genres { get; set; }
    }
}
