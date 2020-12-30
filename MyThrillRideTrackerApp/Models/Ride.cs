using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace MyThrillRideTrackerApp.Models
{
    public class Ride
    {
        public int RideId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Height { get; set; }
        public int Length { get; set; }

        [Display(Name = "Top Speed")]
        public int TopSpeed { get; set; } //mph
        public string RideType { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Build Date")]
        public DateTime BuildDate { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }
        public List<ImageFileName> ImageFiles { get; set; }

        public int ParkId { get; set; }
        public Park Park { get; set; }

    }
}
