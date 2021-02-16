using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
   public partial class AddNewRelationsToEstablishmentReq : Migration
   {
      protected override void Up(MigrationBuilder migrationBuilder)
      {
         var deleteOldRecords = @"DELETE FROM IndustryEstablishmentRequests";
         migrationBuilder.Sql(deleteOldRecords);

         migrationBuilder.AddColumn<int>(
            name: "InvoiceId",
            table: "IndustryEstablishmentRequests",
            nullable : true);

         migrationBuilder.AddColumn<int>(
            name: "UserId",
            table: "IndustryEstablishmentRequests",
            nullable : false,
            defaultValue : 0);

         migrationBuilder.CreateIndex(
            name: "IX_IndustryEstablishmentRequests_InvoiceId",
            table: "IndustryEstablishmentRequests",
            column: "InvoiceId");

         migrationBuilder.CreateIndex(
            name: "IX_IndustryEstablishmentRequests_UserId",
            table: "IndustryEstablishmentRequests",
            column: "UserId");

         migrationBuilder.AddForeignKey(
            name: "FK_IndustryEstablishmentRequests_Invoices_InvoiceId",
            table: "IndustryEstablishmentRequests",
            column: "InvoiceId",
            principalTable: "Invoices",
            principalColumn: "Id",
            onDelete : ReferentialAction.Restrict);

         migrationBuilder.AddForeignKey(
            name: "FK_IndustryEstablishmentRequests_Users_UserId",
            table: "IndustryEstablishmentRequests",
            column: "UserId",
            principalTable: "Users",
            principalColumn: "Id",
            onDelete : ReferentialAction.Restrict);
      }

      protected override void Down(MigrationBuilder migrationBuilder)
      {
         migrationBuilder.DropForeignKey(
            name: "FK_IndustryEstablishmentRequests_Invoices_InvoiceId",
            table: "IndustryEstablishmentRequests");

         migrationBuilder.DropForeignKey(
            name: "FK_IndustryEstablishmentRequests_Users_UserId",
            table: "IndustryEstablishmentRequests");

         migrationBuilder.DropIndex(
            name: "IX_IndustryEstablishmentRequests_InvoiceId",
            table: "IndustryEstablishmentRequests");

         migrationBuilder.DropIndex(
            name: "IX_IndustryEstablishmentRequests_UserId",
            table: "IndustryEstablishmentRequests");

         migrationBuilder.DropColumn(
            name: "InvoiceId",
            table: "IndustryEstablishmentRequests");

         migrationBuilder.DropColumn(
            name: "UserId",
            table: "IndustryEstablishmentRequests");
      }
   }
}
