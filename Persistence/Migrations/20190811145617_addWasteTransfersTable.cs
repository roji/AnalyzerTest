using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class addWasteTransfersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WasteTransfers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WasteId = table.Column<int>(nullable: false),
                    Quantity = table.Column<double>(nullable: false),
                    SenderIndustryId = table.Column<int>(nullable: false),
                    RecieverIndustryId = table.Column<int>(nullable: false),
                    TransferRequestDate = table.Column<DateTimeOffset>(nullable: false),
                    WasteAnalysisFileName = table.Column<string>(nullable: true),
                    RelatedProvincesIds = table.Column<string>(nullable: true),
                    WasteAnalysisResultFileName = table.Column<string>(nullable: true),
                    PostDeadlineDate = table.Column<int>(nullable: true),
                    WasteTransferStatus = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_WasteTransfers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WasteTransfers_Industries_RecieverIndustryId",
                        column: x => x.RecieverIndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WasteTransfers_Industries_SenderIndustryId",
                        column: x => x.SenderIndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WasteTransfers_Wastes_WasteId",
                        column: x => x.WasteId,
                        principalTable: "Wastes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WasteTransfers_RecieverIndustryId",
                table: "WasteTransfers",
                column: "RecieverIndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteTransfers_SenderIndustryId",
                table: "WasteTransfers",
                column: "SenderIndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteTransfers_WasteId",
                table: "WasteTransfers",
                column: "WasteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WasteTransfers");
        }
    }
}
