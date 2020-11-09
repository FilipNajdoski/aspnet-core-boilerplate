using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DistantPointExe.Configuration;

namespace DistantPointExe.Web.Host.Startup
{
    [DependsOn(
       typeof(DistantPointExeWebCoreModule))]
    public class DistantPointExeWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public DistantPointExeWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DistantPointExeWebHostModule).GetAssembly());
        }
    }
}
