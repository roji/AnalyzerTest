using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddWastewaterEmissionUnitNameToWastewaterTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "WastewaterEmissionUnitName",
                table: "Wastewaters",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WastewaterEmissionUnitName",
                table: "Wastewaters");
        }
    }
}
