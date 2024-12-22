using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GentelmansProject.Migrations
{
    public partial class model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d428609-40c3-4dad-a0b6-5299b1ef6f46");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bcd3ac26-2d68-4a8b-87d0-555dc44492d4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cfe9cc14-9e6a-4dee-b985-91138019a0df");

            migrationBuilder.AlterColumn<decimal>(
                name: "HizmetFiyat",
                table: "Servises",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3f9d0151-eae4-4470-bd38-5f429807cad2", "d3f87a77-cbcc-450b-8657-4c33bc991ea0", "ADMIN", "ADMIN" },
                    { "bde0dfaf-1d65-4d32-9637-9c958bcbce9a", "4832fd25-d174-4b0d-a844-cac47d8b3af8", "BERBER", "BERBER" },
                    { "bf9ac070-0166-47c5-8774-55a3701ea009", "182021ad-54ac-4535-ae1a-526b912c84a2", "KULLANCI", "KULLANCI" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f9d0151-eae4-4470-bd38-5f429807cad2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bde0dfaf-1d65-4d32-9637-9c958bcbce9a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf9ac070-0166-47c5-8774-55a3701ea009");

            migrationBuilder.AlterColumn<int>(
                name: "HizmetFiyat",
                table: "Servises",
                type: "integer",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8d428609-40c3-4dad-a0b6-5299b1ef6f46", "15872da6-51e5-44b0-8a11-57c9f6c1b496", "KULLANCI", "KULLANCI" },
                    { "bcd3ac26-2d68-4a8b-87d0-555dc44492d4", "1245733e-fa5d-4879-a468-391f59ed58b5", "BERBER", "BERBER" },
                    { "cfe9cc14-9e6a-4dee-b985-91138019a0df", "08ddba97-e2b9-4a78-bb12-1dd3a504e218", "ADMIN", "ADMIN" }
                });
        }
    }
}
