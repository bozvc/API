using AutoMapper;
using CarRental.API.Domain.Models;
using CarRental.API.Extensions;
using CarRental.API.Resources;

namespace CarRental.API.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Category, CategoryResource>();
            CreateMap<Order, OrderResource>();
            CreateMap<Automobile, AutomobileResource>()
                .ForMember(src => src.FuelType,
                           opt => opt.MapFrom(src => src.FuelType.ToDescriptionString()));
            
        }
    }
}