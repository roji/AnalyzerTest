using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class inheritAddressAndContacts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Geo_Longitude",
                table: "Lab_Addresses",
                newName: "Longitude");

            migrationBuilder.RenameColumn(
                name: "Geo_Latitude",
                table: "Lab_Addresses",
                newName: "Latitude");

            migrationBuilder.RenameColumn(
                name: "Geo_Elevation",
                table: "Lab_Addresses",
                newName: "Elevation");

            migrationBuilder.RenameColumn(
                name: "ContactInfo_WebSite",
                table: "Lab_Addresses",
                newName: "WebSite");

            migrationBuilder.RenameColumn(
                name: "ContactInfo_Phone",
                table: "Lab_Addresses",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "ContactInfo_Mobile",
                table: "Lab_Addresses",
                newName: "Mobile");

            migrationBuilder.RenameColumn(
                name: "ContactInfo_Email",
                table: "Lab_Addresses",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "Geo_Longitude",
                table: "Industry_WorkshopAddresses",
                newName: "Longitude");

            migrationBuilder.RenameColumn(
                name: "Geo_Latitude",
                table: "Industry_WorkshopAddresses",
                newName: "Latitude");

            migrationBuilder.RenameColumn(
                name: "Geo_Elevation",
                table: "Industry_WorkshopAddresses",
                newName: "Elevation");

            migrationBuilder.RenameColumn(
                name: "ContactInfo_WebSite",
                table: "Industry_WorkshopAddresses",
                newName: "WebSite");

            migrationBuilder.RenameColumn(
                name: "ContactInfo_Phone",
                table: "Industry_WorkshopAddresses",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "ContactInfo_Mobile",
                table: "Industry_WorkshopAddresses",
                newName: "Mobile");

            migrationBuilder.RenameColumn(
                name: "ContactInfo_Email",
                table: "Industry_WorkshopAddresses",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "Geo_Longitude",
                table: "Industry_OfficeAddresses",
                newName: "Longitude");

            migrationBuilder.RenameColumn(
                name: "Geo_Latitude",
                table: "Industry_OfficeAddresses",
                newName: "Latitude");

            migrationBuilder.RenameColumn(
                name: "Geo_Elevation",
                table: "Industry_OfficeAddresses",
                newName: "Elevation");

            migrationBuilder.RenameColumn(
                name: "ContactInfo_WebSite",
                table: "Industry_OfficeAddresses",
                newName: "WebSite");

            migrationBuilder.RenameColumn(
                name: "ContactInfo_Phone",
                table: "Industry_OfficeAddresses",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "ContactInfo_Mobile",
                table: "Industry_OfficeAddresses",
                newName: "Mobile");

            migrationBuilder.RenameColumn(
                name: "ContactInfo_Email",
                table: "Industry_OfficeAddresses",
                newName: "Email");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WebSite",
                table: "Lab_Addresses",
                newName: "ContactInfo_WebSite");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Lab_Addresses",
                newName: "ContactInfo_Phone");

            migrationBuilder.RenameColumn(
                name: "Mobile",
                table: "Lab_Addresses",
                newName: "ContactInfo_Mobile");

            migrationBuilder.RenameColumn(
                name: "Longitude",
                table: "Lab_Addresses",
                newName: "Geo_Longitude");

            migrationBuilder.RenameColumn(
                name: "Latitude",
                table: "Lab_Addresses",
                newName: "Geo_Latitude");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Lab_Addresses",
                newName: "ContactInfo_Email");

            migrationBuilder.RenameColumn(
                name: "Elevation",
                table: "Lab_Addresses",
                newName: "Geo_Elevation");

            migrationBuilder.RenameColumn(
                name: "WebSite",
                table: "Industry_WorkshopAddresses",
                newName: "ContactInfo_WebSite");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Industry_WorkshopAddresses",
                newName: "ContactInfo_Phone");

            migrationBuilder.RenameColumn(
                name: "Mobile",
                table: "Industry_WorkshopAddresses",
                newName: "ContactInfo_Mobile");

            migrationBuilder.RenameColumn(
                name: "Longitude",
                table: "Industry_WorkshopAddresses",
                newName: "Geo_Longitude");

            migrationBuilder.RenameColumn(
                name: "Latitude",
                table: "Industry_WorkshopAddresses",
                newName: "Geo_Latitude");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Industry_WorkshopAddresses",
                newName: "ContactInfo_Email");

            migrationBuilder.RenameColumn(
                name: "Elevation",
                table: "Industry_WorkshopAddresses",
                newName: "Geo_Elevation");

            migrationBuilder.RenameColumn(
                name: "WebSite",
                table: "Industry_OfficeAddresses",
                newName: "ContactInfo_WebSite");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Industry_OfficeAddresses",
                newName: "ContactInfo_Phone");

            migrationBuilder.RenameColumn(
                name: "Mobile",
                table: "Industry_OfficeAddresses",
                newName: "ContactInfo_Mobile");

            migrationBuilder.RenameColumn(
                name: "Longitude",
                table: "Industry_OfficeAddresses",
                newName: "Geo_Longitude");

            migrationBuilder.RenameColumn(
                name: "Latitude",
                table: "Industry_OfficeAddresses",
                newName: "Geo_Latitude");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Industry_OfficeAddresses",
                newName: "ContactInfo_Email");

            migrationBuilder.RenameColumn(
                name: "Elevation",
                table: "Industry_OfficeAddresses",
                newName: "Geo_Elevation");
        }
    }
}
