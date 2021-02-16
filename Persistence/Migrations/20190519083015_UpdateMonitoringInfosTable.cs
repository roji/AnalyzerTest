using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class UpdateMonitoringInfosTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "NeedMonitoring",
                table: "MonitoringInfos",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "NeedMonitoring",
                table: "MonitoringInfos",
                nullable: true,
                oldClrType: typeof(bool),
                oldDefaultValue: true);
        }
    }
}
