using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddNormalWasteInformationsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NormalWasteInformations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WasteId = table.Column<int>(nullable: false),
                    DailyAverageProduction = table.Column<double>(nullable: true),
                    TemporaryHoldingStorageWithDoorQuantity = table.Column<int>(nullable: true),
                    TemporaryHoldingStorageWithoutDoorQuantity = table.Column<int>(nullable: true),
                    TemporaryDepotLocationOrTransportCar = table.Column<bool>(nullable: true),
                    DepotLocationTypeId = table.Column<int>(nullable: true),
                    DltDescription = table.Column<string>(nullable: true),
                    HoldingWithIndustrialWastes = table.Column<bool>(nullable: true),
                    HwiwDescription = table.Column<string>(nullable: true),
                    DepotHasRoof = table.Column<bool>(nullable: true),
                    Latitude = table.Column<string>(nullable: true),
                    Longitude = table.Column<string>(nullable: true),
                    PackagingInGoodBags = table.Column<bool>(nullable: true),
                    PigbDescription = table.Column<string>(nullable: true),
                    IsWasteSeparated = table.Column<bool>(nullable: true),
                    NormalWasteTransportFrequencyId = table.Column<int>(nullable: true),
                    TransportingCompanyName = table.Column<string>(nullable: true),
                    HasContract = table.Column<bool>(nullable: true),
                    ContractExpirationDate = table.Column<int>(nullable: true),
                    ContractFileName = table.Column<string>(nullable: true),
                    WasteTransportFinalDestination = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_NormalWasteInformations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NormalWasteInformations_EnumData_DepotLocationTypeId",
                        column: x => x.DepotLocationTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NormalWasteInformations_EnumData_NormalWasteTransportFrequen~",
                        column: x => x.NormalWasteTransportFrequencyId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NormalWasteInformations_Wastes_WasteId",
                        column: x => x.WasteId,
                        principalTable: "Wastes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NormalWasteInformations_DepotLocationTypeId",
                table: "NormalWasteInformations",
                column: "DepotLocationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_NormalWasteInformations_NormalWasteTransportFrequencyId",
                table: "NormalWasteInformations",
                column: "NormalWasteTransportFrequencyId");

            migrationBuilder.CreateIndex(
                name: "IX_NormalWasteInformations_WasteId",
                table: "NormalWasteInformations",
                column: "WasteId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NormalWasteInformations");
        }
    }
}
