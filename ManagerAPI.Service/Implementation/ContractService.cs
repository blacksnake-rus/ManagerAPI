using ManagerAPI.Repository.Interfaces;
using ManagerAPI.Service.Interfaces;

namespace ManagerAPI.Service.Implementation
{
    public class ContractService : IContractService
    {
        private readonly IGenericTypeRepository _genericTypeRepositor;

        public ContractService(IGenericTypeRepository genericTypeRepository)
        {
            _genericTypeRepositor = genericTypeRepository;
        }
    }
}
