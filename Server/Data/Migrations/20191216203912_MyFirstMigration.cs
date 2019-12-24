using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: false),
                    PasswordHash = table.Column<byte[]>(nullable: false),
                    PasswordSalt = table.Column<byte[]>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vendors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Department = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendorId = table.Column<int>(nullable: false),
                    SubContractor = table.Column<string>(nullable: true),
                    DriverName = table.Column<string>(nullable: true),
                    NationalID = table.Column<string>(nullable: true),
                    LicenceType = table.Column<int>(nullable: false),
                    LicenseExpiryDate = table.Column<DateTime>(type: "date", nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    MedicalExaminationDate = table.Column<DateTime>(type: "date", nullable: true),
                    DrugTestDate = table.Column<DateTime>(type: "date", nullable: true),
                    DefensiveDriving = table.Column<string>(nullable: true),
                    HiringDate = table.Column<DateTime>(type: "date", nullable: true),
                    WarningLetter1 = table.Column<string>(nullable: true),
                    WarningLetter2 = table.Column<string>(nullable: true),
                    TerminationDate = table.Column<DateTime>(type: "date", nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Drivers_Vendors_VendorId",
                        column: x => x.VendorId,
                        principalTable: "Vendors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendorId = table.Column<int>(nullable: false),
                    SubContractor = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Year = table.Column<string>(nullable: true),
                    Characters = table.Column<string>(nullable: true),
                    Numbers = table.Column<string>(nullable: true),
                    PlateNumber = table.Column<string>(nullable: true),
                    ExpiryDate = table.Column<DateTime>(type: "date", nullable: true),
                    LatestMaintenanceDate = table.Column<DateTime>(type: "date", nullable: true),
                    MaintenanceKM = table.Column<int>(nullable: true),
                    TyreChangeDate = table.Column<DateTime>(type: "date", nullable: true),
                    TyreChangeKM = table.Column<int>(nullable: true),
                    NextTyreChangeKM = table.Column<int>(nullable: true),
                    GPSLink = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    LastSeenDate = table.Column<DateTime>(type: "date", nullable: true),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehicles_Vendors_VendorId",
                        column: x => x.VendorId,
                        principalTable: "Vendors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Drivers_VendorId",
                table: "Drivers",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_VendorId",
                table: "Vehicles",
                column: "VendorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "Vendors");
        }
    }
}
