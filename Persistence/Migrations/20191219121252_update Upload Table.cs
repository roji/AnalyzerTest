using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class updateUploadTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContainerFolder",
                table: "Uploads");

            migrationBuilder.DropColumn(
                name: "RelatedId",
                table: "Uploads");

            migrationBuilder.RenameColumn(
                name: "FileTypeFolder",
                table: "Uploads",
                newName: "AccessName");

            migrationBuilder.RenameColumn(
                name: "FileExtention",
                table: "Uploads",
                newName: "AccessId");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Uploads",
                maxLength: 38,
                nullable: false,
                oldClrType: typeof(long))
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<uint>(
                name: "Crc32",
                table: "Uploads",
                nullable: false,
                defaultValue: 0u);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Crc32",
                table: "Uploads");

            migrationBuilder.RenameColumn(
                name: "AccessName",
                table: "Uploads",
                newName: "FileTypeFolder");

            migrationBuilder.RenameColumn(
                name: "AccessId",
                table: "Uploads",
                newName: "FileExtention");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Uploads",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 38)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<string>(
                name: "ContainerFolder",
                table: "Uploads",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RelatedId",
                table: "Uploads",
                nullable: false,
                defaultValue: 0);
        }
    }
}
