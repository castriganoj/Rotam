using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Rotam.MultiTenancy.Dto;

namespace Rotam.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

