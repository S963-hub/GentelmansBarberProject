using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GentelmansProject.Migrations
{
    public partial class Authentication : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "25c33e6b-ca2a-4b77-81ed-d9359c7c5fc9", "c67070f0-3182-4810-9945-7fe91b623dea", "Kullanci", "kULLANCI" },
                    { "60262b94-b633-4d38-a829-696a02c5a7d2", "e945ae65-25c5-44b3-bc91-ab5fc56d4400", "Berber", "BERBER" },
                    { "71b9c230-ba11-4ea9-b74a-cf14fcaa1272", "bd2e7a81-70c8-457b-b529-90e77e8eb3d5", "admin", "ADMIN" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "25c33e6b-ca2a-4b77-81ed-d9359c7c5fc9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "60262b94-b633-4d38-a829-696a02c5a7d2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71b9c230-ba11-4ea9-b74a-cf14fcaa1272");

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
    }
}
