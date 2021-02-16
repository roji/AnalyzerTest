using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class RemoveUnitMeasurementIdFromAmbientWasteWaterSoundWasteChimneyParamRes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AmbientAirParametersResults_EnumData_MeasurementUnitId",
                table: "AmbientAirParametersResults");

            migrationBuilder.DropForeignKey(
                name: "FK_ChimneyParametersResults_EnumData_MeasurementUnitId",
                table: "ChimneyParametersResults");

            migrationBuilder.DropForeignKey(
                name: "FK_SoundAndWavesParametersResults_EnumData_MeasurementUnitId",
                table: "SoundAndWavesParametersResults");

            migrationBuilder.DropForeignKey(
                name: "FK_WasteParametersResults_EnumData_MeasurementUnitId",
                table: "WasteParametersResults");

            migrationBuilder.DropForeignKey(
                name: "FK_WastewaterParametersResults_EnumData_MeasurementUnitId",
                table: "WastewaterParametersResults");

            migrationBuilder.DropIndex(
                name: "IX_WastewaterParametersResults_MeasurementUnitId",
                table: "WastewaterParametersResults");

            migrationBuilder.DropIndex(
                name: "IX_WasteParametersResults_MeasurementUnitId",
                table: "WasteParametersResults");

            migrationBuilder.DropIndex(
                name: "IX_SoundAndWavesParametersResults_MeasurementUnitId",
                table: "SoundAndWavesParametersResults");

            migrationBuilder.DropIndex(
                name: "IX_ChimneyParametersResults_MeasurementUnitId",
                table: "ChimneyParametersResults");

            migrationBuilder.DropIndex(
                name: "IX_AmbientAirParametersResults_MeasurementUnitId",
                table: "AmbientAirParametersResults");

            migrationBuilder.DropColumn(
                name: "MeasurementUnitId",
                table: "WastewaterParametersResults");

            migrationBuilder.DropColumn(
                name: "MeasurementUnitId",
                table: "WasteParametersResults");

            migrationBuilder.DropColumn(
                name: "MeasurementUnitId",
                table: "SoundAndWavesParametersResults");

            migrationBuilder.DropColumn(
                name: "MeasurementUnitId",
                table: "ChimneyParametersResults");

            migrationBuilder.DropColumn(
                name: "MeasurementUnitId",
                table: "AmbientAirParametersResults");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MeasurementUnitId",
                table: "WastewaterParametersResults",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MeasurementUnitId",
                table: "WasteParametersResults",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MeasurementUnitId",
                table: "SoundAndWavesParametersResults",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MeasurementUnitId",
                table: "ChimneyParametersResults",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MeasurementUnitId",
                table: "AmbientAirParametersResults",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_WastewaterParametersResults_MeasurementUnitId",
                table: "WastewaterParametersResults",
                column: "MeasurementUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteParametersResults_MeasurementUnitId",
                table: "WasteParametersResults",
                column: "MeasurementUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_SoundAndWavesParametersResults_MeasurementUnitId",
                table: "SoundAndWavesParametersResults",
                column: "MeasurementUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_ChimneyParametersResults_MeasurementUnitId",
                table: "ChimneyParametersResults",
                column: "MeasurementUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_AmbientAirParametersResults_MeasurementUnitId",
                table: "AmbientAirParametersResults",
                column: "MeasurementUnitId");

            migrationBuilder.AddForeignKey(
                name: "FK_AmbientAirParametersResults_EnumData_MeasurementUnitId",
                table: "AmbientAirParametersResults",
                column: "MeasurementUnitId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChimneyParametersResults_EnumData_MeasurementUnitId",
                table: "ChimneyParametersResults",
                column: "MeasurementUnitId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SoundAndWavesParametersResults_EnumData_MeasurementUnitId",
                table: "SoundAndWavesParametersResults",
                column: "MeasurementUnitId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WasteParametersResults_EnumData_MeasurementUnitId",
                table: "WasteParametersResults",
                column: "MeasurementUnitId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WastewaterParametersResults_EnumData_MeasurementUnitId",
                table: "WastewaterParametersResults",
                column: "MeasurementUnitId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
