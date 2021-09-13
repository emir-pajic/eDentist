using AutoMapper;
using eDentist.Model;
using eDentist.WebAPI.Database;

namespace eDentist.WebAPI.Service
{
    public class RoleService : BaseService<MRoles, object, Roles>
    {
        public RoleService(eDentistContext context, IMapper mapper) : base(context, mapper)
        {

        }
    }
}
