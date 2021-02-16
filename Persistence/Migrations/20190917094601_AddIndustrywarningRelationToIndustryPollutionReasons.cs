using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddIndustrywarningRelationToIndustryPollutionReasons : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IndustryWarningId",
                table: "IndustryPollutionReasons",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_IndustryPollutionReasons_IndustryWarningId",
                table: "IndustryPollutionReasons",
                column: "IndustryWarningId");

            migrationBuilder.AddForeignKey(
                name: "FK_IndustryPollutionReasons_IndustryWarnings_IndustryWarningId",
                table: "IndustryPollutionReasons",
                column: "IndustryWarningId",
                principalTable: "IndustryWarnings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IndustryPollutionReasons_IndustryWarnings_IndustryWarningId",
                table: "IndustryPollutionReasons");

            migrationBuilder.DropIndex(
                name: "IX_IndustryPollutionReasons_IndustryWarningId",
                table: "IndustryPollutionReasons");

            migrationBuilder.DropColumn(
                name: "IndustryWarningId",
                table: "IndustryPollutionReasons");
        }
    }
}
