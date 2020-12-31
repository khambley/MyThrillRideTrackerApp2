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
                        Name = "Six Flags Great America",
                        Description = "This is a great park.",
                        City = "Gurnee",
                        State = "IL",
                        WebsiteLink = "https://www.sixflags.com/greatamerica/",
                        ParkMapLink = "https://www.sixflags.com/greatamerica/plan-your-visit/park-map",
                        ImageFiles = new List<ImageFileName>()
                        {
                            new ImageFileName()
                            {
                                FileName = "SFGA-logo1.png"
                            }
                        },
                        Rides = new List<Ride>
                        {
                            new Ride()
                            {
                                Name = "Batman The Ride",
                                Description = "This is a fun looping coaster.",
                                Height = 105,
                                Length = 2700,
                                TopSpeed = 55,
                                GForce = 4,
                                RideType = "Roller Coaster",
                                ThrillType = "High",
                                MaterialType = "Steel",
                                WebsiteLink = "https://www.sixflags.com/greatamerica/attractions/batman-ride-5",
                                BuildDate = Convert.ToDateTime("05/02/1992"),
                                Manufacturer = "Bolliger & Mabillard",
                                ImageFiles = new List<ImageFileName>()
                                {
                                    new ImageFileName()
                                    {
                                        FileName = "Batman_The_Ride_at_Six_Flags_Great_America.jpg"
                                    }
                                }
                            },
                            new Ride()
                            {
                                Name = "Raging Bull",
                                Description = "This is an all-time favorite fun coaster.",
                                Height = 202,
                                Length = 5057,
                                TopSpeed = 73,
                                GForce = 4,
                                RideType = "Roller Coaster",
                                ThrillType = "High",
                                MaterialType = "Steel",
                                WebsiteLink = "https://www.sixflags.com/greatamerica/attractions/raging-bull",
                                BuildDate = Convert.ToDateTime("05/01/1999"),
                                Manufacturer = "Bolliger & Mabillard",
                                ImageFiles = new List<ImageFileName>()
                                {
                                    new ImageFileName()
                                    {
                                        FileName = "raging-bull.jpg"
                                    }
                                }
                            },
                            new Ride()
                            {
                                Name = "Goliath",
                                Description = "This is a super fast zero-G inverted thrill coaster.",
                                Height = 180,
                                Length = 3084,
                                TopSpeed = 72,
                                GForce = 0,
                                RideType = "Roller Coaster",
                                ThrillType = "Max",
                                MaterialType = "Wooden",
                                WebsiteLink = "https://www.sixflags.com/greatamerica/attractions/goliath-3",
                                BuildDate = Convert.ToDateTime("06/19/2014"),
                                Manufacturer = "Rocky Mountain Construction",
                                ImageFiles = new List<ImageFileName>()
                                {
                                    new ImageFileName()
                                    {
                                        FileName = "Goliath-Great-America1.jpg"
                                    }
                                }
                            }
                        }
                    },
                    new Park
                    {
                        Name = "Six Flags Fiesta Texas",
                        Description = "This is a great park.",
                        City = "San Antonio",
                        State = "TX",
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
                                Name = "Goliath",
                                Description = "This is like the Batman at GA.",
                                Height = 100,
                                Length = 2693,
                                TopSpeed = 55,
                                GForce = 4,
                                RideType = "Roller Coaster",
                                ThrillType = "High",
                                MaterialType = "Steel",
                                WebsiteLink = "https://www.sixflags.com/fiestatexas/attractions/goliath-4",
                                BuildDate = Convert.ToDateTime("05/03/2008"),
                                Manufacturer = "Bolliger & Mabillard",
                                ImageFiles = new List<ImageFileName>()
                                {
                                    new ImageFileName()
                                    {
                                        FileName = "sfft_goliath1.jpg"
                                    }
                                }
                            },
                            new Ride()
                            {
                                Name = "Iron Rattler",
                                Description = "This is similar to the Goliath at GA.",
                                Height = 182,
                                Length = 3266,
                                TopSpeed = 70,
                                GForce = 4,
                                RideType = "Roller Coaster",
                                ThrillType = "Max",
                                MaterialType = "Wooden",
                                WebsiteLink = "https://www.sixflags.com/fiestatexas/attractions/iron-rattler",
                                BuildDate = Convert.ToDateTime("05/01/2013"),
                                Manufacturer = "Rocky Mountain Construction",
                                ImageFiles = new List<ImageFileName>()
                                {
                                    new ImageFileName()
                                    {
                                        FileName = "iron-rattler1.jpg"
                                    }
                                }
                            },
                            new Ride()
                            {
                                Name = "Boomerang",
                                Description = "This is a fast looping roller coaster.",
                                Height = 125,
                                Length = 936,
                                TopSpeed = 58,
                                GForce = 5,
                                RideType = "Roller Coaster",
                                ThrillType = "Max",
                                MaterialType = "Steel",
                                WebsiteLink = "https://www.sixflags.com/fiestatexas/attractions/boomerang-2",
                                BuildDate = Convert.ToDateTime("05/01/1999"),
                                Manufacturer = "Vekoma",
                                ImageFiles = new List<ImageFileName>()
                                {
                                    new ImageFileName()
                                    {
                                        FileName = "Boomerang1.jpg"
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
