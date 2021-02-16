using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class RemoveMotorVehiclesParametersResultsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MotorVehiclesParametersResults");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MotorVehiclesParametersResults",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BuildYear = table.Column<double>(nullable: true),
                    GasolineOrDiesel = table.Column<bool>(nullable: false),
                    MeasurementUnitId = table.Column<int>(nullable: false),
                    NumberPlate = table.Column<string>(nullable: true),
                    OwnerName = table.Column<string>(nullable: true),
                    ParametersSamplingResultsId = table.Column<int>(nullable: false),
                    Quantity = table.Column<double>(nullable: false),
                    VehicleType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotorVehiclesParametersResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MotorVehiclesParametersResults_EnumData_MeasurementUnitId",
                        column: x => x.MeasurementUnitId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MotorVehiclesParametersResults_ParametersSamplingResults_Par~",
                        column: x => x.ParametersSamplingResultsId,
                        principalTable: "ParametersSamplingResults",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MotorVehiclesParametersResults_MeasurementUnitId",
                table: "MotorVehiclesParametersResults",
                column: "MeasurementUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_MotorVehiclesParametersResults_ParametersSamplingResultsId",
                table: "MotorVehiclesParametersResults",
                column: "ParametersSamplingResultsId");
        }
    }
}
