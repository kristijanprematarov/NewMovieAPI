using Microsoft.AspNetCore.Mvc;
using NewMovieAPI.Entities;
using NewMovieAPI.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NewMovieAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        // GET: api/<MovieController>
        [HttpGet("Filmovi")]
        public async Task<IEnumerable<Movie>> GetMovies()
        {
            return await _movieService.GetMovies();
        }

        // GET 
        [HttpGet("film/{id}")]
        public async Task<Movie> Get(int id)
        {
            var movie = _movieService.GetMovie(id);
            return await movie;
        }

        // Update
        [HttpPost("film")]
        public async void Update(Movie movie)
        {
            _movieService.Update(movie);
        }

        // DELETE api/<MovieController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
