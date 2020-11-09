using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DistantPointExe.EntityFrameworkCore;
using DistantPointExe.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace DistantPointExe.Web.Tests
{
    [DependsOn(
        typeof(DistantPointExeWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class DistantPointExeWebTestModule : AbpModule
    {
        public DistantPointExeWebTestModule(DistantPointExeEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DistantPointExeWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(DistantPointExeWebMvcModule).Assembly);
        }
    }
}