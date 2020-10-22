using AutoMapper;
using CarRental.API.Domain.Models;
using CarRental.API.Resources;

namespace CarRental.API.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveCategoryResource, Category>();
            CreateMap<SaveOrderResource, Order>();
        }
    }
}