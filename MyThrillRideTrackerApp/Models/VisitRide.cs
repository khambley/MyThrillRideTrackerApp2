using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace MyThrillRideTrackerApp.Models
{
    public class VisitRide : BaseModel
    {
        public int VisitRideId { get; set; }

        public int RideId { get; set; }
        public Ride Ride { get; set; }

        public int VisitId { get; set; }
        public Visit Visit { get; set; }

        public int RideRating { get; set; }
        public string RideComments { get; set; }



    }
}
