using System.Collections.Generic;
using System.Threading.Tasks;

namespace eDentist.WebAPI.Interface
{
    public interface IBaseService<T, TSearch>
    {
        Task<List<T>> Get(TSearch search);
        Task<T> GetById(int ID);

    }
}
