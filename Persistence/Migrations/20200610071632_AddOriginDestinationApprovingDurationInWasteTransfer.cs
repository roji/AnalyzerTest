using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddOriginDestinationApprovingDurationInWasteTransfer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DestinationApprovingDuration",
                table: "WasteTransfers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OriginApprovingDuration",
                table: "WasteTransfers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DestinationApprovingDuration",
                table: "WasteTransfers");

            migrationBuilder.DropColumn(
                name: "OriginApprovingDuration",
                table: "WasteTransfers");
        }
    }
}
