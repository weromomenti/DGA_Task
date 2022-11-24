using AutoMapper;
using Business_Logic.Models;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic.Infrastructure
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Movie, MovieModel>().ReverseMap();
            CreateMap<User, UserModel>().ReverseMap();
        }
    }
}
