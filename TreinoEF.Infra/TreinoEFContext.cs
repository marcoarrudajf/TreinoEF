using Microsoft.EntityFrameworkCore;
using TreinoEF.Domain.Entities;

namespace TreinoEF.Infra
{
    public class TreinoEFContext  : DbContext
    {
        public DbSet<DirectorEntity> Directors { get; set; }
        public DbSet<SchoolEntity> Custormer { get; set; }
        public DbSet<StudentEntity> Students { get; set; }
        public TreinoEFContext(DbContextOptions<TreinoEFContext> options) 
            : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.EnableDetailedErrors();
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TreinoEFContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
