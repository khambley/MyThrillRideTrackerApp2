using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace MyThrillRideTrackerApp.Models
{
    public interface ITrackerRepository
    {
        //Derived from the IEnumerable<T> interface, a collection of objects that can be queried.
        IQueryable<Ride> Rides { get; }
    }
}
