using DAL.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace DAL.Common
{
    public class RedDbContext : IdentityDbContext
    {
        public RedDbContext(DbContextOptions<RedDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Number> Numbers { get; set; }
        public virtual DbSet<Package> Packages { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            ChangeTracker.DetectChanges();

            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
