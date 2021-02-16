using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class RemoveIsNessecaryFromLabRankingCodingExpertPersonnel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsNecessary",
                table: "LabRankingCodingExpertPersonnels");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsNecessary",
                table: "LabRankingCodingExpertPersonnels",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }
    }
}
