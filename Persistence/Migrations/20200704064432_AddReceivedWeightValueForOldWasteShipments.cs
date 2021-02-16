using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddReceivedWeightValueForOldWasteShipments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var cmd = @"UPDATE wastesshipments SET ReceivedWeight=LoadedWeight;";
            migrationBuilder.Sql(cmd);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var cmd = @"UPDATE wastesshipments SET ReceivedWeight=null;";
            migrationBuilder.Sql(cmd);
        }
    }
}
