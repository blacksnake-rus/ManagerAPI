using ManagerAPI.DataCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ManagerAPI.Repository
{
    public abstract class BaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly DataContext _context;

        protected BaseRepository(DataContext context)
        {
            _context = context;
        }

        protected async Task<TEntity> GetById(Guid id)
            => await _context.Set<TEntity>().FirstOrDefaultAsync(x => x.Id == id && !x.DateOff.HasValue);

        protected async Task<IEnumerable<TEntity>> GetAllAsync()
            => await _context.Set<TEntity>().ToListAsync();
    }
}
