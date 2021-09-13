using AutoMapper;
using eDentist.Model;
using eDentist.Model.Request;
using eDentist.WebAPI.Database;

namespace eDentist.WebAPI.Mapper
{
    public class Mapper : Profile
    {
        public Mapper()
        {

            CreateMap<Roles, MRoles>();
            CreateMap<UserRoles, MUserRoles>();

            CreateMap<Users, MUsers>();
            CreateMap<Users, UsersUpsertRequest>().ReverseMap();

        }
    }
}
