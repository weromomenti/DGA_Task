using Data.Data;
using Data.Entities;
using Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly AppDbContext appDbContext;

        public MovieRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async Task AddToUserWatchlistAsync(int movieId, int userId)
        {
            await appDbContext.Users.FindAsync(userId);
        }
        public async Task<IEnumerable<Movie>> GetAllAsync()
        {
            return await appDbContext.Movies.ToListAsync();
        }

        public async Task<Movie> GetByIdAsync(int id)
        {
            return await appDbContext.Movies.Include(m => m.WatchListUsers).FirstOrDefaultAsync(m => m.Id == id);
        }
    }
}
