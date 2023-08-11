using BusinessLogic;
using LogicInterface.Interfaces;
using Microsoft.AspNetCore.Mvc;
using WebModels.Models.In;
using WebModels.Models.Out;

namespace MoviesApi.Controllers
{
    [Route("api/movies")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private IMovieLogic movieLogic;
        public MoviesController(IMovieLogic movieLogic)
        {
            this.movieLogic = movieLogic;
        }
        //Attribute para indicarle a ASP.NET Core que este método de acción 
        //corresponde a una solicitud HTTP con verbo Get
        [HttpGet]
        //Firma del método de acción. 
        //IActionResult es un tipo base para representar respuestas HTTP.
        public IActionResult GetMovieByPostfix([FromQuery] string? endsWith) // ?endsWith=2
        {
            IEnumerable<GetMovieResponse> movies = movieLogic.GetMoviesByPostix(endsWith)
                .Select(s => new GetMovieResponse(s));
            if(endsWith is null)
            {
                return Ok();
            }
            return Ok(movies);
        }

        [HttpGet("{title}")]
        public IActionResult GetMovieByTitle([FromRoute] string title) // /Avatar
        {
            try
            {
                GetMovieResponse movie = new GetMovieResponse(movieLogic.GetMovieByTitle(title));
                return Ok(movie);
            } catch (ArgumentException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult CreateMovie([FromBody] CreateMovieRequest movie)
        {
            CreateMovieResponse response = new CreateMovieResponse(movieLogic.CreateMovie(movie.ToEntity()));
            return CreatedAtAction(nameof(GetMovieByTitle), new { title = response.Title}, response);
        }

    }
}
