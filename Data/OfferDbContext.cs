
using Microsoft.EntityFrameworkCore;
using Trade.Models;

namespace Trade.Data
{
    public class OfferDbContext: DbContext
    {
        public OfferDbContext(DbContextOptions<OfferDbContext> options)
            : base(options)
        {
        }

        public DbSet<Offer> Offer { get; set; }
    }
}
