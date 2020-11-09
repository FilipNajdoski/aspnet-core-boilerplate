using Abp.Application.Services;
using DistantPointExe.MultiTenancy.Dto;

namespace DistantPointExe.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

