using BlazorEfCoreRepro.Server.Models;
using BlazorEfCoreRepro.Server.Models.PhotoSession;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace BlazorEfCoreRepro.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<PhotoSessionInfo> PhotoSessions { get; set; }

        public DbSet<PhotoSessionDetails> PhotoSessionDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<PhotoSessionInfo>()
                   .HasMany(p => p.PhotoSessionDetails)
                   .WithOne(pd => pd.PhotoSessionInfo);

            builder.Entity<PhotoSessionInfo>()
                   .Property(p => p.Price)
                   .HasColumnType("decimal(18, 2)");

            builder.Entity<PhotoSessionDetails>()
                   .HasOne(pd => pd.PhotoSessionInfo)
                   .WithMany(p => p.PhotoSessionDetails);

            base.OnModelCreating(builder);
        }
    }
}
