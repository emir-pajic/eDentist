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

            CreateMap<Appointments, MAppointments>();
            CreateMap<Appointments, AppointmentsUpsertRequest>().ReverseMap();

            CreateMap<Countries, MCountries>();
            CreateMap<Countries, CountriesUpsertRequest>().ReverseMap();

            CreateMap<Cities, MCities>();
            CreateMap<Cities, CitiesUpsertRequest>().ReverseMap();

            CreateMap<Materials, MMaterials>();
            CreateMap<Materials, MaterialsUpsertRequest>().ReverseMap();

            CreateMap<Manufacturers, MManufacturers>();
            CreateMap<Manufacturers, ManufacturersUpsertRequest>().ReverseMap();

            CreateMap<Treatments, MTreatments>();
            CreateMap<Treatments, TreatmentsUpsertRequest>().ReverseMap();

            CreateMap<TreatmentsMaterials, MTreatmentsMaterials>();
            CreateMap<TreatmentsMaterials, TreatmentsMaterialsUpsertRequest>().ReverseMap();

            CreateMap<Examinations, MExaminations>();
            CreateMap<Examinations, ExaminationUpsertRequest>().ReverseMap();
        }
    }
}
