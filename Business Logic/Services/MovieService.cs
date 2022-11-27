using AutoMapper;
using Business_Logic.Interfaces;
using Business_Logic.Models;
using Data.Entities;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic.Services
{
    public class MovieService : IMovieService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public MovieService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<IEnumerable<MovieModel>> GetAllAsync()
        {
            var movies = await unitOfWork.MovieRepository.GetAllAsync();

            return mapper.Map<IEnumerable<MovieModel>>(movies);
        }
        public async Task<IEnumerable<MovieModel>> GetByFilterAsync(SearchModel searchModel)
        {
            var movies = await unitOfWork.MovieRepository.GetAllAsync();
            if (searchModel.Name != null && searchModel.Name != String.Empty)
            {
                movies = movies.Where(m => m.Name.ToLower().Contains(searchModel.Name.ToLower()));
            }

            return mapper.Map<IEnumerable<MovieModel>>(movies);
        }
        public async Task AddMovieToWatchlistAsync(int movieId, int userId)
        {
            var user = await unitOfWork.UserRepository.GetByIdAsync(userId);
            var movie = await unitOfWork.MovieRepository.GetByIdAsync(movieId);

            if (user == null || movie == null)
            {
                throw new Exception();
            }
            user.Movies.Add(movie);
            await unitOfWork.SaveChangesAsync();
        }

    }
}
