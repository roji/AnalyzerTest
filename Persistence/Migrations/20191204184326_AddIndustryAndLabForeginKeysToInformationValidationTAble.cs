using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddIndustryAndLabForeginKeysToInformationValidationTAble : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IndustryId",
                table: "InformationValidations",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LabId",
                table: "InformationValidations",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_InformationValidations_IndustryId",
                table: "InformationValidations",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_InformationValidations_LabId",
                table: "InformationValidations",
                column: "LabId");

            migrationBuilder.AddForeignKey(
                name: "FK_InformationValidations_Industries_IndustryId",
                table: "InformationValidations",
                column: "IndustryId",
                principalTable: "Industries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InformationValidations_Labs_LabId",
                table: "InformationValidations",
                column: "LabId",
                principalTable: "Labs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InformationValidations_Industries_IndustryId",
                table: "InformationValidations");

            migrationBuilder.DropForeignKey(
                name: "FK_InformationValidations_Labs_LabId",
                table: "InformationValidations");

            migrationBuilder.DropIndex(
                name: "IX_InformationValidations_IndustryId",
                table: "InformationValidations");

            migrationBuilder.DropIndex(
                name: "IX_InformationValidations_LabId",
                table: "InformationValidations");

            migrationBuilder.DropColumn(
                name: "IndustryId",
                table: "InformationValidations");

            migrationBuilder.DropColumn(
                name: "LabId",
                table: "InformationValidations");
        }
    }
}
