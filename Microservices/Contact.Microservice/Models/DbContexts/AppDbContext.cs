using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Contact.Microservice.Models.DbContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Domain.Kisiler> Kisiler { get; set; }
        public DbSet<Domain.IletisimBilgileri> IletisimBilgileris { get; set; }
        public DbSet<Domain.Rapor> Rapors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assmb = Assembly.GetExecutingAssembly();
            modelBuilder.ApplyConfigurationsFromAssembly(assmb);
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
