using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class addRiverRankingProvinceFieldInRiverRangeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "RiverRankingInProvince",
                table: "RiverProvinceRanges",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RiverRankingInProvince",
                table: "RiverProvinceRanges");
        }
    }
}
