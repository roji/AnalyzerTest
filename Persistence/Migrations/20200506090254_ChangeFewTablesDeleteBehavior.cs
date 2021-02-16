using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class ChangeFewTablesDeleteBehavior : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GreenIndustries_Industries_IndustryId",
                table: "GreenIndustries");

            migrationBuilder.DropForeignKey(
                name: "FK_HospitalSamplingResults_Labs_LabId",
                table: "HospitalSamplingResults");

            migrationBuilder.DropForeignKey(
                name: "FK_IndustrialUnitsSamplingResults_Labs_LabId",
                table: "IndustrialUnitsSamplingResults");

            migrationBuilder.DropForeignKey(
                name: "FK_IndustryPollutions_Industries_IndustryId",
                table: "IndustryPollutions");

            migrationBuilder.DropForeignKey(
                name: "FK_Wastes_Repositories_RepositoryId",
                table: "Wastes");

            migrationBuilder.AddForeignKey(
                name: "FK_GreenIndustries_Industries_IndustryId",
                table: "GreenIndustries",
                column: "IndustryId",
                principalTable: "Industries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HospitalSamplingResults_Labs_LabId",
                table: "HospitalSamplingResults",
                column: "LabId",
                principalTable: "Labs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IndustrialUnitsSamplingResults_Labs_LabId",
                table: "IndustrialUnitsSamplingResults",
                column: "LabId",
                principalTable: "Labs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IndustryPollutions_Industries_IndustryId",
                table: "IndustryPollutions",
                column: "IndustryId",
                principalTable: "Industries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Wastes_Repositories_RepositoryId",
                table: "Wastes",
                column: "RepositoryId",
                principalTable: "Repositories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GreenIndustries_Industries_IndustryId",
                table: "GreenIndustries");

            migrationBuilder.DropForeignKey(
                name: "FK_HospitalSamplingResults_Labs_LabId",
                table: "HospitalSamplingResults");

            migrationBuilder.DropForeignKey(
                name: "FK_IndustrialUnitsSamplingResults_Labs_LabId",
                table: "IndustrialUnitsSamplingResults");

            migrationBuilder.DropForeignKey(
                name: "FK_IndustryPollutions_Industries_IndustryId",
                table: "IndustryPollutions");

            migrationBuilder.DropForeignKey(
                name: "FK_Wastes_Repositories_RepositoryId",
                table: "Wastes");

            migrationBuilder.AddForeignKey(
                name: "FK_GreenIndustries_Industries_IndustryId",
                table: "GreenIndustries",
                column: "IndustryId",
                principalTable: "Industries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HospitalSamplingResults_Labs_LabId",
                table: "HospitalSamplingResults",
                column: "LabId",
                principalTable: "Labs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IndustrialUnitsSamplingResults_Labs_LabId",
                table: "IndustrialUnitsSamplingResults",
                column: "LabId",
                principalTable: "Labs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IndustryPollutions_Industries_IndustryId",
                table: "IndustryPollutions",
                column: "IndustryId",
                principalTable: "Industries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Wastes_Repositories_RepositoryId",
                table: "Wastes",
                column: "RepositoryId",
                principalTable: "Repositories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
