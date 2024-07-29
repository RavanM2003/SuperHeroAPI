using Microsoft.EntityFrameworkCore;
using SuperHeroAPI___DotNet8.Entities;

namespace SuperHeroAPI___DotNet8.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}
