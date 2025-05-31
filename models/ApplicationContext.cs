using application.models.partner;
using Microsoft.EntityFrameworkCore;

namespace application.models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<PartnerType> partnerTypes { get; set; }
        public DbSet<PlaceForSale> placeForSales { get; set; }
        public DbSet<Partner> partners { get; set; }
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=demodb;Username=postgres;Password=123");
        }
    }
}
