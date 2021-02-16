using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddWasteShipmentsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WastesShipments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WasteTransferId = table.Column<int>(nullable: false),
                    ShipmentDate = table.Column<int>(nullable: false),
                    PostDate = table.Column<int>(nullable: false),
                    RoadTransportRegulationsObserved = table.Column<bool>(nullable: true),
                    RoadAccidentCommitment = table.Column<bool>(nullable: true),
                    CarNumber = table.Column<string>(nullable: true),
                    DriverName = table.Column<string>(nullable: true),
                    DriverPhone = table.Column<string>(nullable: true),
                    HazardousMaterialTransportingLicenseFileName = table.Column<string>(nullable: true),
                    CarGpsNumber = table.Column<string>(nullable: true),
                    BarSealNumber = table.Column<string>(nullable: true),
                    HasAnotherShipment = table.Column<bool>(nullable: true),
                    WayBillFileName = table.Column<string>(nullable: true),
                    LoadingSupervisionAgendaFileName = table.Column<string>(nullable: true),
                    LoadedWeight = table.Column<double>(nullable: true),
                    WasteReceivedDate = table.Column<int>(nullable: true),
                    WasteManagementMethod = table.Column<string>(nullable: true),
                    EliminationPossibleStartDate = table.Column<int>(nullable: true),
                    EliminationFileName = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_WastesShipments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WastesShipments_WasteTransfers_WasteTransferId",
                        column: x => x.WasteTransferId,
                        principalTable: "WasteTransfers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WastesShipments_WasteTransferId",
                table: "WastesShipments",
                column: "WasteTransferId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WastesShipments");
        }
    }
}
