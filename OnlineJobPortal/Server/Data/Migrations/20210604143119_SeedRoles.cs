using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineJobPortal.Server.Data.Migrations
{
    public partial class SeedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d24c74a7-af25-43b3-a240-9d2d95ab446a", "7d3a69f9-4d31-44aa-a31d-30486a68c6ad", "Candidate", "Candidate" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "70c611b6-d13f-4953-8172-7b52370dc8c4", "850e7293-055c-42c6-8ace-ab882399d07e", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c28ad735-4150-4b55-8ca7-b4b15976e298", "499e6aab-6376-42cc-8dde-900533da8e78", "Employer", "Employer" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "70c611b6-d13f-4953-8172-7b52370dc8c4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c28ad735-4150-4b55-8ca7-b4b15976e298");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d24c74a7-af25-43b3-a240-9d2d95ab446a");
        }
    }
}
