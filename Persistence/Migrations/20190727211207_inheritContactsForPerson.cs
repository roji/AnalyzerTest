using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class inheritContactsForPerson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ContactInfo_WebSite",
                table: "Lab_Managers",
                newName: "WebSite");

            migrationBuilder.RenameColumn(
                name: "ContactInfo_Phone",
                table: "Lab_Managers",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "ContactInfo_Mobile",
                table: "Lab_Managers",
                newName: "Mobile");

            migrationBuilder.RenameColumn(
                name: "ContactInfo_Email",
                table: "Lab_Managers",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "ContactInfo_WebSite",
                table: "Industry_Managers",
                newName: "WebSite");

            migrationBuilder.RenameColumn(
                name: "ContactInfo_Phone",
                table: "Industry_Managers",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "ContactInfo_Mobile",
                table: "Industry_Managers",
                newName: "Mobile");

            migrationBuilder.RenameColumn(
                name: "ContactInfo_Email",
                table: "Industry_Managers",
                newName: "Email");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WebSite",
                table: "Lab_Managers",
                newName: "ContactInfo_WebSite");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Lab_Managers",
                newName: "ContactInfo_Phone");

            migrationBuilder.RenameColumn(
                name: "Mobile",
                table: "Lab_Managers",
                newName: "ContactInfo_Mobile");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Lab_Managers",
                newName: "ContactInfo_Email");

            migrationBuilder.RenameColumn(
                name: "WebSite",
                table: "Industry_Managers",
                newName: "ContactInfo_WebSite");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Industry_Managers",
                newName: "ContactInfo_Phone");

            migrationBuilder.RenameColumn(
                name: "Mobile",
                table: "Industry_Managers",
                newName: "ContactInfo_Mobile");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Industry_Managers",
                newName: "ContactInfo_Email");
        }
    }
}
