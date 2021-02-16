using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddUserActivationTemplate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TemplateManagers",
                columns: new[] { "Id", "ContentBody", "ContentTitle", "CreatedByBrowserName", "CreatedByIp", "CreatedByUserId", "CreatedDateTime", "FormatedToHtmlContentBody", "ModifiedByBrowserName", "ModifiedByIp", "ModifiedByUserId", "ModifiedDateTime", "TemplateType", "Title", "UserId" },
                values: new object[] { 8, null, null, null, null, null, null, null, null, null, null, null, 9, "فعالسازی حساب کاربری", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TemplateManagers",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
