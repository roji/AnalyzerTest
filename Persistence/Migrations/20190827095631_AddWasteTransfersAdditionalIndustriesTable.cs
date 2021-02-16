using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddWasteTransfersAdditionalIndustriesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomsIds",
                table: "WasteTransfers");

            migrationBuilder.DropColumn(
                name: "IndustrialEstateCompaniesIds",
                table: "WasteTransfers");

            migrationBuilder.DropColumn(
                name: "SpecialFreeZonesIds",
                table: "WasteTransfers");

            migrationBuilder.CreateTable(
                name: "WasteTransfersAdditionalIndustries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WasteTransferId = table.Column<int>(nullable: false),
                    IndustryId = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_WasteTransfersAdditionalIndustries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WasteTransfersAdditionalIndustries_Industries_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WasteTransfersAdditionalIndustries_WasteTransfers_WasteTrans~",
                        column: x => x.WasteTransferId,
                        principalTable: "WasteTransfers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WasteTransfersAdditionalIndustries_IndustryId",
                table: "WasteTransfersAdditionalIndustries",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteTransfersAdditionalIndustries_WasteTransferId",
                table: "WasteTransfersAdditionalIndustries",
                column: "WasteTransferId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WasteTransfersAdditionalIndustries");

            migrationBuilder.AddColumn<string>(
                name: "CustomsIds",
                table: "WasteTransfers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IndustrialEstateCompaniesIds",
                table: "WasteTransfers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpecialFreeZonesIds",
                table: "WasteTransfers",
                nullable: true);
        }
    }
}
