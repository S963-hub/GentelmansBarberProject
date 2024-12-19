using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GentelmansProject.Migrations
{
    public partial class Authenticationa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "44136912-0aa0-491b-b1fc-3f8318be9675", "d7746c15-f5de-4e68-9c84-f7e056341dba", "ADMIN", "ADMIN" },
                    { "86b5372c-faf3-4ce4-ab5a-c5136f6b71c5", "982cd3a8-b6fe-4c14-876e-8dc5ec7dc961", "BERBER", "BERBER" },
                    { "a0900ee2-9394-44e1-997e-d723d9dea017", "a1c6ee4e-8a6c-4e78-a45f-dec2aec9ab4a", "KULLANCI", "KULLANCI" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44136912-0aa0-491b-b1fc-3f8318be9675");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "86b5372c-faf3-4ce4-ab5a-c5136f6b71c5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0900ee2-9394-44e1-997e-d723d9dea017");

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
    }
}
