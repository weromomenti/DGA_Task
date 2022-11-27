using Business_Logic.Interfaces;
using Business_Logic.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DGA_Task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService userService;

        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }
        [HttpGet("{userId}")]
        public async Task<ActionResult<IEnumerable<MovieModel>>> GetUserWatchlistAsync(int userId)
        {
            var movies = await userService.GetUserWatchlistAsync(userId);

            return new OkObjectResult(movies);
        }
        [HttpPost("{movieId}/{userId}")]
        public async Task<IActionResult> MarkMovieAsWatchedAsync(int movieId, int userId)
        {
            await userService.MarkMovieAsWatchedAsync(movieId, userId);

            return new OkResult();
        }
    }
}
