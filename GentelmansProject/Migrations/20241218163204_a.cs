using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GentelmansProject.Migrations
{
    public partial class a : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "70abfdcd-d6f4-4d8b-aecc-8ce336822104");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c24e190b-a0a1-49f3-aff3-2799250d76ff");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d50663f0-2037-4730-8b18-e657eaf87b8c");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "70abfdcd-d6f4-4d8b-aecc-8ce336822104", "2965d08a-35a7-470c-a5e1-48503a6365e7", "admin", "ADMIN" },
                    { "c24e190b-a0a1-49f3-aff3-2799250d76ff", "7b37d7db-f2a3-481d-b9ad-4c72c7026381", "Berber", "BERBER" },
                    { "d50663f0-2037-4730-8b18-e657eaf87b8c", "f2ac3594-e865-4eea-8c9f-f67058400607", "Kullanci", "kULLANCI" }
                });
        }
    }
}
