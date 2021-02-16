using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class SeedtemplatemanagerDatas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TemplateManagers",
                columns: new[] { "Id", "ContentBody", "ContentTitle", "CreatedByBrowserName", "CreatedByIp", "CreatedByUserId", "CreatedDateTime", "ModifiedByBrowserName", "ModifiedByIp", "ModifiedByUserId", "ModifiedDateTime", "TemplateType", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, null, null, null, null, null, null, null, null, null, null, 2, "تایید مجوز نقل و انتقال پسماند", null },
                    { 2, null, null, null, null, null, null, null, null, null, null, 3, "لغو مجوز نقل و انتقال پسماند", null },
                    { 3, null, null, null, null, null, null, null, null, null, null, 4, "ایمیل خوش آمدگویی", null },
                    { 4, null, null, null, null, null, null, null, null, null, null, 5, "ایمیل تایید حساب کاربری", null },
                    { 5, null, null, null, null, null, null, null, null, null, null, 6, "پیام خوش آمدید میز کار", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TemplateManagers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TemplateManagers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TemplateManagers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TemplateManagers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TemplateManagers",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
