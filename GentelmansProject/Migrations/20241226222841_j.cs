using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GentelmansProject.Migrations
{
    public partial class j : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06d8ad52-ba9e-43eb-8381-00e76ed75da6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d95cda3e-b997-441e-9ad3-5fd1d3ce574d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d9bae93f-9507-4b54-82d0-3a6643710a6b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0623645f-a7e4-4e9b-9fbe-8aa497559201", "3faeb60f-bc93-41d6-b161-fe8a4fccc631", "ADMIN", "ADMIN" },
                    { "0d4bc569-667b-42a6-9a7a-32818311d068", "e000a6bc-10b9-4720-8e1d-481b5f1a1c68", "KULLANCI", "KULLANCI" },
                    { "59048e00-8b85-40d9-ab4e-afd8f160589a", "31403535-9784-404d-8e8f-517cf09897f8", "BERBER", "BERBER" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0623645f-a7e4-4e9b-9fbe-8aa497559201");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d4bc569-667b-42a6-9a7a-32818311d068");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59048e00-8b85-40d9-ab4e-afd8f160589a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "06d8ad52-ba9e-43eb-8381-00e76ed75da6", "1bb9acb1-2486-45cb-8f7d-281084b80260", "BERBER", "BERBER" },
                    { "d95cda3e-b997-441e-9ad3-5fd1d3ce574d", "992a0aa3-9c8f-4698-b0e9-20e40a22e7a7", "KULLANCI", "KULLANCI" },
                    { "d9bae93f-9507-4b54-82d0-3a6643710a6b", "6a382f12-99d2-4a6d-b05d-7fdb715ae558", "ADMIN", "ADMIN" }
                });
        }
    }
}
