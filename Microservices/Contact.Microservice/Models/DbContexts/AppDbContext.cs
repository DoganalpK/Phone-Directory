using Microsoft.EntityFrameworkCore;

namespace Contact.Microservice.Models.DbContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Domain.Kisiler> Kisiler { get; set; }
        public DbSet<Domain.IletisimBilgileri> IletisimBilgileri { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
