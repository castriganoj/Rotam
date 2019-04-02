using System.Threading.Tasks;
using Abp.Application.Services;
using Rotam.Authorization.Accounts.Dto;

namespace Rotam.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
