using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddMonitoringHourFieldsAndExperimentParametersClassificaitonTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MonitoringAlternativeHour",
                table: "IndustrialUnitsSamplingResults",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MonitoringHour",
                table: "IndustrialUnitsSamplingResults",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ExperimentParametersClassifications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ParamClassificationId = table.Column<int>(nullable: false),
                    IndustrialUnitsSamplingResultId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExperimentParametersClassifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExperimentParametersClassifications_IndustrialUnitsSamplingR~",
                        column: x => x.IndustrialUnitsSamplingResultId,
                        principalTable: "IndustrialUnitsSamplingResults",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExperimentParametersClassifications_EnumData_ParamClassifica~",
                        column: x => x.ParamClassificationId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExperimentParametersClassifications_IndustrialUnitsSamplingR~",
                table: "ExperimentParametersClassifications",
                column: "IndustrialUnitsSamplingResultId");

            migrationBuilder.CreateIndex(
                name: "IX_ExperimentParametersClassifications_ParamClassificationId",
                table: "ExperimentParametersClassifications",
                column: "ParamClassificationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExperimentParametersClassifications");

            migrationBuilder.DropColumn(
                name: "MonitoringAlternativeHour",
                table: "IndustrialUnitsSamplingResults");

            migrationBuilder.DropColumn(
                name: "MonitoringHour",
                table: "IndustrialUnitsSamplingResults");
        }
    }
}
