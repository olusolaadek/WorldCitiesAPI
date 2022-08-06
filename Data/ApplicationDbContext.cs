using Microsoft.EntityFrameworkCore;
using WorldCitiesAPI.Data.Models;

namespace WorldCitiesAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public ApplicationDbContext() : base()
        {
        }
        public DbSet<City> Cities => Set<City>();
        public DbSet<Country> Countries => Set<Country>();

    }
}
