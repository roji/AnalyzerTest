using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class removeauditableinterfacefromLicensetable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedByBrowserName",
                table: "Industry_License");

            migrationBuilder.DropColumn(
                name: "CreatedByIp",
                table: "Industry_License");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "Industry_License");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "Industry_License");

            migrationBuilder.DropColumn(
                name: "ModifiedByBrowserName",
                table: "Industry_License");

            migrationBuilder.DropColumn(
                name: "ModifiedByIp",
                table: "Industry_License");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                table: "Industry_License");

            migrationBuilder.DropColumn(
                name: "ModifiedDateTime",
                table: "Industry_License");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedByBrowserName",
                table: "Industry_License",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByIp",
                table: "Industry_License",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "Industry_License",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedDateTime",
                table: "Industry_License",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByBrowserName",
                table: "Industry_License",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByIp",
                table: "Industry_License",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                table: "Industry_License",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ModifiedDateTime",
                table: "Industry_License",
                nullable: true);
        }
    }
}
