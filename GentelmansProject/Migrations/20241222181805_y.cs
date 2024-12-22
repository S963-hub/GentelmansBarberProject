using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GentelmansProject.Migrations
{
    public partial class y : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kaydol");

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
                    { "57dd66fb-f496-4c82-8f23-87355d0c2df5", "92f77871-6df9-42b6-b8f8-962a66f1da5b", "ADMIN", "ADMIN" },
                    { "7eb783f8-c564-4231-aa46-fc3330874409", "777e23e8-b142-4e3c-8b7c-76c3c78a80ff", "KULLANCI", "KULLANCI" },
                    { "e714fbaf-b38c-46b0-9dae-095c7e3ace8d", "abb12cc7-98bd-48a4-b24e-e10000042386", "BERBER", "BERBER" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57dd66fb-f496-4c82-8f23-87355d0c2df5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7eb783f8-c564-4231-aa46-fc3330874409");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e714fbaf-b38c-46b0-9dae-095c7e3ace8d");

            migrationBuilder.CreateTable(
                name: "Kaydol",
                columns: table => new
                {
                    Email = table.Column<string>(type: "text", nullable: false),
                    ConfirmPassword = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kaydol", x => x.Email);
                });

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
    }
}
