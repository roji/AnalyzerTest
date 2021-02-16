using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
   public partial class AddIsKnowledgeBasedFieldAndKnowledgeCategoryField : Migration
   {
      protected override void Up(MigrationBuilder migrationBuilder)
      {
         var deleteOldRecords = @"DELETE FROM ProductClassifications";
         migrationBuilder.Sql(deleteOldRecords);

         migrationBuilder.AddColumn<int>(
            name: "KnowledgebasedClassification",
            table: "ProductClassifications",
            nullable : false,
            defaultValue : 0);

         migrationBuilder.AddColumn<bool>(
            name: "IsKnowledgeBased",
            table: "Industries",
            nullable : false,
            defaultValue : false);
      }

      protected override void Down(MigrationBuilder migrationBuilder)
      {
         migrationBuilder.DropColumn(
            name: "KnowledgebasedClassification",
            table: "ProductClassifications");

         migrationBuilder.DropColumn(
            name: "IsKnowledgeBased",
            table: "Industries");
      }
   }
}
