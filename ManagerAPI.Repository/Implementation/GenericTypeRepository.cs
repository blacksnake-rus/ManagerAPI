using ManagerAPI.DataCore;
using ManagerAPI.DataCore.DomainModel;
using ManagerAPI.Repository.Interfaces;

namespace ManagerAPI.Repository.Implementation
{
    public class GenericTypeRepository : BaseRepository<DbGenericType>, IGenericTypeRepository
    {
        public GenericTypeRepository(DataContext dataContext) : base(dataContext) { }
    }
}
