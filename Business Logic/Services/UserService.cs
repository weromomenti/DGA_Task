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

        public Task MarkMovieAsWatchedAsync(int movieId, int userId)
        {
            throw new NotImplementedException();
        }
    }
}
