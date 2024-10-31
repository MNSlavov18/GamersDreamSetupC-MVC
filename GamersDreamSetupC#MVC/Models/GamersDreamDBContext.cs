using Microsoft.EntityFrameworkCore;

namespace GamersDreamSetupC_MVC.Models
{
    public class GamersDreamDBContext : DbContext
    {
        public DbSet<Game> Games { get; set;}

        public GamersDreamDBContext(DbContextOptions<GamersDreamDBContext> options) : base(options)
        {

        }
    }
}
