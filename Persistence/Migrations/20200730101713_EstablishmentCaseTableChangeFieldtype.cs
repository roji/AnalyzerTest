using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class EstablishmentCaseTableChangeFieldtype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ChimneyDominantWindDirection",
                table: "IndustryEstablishmentCases",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "ChimneyDominantWindDirection",
                table: "IndustryEstablishmentCases",
                type: "double",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
