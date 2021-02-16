using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddFormatedToHtmlContentBodyFieldToTemplateManager : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FormatedToHtmlContentBody",
                table: "TemplateManagers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FormatedToHtmlContentBody",
                table: "TemplateManagers");
        }
    }
}
