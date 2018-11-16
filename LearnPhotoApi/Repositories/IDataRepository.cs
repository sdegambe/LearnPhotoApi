using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnPhotoApi.Repositories
{
    public interface IDataRepository<TEntity, U> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAll();
        Task<int> Add(TEntity b);
    }
}
