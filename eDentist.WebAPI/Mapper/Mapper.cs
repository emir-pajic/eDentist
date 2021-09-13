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
            CreateMap<Users, MUsers>();
            CreateMap<Users, UsersUpsertRequest>().ReverseMap();

        }
    }
}
