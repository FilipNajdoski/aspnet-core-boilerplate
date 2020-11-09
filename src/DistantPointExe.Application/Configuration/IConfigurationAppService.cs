using System.Threading.Tasks;
using DistantPointExe.Configuration.Dto;

namespace DistantPointExe.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
