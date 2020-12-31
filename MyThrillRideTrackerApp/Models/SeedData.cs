using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MyThrillRideTrackerApp.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            DataContext context =
                app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<DataContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Parks.Any())
            {
                context.Parks.AddRange(
                    new Park
                    {
                        Name = "Test Park 1",
                        Description = "This is a test ride description.",
                        City = "Chicago",
                        State = "IL",
                        WebsiteLink = "http://www.google.com",
                        ParkMapLink = "http://google.com/maps",
                        ImageFiles = new List<ImageFileName>()
                        {
                            new ImageFileName()
                            {
                                FileName = "logo1.png"
                            }
                        },
                        Rides = new List<Ride>
                        {
                            new Ride()
                            {
                                Name = "Test Ride 1",
                                Description = "This is a test ride description.",
                                Height = 150,
                                Length = 1200,
                                TopSpeed = 55,
                                RideType = "Roller Coaster",
                                WebsiteLink = "http://www.google.com",
                                BuildDate = Convert.ToDateTime("01/01/2018"),
                                ImageFiles = new List<ImageFileName>()
                                {
                                    new ImageFileName()
                                    {
                                        FileName = "image1.jpg"
                                    }
                                }
                            },
                            new Ride()
                            {
                                Name = "Test Ride 2",
                                Description = "This is a test ride description.",
                                Height = 182,
                                Length = 2400,
                                TopSpeed = 65,
                                RideType = "Roller Coaster",
                                WebsiteLink = "http://www.google.com",
                                BuildDate = Convert.ToDateTime("01/01/2015"),
                                ImageFiles = new List<ImageFileName>()
                                {
                                    new ImageFileName()
                                    {
                                        FileName = "image2.jpg"
                                    }
                                }
                            },
                            new Ride()
                            {
                                Name = "Test Ride 3",
                                Description = "This is a test ride description.",
                                Height = 182,
                                Length = 2400,
                                TopSpeed = 65,
                                RideType = "Roller Coaster",
                                WebsiteLink = "http://www.google.com",
                                BuildDate = Convert.ToDateTime("01/01/2015"),
                                ImageFiles = new List<ImageFileName>()
                                {
                                    new ImageFileName()
                                    {
                                        FileName = "logo1.png"
                                    }
                                }
                            }
                        }
                    },
                    new Park
                    {
                        Name = "Six Flags Great America",
                        Description = "This is a great park.",
                        City = "Gurnee",
                        State = "IL",
                        WebsiteLink = "http://www.google.com",
                        ParkMapLink = "http://google.com/maps",
                        ImageFiles = new List<ImageFileName>()
                        {
                            new ImageFileName()
                            {
                                FileName = "logo1.png"
                            }
                        },
                        Rides = new List<Ride>
                        {
                            new Ride()
                            {
                                Name = "MaxForce",
                                Description = "This is a really fun ride.",
                                Height = 100,
                                Length = 1000,
                                TopSpeed = 75,
                                RideType = "Roller Coaster",
                                WebsiteLink = "http://www.google.com",
                                BuildDate = Convert.ToDateTime("07/03/2019"),
                                ImageFiles = new List<ImageFileName>()
                                {
                                    new ImageFileName()
                                    {
                                        FileName = "image1.jpg"
                                    }
                                }
                            },
                            new Ride()
                            {
                                Name = "Test Ride 2",
                                Description = "This is a test ride description.",
                                Height = 182,
                                Length = 2400,
                                TopSpeed = 65,
                                RideType = "Roller Coaster",
                                WebsiteLink = "http://www.google.com",
                                BuildDate = Convert.ToDateTime("01/01/2015"),
                                ImageFiles = new List<ImageFileName>()
                                {
                                    new ImageFileName()
                                    {
                                        FileName = "image2.jpg"
                                    }
                                }
                            },
                            new Ride()
                            {
                                Name = "Test Ride 3",
                                Description = "This is a test ride description.",
                                Height = 182,
                                Length = 2400,
                                TopSpeed = 65,
                                RideType = "Roller Coaster",
                                WebsiteLink = "http://www.google.com",
                                BuildDate = Convert.ToDateTime("01/01/2015"),
                                ImageFiles = new List<ImageFileName>()
                                {
                                    new ImageFileName()
                                    {
                                        FileName = "logo1.png"
                                    }
                                }
                            }
                        }
                    }
                );
                context.SaveChanges();

            }
        }
    }
}
