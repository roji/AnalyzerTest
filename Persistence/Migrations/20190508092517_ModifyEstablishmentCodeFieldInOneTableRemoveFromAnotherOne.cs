using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class ModifyEstablishmentCodeFieldInOneTableRemoveFromAnotherOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstablishmentCode",
                table: "ParametersSamplingResults");

            migrationBuilder.AlterColumn<int>(
                name: "AssessmentStatus",
                table: "MonitoringInfos",
                nullable: true,
                oldClrType: typeof(bool),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EstablishmentCode",
                table: "ParametersSamplingResults",
                nullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "AssessmentStatus",
                table: "MonitoringInfos",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
