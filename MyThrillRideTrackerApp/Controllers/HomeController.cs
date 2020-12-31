using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using MyThrillRideTrackerApp.Models;
using System.Linq;
using MyThrillRideTrackerApp.Models.ViewModels;

namespace MyThrillRideTrackerApp.Controllers
{
    public class HomeController : Controller
    {
        private ITrackerRepository repository;
        public int PageSize = 4;

        public HomeController(ITrackerRepository repo)
        {
            repository = repo;
        }
        //public IActionResult Index(int ridePage = 1) => View(repository.Rides
        //    .OrderBy(r => r.RideId)
        //    .Skip((ridePage - 1) * PageSize)
        //    .Take(PageSize));

        // Be sure to change the Index view @model to RideListViewModel or you'll get a compile error
        //public ViewResult Index(int ridePage = 1)
        //    => View(new RideListViewModel
        //    {
        //        Rides = repository.Rides
        //            .OrderBy(p => p.RideId)
        //            .Skip((ridePage - 1) * PageSize)
        //            .Take(PageSize),
        //        PagingInfo = new PagingInfo
        //        {
        //            CurrentPage = ridePage,
        //            ItemsPerPage = PageSize,
        //            TotalItems = repository.Rides.Count()
        //        }
        //    });

        public ViewResult Index(int ridePage = 1)
        {
            var rideListViewModel = new RideListViewModel()
            {
                Rides = repository.Rides
                    .OrderBy(r => r.RideId)
                    .Skip((ridePage - 1) * PageSize)
                    .Take(PageSize)
                ,
                PagingInfo = new PagingInfo
                {
                    CurrentPage = ridePage,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Rides.Count()
                }
            };
            return View(rideListViewModel);
        }

    }
}
