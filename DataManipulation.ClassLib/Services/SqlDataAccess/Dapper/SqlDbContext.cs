using System.Collections.Generic;
using System.Threading.Tasks;
using DataManipulation.ClassLib.Interfaces;

namespace DataManipulation.ClassLib.Services.Dapper{
    public class SqlDbContext<T> : IDataService<T> 
    {
        



        public async Task<T> Create(T entity)
        {
            throw new System.NotImplementedException();
        }

        public async Task<bool> Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<T> Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<T> Update(int id, T Entity)
        {
            throw new System.NotImplementedException();
        }
    }
}