using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddIsDevicesResultsAcceptableFieldToHospitalSR : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDevicesResultsAcceptable",
                table: "HospitalSamplingResults",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_HospitalSamplingResults_IsDevicesResultsAcceptable",
                table: "HospitalSamplingResults",
                column: "IsDevicesResultsAcceptable");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_HospitalSamplingResults_IsDevicesResultsAcceptable",
                table: "HospitalSamplingResults");

            migrationBuilder.DropColumn(
                name: "IsDevicesResultsAcceptable",
                table: "HospitalSamplingResults");
        }
    }
}
