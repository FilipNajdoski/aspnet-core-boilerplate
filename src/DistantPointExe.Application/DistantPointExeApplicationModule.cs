using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DistantPointExe.Authorization;

namespace DistantPointExe
{
    [DependsOn(
        typeof(DistantPointExeCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class DistantPointExeApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<DistantPointExeAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(DistantPointExeApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
