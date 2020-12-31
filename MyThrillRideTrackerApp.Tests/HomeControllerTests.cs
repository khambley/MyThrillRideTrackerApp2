using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Moq;
using MyThrillRideTrackerApp.Controllers;
using MyThrillRideTrackerApp.Models;

namespace MyThrillRideTrackerApp.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void Can_Use_Repository()
        {
            // Arrange
            Mock<ITrackerRepository> mock = new Mock<ITrackerRepository>();
            mock.Setup(m => m.Rides).Returns((new Ride[]
            {
                new Ride {RideId = 1, Name = "Ride1"},
                new Ride {RideId = 2, Name = "Ride2"}
            }).AsQueryable<Ride>());

            HomeController controller = new HomeController(mock.Object);

            // Act
            // to get data returned from Action method, have to cast the value of its ViewData.Model property to the expected data type. p.344
            IEnumerable<Ride> result =
                (controller.Index() as ViewResult).ViewData.Model
                as IEnumerable<Ride>;

            // Assert
            Ride[] rideArray = result.ToArray();
            Assert.True(rideArray.Length == 2);
            Assert.Equal("Ride1", rideArray[0].Name);
            Assert.Equal("Ride2", rideArray[1].Name);
        }
    }
}
