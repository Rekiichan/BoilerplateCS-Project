using System.Threading.Tasks;
using Abp.Application.Services;
using MyPrjTest.Authorization.Accounts.Dto;

namespace MyPrjTest.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
