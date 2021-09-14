using AutoMapper;
using eDentist.Model;
using eDentist.Model.Request;
using eDentist.WebAPI.Database;

namespace eDentist.WebAPI.Service
{
    public class ManufacturersService : CRUDService<MManufacturers, ManufacturersSearchRequest, Manufacturers, ManufacturersUpsertRequest, ManufacturersUpsertRequest>
    {
        private readonly eDentistContext _context;
        private readonly IMapper _mapper;
        public ManufacturersService(eDentistContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }


    }
}
