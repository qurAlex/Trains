using Microsoft.EntityFrameworkCore;
using Trains.Server.Data.Models;

namespace Trains.Server.Data
{
    public class TrainsDbContext : DbContext
    {
        public TrainsDbContext(DbContextOptions<TrainsDbContext> options) : base(options) { }
        public DbSet<Station> Stations { get; set; }
        public DbSet<Info> Info { get; set; }
        public DbSet<Direction> Directions { get; set; }
        public DbSet<Road> Roads { get; set; }
        public DbSet<StopTime> StopTime { get; set; }
        public DbSet<Train> Trains { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
    }
}
