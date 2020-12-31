using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyThrillRideTrackerApp.Models
{
    public class TrackerRepository : ITrackerRepository
    {
        private DataContext context;

        public TrackerRepository(DataContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Ride> Rides => context.Rides.Include(r => r.Park);
    }
}
