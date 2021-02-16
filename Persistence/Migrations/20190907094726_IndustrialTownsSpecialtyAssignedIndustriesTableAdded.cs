using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class IndustrialTownsSpecialtyAssignedIndustriesTableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AssignedIndustriesQuantity",
                table: "IndustrialTownsSpecialtyInfos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CommitmentsFileName",
                table: "IndustrialTownsSpecialtyInfos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DevelopmentPrediction",
                table: "IndustrialTownsSpecialtyInfos",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "FuturePredictionArea",
                table: "IndustrialTownsSpecialtyInfos",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "InfrastructureSpace",
                table: "IndustrialTownsSpecialtyInfos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Latitude",
                table: "IndustrialTownsSpecialtyInfos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LicenseFileName",
                table: "IndustrialTownsSpecialtyInfos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Longitude",
                table: "IndustrialTownsSpecialtyInfos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UnassignedIndustriesQuantity",
                table: "IndustrialTownsSpecialtyInfos",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "IndustrialTownsSpecialtyAssignedIndustries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IndustryName = table.Column<string>(nullable: true),
                    IndustrialTownsSpecialtyInfoId = table.Column<int>(nullable: false),
                    CreatedByBrowserName = table.Column<string>(maxLength: 1000, nullable: true),
                    CreatedByIp = table.Column<string>(maxLength: 255, nullable: true),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedDateTime = table.Column<DateTimeOffset>(nullable: true),
                    ModifiedByBrowserName = table.Column<string>(maxLength: 1000, nullable: true),
                    ModifiedByIp = table.Column<string>(maxLength: 255, nullable: true),
                    ModifiedByUserId = table.Column<int>(nullable: true),
                    ModifiedDateTime = table.Column<DateTimeOffset>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndustrialTownsSpecialtyAssignedIndustries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndustrialTownsSpecialtyAssignedIndustries_IndustrialTownsSp~",
                        column: x => x.IndustrialTownsSpecialtyInfoId,
                        principalTable: "IndustrialTownsSpecialtyInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialTownsSpecialtyAssignedIndustries_IndustrialTownsSp~",
                table: "IndustrialTownsSpecialtyAssignedIndustries",
                column: "IndustrialTownsSpecialtyInfoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IndustrialTownsSpecialtyAssignedIndustries");

            migrationBuilder.DropColumn(
                name: "AssignedIndustriesQuantity",
                table: "IndustrialTownsSpecialtyInfos");

            migrationBuilder.DropColumn(
                name: "CommitmentsFileName",
                table: "IndustrialTownsSpecialtyInfos");

            migrationBuilder.DropColumn(
                name: "DevelopmentPrediction",
                table: "IndustrialTownsSpecialtyInfos");

            migrationBuilder.DropColumn(
                name: "FuturePredictionArea",
                table: "IndustrialTownsSpecialtyInfos");

            migrationBuilder.DropColumn(
                name: "InfrastructureSpace",
                table: "IndustrialTownsSpecialtyInfos");

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "IndustrialTownsSpecialtyInfos");

            migrationBuilder.DropColumn(
                name: "LicenseFileName",
                table: "IndustrialTownsSpecialtyInfos");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "IndustrialTownsSpecialtyInfos");

            migrationBuilder.DropColumn(
                name: "UnassignedIndustriesQuantity",
                table: "IndustrialTownsSpecialtyInfos");
        }
    }
}
