using eDentist.Model;
using eDentist.WebAPI.Interface;

namespace eDentist.WebAPI.Controllers
{

    public class RoleController : BaseController<MRoles, object>
    {
        public RoleController(IBaseService<MRoles, object> service) : base(service)
        {
        }
    }
}
