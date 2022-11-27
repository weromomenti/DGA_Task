using Business_Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic.Interfaces
{
    public interface IUserService : ICrud<UserModel>
    {
        Task<IEnumerable<MovieModel>> GetUserWatchlistAsync(int userId);
        Task MarkMovieAsWatchedAsync(int movieId, int userId);
    }
}
