using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class removeRepIdUniqueIndustryEstablishment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_IndustryEstablishments_RepId",
                table: "IndustryEstablishments");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishments_RepId",
                table: "IndustryEstablishments",
                column: "RepId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_IndustryEstablishments_RepId",
                table: "IndustryEstablishments");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishments_RepId",
                table: "IndustryEstablishments",
                column: "RepId",
                unique: true);
        }
    }
}
