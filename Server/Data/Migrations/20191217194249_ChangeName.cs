using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class ChangeName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LicenceType",
                table: "Drivers");

            migrationBuilder.AddColumn<int>(
                name: "LicenseType",
                table: "Drivers",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LicenseType",
                table: "Drivers");

            migrationBuilder.AddColumn<int>(
                name: "LicenceType",
                table: "Drivers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
