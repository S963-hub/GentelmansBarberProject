using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GentelmansProject.Migrations
{
    public partial class o : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26dccfe0-550e-4502-b43c-1aa83939fea0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "479c8574-c5a6-45f1-8ae3-5bac5cd7daac");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "60834832-21dd-453d-947c-e352a59f6f24");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1c153877-4df9-458e-b080-753efd22357b", "2285b8da-7417-4fbc-94b6-00bcd98785cc", "BERBER", "BERBER" },
                    { "5d62f40c-77fc-4a62-9f87-2108341073ba", "070cf74d-fa51-4dc2-b77c-29381e4a8cfb", "KULLANCI", "KULLANCI" },
                    { "8af8c752-6211-44d6-99aa-e022707c0dba", "c8597aa4-e0c5-4e44-b64a-fcd8e69395ba", "ADMIN", "ADMIN" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c153877-4df9-458e-b080-753efd22357b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d62f40c-77fc-4a62-9f87-2108341073ba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8af8c752-6211-44d6-99aa-e022707c0dba");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "26dccfe0-550e-4502-b43c-1aa83939fea0", "d9149aa9-fb00-4a27-a50e-bf4458e9157c", "KULLANCI", "KULLANCI" },
                    { "479c8574-c5a6-45f1-8ae3-5bac5cd7daac", "5478ef7b-cf74-4c2f-89b7-d888e0996167", "ADMIN", "ADMIN" },
                    { "60834832-21dd-453d-947c-e352a59f6f24", "6753e14c-452c-4855-bfd9-79915ad9c231", "BERBER", "BERBER" }
                });
        }
    }
}
