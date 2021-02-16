using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddWasteTransfersRelatedProvincesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RelatedProvincesIds",
                table: "WasteTransfers");

            migrationBuilder.CreateTable(
                name: "WasteTransfersRelatedProvinces",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WasteTransferId = table.Column<int>(nullable: false),
                    ProvinceId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_WasteTransfersRelatedProvinces", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WasteTransfersRelatedProvinces_EnumData_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WasteTransfersRelatedProvinces_WasteTransfers_WasteTransferId",
                        column: x => x.WasteTransferId,
                        principalTable: "WasteTransfers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WasteTransfersRelatedProvinces_ProvinceId",
                table: "WasteTransfersRelatedProvinces",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteTransfersRelatedProvinces_WasteTransferId",
                table: "WasteTransfersRelatedProvinces",
                column: "WasteTransferId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WasteTransfersRelatedProvinces");

            migrationBuilder.AddColumn<string>(
                name: "RelatedProvincesIds",
                table: "WasteTransfers",
                nullable: true);
        }
    }
}
