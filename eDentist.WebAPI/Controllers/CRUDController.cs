using eDentist.WebAPI.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace eDentist.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CRUDController<T, TSearch, TInsert, TUpdate> : BaseController<T, TSearch>
    {
        private readonly ICRUDService<T, TSearch, TInsert, TUpdate> _service;
        public CRUDController(ICRUDService<T, TSearch, TInsert, TUpdate> service) : base(service)
        {
            _service = service;
        }
        [HttpPost]
        [Authorize]
        public async Task<T> Insert(TInsert request)
        {
            return await _service.Insert(request);
        }
        [HttpPut("{ID}")]
        [Authorize]
        public async Task<T> Update(int ID, TUpdate request)
        {
            return await _service.Update(ID, request);
        }
        [HttpDelete("{ID}")]
        [Authorize]
        public async Task<bool> Delete(int ID)
        {
            return await _service.Delete(ID);
        }
    }
}
