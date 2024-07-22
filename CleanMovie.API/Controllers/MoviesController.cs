using CleanMovie.Application;
using CleanMovie.Domain;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CleanMovie.API.Controllers
{

    //contorel- იწერება endpointebi

    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly ImovieService _service;
        public MoviesController(ImovieService service)
        {
            _service= service;
        }


        [HttpGet]
       public ActionResult<List<Movie>> Get()
        {
            var moviesservice=_service.GetAllMovies();
            return Ok(moviesservice);
        }

        [HttpPost]
        public ActionResult<List<Movie>> PostMovie(Movie movie)
        {
            var Movie = _service.CreateMovie(movie);
            
            return Ok(movie);
        }

        
    }
}
