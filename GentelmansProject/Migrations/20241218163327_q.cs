using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GentelmansProject.Migrations
{
    public partial class q : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "611082a9-ac21-40d3-8e27-af6ce7ffc261");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "74d5254d-5551-4446-881d-245097ea5ec3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b12917d9-ad13-4d00-9105-159ac7badd0f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "70b2b295-b211-4e1e-9772-d49121972708", "30a75d4d-316a-430f-bdcd-15d3b3ca24c0", "Kullanci", "kULLANCI" },
                    { "857e786d-3f92-493b-a7d7-06d19c315313", "9e11b018-fa26-4358-a26e-7c7fd0086016", "Berber", "BERBER" },
                    { "ff9b997c-d8f2-42f3-b859-1886ef419fa5", "84950ec7-f8e6-4282-82c4-9a09bd629eb6", "admin", "ADMIN" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "70b2b295-b211-4e1e-9772-d49121972708");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "857e786d-3f92-493b-a7d7-06d19c315313");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff9b997c-d8f2-42f3-b859-1886ef419fa5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "611082a9-ac21-40d3-8e27-af6ce7ffc261", "e39008f4-6456-4886-9e1a-f7c9eb72727e", "admin", "ADMIN" },
                    { "74d5254d-5551-4446-881d-245097ea5ec3", "62560412-4bcb-46ce-991b-537da2462150", "Kullanci", "kULLANCI" },
                    { "b12917d9-ad13-4d00-9105-159ac7badd0f", "963dab10-8ccf-43c4-b0db-8db18aa619e7", "Berber", "BERBER" }
                });
        }
    }
}
