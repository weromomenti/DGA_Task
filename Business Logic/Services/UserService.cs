using AutoMapper;
using Business_Logic.Interfaces;
using Business_Logic.Models;
using Data.Data;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public UserService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<IEnumerable<UserModel>> GetAllAsync()
        {
            var users = await unitOfWork.UserRepository.GetAllAsync();

            return mapper.Map<IEnumerable<UserModel>>(users);
        }
        public async Task<IEnumerable<MovieModel>> GetUserWatchlistAsync(int userId)
        {
            var user = await unitOfWork.UserRepository.GetByIdAsync(userId);

            return mapper.Map<IEnumerable<MovieModel>>(user.WatchList);
        }
        public async Task MarkMovieAsWatchedAsync(int movieId, int userId)
        {
            var user = await unitOfWork.UserRepository.GetByIdAsync(userId);
            var movie = await unitOfWork.MovieRepository.GetByIdAsync(movieId);

            if (movie == null || user == null)
            {
                throw new Exception();
            }
            if (user.WatchList.FirstOrDefault(m => m.Id == movieId) == null)
            {
                throw new Exception();
            }
            user.WatchedMovies.Add(movie);
            await unitOfWork.SaveChangesAsync();
        }
    }
}
