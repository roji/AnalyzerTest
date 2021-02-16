using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class ChangeCustomFieldsinWasteExportImport : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WasteExportImportCustoms");

            migrationBuilder.AddColumn<int>(
                name: "BorderCustomId",
                table: "WasteExportImports",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InternalTransitId",
                table: "WasteExportImports",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WasteExportImports_BorderCustomId",
                table: "WasteExportImports",
                column: "BorderCustomId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteExportImports_InternalTransitId",
                table: "WasteExportImports",
                column: "InternalTransitId");

            migrationBuilder.AddForeignKey(
                name: "FK_WasteExportImports_Industries_BorderCustomId",
                table: "WasteExportImports",
                column: "BorderCustomId",
                principalTable: "Industries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WasteExportImports_Industries_InternalTransitId",
                table: "WasteExportImports",
                column: "InternalTransitId",
                principalTable: "Industries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WasteExportImports_Industries_BorderCustomId",
                table: "WasteExportImports");

            migrationBuilder.DropForeignKey(
                name: "FK_WasteExportImports_Industries_InternalTransitId",
                table: "WasteExportImports");

            migrationBuilder.DropIndex(
                name: "IX_WasteExportImports_BorderCustomId",
                table: "WasteExportImports");

            migrationBuilder.DropIndex(
                name: "IX_WasteExportImports_InternalTransitId",
                table: "WasteExportImports");

            migrationBuilder.DropColumn(
                name: "BorderCustomId",
                table: "WasteExportImports");

            migrationBuilder.DropColumn(
                name: "InternalTransitId",
                table: "WasteExportImports");

            migrationBuilder.CreateTable(
                name: "WasteExportImportCustoms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CustomId = table.Column<int>(type: "int", nullable: false),
                    CustomType = table.Column<int>(type: "int", nullable: false),
                    WasteExportImportId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WasteExportImportCustoms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WasteExportImportCustoms_Industries_CustomId",
                        column: x => x.CustomId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WasteExportImportCustoms_WasteExportImports_WasteExportImpor~",
                        column: x => x.WasteExportImportId,
                        principalTable: "WasteExportImports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WasteExportImportCustoms_CustomId",
                table: "WasteExportImportCustoms",
                column: "CustomId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteExportImportCustoms_WasteExportImportId",
                table: "WasteExportImportCustoms",
                column: "WasteExportImportId");
        }
    }
}
