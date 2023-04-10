using AutoMapper;
using Domain.Models;
using Infrastructure.Common;
using Infrastructure.Restaurants.Commands;
using Infrastructure.Restaurants.ViewModels;

namespace Infrastructure.Restaurants.Profiles
{
    public class RestaurantProfile : Profile, IProfileRegister
    {
        public RestaurantProfile()
        {
            CreateMap<CreateRestaurantCommand, Restaurant>().ReverseMap();
            CreateMap<GetRestaurantVm, Restaurant>().ReverseMap();
            CreateMap<CreateRestaurantVm, Restaurant>().ReverseMap();
            CreateMap<UpdateRestaurantVm, Restaurant>().ReverseMap();
        }
    }
}
