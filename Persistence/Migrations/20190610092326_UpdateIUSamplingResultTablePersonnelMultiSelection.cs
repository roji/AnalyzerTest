using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class UpdateIUSamplingResultTablePersonnelMultiSelection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IndustrialUnitsSamplingResults_Personnels_SamplerExpertId",
                table: "IndustrialUnitsSamplingResults");

            migrationBuilder.DropForeignKey(
                name: "FK_IndustrialUnitsSamplingResults_Personnels_TechnicalAssistant~",
                table: "IndustrialUnitsSamplingResults");

            migrationBuilder.DropForeignKey(
                name: "FK_IndustrialUnitsSamplingResults_Personnels_TesterId",
                table: "IndustrialUnitsSamplingResults");

            migrationBuilder.DropIndex(
                name: "IX_IndustrialUnitsSamplingResults_SamplerExpertId",
                table: "IndustrialUnitsSamplingResults");

            migrationBuilder.DropIndex(
                name: "IX_IndustrialUnitsSamplingResults_TechnicalAssistantVerifierId",
                table: "IndustrialUnitsSamplingResults");

            migrationBuilder.DropIndex(
                name: "IX_IndustrialUnitsSamplingResults_TesterId",
                table: "IndustrialUnitsSamplingResults");

            migrationBuilder.DropColumn(
                name: "SamplerExpertId",
                table: "IndustrialUnitsSamplingResults");

            migrationBuilder.DropColumn(
                name: "TechnicalAssistantVerifierId",
                table: "IndustrialUnitsSamplingResults");

            migrationBuilder.DropColumn(
                name: "TesterId",
                table: "IndustrialUnitsSamplingResults");

            migrationBuilder.AddColumn<string>(
                name: "SamplerExpertsIds",
                table: "IndustrialUnitsSamplingResults",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TechnicalAssistantVerifiersIds",
                table: "IndustrialUnitsSamplingResults",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TestersIds",
                table: "IndustrialUnitsSamplingResults",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SamplerExpertsIds",
                table: "IndustrialUnitsSamplingResults");

            migrationBuilder.DropColumn(
                name: "TechnicalAssistantVerifiersIds",
                table: "IndustrialUnitsSamplingResults");

            migrationBuilder.DropColumn(
                name: "TestersIds",
                table: "IndustrialUnitsSamplingResults");

            migrationBuilder.AddColumn<int>(
                name: "SamplerExpertId",
                table: "IndustrialUnitsSamplingResults",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TechnicalAssistantVerifierId",
                table: "IndustrialUnitsSamplingResults",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TesterId",
                table: "IndustrialUnitsSamplingResults",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialUnitsSamplingResults_SamplerExpertId",
                table: "IndustrialUnitsSamplingResults",
                column: "SamplerExpertId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialUnitsSamplingResults_TechnicalAssistantVerifierId",
                table: "IndustrialUnitsSamplingResults",
                column: "TechnicalAssistantVerifierId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialUnitsSamplingResults_TesterId",
                table: "IndustrialUnitsSamplingResults",
                column: "TesterId");

            migrationBuilder.AddForeignKey(
                name: "FK_IndustrialUnitsSamplingResults_Personnels_SamplerExpertId",
                table: "IndustrialUnitsSamplingResults",
                column: "SamplerExpertId",
                principalTable: "Personnels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IndustrialUnitsSamplingResults_Personnels_TechnicalAssistant~",
                table: "IndustrialUnitsSamplingResults",
                column: "TechnicalAssistantVerifierId",
                principalTable: "Personnels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IndustrialUnitsSamplingResults_Personnels_TesterId",
                table: "IndustrialUnitsSamplingResults",
                column: "TesterId",
                principalTable: "Personnels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
