using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddEstablishmentGroupIdInIndustry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EstablishmentGroupingId",
                table: "Industries",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Industries_EstablishmentGroupingId",
                table: "Industries",
                column: "EstablishmentGroupingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Industries_EnumData_EstablishmentGroupingId",
                table: "Industries",
                column: "EstablishmentGroupingId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Industries_EnumData_EstablishmentGroupingId",
                table: "Industries");

            migrationBuilder.DropIndex(
                name: "IX_Industries_EstablishmentGroupingId",
                table: "Industries");

            migrationBuilder.DropColumn(
                name: "EstablishmentGroupingId",
                table: "Industries");
        }
    }
}
