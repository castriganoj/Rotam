using System.Threading.Tasks;
using Rotam.Configuration.Dto;

namespace Rotam.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
