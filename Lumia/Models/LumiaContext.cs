using Microsoft.EntityFrameworkCore;

namespace Lumia.Models
{
    public class LumiaContext:DbContext
    {
        public LumiaContext(DbContextOptions<LumiaContext>options):base(options) { }

        public DbSet<Portfolio> portfolios { get; set; }
        public List<Catagory> catagories { get; set; }
        public List<Position> positions { get; set; }
        public List<PotfolioImage> potfolioImages { get; set; }




    }
}
