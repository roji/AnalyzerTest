using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class RemoveUnitMeasurementFromMonitoringParametersAkaMonitoringCoding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MonitoringParameters_EnumData_MeasurementUnitId",
                table: "MonitoringParameters");

            migrationBuilder.DropIndex(
                name: "IX_MonitoringParameters_MeasurementUnitId",
                table: "MonitoringParameters");

            migrationBuilder.DropColumn(
                name: "MeasurementUnitId",
                table: "MonitoringParameters");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MeasurementUnitId",
                table: "MonitoringParameters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MonitoringParameters_MeasurementUnitId",
                table: "MonitoringParameters",
                column: "MeasurementUnitId");

            migrationBuilder.AddForeignKey(
                name: "FK_MonitoringParameters_EnumData_MeasurementUnitId",
                table: "MonitoringParameters",
                column: "MeasurementUnitId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
