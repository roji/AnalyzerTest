using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class RemoveSpecializedGroupAddMonitoringTypeIdToLabRankingCodingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SpecializedGroup",
                table: "LabRankingCodings");

            migrationBuilder.AddColumn<int>(
                name: "MonitoringTypeId",
                table: "LabRankingCodings",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_LabRankingCodings_MonitoringTypeId",
                table: "LabRankingCodings",
                column: "MonitoringTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_LabRankingCodings_EnumData_MonitoringTypeId",
                table: "LabRankingCodings",
                column: "MonitoringTypeId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LabRankingCodings_EnumData_MonitoringTypeId",
                table: "LabRankingCodings");

            migrationBuilder.DropIndex(
                name: "IX_LabRankingCodings_MonitoringTypeId",
                table: "LabRankingCodings");

            migrationBuilder.DropColumn(
                name: "MonitoringTypeId",
                table: "LabRankingCodings");

            migrationBuilder.AddColumn<int>(
                name: "SpecializedGroup",
                table: "LabRankingCodings",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
