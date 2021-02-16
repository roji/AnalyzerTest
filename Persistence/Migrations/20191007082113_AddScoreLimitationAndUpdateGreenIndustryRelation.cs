using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddScoreLimitationAndUpdateGreenIndustryRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GreenIndustryRelations_EnumData_StrategyId",
                table: "GreenIndustryRelations");

            migrationBuilder.RenameColumn(
                name: "StrategyId",
                table: "GreenIndustryRelations",
                newName: "UnderCriteriaId");

            migrationBuilder.DropIndex(
                name: "IX_GreenIndustryRelations_StrategyId",
                table: "GreenIndustryRelations");

            migrationBuilder.CreateIndex(
                name: "IX_GreenIndustryRelations_UnderCriteriaId",
                table: "GreenIndustryRelations",
                column: "UnderCriteriaId");

            migrationBuilder.AddColumn<double>(
                name: "ScoreLimitation",
                table: "GreenIndustryRelations",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_GreenIndustryRelations_EnumData_UnderCriteriaId",
                table: "GreenIndustryRelations",
                column: "UnderCriteriaId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GreenIndustryRelations_EnumData_UnderCriteriaId",
                table: "GreenIndustryRelations");

            migrationBuilder.DropColumn(
                name: "ScoreLimitation",
                table: "GreenIndustryRelations");

            migrationBuilder.RenameColumn(
                name: "UnderCriteriaId",
                table: "GreenIndustryRelations",
                newName: "StrategyId");

            migrationBuilder.DropIndex(
              name: "IX_GreenIndustryRelations_UnderCriteriaId",
              table: "GreenIndustryRelations");

            migrationBuilder.CreateIndex(
                name: "IX_GreenIndustryRelations_StrategyId",
                table: "GreenIndustryRelations",
                column: "StrategyId");

            migrationBuilder.AddForeignKey(
                name: "FK_GreenIndustryRelations_EnumData_StrategyId",
                table: "GreenIndustryRelations",
                column: "StrategyId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
