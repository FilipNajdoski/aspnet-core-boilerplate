using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using DistantPointExe.Authorization.Roles;
using DistantPointExe.Authorization.Users;
using DistantPointExe.MultiTenancy;
using DistantPointExe.Entities;

namespace DistantPointExe.EntityFrameworkCore
{
    public class DistantPointExeDbContext : AbpZeroDbContext<Tenant, Role, User, DistantPointExeDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Patient> Patients { get; set; }
        public DbSet<AdditionalInfo> AdditionalInfo { get; set; }

        public DistantPointExeDbContext(DbContextOptions<DistantPointExeDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AdditionalInfo>()
                .HasOne<Patient>(p => p.Patient)
                .WithMany(ai => ai.AdditionalInfo)
                .HasForeignKey(p => p.PatientID);
        }
    }
}
