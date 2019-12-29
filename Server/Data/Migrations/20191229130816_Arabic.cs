﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Arabic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Frequencys");

            migrationBuilder.AddColumn<string>(
                name: "ArabicName",
                table: "Frequencys",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EnglishName",
                table: "Frequencys",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArabicName",
                table: "Frequencys");

            migrationBuilder.DropColumn(
                name: "EnglishName",
                table: "Frequencys");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Frequencys",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
