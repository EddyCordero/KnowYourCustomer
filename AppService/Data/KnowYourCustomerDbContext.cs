using Microsoft.EntityFrameworkCore;

namespace AppService.Data
{
    public class KnowYourCustomerDbContext : DbContext
    {
        public KnowYourCustomerDbContext(DbContextOptions<KnowYourCustomerDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(KnowYourCustomerDbContext).Assembly);
        }
    }
}
