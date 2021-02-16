using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddApiKeyUsageTemplate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TemplateManagers",
                columns: new[] { "Id", "ContentBody", "ContentTitle", "CreatedByBrowserName", "CreatedByIp", "CreatedByUserId", "CreatedDateTime", "FormatedToHtmlContentBody", "ModifiedByBrowserName", "ModifiedByIp", "ModifiedByUserId", "ModifiedDateTime", "TemplateType", "Title", "UserId" },
                values: new object[] { 10, null, null, null, null, null, null, null, null, null, null, null, 11, "استفاده از کلید API", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TemplateManagers",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
