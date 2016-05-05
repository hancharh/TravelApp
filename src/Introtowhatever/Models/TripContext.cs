using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;


namespace TravelApp.Models
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connString =
        Startup.Configuration["Data:DefaultConnection:TripsConnectionString"];
        optionsBuilder.UseSqlServer(connString);
        base.OnConfiguring(optionsBuilder);
    }


    public class TripContext : DbContext
    {
        public DbSet<Trip> Trips { get; set; }
        public DbSet<Stop> Stops { get; set; }
        Database.EnsureCreated();
    }

}
