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
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext appDbContext;

        public UserRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await appDbContext.Users.ToListAsync();
        }
        public Task MarkMovieWatchedAsync(int movieId)
        {
            throw new NotImplementedException();
        }
    }
}
