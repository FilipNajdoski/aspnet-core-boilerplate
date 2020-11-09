using System.Threading.Tasks;
using Abp.Application.Services;
using DistantPointExe.Sessions.Dto;

namespace DistantPointExe.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
