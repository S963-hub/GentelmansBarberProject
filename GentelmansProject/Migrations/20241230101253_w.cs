using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GentelmansProject.Migrations
{
    public partial class w : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "460a0637-7c1b-48f6-afb9-3e00acca34fb", "0e564d1f-1ff8-4fb2-b826-3b55f9fe0e14", "KULLANCI", "KULLANCI" },
                    { "73712b33-bb29-4413-bec9-cfa28c106873", "d690637d-b381-426a-9f33-2e77259fa049", "BERBER", "BERBER" },
                    { "c8544b4e-872d-45a5-85b1-e06c0cac8642", "a0e77f28-b2cb-4d6c-81d5-818306fdfd6d", "ADMIN", "ADMIN" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "460a0637-7c1b-48f6-afb9-3e00acca34fb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73712b33-bb29-4413-bec9-cfa28c106873");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8544b4e-872d-45a5-85b1-e06c0cac8642");

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
    }
}
