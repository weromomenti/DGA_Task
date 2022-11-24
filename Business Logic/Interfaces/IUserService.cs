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
        Task MarkMovieAsWatchedAsync(int movieId, int userId);
    }
}
