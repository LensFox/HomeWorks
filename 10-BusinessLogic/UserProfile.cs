using AutoMapper;

namespace _10_ThreeLayerProject.BLL
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<DAL.Entities.User, Entitites.User>().ReverseMap();
        }
    }
}
