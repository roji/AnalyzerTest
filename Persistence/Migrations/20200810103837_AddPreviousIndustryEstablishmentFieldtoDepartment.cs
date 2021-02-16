using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddPreviousIndustryEstablishmentFieldtoDepartment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PreviousIndustryEstablishmentId",
                table: "IndustryEstablishmentPreviousDepartments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishmentPreviousDepartments_PreviousIndustryEst~",
                table: "IndustryEstablishmentPreviousDepartments",
                column: "PreviousIndustryEstablishmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_IndustryEstablishmentPreviousDepartments_IndustryEstablishm~1",
                table: "IndustryEstablishmentPreviousDepartments",
                column: "PreviousIndustryEstablishmentId",
                principalTable: "IndustryEstablishments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IndustryEstablishmentPreviousDepartments_IndustryEstablishm~1",
                table: "IndustryEstablishmentPreviousDepartments");

            migrationBuilder.DropIndex(
                name: "IX_IndustryEstablishmentPreviousDepartments_PreviousIndustryEst~",
                table: "IndustryEstablishmentPreviousDepartments");

            migrationBuilder.DropColumn(
                name: "PreviousIndustryEstablishmentId",
                table: "IndustryEstablishmentPreviousDepartments");
        }
    }
}
