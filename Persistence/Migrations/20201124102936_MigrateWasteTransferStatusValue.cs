using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
   public partial class MigrateWasteTransferStatusValue : Migration
   {
      protected override void Up(MigrationBuilder migrationBuilder)
      {
         var updateCmd = @"UPDATE wastetransfers SET `WasteTransferStatus`=-1 WHERE `WasteTransferStatus` = 15";
         migrationBuilder.Sql(updateCmd);
      }

      protected override void Down(MigrationBuilder migrationBuilder)
      {

      }
   }
}
