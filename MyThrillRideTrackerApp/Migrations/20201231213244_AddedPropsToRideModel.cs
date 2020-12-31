using Microsoft.EntityFrameworkCore.Migrations;

namespace MyThrillRideTrackerApp.Migrations
{
    public partial class AddedPropsToRideModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImageFileNames_Parks_ParkId",
                table: "ImageFileNames");

            migrationBuilder.DropForeignKey(
                name: "FK_ImageFileNames_Rides_RideId",
                table: "ImageFileNames");

            migrationBuilder.DropForeignKey(
                name: "FK_ImageFileNames_Visits_VisitId",
                table: "ImageFileNames");

            migrationBuilder.DropForeignKey(
                name: "FK_ImageFileNames_VisitRides_VisitRideId",
                table: "ImageFileNames");

            migrationBuilder.AddColumn<int>(
                name: "GForce",
                table: "Rides",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Manufacturer",
                table: "Rides",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MaterialType",
                table: "Rides",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThrillType",
                table: "Rides",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "VisitRideId",
                table: "ImageFileNames",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "VisitId",
                table: "ImageFileNames",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "RideId",
                table: "ImageFileNames",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ParkId",
                table: "ImageFileNames",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ImageFileNames_Parks_ParkId",
                table: "ImageFileNames",
                column: "ParkId",
                principalTable: "Parks",
                principalColumn: "ParkId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ImageFileNames_Rides_RideId",
                table: "ImageFileNames",
                column: "RideId",
                principalTable: "Rides",
                principalColumn: "RideId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ImageFileNames_Visits_VisitId",
                table: "ImageFileNames",
                column: "VisitId",
                principalTable: "Visits",
                principalColumn: "VisitId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ImageFileNames_VisitRides_VisitRideId",
                table: "ImageFileNames",
                column: "VisitRideId",
                principalTable: "VisitRides",
                principalColumn: "VisitRideId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImageFileNames_Parks_ParkId",
                table: "ImageFileNames");

            migrationBuilder.DropForeignKey(
                name: "FK_ImageFileNames_Rides_RideId",
                table: "ImageFileNames");

            migrationBuilder.DropForeignKey(
                name: "FK_ImageFileNames_Visits_VisitId",
                table: "ImageFileNames");

            migrationBuilder.DropForeignKey(
                name: "FK_ImageFileNames_VisitRides_VisitRideId",
                table: "ImageFileNames");

            migrationBuilder.DropColumn(
                name: "GForce",
                table: "Rides");

            migrationBuilder.DropColumn(
                name: "Manufacturer",
                table: "Rides");

            migrationBuilder.DropColumn(
                name: "MaterialType",
                table: "Rides");

            migrationBuilder.DropColumn(
                name: "ThrillType",
                table: "Rides");

            migrationBuilder.AlterColumn<int>(
                name: "VisitRideId",
                table: "ImageFileNames",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "VisitId",
                table: "ImageFileNames",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RideId",
                table: "ImageFileNames",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ParkId",
                table: "ImageFileNames",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ImageFileNames_Parks_ParkId",
                table: "ImageFileNames",
                column: "ParkId",
                principalTable: "Parks",
                principalColumn: "ParkId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ImageFileNames_Rides_RideId",
                table: "ImageFileNames",
                column: "RideId",
                principalTable: "Rides",
                principalColumn: "RideId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ImageFileNames_Visits_VisitId",
                table: "ImageFileNames",
                column: "VisitId",
                principalTable: "Visits",
                principalColumn: "VisitId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ImageFileNames_VisitRides_VisitRideId",
                table: "ImageFileNames",
                column: "VisitRideId",
                principalTable: "VisitRides",
                principalColumn: "VisitRideId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
