using Kreshnik.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Kreshnik.Api.Data
{
    public class GameDbContext : DbContext
    {
        public GameDbContext(DbContextOptions<GameDbContext> options) : base(options) { }

        public DbSet<Hero> Heroes { get; set; }
    }
}
