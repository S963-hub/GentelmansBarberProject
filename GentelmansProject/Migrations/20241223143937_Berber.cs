using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GentelmansProject.Migrations
{
    public partial class Berber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00af7329-ddc8-4263-b9ed-c4ffbaf6fee1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "79e78795-b2e5-47e7-99f3-7e12bb5ef909");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7ff6a115-a432-4398-b67c-0d731b3cfcac");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "34beac72-6594-4c17-a2ad-cbb50eaa6e4e", "d1bcce71-af5e-4bc8-8347-4f79ad041111", "BERBER", "BERBER" },
                    { "446305f3-b022-454a-9cf2-cf3e4af7a394", "aaf08bb8-f975-46b7-9741-2a209c55c491", "ADMIN", "ADMIN" },
                    { "d4ebe06a-2154-44cd-8a1d-0734240ddeee", "a5a3b8f5-bd30-4469-9235-80564719da7b", "KULLANCI", "KULLANCI" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "34beac72-6594-4c17-a2ad-cbb50eaa6e4e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "446305f3-b022-454a-9cf2-cf3e4af7a394");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4ebe06a-2154-44cd-8a1d-0734240ddeee");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "00af7329-ddc8-4263-b9ed-c4ffbaf6fee1", "b62b79cc-e95a-4870-add3-dbe7839c7005", "KULLANCI", "KULLANCI" },
                    { "79e78795-b2e5-47e7-99f3-7e12bb5ef909", "d276f7c3-11f9-45ec-95d5-09317412f628", "BERBER", "BERBER" },
                    { "7ff6a115-a432-4398-b67c-0d731b3cfcac", "eed3d119-b6fd-48cd-a275-90c36986ae9a", "ADMIN", "ADMIN" }
                });
        }
    }
}
