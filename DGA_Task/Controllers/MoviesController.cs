using Business_Logic.Interfaces;
using Business_Logic.Models;
using Business_Logic.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace DGA_Task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService movieService;
        public MoviesController(IMovieService movieService)
        {
            this.movieService = movieService;
        }
        [HttpGet]
        public async Task<ActionResult<MovieModel>> GetMoviesAsync([FromQuery] SearchModel searchModel)
        {
            var movies = await movieService.GetByFilterAsync(searchModel);

            return new OkObjectResult(movies);
        }
        [HttpPost("{movieId}/{userId}")]
        public async Task<IActionResult> AddMovieToWatchlistAsync(int movieId, int userId)
        {
            await movieService.AddMovieToWatchlistAsync(movieId, userId);

            return new OkResult();
        }
    }
}
