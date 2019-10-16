using ManagerAPI.DataCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ManagerAPI.Repository.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        Task<TEntity> GetById(Guid id);

        Task<IEnumerable<TEntity>> GetAllAsync();
    }
}
