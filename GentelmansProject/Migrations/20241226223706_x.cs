using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GentelmansProject.Migrations
{
    public partial class x : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "215a30b9-0130-4953-9200-40d2cb50d36a", "bd6009be-14a6-4178-b816-621db8315243", "KULLANCI", "KULLANCI" },
                    { "4bf49434-4800-462a-956d-722f1220ff83", "2538c55e-aff0-403d-88b4-0d27456dbf45", "BERBER", "BERBER" },
                    { "ebd0cc98-86df-4052-aeba-c5cb67878d90", "3fcd9444-baa6-4dc2-941e-35e9bb4c4c6a", "ADMIN", "ADMIN" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "0623645f-a7e4-4e9b-9fbe-8aa497559201", "3faeb60f-bc93-41d6-b161-fe8a4fccc631", "ADMIN", "ADMIN" },
                    { "0d4bc569-667b-42a6-9a7a-32818311d068", "e000a6bc-10b9-4720-8e1d-481b5f1a1c68", "KULLANCI", "KULLANCI" },
                    { "59048e00-8b85-40d9-ab4e-afd8f160589a", "31403535-9784-404d-8e8f-517cf09897f8", "BERBER", "BERBER" }
                });
        }
    }
}
