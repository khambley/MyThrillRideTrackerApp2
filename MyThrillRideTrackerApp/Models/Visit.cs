using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace MyThrillRideTrackerApp.Models
{
    public class Visit : BaseModel
    {
        public int VisitId { get; set; }
        public DateTime VisitDate { get; set; }

        public int ParkId { get; set; }
        public Park Park { get; set; }

        public List<VisitRide> VisitRides { get; set; }

        public int VisitRating { get; set; }
        public string VisitComments { get; set; }

    }
}
