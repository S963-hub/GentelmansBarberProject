using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GentelmansProject.Migrations
{
    public partial class onaylandi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "Onaylandi",
                table: "Randevulars",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Servises2",
                table: "Servises2",
                column: "Id");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Servises2",
                table: "Servises2");

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

            migrationBuilder.DropColumn(
                name: "Onaylandi",
                table: "Randevulars");

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
    }
}
