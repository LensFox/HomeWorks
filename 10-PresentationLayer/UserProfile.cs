using _10_ThreeLayerProject.BLL.Entitites;
using _10_ThreeLayerProject.PL.Models;
using AutoMapper;

namespace _10_ThreeLayerProject.PL
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserModel>()
                .ForMember(dest =>
                dest.FName,
                opt => opt.MapFrom(src => src.FirstName))
            .ForMember(dest =>
                dest.LName,
                opt => opt.MapFrom(src => src.LastName))
             .ForMember(dest =>
                dest.Id,
                opt => opt.MapFrom(src => src.Id))
              .ForMember(dest =>
                dest.Age,
                opt => opt.MapFrom(src => src.Age))
            .ReverseMap();
        }
    }
}
