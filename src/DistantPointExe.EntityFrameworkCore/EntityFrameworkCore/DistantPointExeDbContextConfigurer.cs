using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace DistantPointExe.EntityFrameworkCore
{
    public static class DistantPointExeDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<DistantPointExeDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<DistantPointExeDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
