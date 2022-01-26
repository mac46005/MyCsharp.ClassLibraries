using System.Collections.Generic;
using System.Threading.Tasks;
using DataManipulation.ClassLib.Interfaces;

namespace DataManipulation.ClassLib.Services.EntityFramework{
    {
        private readonly Context _contextFactory;
        public virtual Task<T> Create(T entity)
        {
            throw new System.NotImplementedException();
        }

        public virtual Task<bool> Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<T> Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<T> Update(int id, T Entity)
        {
            throw new System.NotImplementedException();
        }
    }
}