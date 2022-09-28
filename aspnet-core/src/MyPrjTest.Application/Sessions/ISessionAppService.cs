using System.Threading.Tasks;
using Abp.Application.Services;
using MyPrjTest.Sessions.Dto;

namespace MyPrjTest.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
