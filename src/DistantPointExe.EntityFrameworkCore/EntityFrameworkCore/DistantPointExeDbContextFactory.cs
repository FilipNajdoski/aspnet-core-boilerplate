using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using DistantPointExe.Configuration;
using DistantPointExe.Web;

namespace DistantPointExe.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class DistantPointExeDbContextFactory : IDesignTimeDbContextFactory<DistantPointExeDbContext>
    {
        public DistantPointExeDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<DistantPointExeDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DistantPointExeDbContextConfigurer.Configure(builder, configuration.GetConnectionString(DistantPointExeConsts.ConnectionStringName));

            return new DistantPointExeDbContext(builder.Options);
        }
    }
}
