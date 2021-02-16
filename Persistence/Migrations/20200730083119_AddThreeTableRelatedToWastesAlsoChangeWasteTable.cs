using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddThreeTableRelatedToWastesAlsoChangeWasteTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsWasteRecyclingInUnit",
                table: "Wastes");

            migrationBuilder.AddColumn<double>(
                name: "BurialPercentage",
                table: "Wastes",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "BurnPercentage",
                table: "Wastes",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "PilingUpPercentage",
                table: "Wastes",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "RecyclePercentage",
                table: "Wastes",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "SalePercentage",
                table: "Wastes",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "TransferToAuthorizedCenterPercentage",
                table: "Wastes",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "WasteCollectMethods",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CollectMethodId = table.Column<int>(nullable: false),
                    WasteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WasteCollectMethods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WasteCollectMethods_EnumData_CollectMethodId",
                        column: x => x.CollectMethodId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WasteCollectMethods_Wastes_WasteId",
                        column: x => x.WasteId,
                        principalTable: "Wastes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WasteKeepingMethods",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    KeepingMethodId = table.Column<int>(nullable: false),
                    WasteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WasteKeepingMethods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WasteKeepingMethods_EnumData_KeepingMethodId",
                        column: x => x.KeepingMethodId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WasteKeepingMethods_Wastes_WasteId",
                        column: x => x.WasteId,
                        principalTable: "Wastes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WasteMaterialModes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MaterialModeId = table.Column<int>(nullable: false),
                    WasteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WasteMaterialModes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WasteMaterialModes_EnumData_MaterialModeId",
                        column: x => x.MaterialModeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WasteMaterialModes_Wastes_WasteId",
                        column: x => x.WasteId,
                        principalTable: "Wastes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WasteCollectMethods_CollectMethodId",
                table: "WasteCollectMethods",
                column: "CollectMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteCollectMethods_WasteId",
                table: "WasteCollectMethods",
                column: "WasteId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteKeepingMethods_KeepingMethodId",
                table: "WasteKeepingMethods",
                column: "KeepingMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteKeepingMethods_WasteId",
                table: "WasteKeepingMethods",
                column: "WasteId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteMaterialModes_MaterialModeId",
                table: "WasteMaterialModes",
                column: "MaterialModeId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteMaterialModes_WasteId",
                table: "WasteMaterialModes",
                column: "WasteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WasteCollectMethods");

            migrationBuilder.DropTable(
                name: "WasteKeepingMethods");

            migrationBuilder.DropTable(
                name: "WasteMaterialModes");

            migrationBuilder.DropColumn(
                name: "BurialPercentage",
                table: "Wastes");

            migrationBuilder.DropColumn(
                name: "BurnPercentage",
                table: "Wastes");

            migrationBuilder.DropColumn(
                name: "PilingUpPercentage",
                table: "Wastes");

            migrationBuilder.DropColumn(
                name: "RecyclePercentage",
                table: "Wastes");

            migrationBuilder.DropColumn(
                name: "SalePercentage",
                table: "Wastes");

            migrationBuilder.DropColumn(
                name: "TransferToAuthorizedCenterPercentage",
                table: "Wastes");

            migrationBuilder.AddColumn<bool>(
                name: "IsWasteRecyclingInUnit",
                table: "Wastes",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }
    }
}
