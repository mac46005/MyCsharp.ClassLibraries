using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataManipulation.ClassLib.Interfaces{

    public interface IDataService<T>
    {
        Task<T> Get(int id);
        Task<IEnumerable<T>> GetAll();
        Task<T> Create(T entity);
        Task<T> Update(int id,T Entity);
        Task<bool> Delete(int id);
    }
}