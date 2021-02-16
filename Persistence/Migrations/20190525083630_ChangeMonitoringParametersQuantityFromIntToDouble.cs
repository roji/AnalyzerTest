using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class ChangeMonitoringParametersQuantityFromIntToDouble : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "PollutionLimitQuantity",
                table: "MonitoringParameters",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<double>(
                name: "LimitAmountQuantity",
                table: "MonitoringParameters",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PollutionLimitQuantity",
                table: "MonitoringParameters",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<int>(
                name: "LimitAmountQuantity",
                table: "MonitoringParameters",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
