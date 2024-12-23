using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GentelmansProject.Migrations
{
    public partial class Berberlervemodellereklenild : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "098ccb60-c714-40d2-983c-22f19e836512");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5c6583ca-1622-4b1e-974c-3f82fdda9f84");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9de7daf1-c28b-4b6d-b33f-148497f39c85");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "098ccb60-c714-40d2-983c-22f19e836512", "f6acc6e9-5aca-497e-af0c-450b2cf70078", "ADMIN", "ADMIN" },
                    { "5c6583ca-1622-4b1e-974c-3f82fdda9f84", "c1a2419a-7b33-491f-97cb-e8ae2c9a8ae8", "KULLANCI", "KULLANCI" },
                    { "9de7daf1-c28b-4b6d-b33f-148497f39c85", "f921d70e-d4fa-4d45-8693-28186137ed3d", "BERBER", "BERBER" }
                });
        }
    }
}
