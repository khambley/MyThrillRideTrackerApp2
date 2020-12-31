﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyThrillRideTrackerApp.Models;

namespace MyThrillRideTrackerApp.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyThrillRideTrackerApp.Models.ImageFileName", b =>
                {
                    b.Property<int>("ImageFileNameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParkId")
                        .HasColumnType("int");

                    b.Property<int?>("RideId")
                        .HasColumnType("int");

                    b.Property<int?>("VisitId")
                        .HasColumnType("int");

                    b.Property<int?>("VisitRideId")
                        .HasColumnType("int");

                    b.HasKey("ImageFileNameId");

                    b.HasIndex("ParkId");

                    b.HasIndex("RideId");

                    b.HasIndex("VisitId");

                    b.HasIndex("VisitRideId");

                    b.ToTable("ImageFileNames");
                });

            modelBuilder.Entity("MyThrillRideTrackerApp.Models.Park", b =>
                {
                    b.Property<int>("ParkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParkMapLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WebsiteLink")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ParkId");

                    b.ToTable("Parks");
                });

            modelBuilder.Entity("MyThrillRideTrackerApp.Models.Ride", b =>
                {
                    b.Property<int>("RideId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BuildDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GForce")
                        .HasColumnType("int");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<int>("Length")
                        .HasColumnType("int");

                    b.Property<string>("Manufacturer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaterialType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ParkId")
                        .HasColumnType("int");

                    b.Property<string>("RideType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThrillType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TopSpeed")
                        .HasColumnType("int");

                    b.Property<string>("WebsiteLink")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RideId");

                    b.HasIndex("ParkId");

                    b.ToTable("Rides");
                });

            modelBuilder.Entity("MyThrillRideTrackerApp.Models.Visit", b =>
                {
                    b.Property<int>("VisitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ParkId")
                        .HasColumnType("int");

                    b.Property<string>("VisitComments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("VisitDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("VisitRating")
                        .HasColumnType("int");

                    b.HasKey("VisitId");

                    b.HasIndex("ParkId");

                    b.ToTable("Visits");
                });

            modelBuilder.Entity("MyThrillRideTrackerApp.Models.VisitRide", b =>
                {
                    b.Property<int>("VisitRideId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RideComments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RideId")
                        .HasColumnType("int");

                    b.Property<int>("RideRating")
                        .HasColumnType("int");

                    b.Property<int>("VisitId")
                        .HasColumnType("int");

                    b.HasKey("VisitRideId");

                    b.HasIndex("RideId");

                    b.HasIndex("VisitId");

                    b.ToTable("VisitRides");
                });

            modelBuilder.Entity("MyThrillRideTrackerApp.Models.ImageFileName", b =>
                {
                    b.HasOne("MyThrillRideTrackerApp.Models.Park", "Park")
                        .WithMany("ImageFiles")
                        .HasForeignKey("ParkId");

                    b.HasOne("MyThrillRideTrackerApp.Models.Ride", "Ride")
                        .WithMany("ImageFiles")
                        .HasForeignKey("RideId");

                    b.HasOne("MyThrillRideTrackerApp.Models.Visit", "Visit")
                        .WithMany("ImageFiles")
                        .HasForeignKey("VisitId");

                    b.HasOne("MyThrillRideTrackerApp.Models.VisitRide", "VisitRide")
                        .WithMany("ImageFiles")
                        .HasForeignKey("VisitRideId");
                });

            modelBuilder.Entity("MyThrillRideTrackerApp.Models.Ride", b =>
                {
                    b.HasOne("MyThrillRideTrackerApp.Models.Park", "Park")
                        .WithMany("Rides")
                        .HasForeignKey("ParkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyThrillRideTrackerApp.Models.Visit", b =>
                {
                    b.HasOne("MyThrillRideTrackerApp.Models.Park", "Park")
                        .WithMany("Visits")
                        .HasForeignKey("ParkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyThrillRideTrackerApp.Models.VisitRide", b =>
                {
                    b.HasOne("MyThrillRideTrackerApp.Models.Ride", "Ride")
                        .WithMany()
                        .HasForeignKey("RideId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyThrillRideTrackerApp.Models.Visit", "Visit")
                        .WithMany("VisitRides")
                        .HasForeignKey("VisitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
