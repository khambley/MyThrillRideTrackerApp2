using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyThrillRideTrackerApp.Models;

namespace MyThrillRideTrackerApp.Models.ViewModels
{
    public class RideListViewModel
    {
        public IEnumerable<Ride> Rides { get; set; }
        public PagingInfo PagingInfo { get; set; }

    }
}
