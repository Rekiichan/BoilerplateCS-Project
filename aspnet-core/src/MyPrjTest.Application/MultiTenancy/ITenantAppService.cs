using Abp.Application.Services;
using MyPrjTest.MultiTenancy.Dto;

namespace MyPrjTest.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

