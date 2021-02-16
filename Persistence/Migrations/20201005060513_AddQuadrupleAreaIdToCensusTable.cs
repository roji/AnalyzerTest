using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddQuadrupleAreaIdToCensusTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QuadrupleAreaId",
                table: "MammalsCensuses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MammalsCensuses_QuadrupleAreaId",
                table: "MammalsCensuses",
                column: "QuadrupleAreaId");

            migrationBuilder.AddForeignKey(
                name: "FK_MammalsCensuses_EnumData_QuadrupleAreaId",
                table: "MammalsCensuses",
                column: "QuadrupleAreaId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MammalsCensuses_EnumData_QuadrupleAreaId",
                table: "MammalsCensuses");

            migrationBuilder.DropIndex(
                name: "IX_MammalsCensuses_QuadrupleAreaId",
                table: "MammalsCensuses");

            migrationBuilder.DropColumn(
                name: "QuadrupleAreaId",
                table: "MammalsCensuses");
        }
    }
}
