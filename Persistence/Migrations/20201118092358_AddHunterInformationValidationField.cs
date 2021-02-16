using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddHunterInformationValidationField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HunterId",
                table: "InformationValidations",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HunterValidationScore",
                table: "InformationValidations",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ValidationScore",
                table: "Hunters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_InformationValidations_HunterId",
                table: "InformationValidations",
                column: "HunterId");

            migrationBuilder.AddForeignKey(
                name: "FK_InformationValidations_Hunters_HunterId",
                table: "InformationValidations",
                column: "HunterId",
                principalTable: "Hunters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InformationValidations_Hunters_HunterId",
                table: "InformationValidations");

            migrationBuilder.DropIndex(
                name: "IX_InformationValidations_HunterId",
                table: "InformationValidations");

            migrationBuilder.DropColumn(
                name: "HunterId",
                table: "InformationValidations");

            migrationBuilder.DropColumn(
                name: "HunterValidationScore",
                table: "InformationValidations");

            migrationBuilder.DropColumn(
                name: "ValidationScore",
                table: "Hunters");
        }
    }
}
