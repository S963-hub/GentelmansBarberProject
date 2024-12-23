using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GentelmansProject.Migrations
{
    public partial class Berbers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Servises2",
                table: "Servises2");

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

            migrationBuilder.RenameTable(
                name: "Servises2",
                newName: "Servisess2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Servisess2",
                table: "Servisess2",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0cc20163-ebde-47ac-8dfe-a91bcacbb0b2", "188fc8fb-4ab8-4c51-89a3-cc37777d54c1", "ADMIN", "ADMIN" },
                    { "4456b73a-9089-415d-a9d0-533deae9364a", "a9ee33cb-454b-482d-98da-5edc1e86bb6b", "BERBER", "BERBER" },
                    { "772e8a69-72d5-4a4a-b645-ffbee56a185d", "f56fc482-dd41-4a52-a68b-773492caabca", "KULLANCI", "KULLANCI" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Servisess2",
                table: "Servisess2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0cc20163-ebde-47ac-8dfe-a91bcacbb0b2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4456b73a-9089-415d-a9d0-533deae9364a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "772e8a69-72d5-4a4a-b645-ffbee56a185d");

            migrationBuilder.RenameTable(
                name: "Servisess2",
                newName: "Servises2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Servises2",
                table: "Servises2",
                column: "Id");

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
    }
}
