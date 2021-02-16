using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class RenameTechnologyinGreenIndustryRelationstoToStrategy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GreenIndustryRelations_EnumData_TechnologyId",
                table: "GreenIndustryRelations");

            migrationBuilder.RenameColumn(
                name: "TechnologyId",
                table: "GreenIndustryRelations",
                newName: "StrategyId");

            migrationBuilder.DropIndex(
                name: "IX_GreenIndustryRelations_TechnologyId",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GreenIndustryRelations_EnumData_StrategyId",
                table: "GreenIndustryRelations");

            migrationBuilder.RenameColumn(
                name: "StrategyId",
                table: "GreenIndustryRelations",
                newName: "TechnologyId");

            migrationBuilder.DropIndex(
                name: "IX_GreenIndustryRelations_StrategyId",
                table: "GreenIndustryRelations");

            migrationBuilder.CreateIndex(
                name: "IX_GreenIndustryRelations_TechnologyId",
                table: "GreenIndustryRelations",
                column: "TechnologyId");

            migrationBuilder.AddForeignKey(
                name: "FK_GreenIndustryRelations_EnumData_TechnologyId",
                table: "GreenIndustryRelations",
                column: "TechnologyId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
