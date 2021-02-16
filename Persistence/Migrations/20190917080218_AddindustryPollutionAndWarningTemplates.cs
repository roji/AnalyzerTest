using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddindustryPollutionAndWarningTemplates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TemplateManagers",
                columns: new[] { "Id", "ContentBody", "ContentTitle", "CreatedByBrowserName", "CreatedByIp", "CreatedByUserId", "CreatedDateTime", "FormatedToHtmlContentBody", "ModifiedByBrowserName", "ModifiedByIp", "ModifiedByUserId", "ModifiedDateTime", "TemplateType", "Title", "UserId" },
                values: new object[] { 6, null, null, null, null, null, null, null, null, null, null, null, 7, "اعلام آلایندگی مرکز", null });

            migrationBuilder.InsertData(
                table: "TemplateManagers",
                columns: new[] { "Id", "ContentBody", "ContentTitle", "CreatedByBrowserName", "CreatedByIp", "CreatedByUserId", "CreatedDateTime", "FormatedToHtmlContentBody", "ModifiedByBrowserName", "ModifiedByIp", "ModifiedByUserId", "ModifiedDateTime", "TemplateType", "Title", "UserId" },
                values: new object[] { 7, null, null, null, null, null, null, null, null, null, null, null, 8, "صدور اخطاریه مرکز", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TemplateManagers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TemplateManagers",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
