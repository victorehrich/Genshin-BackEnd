using GenshinApplication.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace GenshinApplication.DataContext
{
    public class DataBaseContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DataBaseContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("WebApiDatabase"));
        }
        public DbSet<Set> Set { get; set; }
        public DbSet<Artifacts> Artifacts { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<Constelation> Constelation { get; set; }
        public DbSet<Characters> Characters { get; set; }

    }
}
