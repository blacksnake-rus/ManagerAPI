using ManagerAPI.Repository.Implementation;
using ManagerAPI.Repository.Interfaces;
using ManagerAPI.Service.Implementation;
using ManagerAPI.Service.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ManagerAPI.Extentions
{
    public static class ServiceCollectionExtentions
    {
        public static void ConfigureDI(this IServiceCollection services)
        {

            services.AddTransient<IGenericTypeRepository, GenericTypeRepository>();

            services.AddTransient<IContractService, ContractService>();
        }
    }
}
