﻿using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IMovieRepository : IRepository<Movie>
    {
        Task AddToUserWatchlistAsync(int movieId, int userId);
    }
}
