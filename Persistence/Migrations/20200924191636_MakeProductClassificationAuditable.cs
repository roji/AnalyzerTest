using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class MakeProductClassificationAuditable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedByBrowserName",
                table: "ProductClassifications",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByIp",
                table: "ProductClassifications",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "ProductClassifications",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedDateTime",
                table: "ProductClassifications",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByBrowserName",
                table: "ProductClassifications",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByIp",
                table: "ProductClassifications",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                table: "ProductClassifications",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ModifiedDateTime",
                table: "ProductClassifications",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedByBrowserName",
                table: "ProductClassifications");

            migrationBuilder.DropColumn(
                name: "CreatedByIp",
                table: "ProductClassifications");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "ProductClassifications");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "ProductClassifications");

            migrationBuilder.DropColumn(
                name: "ModifiedByBrowserName",
                table: "ProductClassifications");

            migrationBuilder.DropColumn(
                name: "ModifiedByIp",
                table: "ProductClassifications");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                table: "ProductClassifications");

            migrationBuilder.DropColumn(
                name: "ModifiedDateTime",
                table: "ProductClassifications");
        }
    }
}
