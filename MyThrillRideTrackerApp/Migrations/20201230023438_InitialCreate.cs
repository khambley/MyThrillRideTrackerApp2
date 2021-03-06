﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyThrillRideTrackerApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parks",
                columns: table => new
                {
                    ParkId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    WebsiteLink = table.Column<string>(nullable: true),
                    ParkMapLink = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parks", x => x.ParkId);
                });

            migrationBuilder.CreateTable(
                name: "Rides",
                columns: table => new
                {
                    RideId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Height = table.Column<int>(nullable: false),
                    Length = table.Column<int>(nullable: false),
                    TopSpeed = table.Column<int>(nullable: false),
                    RideType = table.Column<string>(nullable: true),
                    WebsiteLink = table.Column<string>(nullable: true),
                    BuildDate = table.Column<DateTime>(nullable: false),
                    ParkId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rides", x => x.RideId);
                    table.ForeignKey(
                        name: "FK_Rides_Parks_ParkId",
                        column: x => x.ParkId,
                        principalTable: "Parks",
                        principalColumn: "ParkId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Visits",
                columns: table => new
                {
                    VisitId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitDate = table.Column<DateTime>(nullable: false),
                    ParkId = table.Column<int>(nullable: false),
                    VisitRating = table.Column<int>(nullable: false),
                    VisitComments = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visits", x => x.VisitId);
                    table.ForeignKey(
                        name: "FK_Visits_Parks_ParkId",
                        column: x => x.ParkId,
                        principalTable: "Parks",
                        principalColumn: "ParkId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VisitRides",
                columns: table => new
                {
                    VisitRideId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RideId = table.Column<int>(nullable: false),
                    VisitId = table.Column<int>(nullable: false),
                    RideRating = table.Column<int>(nullable: false),
                    RideComments = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitRides", x => x.VisitRideId);
                    table.ForeignKey(
                        name: "FK_VisitRides_Rides_RideId",
                        column: x => x.RideId,
                        principalTable: "Rides",
                        principalColumn: "RideId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_VisitRides_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "Visits",
                        principalColumn: "VisitId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ImageFileNames",
                columns: table => new
                {
                    ImageFileNameId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(nullable: true),
                    ParkId = table.Column<int>(nullable: true),
                    RideId = table.Column<int>(nullable: true),
                    VisitId = table.Column<int>(nullable: true),
                    VisitRideId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageFileNames", x => x.ImageFileNameId);
                    table.ForeignKey(
                        name: "FK_ImageFileNames_Parks_ParkId",
                        column: x => x.ParkId,
                        principalTable: "Parks",
                        principalColumn: "ParkId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ImageFileNames_Rides_RideId",
                        column: x => x.RideId,
                        principalTable: "Rides",
                        principalColumn: "RideId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ImageFileNames_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "Visits",
                        principalColumn: "VisitId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ImageFileNames_VisitRides_VisitRideId",
                        column: x => x.VisitRideId,
                        principalTable: "VisitRides",
                        principalColumn: "VisitRideId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ImageFileNames_ParkId",
                table: "ImageFileNames",
                column: "ParkId");

            migrationBuilder.CreateIndex(
                name: "IX_ImageFileNames_RideId",
                table: "ImageFileNames",
                column: "RideId");

            migrationBuilder.CreateIndex(
                name: "IX_ImageFileNames_VisitId",
                table: "ImageFileNames",
                column: "VisitId");

            migrationBuilder.CreateIndex(
                name: "IX_ImageFileNames_VisitRideId",
                table: "ImageFileNames",
                column: "VisitRideId");

            migrationBuilder.CreateIndex(
                name: "IX_Rides_ParkId",
                table: "Rides",
                column: "ParkId");

            migrationBuilder.CreateIndex(
                name: "IX_VisitRides_RideId",
                table: "VisitRides",
                column: "RideId");

            migrationBuilder.CreateIndex(
                name: "IX_VisitRides_VisitId",
                table: "VisitRides",
                column: "VisitId");

            migrationBuilder.CreateIndex(
                name: "IX_Visits_ParkId",
                table: "Visits",
                column: "ParkId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ImageFileNames");

            migrationBuilder.DropTable(
                name: "VisitRides");

            migrationBuilder.DropTable(
                name: "Rides");

            migrationBuilder.DropTable(
                name: "Visits");

            migrationBuilder.DropTable(
                name: "Parks");
        }
    }
}
