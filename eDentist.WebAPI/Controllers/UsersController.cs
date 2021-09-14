
using eDentist.Model;
using eDentist.Model.Request;
using eDentist.WebAPI.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace eDentist.WebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : CRUDController<MUsers, UsersSearchRequest, UsersUpsertRequest, UsersUpsertRequest>
    {
        private readonly IUserService _service;
        public UserController(IUserService service) : base(service)
        {
            _service = service;
        }
        [HttpPost("Authenticate")]
        public async Task<MUsers> Authenticate(UserAuthenticationRequest request)
        {
            return await _service.Authenticate(request);
        }
        [HttpPost("Register")]
        public async Task<MUsers> Register(UsersUpsertRequest request)
        {
            return await _service.Insert(request);
        }

    }
}

