using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddAfterStatusFieldInEstablishment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StatusAfterProvinceGeneralManagerStep",
                table: "IndustryEstablishments",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatusAfterProvinceGeneralManagerStep",
                table: "IndustryEstablishments");
        }
    }
}
