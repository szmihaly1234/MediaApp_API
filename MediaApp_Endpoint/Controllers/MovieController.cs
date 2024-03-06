using Logic.Interfaces;
using MediaApp_Models;
using Microsoft.AspNetCore.Mvc;

namespace MediaApp_Endpoint.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MovieController : Controller
    {
        IMovieLogic ml;
        public MovieController(IMovieLogic ml)
        {
            this.ml = ml;
        }
        [HttpGet]
        public IEnumerable<Movie> ReadAll()
        {
            return ml.ReadAll();
        }

        [HttpGet("{id}")]
        public Movie Read(int id)
        {
            return ml.Read(id);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var movietodelete = ml.Read(id);
            ml.Delete(id);
        }
        [HttpPost]
        public void Create([FromBody] Movie movie)
        {
            ml.Create(movie);
        }
        [HttpPut]
        public void Update([FromBody] Movie movie)
        {
            ml.Update(movie);
        }
    }
}
