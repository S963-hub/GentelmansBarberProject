using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GentelmansProject.Migrations
{
    public partial class cc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40e2ca74-8266-43bf-b9a1-6f1c207b12dc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af413b73-7872-40de-9a18-6b9a1eb66745");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f067c902-f8a8-481e-bef2-0b3d35ba0224");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "29a186c5-499b-4559-bf6b-c5c3c7ccce4d", "eed150eb-5a55-47c2-88eb-3eb0f05a53d3", "ADMIN", "ADMIN" },
                    { "433badfc-6283-474a-b777-d4aa125c6424", "e33fa9c9-155c-4d36-9c1c-790da4ca796e", "BERBER", "BERBER" },
                    { "d85dc5c0-22f0-4513-a65c-65099b606b7b", "6f34a3d0-9f8d-44d3-bf2b-72b658396660", "KULLANCI", "KULLANCI" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "29a186c5-499b-4559-bf6b-c5c3c7ccce4d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "433badfc-6283-474a-b777-d4aa125c6424");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d85dc5c0-22f0-4513-a65c-65099b606b7b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "40e2ca74-8266-43bf-b9a1-6f1c207b12dc", "c1cbb2ce-64a3-47ae-a620-199ccb907e7a", "BERBER", "BERBER" },
                    { "af413b73-7872-40de-9a18-6b9a1eb66745", "015946c2-661c-4d7e-b3af-e13844d64938", "KULLANCI", "KULLANCI" },
                    { "f067c902-f8a8-481e-bef2-0b3d35ba0224", "7f5b5915-f464-4df8-9ba0-8fed6bd9a60b", "ADMIN", "ADMIN" }
                });
        }
    }
}
