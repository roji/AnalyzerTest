using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class DropChangeLogTemplate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TemplateManagers",
                keyColumn: "Id",
                keyValue: 9);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TemplateManagers",
                columns: new[] { "Id", "ContentBody", "ContentTitle", "CreatedByBrowserName", "CreatedByIp", "CreatedByUserId", "CreatedDateTime", "FormatedToHtmlContentBody", "ModifiedByBrowserName", "ModifiedByIp", "ModifiedByUserId", "ModifiedDateTime", "TemplateType", "Title", "UserId" },
                values: new object[] { 9, null, null, null, null, null, null, null, null, null, null, null, 10, "تغییرات بروزرسانی", null });
        }
    }
}
