using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GentelmansProject.Migrations
{
    public partial class hj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "215a30b9-0130-4953-9200-40d2cb50d36a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4bf49434-4800-462a-956d-722f1220ff83");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ebd0cc98-86df-4052-aeba-c5cb67878d90");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "215a30b9-0130-4953-9200-40d2cb50d36a", "bd6009be-14a6-4178-b816-621db8315243", "KULLANCI", "KULLANCI" },
                    { "4bf49434-4800-462a-956d-722f1220ff83", "2538c55e-aff0-403d-88b4-0d27456dbf45", "BERBER", "BERBER" },
                    { "ebd0cc98-86df-4052-aeba-c5cb67878d90", "3fcd9444-baa6-4dc2-941e-35e9bb4c4c6a", "ADMIN", "ADMIN" }
                });
        }
    }
}
