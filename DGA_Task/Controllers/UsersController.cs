using Business_Logic.Interfaces;
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
        [HttpPost("{movieId}/{userId}")]
        public async Task<IActionResult> MarkMovieAsWatchedAsync(int movieId, int userId)
        {
            await userService.MarkMovieAsWatchedAsync(movieId, userId);

            return new OkResult();
        }
    }
}
