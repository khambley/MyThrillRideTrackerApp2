using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyThrillRideTrackerApp.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        public DbSet<Park> Parks { get; set; }
        public DbSet<Ride> Rides { get; set; }
        public DbSet<Visit> Visits { get; set; }
        public DbSet<VisitRide> VisitRides { get; set; }
        public DbSet<ImageFileName> ImageFileNames { get; set; }

    }
}
