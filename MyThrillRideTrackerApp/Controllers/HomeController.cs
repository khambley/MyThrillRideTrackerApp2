using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using MyThrillRideTrackerApp.Models;

namespace MyThrillRideTrackerApp.Controllers
{
    public class HomeController : Controller
    {
        private ITrackerRepository repository;

        public HomeController(ITrackerRepository repo)
        {
            repository = repo;
        }
        public IActionResult Index() => View(repository.Rides);
    }
}
