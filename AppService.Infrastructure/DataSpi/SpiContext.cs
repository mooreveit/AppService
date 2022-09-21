using AppService.Core.EntitiesSpi;
using Microsoft.EntityFrameworkCore;

namespace AppService.Infrastructure.DataSpi
{
    public class SpiContext : DbContext
    {
        public SpiContext(DbContextOptions<SpiContext> options) : base(options)
        {

        }
        public DbSet<NMM024> NMM024 { get; set; }

        public DbSet<NMT033> NMT033 { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder
            .Entity<NMM024>(builder =>
            {
                builder.HasNoKey();
                builder.ToTable("NMM024");
            });

            modelBuilder
           .Entity<NMT033>(builder =>
           {
               builder.HasNoKey();
               builder.ToTable("NMT033");
           });


        }

    }
}
