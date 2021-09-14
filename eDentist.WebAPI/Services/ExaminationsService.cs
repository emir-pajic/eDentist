using AutoMapper;
using eDentist.Model;
using eDentist.Model.Request;
using eDentist.WebAPI.Database;

namespace eDentist.WebAPI.Service
{
    public class ExaminationsService : CRUDService<MExaminations, ExaminationsSearchRequest, Examinations, ExaminationUpsertRequest, ExaminationUpsertRequest>
    {
        private readonly eDentistContext _context;
        private readonly IMapper _mapper;
        public ExaminationsService(eDentistContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }


    }
}
