using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
   public partial class MakeRepIdinEstablishmentunique : Migration
   {
      protected override void Up(MigrationBuilder migrationBuilder)
      {
         var cmd = "delete from industryestablishments";
         migrationBuilder.Sql(cmd);
         migrationBuilder.CreateIndex(
            name: "IX_IndustryEstablishments_RepId",
            table: "IndustryEstablishments",
            column: "RepId",
            unique : true);
      }

      protected override void Down(MigrationBuilder migrationBuilder)
      {
         migrationBuilder.DropIndex(
            name: "IX_IndustryEstablishments_RepId",
            table: "IndustryEstablishments");
      }
   }
}
