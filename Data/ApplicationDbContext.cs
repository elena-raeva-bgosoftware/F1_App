using F1_Web_App.Data.Models;
using F1_Web_App.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace F1_Web_App.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Circuit> Circuits { get; set; }
        public DbSet<CircuitSeason> CircuitSeasons { get; set; }
        public DbSet<Participation> Participations { get; set; }
        public DbSet<DriverSeason> DriverSeasons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}