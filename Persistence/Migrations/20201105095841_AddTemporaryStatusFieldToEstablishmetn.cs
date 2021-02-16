using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddTemporaryStatusFieldToEstablishmetn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StatusBeforeProvinceGeneralManagerStep",
                table: "IndustryEstablishments",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatusBeforeProvinceGeneralManagerStep",
                table: "IndustryEstablishments");
        }
    }
}
