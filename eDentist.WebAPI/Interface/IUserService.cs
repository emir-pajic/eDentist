using eDentist.Model;
using eDentist.Model.Request;
using System.Threading.Tasks;

namespace eDentist.WebAPI.Interface
{
    public interface IUserService : ICRUDService<MUsers, UsersSearchRequest, UsersUpsertRequest, UsersUpsertRequest>
    {
        Task<MUsers> Authenticate(UserAuthenticationRequest request);
        Task<MUsers> Register(UsersUpsertRequest request);

    }
}
