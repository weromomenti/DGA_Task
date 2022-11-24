using Business_Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic.Interfaces
{
    public interface IMovieService : ICrud<MovieModel>
    {
        Task<IEnumerable<MovieModel>> GetByFilterAsync(SearchModel searchModel);
        Task AddMovieToWatchlistAsync(int movieId, int userId);
    }
}
