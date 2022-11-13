using Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace Entity.Context
{
    public class SmartDbContext : DbContext
    {
        public SmartDbContext(DbContextOptions<SmartDbContext> options) : base(options)
        { }

        public DbSet<Provience> Provience { get; set; }
        public DbSet<District> District { get; set; }
        public DbSet<City> City { get; set; }

    }
}
