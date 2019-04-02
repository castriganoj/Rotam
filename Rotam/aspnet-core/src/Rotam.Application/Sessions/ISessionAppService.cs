using System.Threading.Tasks;
using Abp.Application.Services;
using Rotam.Sessions.Dto;

namespace Rotam.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
