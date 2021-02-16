using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class DropUnusedProductTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Capacity = table.Column<int>(type: "int", nullable: true),
                    CreatedByBrowserName = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    CreatedByIp = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedDateTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    Description = table.Column<string>(type: "longtext", nullable: true),
                    HsCodeId = table.Column<int>(type: "int", nullable: true),
                    IndustryId = table.Column<int>(type: "int", nullable: true),
                    MeasurementUnitId = table.Column<int>(type: "int", nullable: true),
                    ModifiedByBrowserName = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    ModifiedByIp = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedDateTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_EnumData_HsCodeId",
                        column: x => x.HsCodeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_Industries_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_EnumData_MeasurementUnitId",
                        column: x => x.MeasurementUnitId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_HsCodeId",
                table: "Product",
                column: "HsCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_IndustryId",
                table: "Product",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_MeasurementUnitId",
                table: "Product",
                column: "MeasurementUnitId");
        }
    }
}
