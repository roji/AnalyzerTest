using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class RemoveIngredientClassificationFieldFromChemicalPropertiesParametersWastewater : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChemicalPropertiesParameters_EnumData_IngredientClassificati~",
                table: "ChemicalPropertiesParameters");

            migrationBuilder.DropIndex(
                name: "IX_ChemicalPropertiesParameters_IngredientClassificationId",
                table: "ChemicalPropertiesParameters");

            migrationBuilder.DropColumn(
                name: "IngredientClassificationId",
                table: "ChemicalPropertiesParameters");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IngredientClassificationId",
                table: "ChemicalPropertiesParameters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ChemicalPropertiesParameters_IngredientClassificationId",
                table: "ChemicalPropertiesParameters",
                column: "IngredientClassificationId");

            migrationBuilder.AddForeignKey(
                name: "FK_ChemicalPropertiesParameters_EnumData_IngredientClassificati~",
                table: "ChemicalPropertiesParameters",
                column: "IngredientClassificationId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
